namespace Project_Turnaw
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.templatesHTML = new System.Windows.Forms.ComboBox();
            this.htmlOriginal = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarTAGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrasConfiguraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // templatesHTML
            // 
            this.templatesHTML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templatesHTML.FormattingEnabled = true;
            resources.ApplyResources(this.templatesHTML, "templatesHTML");
            this.templatesHTML.Name = "templatesHTML";
            this.templatesHTML.SelectedIndexChanged += new System.EventHandler(this.templatesHTML_SelectedIndexChanged);
            // 
            // htmlOriginal
            // 
            resources.ApplyResources(this.htmlOriginal, "htmlOriginal");
            this.htmlOriginal.BackColor = System.Drawing.Color.Silver;
            this.htmlOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htmlOriginal.DetectUrls = false;
            this.htmlOriginal.Name = "htmlOriginal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarHTMLToolStripMenuItem,
            this.adicionarTAGsToolStripMenuItem,
            this.outrasConfiguraçõesToolStripMenuItem,
            this.sobreBtn,
            this.toolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // configurarHTMLToolStripMenuItem
            // 
            this.configurarHTMLToolStripMenuItem.Name = "configurarHTMLToolStripMenuItem";
            resources.ApplyResources(this.configurarHTMLToolStripMenuItem, "configurarHTMLToolStripMenuItem");
            this.configurarHTMLToolStripMenuItem.Click += new System.EventHandler(this.configurarHTMLToolStripMenuItem_Click);
            // 
            // adicionarTAGsToolStripMenuItem
            // 
            this.adicionarTAGsToolStripMenuItem.Name = "adicionarTAGsToolStripMenuItem";
            resources.ApplyResources(this.adicionarTAGsToolStripMenuItem, "adicionarTAGsToolStripMenuItem");
            this.adicionarTAGsToolStripMenuItem.Click += new System.EventHandler(this.adicionarTAGsToolStripMenuItem_Click);
            // 
            // outrasConfiguraçõesToolStripMenuItem
            // 
            this.outrasConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corDaJanelaToolStripMenuItem});
            this.outrasConfiguraçõesToolStripMenuItem.Name = "outrasConfiguraçõesToolStripMenuItem";
            resources.ApplyResources(this.outrasConfiguraçõesToolStripMenuItem, "outrasConfiguraçõesToolStripMenuItem");
            // 
            // corDaJanelaToolStripMenuItem
            // 
            this.corDaJanelaToolStripMenuItem.Name = "corDaJanelaToolStripMenuItem";
            resources.ApplyResources(this.corDaJanelaToolStripMenuItem, "corDaJanelaToolStripMenuItem");
            this.corDaJanelaToolStripMenuItem.Click += new System.EventHandler(this.corDaJanelaToolStripMenuItem_Click);
            // 
            // sobreBtn
            // 
            this.sobreBtn.Name = "sobreBtn";
            resources.ApplyResources(this.sobreBtn, "sobreBtn");
            this.sobreBtn.Click += new System.EventHandler(this.sobreBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Image = global::Project_Turnaw.Properties.Resources.icons8_mais_vendidos_96;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.htmlOriginal);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.templatesHTML);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarTAGsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreBtn;
        private System.Windows.Forms.ToolStripMenuItem outrasConfiguraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDaJanelaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.RichTextBox htmlOriginal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox templatesHTML;
    }
}

