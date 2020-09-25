using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_SQL_Helper.SOLID;


namespace MS_SQL_Helper
{
    public partial class CreateTableFC : Form
    {
        public CreateTableFC()
        {
            InitializeComponent();
        }

        /* Переменные для CreateTableFC */
        private List<string> collectionTables = new List<string>();// Коллекция имен таблиц для создания связей (panelRelation)
        private string comboBoxFirstTable = "";// Переменная для PK в создании связей (panelRelation)

        void ShowPanels()
        {
            panel2.Visible = true;
            richTextBoxResult.Visible = true;
            btnGenerateScript.Visible = true;

            panel1.Visible = false;

            panelRelations.Visible = true;
            textBoxField.Focus();
        }

        void HidePanels()
        {
            panel2.Visible = false;

            if (string.IsNullOrEmpty(richTextBoxResult.Text) | string.IsNullOrWhiteSpace(richTextBoxResult.Text))
                btnGenerateScript.Visible = false;
            else
                btnGenerateScript.Visible = true;

            panel1.Visible = true;
            textBoxTable.Clear();
            textBoxTable.Focus();
        }

        private void CreateTableFC_Load(object sender, EventArgs e)
        {
            new WorkWithComboBox().SetAutoCompleteAndItems(comboBoxType, Variables.CollectionTypesCsharp);

            textBoxTable.Focus();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTable.Text) | string.IsNullOrWhiteSpace(textBoxTable.Text))
                return;

            collectionTables.Add(textBoxTable.Text);// Добавляем в коллекцию, чтобы дальше выбирать связи

            richTextBoxResult.AppendText($"public class {textBoxTable.Text}{Environment.NewLine}");
            richTextBoxResult.AppendText("{");

