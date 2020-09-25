using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;

namespace MS_SQL_Helper.SOLID
{
    class SyntaxHighlighting
    {
        public void Highlighting(RichTextBox richTextBox,
                                 string[] collectionOne,
                                 string[] collectionTwo,
                                 Color first,
                                 Color second)
        {
            Color def = Color.FromArgb(215, 220, 226);

            int currentSelStart = richTextBox.SelectionStart;
            int currentSelLength = richTextBox.SelectionLength;

            richTextBox.SelectAll();
            richTextBox.SelectionColor = def;// Цвет по умолчанию

            foreach (var item in collectionOne)
            {
                var matches = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = first;// Цвет для первой коллекции
                }
            }

            foreach (var item in collectionTwo)
            {
                var matches2 = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches2.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = second;// Цвет для второй коллекции
                }
            }

            richTextBox.Select(currentSelStart, currentSelLength);
            richTextBox.SelectionColor = def;
        }

        public void Highlighting(RichTextBox richTextBox,
                                 string[] collectionOne,
                                 string[] collectionTwo,
                                 string[] collectionThree,
                                 Color first,
                                 Color second,
                                 Color third)
        {
            Color def = Color.FromArgb(215, 220, 226);

            int currentSelStart = richTextBox.SelectionStart;
            int currentSelLength = richTextBox.SelectionLength;

            richTextBox.SelectAll();
            richTextBox.SelectionColor = def;// Цвет по умолчанию

            foreach (var item in collectionOne)
            {
                var matches = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = first;// Цвет для первой коллекции
                }
            }

            foreach (var item in collectionTwo)
            {
                var matches2 = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches2.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = second;// Цвет для второй коллекции
                }
            }

            foreach (var item in collectionThree)
            {
                var matches2 = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches2.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = third;// Цвет для третьей коллекции
                }
            }

            richTextBox.Select(currentSelStart, currentSelLength);
            richTextBox.SelectionColor = def;
        }
    }
}
