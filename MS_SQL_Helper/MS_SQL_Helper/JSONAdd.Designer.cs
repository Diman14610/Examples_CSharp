namespace MS_SQL_Helper
{
    partial class JSONAdd
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
            this.btnAddField = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.panelRigth = new System.Windows.Forms.Panel();
            this.checkedListBoxJSON = new System.Windows.Forms.CheckedListBox();
            this.panelLeft.SuspendLayout();
            this.panelRigth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddField.FlatAppearance.BorderSize = 0;
            this.btnAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddField.Location = new System.Drawing.Point(16, 96);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(590, 40);
            this.btnAddField.TabIndex = 2;
            this.btnAddField.Text = "Добавить";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.comboBoxType);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.textBoxContent);
            this.panelLeft.Controls.Add(this.btnAddField);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(904, 719);
            this.panelLeft.TabIndex = 18;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(124, 53);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(482, 28);
            this.comboBoxType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя поля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип данных";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(124, 12);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(482, 26);
            this.textBoxContent.TabIndex = 0;
            // 
            // panelRigth
            // 
            this.panelRigth.Controls.Add(this.checkedListBoxJSON);
            this.panelRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigth.Location = new System.Drawing.Point(604, 0);
            this.panelRigth.Name = "panelRigth";
            this.panelRigth.Size = new System.Drawing.Size(300, 719);
            this.panelRigth.TabIndex = 19;
            // 
            // checkedListBoxJSON
            // 
            this.checkedListBoxJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.checkedListBoxJSON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxJSON.CheckOnClick = true;
            this.checkedListBoxJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBoxJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.checkedListBoxJSON.FormattingEnabled = true;
            this.checkedListBoxJSON.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxJSON.Name = "checkedListBoxJSON";
            this.checkedListBoxJSON.Size = new System.Drawing.Size(300, 719);
            this.checkedListBoxJSON.TabIndex = 0;
            // 
            // JSONAdd
            // 
            this.AcceptButton = this.btnAddField;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(904, 719);
            this.Controls.Add(this.panelRigth);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JSONAdd";
            this.Text = "JSONAdd";
            this.Load += new System.EventHandler(this.JSONAdd_Load);
            this.Leave += new System.EventHandler(this.JSONAdd_Leave);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRigth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Panel panelRigth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckedListBox checkedListBoxJSON;
    }
}