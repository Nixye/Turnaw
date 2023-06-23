namespace Project_Turnaw.Windows
{
    partial class gerenciarHTML
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciarHTML));
            this.templateID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.footerText = new System.Windows.Forms.RichTextBox();
            this.headerText = new System.Windows.Forms.RichTextBox();
            this.nameHTMLTemp = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.excluirbtn = new System.Windows.Forms.Button();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.novobtn = new System.Windows.Forms.Button();
            this.editarbtn = new System.Windows.Forms.Button();
            this.comboTemplatesSalvos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // templateID
            // 
            this.templateID.AutoSize = true;
            this.templateID.Enabled = false;
            this.templateID.Location = new System.Drawing.Point(429, 23);
            this.templateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.templateID.Name = "templateID";
            this.templateID.Size = new System.Drawing.Size(14, 16);
            this.templateID.TabIndex = 25;
            this.templateID.Text = "0";
            this.templateID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome do Template HTML";
            // 
            // footerText
            // 
            this.footerText.BackColor = System.Drawing.Color.Silver;
            this.footerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerText.Location = new System.Drawing.Point(4, 3);
            this.footerText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.footerText.Name = "footerText";
            this.footerText.ReadOnly = true;
            this.footerText.Size = new System.Drawing.Size(670, 381);
            this.footerText.TabIndex = 6;
            this.footerText.Text = "";
            // 
            // headerText
            // 
            this.headerText.BackColor = System.Drawing.Color.Silver;
            this.headerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerText.Location = new System.Drawing.Point(4, 3);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.headerText.Name = "headerText";
            this.headerText.ReadOnly = true;
            this.headerText.Size = new System.Drawing.Size(670, 381);
            this.headerText.TabIndex = 6;
            this.headerText.Text = "";
            // 
            // nameHTMLTemp
            // 
            this.nameHTMLTemp.Enabled = false;
            this.nameHTMLTemp.Location = new System.Drawing.Point(174, 29);
            this.nameHTMLTemp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameHTMLTemp.Name = "nameHTMLTemp";
            this.nameHTMLTemp.Size = new System.Drawing.Size(381, 23);
            this.nameHTMLTemp.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // excluirbtn
            // 
            this.excluirbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excluirbtn.BackgroundImage")));
            this.excluirbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excluirbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirbtn.Enabled = false;
            this.excluirbtn.FlatAppearance.BorderSize = 0;
            this.excluirbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.excluirbtn.Location = new System.Drawing.Point(10, 486);
            this.excluirbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirbtn.Name = "excluirbtn";
            this.excluirbtn.Size = new System.Drawing.Size(70, 34);
            this.excluirbtn.TabIndex = 10;
            this.excluirbtn.Text = "&Deletar";
            this.excluirbtn.UseVisualStyleBackColor = true;
            this.excluirbtn.Click += new System.EventHandler(this.excluirbtn_Click);
            // 
            // salvarbtn
            // 
            this.salvarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salvarbtn.BackgroundImage")));
            this.salvarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salvarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarbtn.Enabled = false;
            this.salvarbtn.FlatAppearance.BorderSize = 0;
            this.salvarbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.salvarbtn.Location = new System.Drawing.Point(622, 486);
            this.salvarbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(70, 34);
            this.salvarbtn.TabIndex = 8;
            this.salvarbtn.Text = "&Salvar";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.BackgroundImage = global::Project_Turnaw.Properties.Resources.Cancel_Disabled;
            this.cancelarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarbtn.Enabled = false;
            this.cancelarbtn.FlatAppearance.BorderSize = 0;
            this.cancelarbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelarbtn.Location = new System.Drawing.Point(545, 486);
            this.cancelarbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(70, 34);
            this.cancelarbtn.TabIndex = 9;
            this.cancelarbtn.Text = "&Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // novobtn
            // 
            this.novobtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("novobtn.BackgroundImage")));
            this.novobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novobtn.FlatAppearance.BorderSize = 0;
            this.novobtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.novobtn.Location = new System.Drawing.Point(14, 14);
            this.novobtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(70, 34);
            this.novobtn.TabIndex = 1;
            this.novobtn.Text = "&Novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // editarbtn
            // 
            this.editarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarbtn.BackgroundImage")));
            this.editarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarbtn.FlatAppearance.BorderSize = 0;
            this.editarbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editarbtn.Location = new System.Drawing.Point(377, 14);
            this.editarbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editarbtn.Name = "editarbtn";
            this.editarbtn.Size = new System.Drawing.Size(70, 34);
            this.editarbtn.TabIndex = 3;
            this.editarbtn.Text = "&Editar";
            this.editarbtn.UseVisualStyleBackColor = true;
            this.editarbtn.Click += new System.EventHandler(this.editarbtn_Click);
            // 
            // comboTemplatesSalvos
            // 
            this.comboTemplatesSalvos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemplatesSalvos.FormattingEnabled = true;
            this.comboTemplatesSalvos.Location = new System.Drawing.Point(91, 19);
            this.comboTemplatesSalvos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboTemplatesSalvos.Name = "comboTemplatesSalvos";
            this.comboTemplatesSalvos.Size = new System.Drawing.Size(278, 24);
            this.comboTemplatesSalvos.TabIndex = 2;
            this.comboTemplatesSalvos.SelectedIndexChanged += new System.EventHandler(this.comboTemplatesSalvos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameHTMLTemp);
            this.groupBox1.Controls.Add(this.cancelarbtn);
            this.groupBox1.Controls.Add(this.excluirbtn);
            this.groupBox1.Controls.Add(this.salvarbtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(716, 527);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Template";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 63);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 416);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.headerText);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(678, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Header do Template";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.footerText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(678, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Footer do Template";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gerenciarHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(750, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboTemplatesSalvos);
            this.Controls.Add(this.editarbtn);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.templateID);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gerenciarHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Templates HTML";
            this.Load += new System.EventHandler(this.gerenciarHTML_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label templateID;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox footerText;
        public System.Windows.Forms.RichTextBox headerText;
        public System.Windows.Forms.TextBox nameHTMLTemp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button excluirbtn;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Button editarbtn;
        private System.Windows.Forms.ComboBox comboTemplatesSalvos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}