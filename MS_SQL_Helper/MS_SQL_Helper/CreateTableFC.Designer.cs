namespace MS_SQL_Helper
{
    partial class CreateTableFC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRelations = new System.Windows.Forms.Panel();
            this.btnAddRelations = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRelations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRelations
            // 
            this.panelRelations.AutoScroll = true;
            this.panelRelations.Controls.Add(this.btnAddRelations);
            this.panelRelations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRelations.Location = new System.Drawing.Point(604, 0);
            this.panelRelations.Name = "panelRelations";
            this.panelRelations.Size = new System.Drawing.Size(300, 504);
            this.panelRelations.TabIndex = 20;
            this.panelRelations.Visible = false;
            // 
            // btnAddRelations
            // 
            this.btnAddRelations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddRelations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRelations.FlatAppearance.BorderSize = 0;
            this.btnAddRelations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRelations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddRelations.Location = new System.Drawing.Point(0, 0);
            this.btnAddRelations.Name = "btnAddRelations";
            this.btnAddRelations.Size = new System.Drawing.Size(300, 40);
            this.btnAddRelations.TabIndex = 18;
            this.btnAddRelations.Text = "Добавить связи";
            this.btnAddRelations.UseVisualStyleBackColor = false;
            this.btnAddRelations.Click += new System.EventHandler(this.btnAddRelations_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 32);
            this.panel1.TabIndex = 16;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(137, 3);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(355, 26);
            this.textBoxTable.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя класса";
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddTable.Location = new System.Drawing.Point(498, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(100, 26);
            this.btnAddTable.TabIndex = 15;
            this.btnAddTable.Text = "ОК";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxType);
            this.panel2.Controls.Add(this.btnCloseTable);
            this.panel2.Controls.Add(this.btnAddField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 114);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тип данных";
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(137, 6);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(461, 26);
            this.textBoxField.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Имя поля";
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(137, 39);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(461, 26);
            this.comboBoxType.TabIndex = 14;
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnCloseTable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseTable.FlatAppearance.BorderSize = 0;
            this.btnCloseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnCloseTable.Location = new System.Drawing.Point(313, 71);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(285, 40);
            this.btnCloseTable.TabIndex = 16;
            this.btnCloseTable.Text = "Закрыть класс";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            this.btnCloseTable.Click += new System.EventHandler(this.btnCloseTable_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddField.FlatAppearance.BorderSize = 0;
            this.btnAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddField.Location = new System.Drawing.Point(16, 71);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(285, 40);
            this.btnAddField.TabIndex = 15;
            this.btnAddField.Text = "Добавить";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelRelations);
            this.panelBottom.Controls.Add(this.richTextBoxResult);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 215);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(904, 504);
            this.panelBottom.TabIndex = 1;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.richTextBoxResult.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(598, 504);
            this.richTextBoxResult.TabIndex = 19;
            this.richTextBoxResult.Text = "";
            this.richTextBoxResult.TextChanged += new System.EventHandler(this.richTextBoxResult_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerateScript);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 58);
            this.panel3.TabIndex = 20;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnGenerateScript.FlatAppearance.BorderSize = 0;
            this.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnGenerateScript.Location = new System.Drawing.Point(16, 7);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(582, 40);
            this.btnGenerateScript.TabIndex = 18;
            this.btnGenerateScript.Text = "Сохранить";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(904, 215);
            this.panelTop.TabIndex = 0;
            // 
            // CreateTableFC
            // 
            this.AcceptButton = this.btnAddField;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.CancelButton = this.btnCloseTable;
            this.ClientSize = new System.Drawing.Size(904, 719);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTableFC";
            this.Text = "CreateTableFC";
            this.Load += new System.EventHandler(this.CreateTableFC_Load);
            this.panelRelations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRelations;
        private System.Windows.Forms.Button btnAddRelations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel panelTop;
    }
}