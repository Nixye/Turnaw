using Project_Turnaw.Engine.GerenciaCorForm;
using Project_Turnaw.Engine.GerenciaTransparenciaForm;
using Project_Turnaw.Engine.MainForm;
using Project_Turnaw.Engine.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class VisualizarHTML : Form {
        public VisualizarHTML() {
            InitializeComponent();
        }
        public string browserText = "";
        public int htmlSelectedID = 0;
        public string tickBrowserText = "";
        public int tickHtmlSelectedID = 0;
        Form1 _form1;

        private void VisualizarHTML_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
            validationText.Enabled = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            htmlConvertido.ForeColor = ForeColor;
            htmlConvertido.BackColor = BackColor;
            tabControl1.Selecting += new TabControlCancelEventHandler(selectPageView);

        }
        private void toolStripStatusLabel4_Click(object sender, EventArgs e) {
            webBrowser1.Navigate("https://htmledit.squarefree.com/");
        }
        private void button3_Click(object sender, EventArgs e) {
            Clipboard.SetText(htmlConvertido.Text);
            MessageBox.Show("Copiado.", "Informação (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e) {
            Clipboard.SetText(htmlConvertido.Text);
            MessageBox.Show("Copiado.", "Informação (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bWork_DoWork(object sender, DoWorkEventArgs e) {
            bWork.ReportProgress(100);
        }
        private void bWork_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            htmlConvertido.Text = loadHTML(this);
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
                webBrowser1.Document.Write(string.Empty);
            webBrowser1.DocumentText = preparePage(false);
        }
        private void validationText_Tick(object sender, EventArgs e) {
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Form1")
                    _form1 = (Form1)f;
            string[] textSplited = _form1.templatesHTML.Text.Split(' ');
            try { tickHtmlSelectedID = int.Parse(textSplited[0]); } catch { }
            tickBrowserText = AdjustEngine.AdjustText(_form1.htmlOriginal.Text, tickHtmlSelectedID);
            if (!tickHtmlSelectedID.Equals(htmlSelectedID) || !tickBrowserText.Equals(browserText)) {
                if (!bWork.IsBusy)
                    bWork.RunWorkerAsync();
            }
        }

        #region [Tools]
        public string loadHTML(VisualizarHTML vHtml) {
            try {
                vHtml.browserText = tickBrowserText;
                vHtml.htmlSelectedID = tickHtmlSelectedID;
                return tickBrowserText;
            } catch { return ""; }
        }
        public string preparePage(bool getFromHTMLViwer)
        {
            string finalPage = "";
            finalPage += "<!DOCTYPE html>\n";
            finalPage += "<html>\n";
            finalPage += "<head>\n";
            finalPage += "  <link href=\"https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css\" rel=\"stylesheet\">\n";
            finalPage += "  <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css\">\n";
            finalPage += "  <script src=\"https://code.jquery.com/jquery-1.10.2.js\"></script>\n";
            finalPage += "  <script src=\"https://code.jquery.com/ui/1.10.4/jquery-ui.js\"></script>\n";
            finalPage += "</head>\n";
            finalPage += "<body>\n\n\n\n";
            if(getFromHTMLViwer)
                finalPage += htmlConvertido.Text;
            else
                finalPage += browserText;
            finalPage += "\n\n\n\n</body>\n";
            finalPage += "</html>";
            return finalPage;
        }
        void selectPageView(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if(current.Name == "pageView")
                webBrowser1.DocumentText = preparePage(true);
        }


        #endregion


    }
}
