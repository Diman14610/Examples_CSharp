using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Helper
{
    public partial class RelationShip : Form
    {
        public RelationShip()
        {
            InitializeComponent();
        }

        // Глобальне переменные для повторяющих значений
        int buttonHeight = 60, 
            groupBoxWidth = 156, groupBoxLocationX = 12, groupBoxLocationY = 30;

        #region Button Click
        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DBS (*.dbs)|*.dbs";
            openFileDialog1.InitialDirectory = Path.GetFullPath("Resource/Tables");

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            panelFill.Controls.Clear();
            Variables.MaxHeight = 0;
            checkedListBoxRelation.Items.Clear();

            int yGB = groupBoxLocationY > Variables.MaxHeight ? groupBoxLocationY : Variables.MaxHeight;// Если в MaxHeight меньше 30, то оставляем 30
            int xGB = groupBoxLocationX;

            foreach (String file in openFileDialog1.FileNames)
            {
                string[] fileText = File.ReadAllLines(file);
                GroupBox groupBox = new GroupBox();
                int yBT = 35;

                for (int i = 0; i < fileText.Length; i++)
                {
                    foreach (var item in Variables.CollectionTypesSQL)
                    {/* Парсинг строки вида:
                      *  CREATE TABLE <поле> (,
                      *     <поле> INT)
                      */
                        fileText[i] = Regex.Replace(fileText[i], @"\d", "").Replace($"{Environment.NewLine}", "");
                        fileText[i] = fileText[i].Replace(item.Replace("()",""), "")
                            .Replace("CREATE TABLE ", "")
                            .Replace(" ","")
                            .Replace("PRIMARYKEYIDENTITY","")
                            .Replace("(",Environment.NewLine)
                            .Replace(",", Environment.NewLine)
                            .Replace(")","");
                    }

                    // Отменяем создание кнопки для скобки
                    if (string.IsNullOrEmpty(fileText[i]) | string.IsNullOrWhiteSpace(fileText[i]))
                        break;

                    Button button = new Button();

                    if (i == 0)
                    {/* Генерация GroupBox для каждой таблицы
                      * с индексом 0 для получение имени таблицы
                      */
                        if (xGB >= panelFill.Width - groupBoxWidth)//126
                        {
                            yGB = Variables.MaxHeight;
                            xGB = groupBoxLocationX;
                        }

                        // Если текущая максимальная высота(fileText.Length * buttonHeight) больше предыдущей(Variables.MaxHeight), то перезапишет
                        Variables.MaxHeight = fileText.Length * buttonHeight > Variables.MaxHeight ? fileText.Length * buttonHeight + 50: Variables.MaxHeight;

                        groupBox.Size = new Size(groupBoxWidth, (fileText.Length - 1) * buttonHeight);// (Кол-во строк - скобка) * на высоту кнопки(buttonHeight)
                        groupBox.Text = fileText[i];
                        groupBox.BackColor = Color.FromArgb(29, 36, 51);
                        groupBox.ForeColor = Color.FromArgb(255, 191, 76);// 255, 191, 76
                        groupBox.Font = new Font("Verdana", 12);
                        groupBox.Location = new Point(xGB, yGB);
                        groupBox.Parent = panelFill;
                        xGB += 180;
                    }               
                    else
                    {/* Генерация Button и добавление в GroupBox*/
                        button.Size = new Size(150, buttonHeight);
                        button.Text = fileText[i];
                        button.BackColor = Color.FromArgb(29, 36, 51);// 54, 79, 107
                        button.ForeColor = Color.FromArgb(215, 220, 226);
                        button.Font = new Font("Verdana", 12);
                        button.Location = new Point(3, yBT);
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        yBT += buttonHeight;
                        button.Click += EventButton;
                        groupBox.Controls.Add(button);
                    }
                }
            }
            btnGenerateScript.Visible = true;
            openFileDialog1.Dispose();
        }

        void EventButton(object s, EventArgs e)
        {// Событие для сгенерированных кнопок
            Button button = (Button)s;
            button.ForeColor = Color.FromArgb(215, 220, 226);
            button.BackColor = Color.FromArgb(47, 59, 84);//  54, 79, 107

            string btnTextParseNumbers = Regex.Replace(button.Text, @"\d", "");// Убирает ссылки на связь: id13, где 1,3 ссылка на checkBox

            if (Variables.PK_FK == $"{checkedListBoxRelation.Items.Count + 1}) PK_{button.Parent.Text}_{btnTextParseNumbers}")
            {// При повторном нажатии снимаем выделение и очищаем содержимое Variables.PK_FK
                Variables.PK_FK = "";
                button.Text = btnTextParseNumbers;
                button.ForeColor = Color.FromArgb(215, 220, 226);
                button.BackColor = Color.FromArgb(29, 36, 51);
            }
            else if (Variables.PK_FK == "" | Variables.PK_FK == null)
            {// Для PK
                Variables.PK_FK = $"{checkedListBoxRelation.Items.Count + 1}) PK_{button.Parent.Text}_{btnTextParseNumbers}";
                button.Text += checkedListBoxRelation.Items.Count + 1;
            }
            else
            {// Для FK
                Variables.PK_FK += $" → FK_{button.Parent.Text}_{btnTextParseNumbers}";
                checkedListBoxRelation.Items.Add(Variables.PK_FK, true);
                button.Text += checkedListBoxRelation.Items.Count;
                Variables.PK_FK = "";
            }
        }

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {/* При нажати кнопки Сформировать скрипт */
            if (checkedListBoxRelation.Items.Count == 0)
                return;

            // Переписанный парсер через регулярки, но не до конца
            //foreach (var item in checkedListBoxRelation.CheckedItems)
            //{
            //    string l = Regex.Replace(item.ToString(), @"\d", "").Replace(") ", "").Replace("PK_", "").Replace("FK_", "");

            //    string pk_table = Regex.Replace(l, @" → (.*)", "");
            //    string fk_table = Regex.Replace(l, @"(.*) → ", "");

            //    string pk_key = Regex.Replace(pk_table, @"(.*)_", "");
            //    string fk_key = fk_table.Remove(0, fk_table.IndexOf("_") + 1);

            //    MessageBox.Show(pk_table);
            //    MessageBox.Show(pk_key);
            //}

            List<string> collectionTables = new List<string>();// Список для имен таблиц
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in checkedListBoxRelation.CheckedItems)
            {
                string l = Regex.Replace(item.ToString(), @"\d", "").Replace(") ", "");

                string pk = l.Replace("PK_", "");// Парсит все кроме имени таблицы у PK
                string pkKey = pk.Remove(0, pk.IndexOf("_") + 1);// Парсит все кроме поля таблицы у PK
                pkKey = pkKey.Remove(pkKey.IndexOf(" → "));
                pk = pk.Remove(pk.IndexOf("_"));

                string fk = l.Replace("FK_", "").Replace("PK_", "").Remove(0, l.IndexOf(" → "));// Парсит все кроме имени таблицы у FK
                string fkKey = fk.Remove(0, fk.IndexOf("_") + 1);// Парсит все кроме поля таблицы у FK
                fk = fk.Remove(fk.IndexOf("_"));

                stringBuilder.AppendLine($"ALTER TABLE {fk}")
                    .AppendLine($"ADD CONSTRAINT {l} ({fkKey}) REFERENCES {pk} ({pkKey}){Environment.NewLine}");

                collectionTables.Add(pk);// Добавление имени таблицы PK
                collectionTables.Add(fk);// Добавление имени таблицы FK
            }

            collectionTables = collectionTables.Distinct().ToList();// Удаление повторяющих записей

            string pathName = $"Resource/Scripts/{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString().Replace(":", ".")} Relations({checkedListBoxRelation.CheckedItems.Count}).txt";// дата время связей(кол-во).txt

            File.Delete(pathName);// Удаление файла, если уже есть с датой и кол-вом сущностей повторяющих .txt

            foreach (var item in collectionTables)
            {
                File.AppendAllText(pathName, File.ReadAllText($"Resource/Tables/{item}.dbs") + Environment.NewLine + Environment.NewLine);
            }

            File.AppendAllText(pathName, stringBuilder.ToString());

            Process.Start($"{Directory.GetCurrentDirectory()}/{pathName}").WaitForExit();

        }// Regex.Replace(l,@"\w+[_]","")   id → сотрудника
        #endregion

        private void RelationShip_Resize(object sender, EventArgs e)
        {/* Перерисовка */
            int yGB = groupBoxLocationY;
            int xGB = groupBoxLocationX;
            foreach (GroupBox item in panelFill.Controls)
            {
                if (xGB >= panelFill.Width - groupBoxWidth)//126
                {
                    yGB = Variables.MaxHeight;
                    xGB = groupBoxLocationX;
                }
                item.Location = new Point(xGB,yGB);
                xGB += 180;
            }
        }

        #region Показ боковой панели при наведении
        private void checkedListBoxRelation_MouseEnter(object sender, EventArgs e)
        {
            panelRelation.Width = ClientSize.Width / 2;
        }

        private void checkedListBoxRelation_MouseLeave(object sender, EventArgs e)
        {
            panelRelation.Width = 21;
        }
        #endregion
    }
}
