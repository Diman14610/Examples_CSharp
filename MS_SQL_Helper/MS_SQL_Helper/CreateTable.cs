using MS_SQL_Helper.SOLID;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MS_SQL_Helper
{
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        class AutoInserTypes
        {
            public string Type { get; set; }
            public string Content { get; set; }
        }
        List<AutoInserTypes> ListAutoInserTypes;

        private void Form2_Load(object sender, EventArgs e)
        {
            panelRigth.Width = 23;
            btnShowRigth.Location = new Point(panelRigth.Location.X - 10, ClientSize.Height / 2);
            textBoxTable.Focus();

            new WorkWithComboBox().SetAutoCompleteAndItems(comboBoxType);// Fill comboBoxType

            #region Load preset CheckBox
            string pathSetting = "Resource/Settings/CheckBox.setting";

            if (!File.Exists(pathSetting))// Если нету файла
                return;
            if (panelRigth.Controls.Count > File.ReadAllLines(pathSetting).Count())// Кол-во флажков больше содержимого файла
                return;

            string[] collectionSetting = File.ReadAllLines(pathSetting);
            if (collectionSetting.Length == 0)
                return;

            byte i = 0;
            foreach (CheckBox item in panelRigth.Controls)
            {
                item.Checked = Convert.ToBoolean(collectionSetting[i++]);
            }

            if (checkBoxPK.Checked)
                Variables.PK = true;
            if (checkBoxAI.Checked)
                Variables.AI = true;
            #endregion

            #region Load JSON AutoInserTypes
            if (!File.Exists($"Resource/Settings/AutoInserTypes.json"))
                return;

            ListAutoInserTypes = JsonConvert.DeserializeObject<List<AutoInserTypes>>(File.ReadAllText($"Resource/Settings/AutoInserTypes.json"));
            #endregion
        }

        void ShowPanels()
        {
            panel2.Visible = true;
            richTextBoxResult.Visible = true;
            btnGenerateScript.Visible = true;

            panel1.Visible = false;
            textBoxField.Focus();
        }

        void HidePanels()
        {
            panel2.Visible = false;

            if (string.IsNullOrEmpty(richTextBoxResult.Text) | string.IsNullOrWhiteSpace(richTextBoxResult.Text))
                btnGenerateScript.Visible = false;
            else
                btnGenerateScript.Visible = true;

            if (checkBoxPK.Checked)
                Variables.PK = true;
            if (checkBoxAI.Checked)
                Variables.AI = true;

            panel1.Visible = true;
            textBoxTable.Clear();
            textBoxTable.Focus();
        }

        #region Button Click
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowRigth_Click(object sender, EventArgs e)
        {// Resize
            if (panelRigth.Width == 23)
            {
                panelRigth.Width = 290;
                btnShowRigth.Text = ">";
                btnShowRigth.Location = new Point(panelRigth.Location.X - btnShowRigth.Width, ClientSize.Height / 2);
                btnClose.Location = new Point(panelRigth.Location.X - btnClose.Width - 2, btnClose.Location.Y);
            }
            else
            {
                panelRigth.Width = 23;
                btnShowRigth.Text = "<";
                btnShowRigth.Location = new Point(panelRigth.Location.X - btnShowRigth.Width, ClientSize.Height / 2);
                btnClose.Location = new Point(panelLeft.Width - btnClose.Width - 2, panelLeft.Height - btnClose.Height);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTable.Text) | string.IsNullOrWhiteSpace(textBoxTable.Text))
                return;

            if (checkBoxToUpper.Checked)
                textBoxTable.Text = textBoxTable.Text.Remove(1, textBoxTable.Text.Length - 1).ToUpper() + textBoxTable.Text.Remove(0, 1);

            richTextBoxResult.AppendText($"CREATE TABLE {textBoxTable.Text} (");

            ShowPanels();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxField.Text) | string.IsNullOrWhiteSpace(textBoxField.Text) | string.IsNullOrEmpty(comboBoxType.Text) | string.IsNullOrWhiteSpace(comboBoxType.Text))
                return;

            StringBuilder stringBuilder = new StringBuilder(70);

            if (Variables.PK)
            {
                stringBuilder.Append(checkBoxPK.Text + " ");
                Variables.PK = false;
            }
            if (Variables.AI)
            {
                stringBuilder.Append(checkBoxAI.Text);
                Variables.AI = false;
            }

            richTextBoxResult.AppendText($"{Environment.NewLine}   {textBoxField.Text} {comboBoxType.Text.ToUpper()} {stringBuilder},");

            comboBoxType.Text = "";
            textBoxField.Clear();
            textBoxField.Focus();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {// При нажати Esc или Закрыть таблицу удаляет запятую в конце и добавляет скобку
            HidePanels();

            string line = $"{richTextBoxResult.Text.Remove(richTextBoxResult.Text.Length - 1, 1)}{Environment.NewLine}){Environment.NewLine}";

            richTextBoxResult.Text = line;
        }

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            string[] collectionWriting = richTextBoxResult.Lines;// Присваиваем содержимое в richTextBox
            richTextBoxResult.Clear();

        // Начало формирование каждой таблицы в файл
        PointStart:
            int start = 0;
            int end = 0;

            for (int i = 0; i < collectionWriting.Count(); i++)
            {// Получаем позицию начало CREATE TABLE и конец )
                if (collectionWriting[i].Contains("CREATE TABLE"))
                    start = i;
                if (collectionWriting[i].Contains(")"))
                    end = i;
            }

            string nameTable = "";
            for (int i = start; i < end + 1; i++)
            {// Записываем в файл таблицы
                if (i == start)
                {// Берем имя таблицы для заголовка файла(Таблица.dbs)
                    nameTable = $"Resource/Tables/{collectionWriting[i].Replace("CREATE TABLE", "").Replace("(", "").Replace(" ", "")}.dbs";
                    File.WriteAllText(nameTable, collectionWriting[i]);
                }
                else
                    File.AppendAllText(nameTable, $"{Environment.NewLine}{collectionWriting[i].Replace(" ,", ",")}");// Записывает в файл

                collectionWriting[i] = "";// Очищаем добавленную строку
            }
            
            for (int i = 0; i < collectionWriting.Length; i++)
            {// Цикл для проверки наличия таблиц
                if (collectionWriting[i].Contains("CREATE TABLE"))// Проверка, если ли в коллекции таблица
                    goto PointStart;// Если есть CREATE TABLE, то запускаем весь процесс заново
            }
            HidePanels();
        }
        #endregion

        private void Form2_Resize(object sender, EventArgs e)
        {/* Resize */
            btnClose.Location = new Point(panelRigth.Location.X - btnClose.Width - 2, panelLeft.Height - btnClose.Height);
            btnShowRigth.Location = new Point(panelRigth.Location.X - btnShowRigth.Width, ClientSize.Height / 2);
        }

        #region Syntaxis
        private protected SyntaxHighlighting Syntax = new SyntaxHighlighting();// Подсветка синтаксиса

        private void richTextBoxResult_TextChanged(object sender, EventArgs e)
        {
            string[] collectionGold = { "CREATE TABLE", "PRIMARY KEY", "IDENTITY" };

            Syntax.Highlighting(richTextBoxResult,
                collectionGold,
                Variables.CollectionTypesSQL,
                Color.FromArgb(255, 191, 76),
                Color.FromArgb(30, 129, 206)
                );
        }
        #endregion

        #region Event KeyPress, KeyDown
        #region Замена пробела на _
        private void ReplaceSpace(TextBox textBox, KeyPressEventArgs e)
        {
            if (checkBoxReplaceSpace.Checked)
            {
                if (e.KeyChar == 0x20)
                {
                    e.KeyChar = '\0';//при нажатие пробела не будет отступа
                    textBox.AppendText("_");
                    e.Handled = e.KeyChar == (char)Keys.None;//при нажатии не будет системных звуков
                }
            }
        }
        private void textBoxTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReplaceSpace(textBoxTable, e);
        }

        private void textBoxField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReplaceSpace(textBoxField, e);
        }
        #endregion

        private void comboBoxType_KeyDown(object sender, KeyEventArgs e)
        {
            new WorkWithComboBox().PressRigthFocus(comboBoxType, e);
        }
        #endregion

        #region Event Leave
        private void Form2_Leave(object sender, EventArgs e)
        {
            File.Delete("Resource/Settings/CheckBox.setting");
            foreach (CheckBox item in panelRigth.Controls)
            {
                File.AppendAllText("Resource/Settings/CheckBox.setting", $"{item.Checked}{Environment.NewLine}");
            }
        }

        private void textBoxTable_Leave(object sender, EventArgs e)
        {
            if (checkBoxInsertID.Checked)
            {
                textBoxField.Text = "id";
                comboBoxType.Text = "INT";
            }
        }
        #endregion

        #region Event Enter
        private void comboBoxType_Enter(object sender, EventArgs e)
        {
            if (checkBoxAutoInserType.Checked & !textBoxField.Text.ToLower().Contains("id") & ListAutoInserTypes != null)
            {
                foreach (AutoInserTypes item in ListAutoInserTypes)
                {
                    if (textBoxField.Text.ToLower().Contains(item.Content))
                    {
                        comboBoxType.Text = item.Type;
                        new WorkWithComboBox().Focus(comboBoxType);
                    }
                }
            }
        }
        #endregion
    }
}