namespace MS_SQL_Helper
{
    partial class RelationShip
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelRelation = new System.Windows.Forms.Panel();
            this.checkedListBoxRelation = new System.Windows.Forms.CheckedListBox();
            this.panelTop.SuspendLayout();
            this.panelRelation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnGenerateScript);
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop.Size = new System.Drawing.Size(904, 50);
            this.panelTop.TabIndex = 0;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnGenerateScript.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateScript.FlatAppearance.BorderSize = 0;
            this.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnGenerateScript.Location = new System.Drawing.Point(601, 5);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(298, 40);
            this.btnGenerateScript.TabIndex = 1;
            this.btnGenerateScript.Text = "Сформировать скрипт";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Visible = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnLoad.Location = new System.Drawing.Point(5, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(298, 40);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить таблицы";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 50);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(904, 669);
            this.panelFill.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // panelRelation
            // 
            this.panelRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.panelRelation.Controls.Add(this.checkedListBoxRelation);
            this.panelRelation.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRelation.Location = new System.Drawing.Point(883, 50);
            this.panelRelation.Name = "panelRelation";
            this.panelRelation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panelRelation.Size = new System.Drawing.Size(21, 669);
            this.panelRelation.TabIndex = 2;
            // 
            // checkedListBoxRelation
            // 
            this.checkedListBoxRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.checkedListBoxRelation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxRelation.CheckOnClick = true;
            this.checkedListBoxRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxRelation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.checkedListBoxRelation.FormattingEnabled = true;
            this.checkedListBoxRelation.Location = new System.Drawing.Point(3, 0);
            this.checkedListBoxRelation.Name = "checkedListBoxRelation";
            this.checkedListBoxRelation.Size = new System.Drawing.Size(18, 669);
            this.checkedListBoxRelation.TabIndex = 2;
            this.checkedListBoxRelation.MouseEnter += new System.EventHandler(this.checkedListBoxRelation_MouseEnter);
            this.checkedListBoxRelation.MouseLeave += new System.EventHandler(this.checkedListBoxRelation_MouseLeave);
            // 
            // RelationShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(904, 719);
            this.Controls.Add(this.panelRelation);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RelationShip";
            this.Text = "RelationShip";
            this.Resize += new System.EventHandler(this.RelationShip_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelRelation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelRelation;
        private System.Windows.Forms.CheckedListBox checkedListBoxRelation;
    }
}