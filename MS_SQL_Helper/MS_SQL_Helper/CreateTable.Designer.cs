namespace MS_SQL_Helper
{
    partial class CreateTable
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
            this.panelRigth = new System.Windows.Forms.Panel();
            this.checkBoxAutoInserType = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertID = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxToUpper = new System.Windows.Forms.CheckBox();
            this.checkBoxAI = new System.Windows.Forms.CheckBox();
            this.checkBoxPK = new System.Windows.Forms.CheckBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.btnShowRigth = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRigth.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRigth
            // 
            this.panelRigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.panelRigth.Controls.Add(this.checkBoxAutoInserType);
            this.panelRigth.Controls.Add(this.checkBoxInsertID);
            this.panelRigth.Controls.Add(this.checkBoxReplaceSpace);
            this.panelRigth.Controls.Add(this.checkBoxToUpper);
            this.panelRigth.Controls.Add(this.checkBoxAI);
            this.panelRigth.Controls.Add(this.checkBoxPK);
            this.panelRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigth.Location = new System.Drawing.Point(614, 0);
            this.panelRigth.Name = "panelRigth";
            this.panelRigth.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelRigth.Size = new System.Drawing.Size(290, 719);
            this.panelRigth.TabIndex = 4;
            // 
            // checkBoxAutoInserType
            // 
            this.checkBoxAutoInserType.AutoSize = true;
            this.checkBoxAutoInserType.Checked = true;
            this.checkBoxAutoInserType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoInserType.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxAutoInserType.Location = new System.Drawing.Point(5, 120);
            this.checkBoxAutoInserType.Name = "checkBoxAutoInserType";
            this.checkBoxAutoInserType.Size = new System.Drawing.Size(285, 24);
            this.checkBoxAutoInserType.TabIndex = 5;
            this.checkBoxAutoInserType.Text = "Авто подстановка типов";
            this.checkBoxAutoInserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAutoInserType.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertID
            // 
            this.checkBoxInsertID.AutoSize = true;
            this.checkBoxInsertID.Checked = true;
            this.checkBoxInsertID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInsertID.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxInsertID.Location = new System.Drawing.Point(5, 96);
            this.checkBoxInsertID.Name = "checkBoxInsertID";
            this.checkBoxInsertID.Size = new System.Drawing.Size(285, 24);
            this.checkBoxInsertID.TabIndex = 4;
            this.checkBoxInsertID.Text = "Начинать имя поля с id INT";
            this.checkBoxInsertID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxInsertID.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceSpace
            // 
            this.checkBoxReplaceSpace.AutoSize = true;
            this.checkBoxReplaceSpace.Checked = true;
            this.checkBoxReplaceSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReplaceSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxReplaceSpace.Location = new System.Drawing.Point(5, 72);
            this.checkBoxReplaceSpace.Name = "checkBoxReplaceSpace";
            this.checkBoxReplaceSpace.Size = new System.Drawing.Size(285, 24);
            this.checkBoxReplaceSpace.TabIndex = 3;
            this.checkBoxReplaceSpace.Text = "Заменять пробел на _";
            this.checkBoxReplaceSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxReplaceSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxToUpper
            // 
            this.checkBoxToUpper.AutoSize = true;
            this.checkBoxToUpper.Checked = true;
            this.checkBoxToUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxToUpper.Location = new System.Drawing.Point(5, 48);
            this.checkBoxToUpper.Name = "checkBoxToUpper";
            this.checkBoxToUpper.Size = new System.Drawing.Size(285, 24);
            this.checkBoxToUpper.TabIndex = 2;
            this.checkBoxToUpper.Text = "Имя таблицы с заглавной";
            this.checkBoxToUpper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxToUpper.UseVisualStyleBackColor = true;
            // 
            // checkBoxAI
            // 
            this.checkBoxAI.AutoSize = true;
            this.checkBoxAI.Checked = true;
            this.checkBoxAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxAI.Location = new System.Drawing.Point(5, 24);
            this.checkBoxAI.Name = "checkBoxAI";
            this.checkBoxAI.Size = new System.Drawing.Size(285, 24);
            this.checkBoxAI.TabIndex = 1;
            this.checkBoxAI.Text = "IDENTITY(1,1)";
            this.checkBoxAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAI.UseVisualStyleBackColor = true;
            // 
            // checkBoxPK
            // 
            this.checkBoxPK.AutoSize = true;
            this.checkBoxPK.Checked = true;
            this.checkBoxPK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPK.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPK.Location = new System.Drawing.Point(5, 0);
            this.checkBoxPK.Name = "checkBoxPK";
            this.checkBoxPK.Size = new System.Drawing.Size(285, 24);
            this.checkBoxPK.TabIndex = 0;
            this.checkBoxPK.Text = "PRIMARY KEY";
            this.checkBoxPK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPK.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.btnShowRigth);
            this.panelLeft.Controls.Add(this.richTextBoxResult);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.btnClose);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(614, 719);
            this.panelLeft.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerateScript);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 58);
            this.panel3.TabIndex = 19;
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
            this.btnGenerateScript.Text = "Сформировать";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Visible = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // btnShowRigth
            // 
            this.btnShowRigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnShowRigth.FlatAppearance.BorderSize = 0;
            this.btnShowRigth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRigth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnShowRigth.Location = new System.Drawing.Point(273, 700);
            this.btnShowRigth.Name = "btnShowRigth";
            this.btnShowRigth.Size = new System.Drawing.Size(28, 50);
            this.btnShowRigth.TabIndex = 8;
            this.btnShowRigth.TabStop = false;
            this.btnShowRigth.Text = "<";
            this.btnShowRigth.UseVisualStyleBackColor = false;
            this.btnShowRigth.Click += new System.EventHandler(this.btnShowRigth_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.richTextBoxResult.Location = new System.Drawing.Point(16, 205);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(582, 489);
            this.richTextBoxResult.TabIndex = 17;
            this.richTextBoxResult.Text = "";
            this.richTextBoxResult.Visible = false;
            this.richTextBoxResult.TextChanged += new System.EventHandler(this.richTextBoxResult_TextChanged);
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
            this.panel2.Size = new System.Drawing.Size(614, 114);
            this.panel2.TabIndex = 16;
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
            this.textBoxField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxField_KeyPress);
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
            this.comboBoxType.Enter += new System.EventHandler(this.comboBoxType_Enter);
            this.comboBoxType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxType_KeyDown);
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
            this.btnCloseTable.Text = "Закрыть таблицу";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 32);
            this.panel1.TabIndex = 15;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(137, 3);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(355, 26);
            this.textBoxTable.TabIndex = 14;
            this.textBoxTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTable_KeyPress);
            this.textBoxTable.Leave += new System.EventHandler(this.textBoxTable_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя таблицы";
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnClose.Location = new System.Drawing.Point(468, 700);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAddField;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.CancelButton = this.btnCloseTable;
            this.ClientSize = new System.Drawing.Size(904, 719);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRigth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Leave += new System.EventHandler(this.Form2_Leave);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panelRigth.ResumeLayout(false);
            this.panelRigth.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRigth;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxAI;
        private System.Windows.Forms.CheckBox checkBoxPK;
        private System.Windows.Forms.Button btnShowRigth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.CheckBox checkBoxToUpper;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxReplaceSpace;
        private System.Windows.Forms.CheckBox checkBoxInsertID;
        private System.Windows.Forms.CheckBox checkBoxAutoInserType;
    }
}