            ShowPanels();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxField.Text) | string.IsNullOrWhiteSpace(textBoxField.Text) | string.IsNullOrEmpty(comboBoxType.Text) | string.IsNullOrWhiteSpace(comboBoxType.Text))
                return;

            richTextBoxResult.AppendText(Environment.NewLine + "    public " + comboBoxType.Text + " " + textBoxField.Text + " { get; set; }");

            comboBoxType.Text = "";
            textBoxField.Clear();
            textBoxField.Focus();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            HidePanels();

            string line = Environment.NewLine + "} " + Environment.NewLine + Environment.NewLine;// Добавляю пробел, чтобы в конце спарсить добавление связи

            richTextBoxResult.AppendText(line);
        }

        #region Syntaxis
        private protected SyntaxHighlighting Syntax = new SyntaxHighlighting();// Подсветка синтаксиса

        private void richTextBoxResult_TextChanged(object sender, EventArgs e)
        {
            string[] collectionGold = { "public", "private", "protected", "void", "get", "set", "virtual" };
            string[] collectionGreen = { "class", "IList", "ICollection" };

            Syntax.Highlighting(richTextBoxResult,
                collectionGold,
                collectionGreen,
                Variables.CollectionTypesCsharp,
                Color.FromArgb(255, 191, 76),
                Color.FromArgb(23, 185, 120),
                Color.FromArgb(30, 129, 206));
        }
        #endregion

        #region ComboBox
        private void btnAddRelations_Click(object sender, EventArgs e)
        {// Добавляеть два CB для создания связей
            ComboBox comboBox = new ComboBox
            {
                Width = panelRelations.Width / 2,
                Height = 50,
                Top = 35 + panelRelations.Controls.Count * 15,
            };

            ComboBox comboBox2 = new ComboBox
            {
                Width = panelRelations.Width / 2,
                Height = 50,
                Top = 35 + panelRelations.Controls.Count * 15,
                Left = panelRelations.Width / 2,
            };

            comboBox.SelectedIndexChanged += comboBoxFirstClick;// События для присваивания переменой выбраного имени таблицы
            comboBox2.SelectedIndexChanged += comboBoxLastClick;// Событие для вставки public IList<>
            comboBox2.Click += comboBoxClearClick;// При повторном нажатии на CB удалит стекущую связь

            foreach (var item in collectionTables)
            {
                comboBox.Items.Add(item);
                comboBox2.Items.Add(item);
            }

            panelRelations.Controls.Add(comboBox);
            panelRelations.Controls.Add(comboBox2);
        }
        
        private void comboBoxFirstClick(object s, EventArgs e)
        {// Выбор в первом CB добавит имя выбранной таблицы
            ComboBox comboBox = (ComboBox)s;

            comboBoxFirstTable = "class " + comboBox.Text;
        }

        private void comboBoxLastClick(object s, EventArgs e)
        {// Добавляет IList<> после выбора второй таблицы в CB
            ComboBox comboBox = (ComboBox)s;

            int str = richTextBoxResult.Find("} ",
                richTextBoxResult.Text.IndexOf(comboBoxFirstTable),
                RichTextBoxFinds.NoHighlight);// Получаем позицию } конкретной таблицы (comboBoxFirstTable)

            if (str == -1)// Если не найдена таблица
                return;
            
            richTextBoxResult.Select(str, 1);// Выделяет }
            richTextBoxResult.SelectedText =
                "    public virtual ICollection<"
                + comboBox.Text
                + "> " + comboBox.Text
                + "s { get; set; }"
                + Environment.NewLine + "}";// Заменяет } на public IList<>


            /* Подстановка ID с PK таблицы */
            string _ = "class " + comboBox.Text;
            
            richTextBoxResult.Select(richTextBoxResult.Find("} ", richTextBoxResult.Text.IndexOf(_), RichTextBoxFinds.NoHighlight), 1);
            richTextBoxResult.SelectedText =
                "    public int " 
                + comboBoxFirstTable.Replace("class ", "") + "ID"
                + " { get; set; }" 
                + Environment.NewLine//
                + "    public virtual " + comboBoxFirstTable.Replace("class ", "") 
                + " " + comboBoxFirstTable.Replace("class ", "")
                + " { get; set; }"
                + Environment.NewLine + "}";


            //richTextBoxResult.Select(richTextBoxResult.Find("} ", richTextBoxResult.Text.IndexOf(_), RichTextBoxFinds.NoHighlight), 1);
            //richTextBoxResult.SelectedText =
            //    "    public virtual " + comboBoxFirstTable +
            //    " " + comboBoxFirstTable +
            //    "{ get; set; }"
            //    + Environment.NewLine + "}";
        }

        private void comboBoxClearClick(object s, EventArgs e)
        {// При повторном нажатии на второй CB будет удалять IList<> в родительской таблице
            ComboBox comboBox = (ComboBox)s;

            if (string.IsNullOrEmpty(comboBox.Text) | string.IsNullOrWhiteSpace(comboBox.Text))
                return;

            string str = "    public virtual ICollection<" + comboBox.Text + "> " + comboBox.Text + "s { get; set; }";

            if (richTextBoxResult.Find(str) == -1)
                return;

            if (richTextBoxResult.Text.IndexOf(comboBoxFirstTable) == -1)
                return;

            richTextBoxResult.Select(
                richTextBoxResult.Find(str,// Поиск для нахождения начальной позиции
                richTextBoxResult.Text.IndexOf(comboBoxFirstTable),RichTextBoxFinds.NoHighlight),// Поиск родительской таблицы, чтобы получить начальную позицию для удаления
                str.Length + 1);// Выделить public IList<> и \n чтобы небыло новых строк
            richTextBoxResult.SelectedText = "";


            /* Удаление 2-ух полей добавившие ID и virtual class */
            string str2 = "    public int " + comboBoxFirstTable.Replace("class ", "") + "ID" + " { get; set; }";
            string str3 = 
                "    public virtual " + comboBoxFirstTable.Replace("class ", "")
                + " " + comboBoxFirstTable.Replace("class ", "")
                + " { get; set; }";

            richTextBoxResult.Select(
                richTextBoxResult.Find(str2,
                richTextBoxResult.Text.IndexOf(comboBoxFirstTable), RichTextBoxFinds.NoHighlight),
                str2.Length + str3.Length + 2);
            richTextBoxResult.SelectedText = "";
        }
        #endregion
    }
}
