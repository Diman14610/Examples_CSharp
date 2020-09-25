using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Helper.SOLID
{
    class WorkWithComboBox
    {
        public void SetAutoCompleteAndItems(ComboBox comboBox)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            foreach (var item in Variables.CollectionTypesSQL)
            {
                auto.Add(item);
                comboBox.AutoCompleteCustomSource = auto;
                comboBox.Items.Add(item);
            }
        }

        public void SetAutoCompleteAndItems(ComboBox comboBox, string[] collection)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            foreach (var item in collection)
            {
                auto.Add(item);
                comboBox.AutoCompleteCustomSource = auto;
                comboBox.Items.Add(item);
            }
        }

        public void Focus(ComboBox comboBox)
        {/* Установить фокус в скобках */
            comboBox.Focus();
            comboBox.Select(comboBox.Text.Length - 1, 0);
        }

        public void PressRigthFocus(ComboBox comboBox, KeyEventArgs e)
        {/* При нажатие на стрелку фокус будет в скобках */
            if (e.KeyCode == Keys.Right)
                comboBox.Select(comboBox.Text.Length - 2, 0);
        }
    }
}
