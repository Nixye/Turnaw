namespace Project_Turnaw.Windows
{
    partial class gerenciarTAGs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciarTAGs));
            this.gridTags = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTemplateHTMLVinculado = new System.Windows.Forms.ComboBox();
            this.textoSubstituto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelT = new System.Windows.Forms.Label();
            this.novaTAGbtn = new System.Windows.Forms.Button();
            this.TAGName = new System.Windows.Forms.TextBox();
            this.idTag = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelaTAGbtn = new System.Windows.Forms.Button();
            this.saveTAGbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.editTag = new System.Windows.Forms.Button();
            this.excluirTAGbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTags
            // 
            this.gridTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTags.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tag});
            this.gridTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTags.Enabled = false;
            this.gridTags.Location = new System.Drawing.Point(3, 19);
            this.gridTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridTags.MultiSelect = false;
            this.gridTags.Name = "gridTags";
            this.gridTags.ReadOnly = true;
            this.gridTags.RowHeadersVisible = false;
            this.gridTags.RowTemplate.Height = 25;
            this.gridTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTags.ShowEditingIcon = false;
            this.gridTags.Size = new System.Drawing.Size(155, 352);
            this.gridTags.TabIndex = 3;
            this.gridTags.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTags_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 24;
            // 
            // tag
            // 
            this.tag.HeaderText = "TAG";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Template:";
            // 
            // comboTemplateHTMLVinculado
            // 
            this.comboTemplateHTMLVinculado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemplateHTMLVinculado.FormattingEnabled = true;
            this.comboTemplateHTMLVinculado.Location = new System.Drawing.Point(83, 19);
            this.comboTemplateHTMLVinculado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboTemplateHTMLVinculado.Name = "comboTemplateHTMLVinculado";
            this.comboTemplateHTMLVinculado.Size = new System.Drawing.Size(227, 24);
            this.comboTemplateHTMLVinculado.TabIndex = 1;
            this.comboTemplateHTMLVinculado.SelectedIndexChanged += new System.EventHandler(this.comboTemplateHTMLVinculado_SelectedIndexChanged);
            // 
            // textoSubstituto
            // 
            this.textoSubstituto.BackColor = System.Drawing.Color.Silver;
            this.textoSubstituto.Location = new System.Drawing.Point(10, 103);
            this.textoSubstituto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoSubstituto.Name = "textoSubstituto";
            this.textoSubstituto.ReadOnly = true;
            this.textoSubstituto.Size = new System.Drawing.Size(358, 222);
            this.textoSubstituto.TabIndex = 45;
            this.textoSubstituto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Substituir Tag Por:";
            // 
            // LabelT
            // 
            this.LabelT.AutoSize = true;
            this.LabelT.Location = new System.Drawing.Point(7, 47);
            this.LabelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelT.Name = "LabelT";
            this.LabelT.Size = new System.Drawing.Size(32, 16);
            this.LabelT.TabIndex = 46;
            this.LabelT.Text = "Tag:";
            // 
            // novaTAGbtn
            // 
            this.novaTAGbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novaTAGbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novaTAGbtn.Enabled = false;
            this.novaTAGbtn.FlatAppearance.BorderSize = 0;
            this.novaTAGbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.novaTAGbtn.Location = new System.Drawing.Point(180, 178);
            this.novaTAGbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.novaTAGbtn.Name = "novaTAGbtn";
            this.novaTAGbtn.Size = new System.Drawing.Size(60, 34);
            this.novaTAGbtn.TabIndex = 30;
            this.novaTAGbtn.Text = "&Novo";
            this.novaTAGbtn.UseVisualStyleBackColor = true;
            this.novaTAGbtn.Click += new System.EventHandler(this.novaTAGbtn_Click);
            // 
            // TAGName
            // 
            this.TAGName.Enabled = false;
            this.TAGName.Location = new System.Drawing.Point(46, 43);
            this.TAGName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TAGName.Name = "TAGName";
            this.TAGName.Size = new System.Drawing.Size(180, 23);
            this.TAGName.TabIndex = 44;
            // 
            // idTag
            // 
            this.idTag.AutoSize = true;
            this.idTag.Location = new System.Drawing.Point(7, 18);
            this.idTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idTag.Name = "idTag";
            this.idTag.Size = new System.Drawing.Size(14, 16);
            this.idTag.TabIndex = 43;
            this.idTag.Text = "0";
            this.idTag.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelT);
            this.groupBox1.Controls.Add(this.TAGName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoSubstituto);
            this.groupBox1.Controls.Add(this.cancelaTAGbtn);
            this.groupBox1.Controls.Add(this.saveTAGbtn);
            this.groupBox1.Controls.Add(this.idTag);
            this.groupBox1.Location = new System.Drawing.Point(247, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 374);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da TAG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cancelaTAGbtn
            // 
            this.cancelaTAGbtn.BackgroundImage = global::Project_Turnaw.Properties.Resources.Cancel_Disabled;
            this.cancelaTAGbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelaTAGbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelaTAGbtn.Enabled = false;
            this.cancelaTAGbtn.FlatAppearance.BorderSize = 0;
            this.cancelaTAGbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelaTAGbtn.Location = new System.Drawing.Point(240, 333);
            this.cancelaTAGbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelaTAGbtn.Name = "cancelaTAGbtn";
            this.cancelaTAGbtn.Size = new System.Drawing.Size(60, 34);
            this.cancelaTAGbtn.TabIndex = 46;
            this.cancelaTAGbtn.Text = "&Cancelar";
            this.cancelaTAGbtn.UseVisualStyleBackColor = true;
            this.cancelaTAGbtn.Click += new System.EventHandler(this.cancelaTAGbtn_Click);
            // 
            // saveTAGbtn
            // 
            this.saveTAGbtn.BackgroundImage = global::Project_Turnaw.Properties.Resources.Save_Disabled;
            this.saveTAGbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveTAGbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTAGbtn.Enabled = false;
            this.saveTAGbtn.FlatAppearance.BorderSize = 0;
            this.saveTAGbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveTAGbtn.Location = new System.Drawing.Point(308, 333);
            this.saveTAGbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveTAGbtn.Name = "saveTAGbtn";
            this.saveTAGbtn.Size = new System.Drawing.Size(60, 34);
            this.saveTAGbtn.TabIndex = 47;
            this.saveTAGbtn.Text = "&Salvar";
            this.saveTAGbtn.UseVisualStyleBackColor = true;
            this.saveTAGbtn.Click += new System.EventHandler(this.saveTAGbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridTags);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 374);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Project_Turnaw.Properties.Resources.Delete_Disabled;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(318, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exportar &TAGs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editTag
            // 
            this.editTag.BackgroundImage = global::Project_Turnaw.Properties.Resources.Edit_Disabled;
            this.editTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTag.Enabled = false;
            this.editTag.FlatAppearance.BorderSize = 0;
            this.editTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editTag.Location = new System.Drawing.Point(180, 219);
            this.editTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editTag.Name = "editTag";
            this.editTag.Size = new System.Drawing.Size(60, 34);
            this.editTag.TabIndex = 31;
            this.editTag.Text = "&Editar";
            this.editTag.UseVisualStyleBackColor = true;
            this.editTag.Click += new System.EventHandler(this.editTag_Click);
            // 
            // excluirTAGbtn
            // 
            this.excluirTAGbtn.BackgroundImage = global::Project_Turnaw.Properties.Resources.Delete_Disabled;
            this.excluirTAGbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excluirTAGbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirTAGbtn.Enabled = false;
            this.excluirTAGbtn.FlatAppearance.BorderSize = 0;
            this.excluirTAGbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.excluirTAGbtn.Location = new System.Drawing.Point(180, 261);
            this.excluirTAGbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirTAGbtn.Name = "excluirTAGbtn";
            this.excluirTAGbtn.Size = new System.Drawing.Size(60, 34);
            this.excluirTAGbtn.TabIndex = 32;
            this.excluirTAGbtn.Text = "&Deletar";
            this.excluirTAGbtn.UseVisualStyleBackColor = true;
            this.excluirTAGbtn.Click += new System.EventHandler(this.excluirTAGbtn_Click);
            // 
            // gerenciarTAGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(632, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.editTag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTemplateHTMLVinculado);
            this.Controls.Add(this.excluirTAGbtn);
            this.Controls.Add(this.novaTAGbtn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gerenciarTAGs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de TAGs";
            this.Load += new System.EventHandler(this.gerenciarTAGs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTemplateHTMLVinculado;
        private System.Windows.Forms.Button excluirTAGbtn;
        private System.Windows.Forms.Button cancelaTAGbtn;
        private System.Windows.Forms.Button saveTAGbtn;
        private System.Windows.Forms.RichTextBox textoSubstituto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelT;
        private System.Windows.Forms.Button novaTAGbtn;
        private System.Windows.Forms.TextBox TAGName;
        private System.Windows.Forms.Label idTag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editTag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}