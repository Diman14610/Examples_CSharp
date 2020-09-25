using MS_SQL_Helper.SOLID;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Helper
{
    public partial class JSONAdd : Form
    {
        public JSONAdd()
        {
            InitializeComponent();
        }

        class AutoInserTypes
        {/* Класс для JSON */
            public string Type { get; set; }
            public string Content { get; set; }
        }

        int count = 1;// Для счетчика в listBox
        private readonly string path = $"Resource/Settings/AutoInserTypes.json";

        private void JSONAdd_Load(object sender, EventArgs e)
        {
            textBoxContent.Focus();

            new WorkWithComboBox().SetAutoCompleteAndItems(comboBoxType);// Fill comboBoxType

            if (!File.Exists(path))
                File.CreateText(path).Dispose();

            List<AutoInserTypes> types = JsonConvert.DeserializeObject<List<AutoInserTypes>>(File.ReadAllText(path));

            if (types == null)
                return;

            foreach (AutoInserTypes item in types)
            {
                checkedListBoxJSON.Items.Add($"{count++})  {item.Content} {item.Type}", true);
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContent.Text) | string.IsNullOrEmpty(textBoxContent.Text)
                & string.IsNullOrWhiteSpace(comboBoxType.Text) | string.IsNullOrEmpty(comboBoxType.Text))
                return;

            checkedListBoxJSON.Items.Add($"{count++})  {textBoxContent.Text} {comboBoxType.Text.ToUpper()}", true);

            textBoxContent.Clear();
            comboBoxType.Text = "";
            textBoxContent.Focus();
        }

        private void JSONAdd_Leave(object sender, EventArgs e)
        {
            if (checkedListBoxJSON.Items.Count == 0)
                return;

            List<AutoInserTypes> types = new List<AutoInserTypes>();
            List<string> collectionJSON = new List<string>();

            foreach (var item in checkedListBoxJSON.CheckedItems)
            {
                string str = Regex.Replace(item.ToString(), @"\d", "").Remove(0, 1).Replace("  ", "");

                string con = str.Remove(str.IndexOf(" "));
                string type = str.Remove(0, con.Length + 1);

                collectionJSON.Add($"{type} {con}");
            }

            collectionJSON = collectionJSON.Distinct().ToList();

            foreach (var item in collectionJSON)
            {
                string str = item;

                string type = str.Remove(str.IndexOf(" "));
                string con = str.Remove(0, type.Length + 1);

                types.Add(new AutoInserTypes { Type = type, Content = con });
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                JsonSerializer json = new JsonSerializer();
                json.Serialize(sw, types);
            }
        }
    }
}
