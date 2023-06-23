namespace Project_Turnaw.Windows
{
    partial class VisualizarHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarHTML));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.htmlView = new System.Windows.Forms.TabPage();
            this.copiarTextobtn1 = new System.Windows.Forms.Button();
            this.htmlConvertido = new System.Windows.Forms.RichTextBox();
            this.pageView = new System.Windows.Forms.TabPage();
            this.copiarTextobtn2 = new System.Windows.Forms.Button();
            this.bWork = new System.ComponentModel.BackgroundWorker();
            this.validationText = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.htmlView.SuspendLayout();
            this.pageView.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 4);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(898, 362);
            this.webBrowser1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(4, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(422, 17);
            this.toolStripStatusLabel3.Text = "O Html pode ficar um pouco desconfigurado, para melhor visualização utilize: ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.IsLink = true;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel4.Text = "HTML FORMATTER";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.htmlView);
            this.tabControl1.Controls.Add(this.pageView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 421);
            this.tabControl1.TabIndex = 3;
            // 
            // htmlView
            // 
            this.htmlView.Controls.Add(this.copiarTextobtn1);
            this.htmlView.Controls.Add(this.htmlConvertido);
            this.htmlView.Location = new System.Drawing.Point(4, 25);
            this.htmlView.Margin = new System.Windows.Forms.Padding(4);
            this.htmlView.Name = "htmlView";
            this.htmlView.Padding = new System.Windows.Forms.Padding(4);
            this.htmlView.Size = new System.Drawing.Size(906, 392);
            this.htmlView.TabIndex = 0;
            this.htmlView.Text = "Texto HTML";
            this.htmlView.UseVisualStyleBackColor = true;
            // 
            // copiarTextobtn1
            // 
            this.copiarTextobtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copiarTextobtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copiarTextobtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copiarTextobtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copiarTextobtn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copiarTextobtn1.Location = new System.Drawing.Point(812, 20);
            this.copiarTextobtn1.Margin = new System.Windows.Forms.Padding(4);
            this.copiarTextobtn1.Name = "copiarTextobtn1";
            this.copiarTextobtn1.Size = new System.Drawing.Size(70, 37);
            this.copiarTextobtn1.TabIndex = 3;
            this.copiarTextobtn1.Text = "&Copiar";
            this.copiarTextobtn1.UseVisualStyleBackColor = true;
            this.copiarTextobtn1.Click += new System.EventHandler(this.button3_Click);
            // 
            // htmlConvertido
            // 
            this.htmlConvertido.BackColor = System.Drawing.Color.Silver;
            this.htmlConvertido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlConvertido.Location = new System.Drawing.Point(4, 4);
            this.htmlConvertido.Margin = new System.Windows.Forms.Padding(4);
            this.htmlConvertido.Name = "htmlConvertido";
            this.htmlConvertido.Size = new System.Drawing.Size(898, 384);
            this.htmlConvertido.TabIndex = 4;
            this.htmlConvertido.Text = "";
            // 
            // pageView
            // 
            this.pageView.Controls.Add(this.copiarTextobtn2);
            this.pageView.Controls.Add(this.webBrowser1);
            this.pageView.Controls.Add(this.statusStrip1);
            this.pageView.Location = new System.Drawing.Point(4, 25);
            this.pageView.Margin = new System.Windows.Forms.Padding(4);
            this.pageView.Name = "pageView";
            this.pageView.Padding = new System.Windows.Forms.Padding(4);
            this.pageView.Size = new System.Drawing.Size(906, 392);
            this.pageView.TabIndex = 1;
            this.pageView.Text = "Visualização HTML";
            this.pageView.UseVisualStyleBackColor = true;
            // 
            // copiarTextobtn2
            // 
            this.copiarTextobtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copiarTextobtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copiarTextobtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copiarTextobtn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copiarTextobtn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copiarTextobtn2.Location = new System.Drawing.Point(812, 20);
            this.copiarTextobtn2.Margin = new System.Windows.Forms.Padding(4);
            this.copiarTextobtn2.Name = "copiarTextobtn2";
            this.copiarTextobtn2.Size = new System.Drawing.Size(70, 37);
            this.copiarTextobtn2.TabIndex = 2;
            this.copiarTextobtn2.Text = "&Copiar";
            this.copiarTextobtn2.UseVisualStyleBackColor = true;
            this.copiarTextobtn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bWork
            // 
            this.bWork.WorkerReportsProgress = true;
            this.bWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWork_DoWork);
            this.bWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWork_ProgressChanged);
            // 
            // validationText
            // 
            this.validationText.Tick += new System.EventHandler(this.validationText_Tick);
            // 
            // VisualizarHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(914, 421);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualizarHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar HTML";
            this.Load += new System.EventHandler(this.VisualizarHTML_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.htmlView.ResumeLayout(false);
            this.pageView.ResumeLayout(false);
            this.pageView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage htmlView;
        private System.Windows.Forms.TabPage pageView;
        private System.Windows.Forms.Button copiarTextobtn2;
        private System.Windows.Forms.Button copiarTextobtn1;
        public System.Windows.Forms.RichTextBox htmlConvertido;
        private System.ComponentModel.BackgroundWorker bWork;
        private System.Windows.Forms.Timer validationText;
    }
}