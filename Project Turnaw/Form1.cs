using Project_Turnaw.Engine.GerenciarHTMLForm;
using Project_Turnaw.Engine.MainForm;
using Project_Turnaw.Engine.Tools;
using Project_Turnaw.Engine.Update;
using Project_Turnaw.Windows;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Turnaw
{
    public partial class Form1 : Form
    {
        public static Form1 fMain;
        public Form1() {
            InitializeComponent();
            fMain = this;
        }

        public string htmlConvertido = "";
        VisualizarHTML visHTML = new VisualizarHTML();
        bool isPremium = false;
        string softwareVersion = "2.1.1";

        private void configurarHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarHTML gerHTML = new gerenciarHTML();
            gerHTML.FormClosing += new FormClosingEventHandler(this.gerenciaHTMLClosing);
            gerHTML.ShowDialog();
        }
        private void adicionarTAGsToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenOtherForms.openGerenciarTags();
        }
        private void Form1_Load(object sender, EventArgs e) {
            //updater();
            DBHelper.CriarBancoSQLite();
            DBHelper.CriarTabelaSQlite();
            validaPremium();
            updateTemplateList();
            defineTooltips();
            validaGC();
            getTZ();
        }
        private void button2_Click(object sender, EventArgs e) {
            bool formOpened = false;
            foreach (Form f in Application.OpenForms)
                if (f.Name == "VisualizarHTML")
                    formOpened = true;
            if (!formOpened) {
                visHTML = new VisualizarHTML();
                visHTML.Show();
                return;
            }
            visHTML.Activate();
        }
        private void sobreBtn_Click(object sender, EventArgs e) {
            OpenOtherForms.openGerenciaSobre();
        }
        private void corDaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPremium) {
                OpenOtherForms.openGerenciaCor();
            } else {
                MessageBox.Show("Este é um recurso apenas para assinantes!\n Acesse o botão [Seja Premium] para assinar, ou ativar o aplicativo.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            salvaGC();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            OpenOtherForms.openAssinatura();
        }
        private void templatesHTML_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] textSplited = templatesHTML.Text.Split(' ');
            try { int.Parse(textSplited[0]); }
            catch { return; }
            htmlConvertido = "";
            htmlConvertido = AdjustEngine.AdjustText(htmlOriginal.Text, int.Parse(textSplited[0]));
            FormCollection formCollection = Application.OpenForms;
            bool formOpened = false;
            foreach (Form f in formCollection) {
                if (f.Name == "VisualizarHTML")
                    formOpened = true;
            }
            if (formOpened) {
                visHTML.browserText = htmlConvertido;
                visHTML.htmlConvertido.Text = visHTML.browserText;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (htmlOriginal.ZoomFactor < 5)
                htmlOriginal.ZoomFactor = htmlOriginal.ZoomFactor + 0.5f;
            validateZoomButtons();
            SGDBHelper.saveTZ(new TZ { textZoom = htmlOriginal.ZoomFactor.ToString() });
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (htmlOriginal.ZoomFactor > 1)
                htmlOriginal.ZoomFactor = htmlOriginal.ZoomFactor - 0.5f;
            validateZoomButtons();
            SGDBHelper.saveTZ(new TZ { textZoom = htmlOriginal.ZoomFactor.ToString() });
        }

        #region[Tools]
        private void gerenciaHTMLClosing(object sender, FormClosingEventArgs e) {
            updateTemplateList();
        }
        public void updateTemplateList()
        {
            HTMLs hmls = engineGHTMLF.getHTMLs();
            templatesHTML.Items.Clear();
            if (hmls != null) {
                if (hmls.htmls.Count > 0) {
                    foreach (HTML s in hmls.htmls) { templatesHTML.Items.Add(s.id + " > " + s.title); }
                    templatesHTML.SelectedIndex = 0;
                }
            }
        }
        public void defineTooltips() {
            toolTip1.SetToolTip(templatesHTML, "Escolha o template que será usado como padrão para converter o turno abaixo!");
            toolTip1.SetToolTip(button2, "Visualize o HTML convertido!");
        }
        public void validaPremium()
        {
            isPremium = EngineColorAndTransp.defineCT_PremiumAdvanced(this);
            toolStripMenuItem1.Text = "Freeware Version";
            groupBox1.ForeColor = ForeColor;
            groupBox1.BackColor = BackColor;
            htmlOriginal.BackColor = BackColor;
            htmlOriginal.ForeColor = ForeColor;
            toolStripMenuItem1.Font = Font;
            menuStrip1.Font = Font;
            htmlOriginal.Font = Font;
        }
        public void validaGC() {
            Engine.Tools.GC gcData = SGDBHelper.getGC();
            Width = (gcData.widght > 460 ? gcData.widght : 460);
            Height = (gcData.height > 215 ? gcData.height : 215);
            Rectangle b = Screen.GetWorkingArea(this);
            gcData.positionX = gcData.positionX < -b.Height ? 0 : gcData.positionX;
            gcData.positionX = gcData.positionX > b.Height ? 0 : gcData.positionX;
            gcData.positionY = gcData.positionY < -b.Width ? 0 : gcData.positionY;
            gcData.positionY = gcData.positionY > b.Width ? 0 : gcData.positionY;
            if (gcData.positionY == 0 && gcData.positionX == 0) CenterToScreen();
            else Location = new Point(gcData.positionX, gcData.positionY);
            htmlOriginal.Text = (!string.IsNullOrEmpty(gcData.textoNSalvo) ? gcData.textoNSalvo : "");
            if (!string.IsNullOrEmpty(gcData.ultimoHtml)) {
                foreach (string i in templatesHTML.Items) {
                    if (i == gcData.ultimoHtml)
                        templatesHTML.SelectedIndex = templatesHTML.FindStringExact(gcData.ultimoHtml);
                }
            }
            Visible = true;
        }
        public void salvaGC() {
            Engine.Tools.GC gcData = SGDBHelper.getGC();
            if (!string.IsNullOrEmpty(templatesHTML.Text))
                gcData.ultimoHtml = templatesHTML.Text;
            if (!string.IsNullOrEmpty(htmlOriginal.Text))
                gcData.textoNSalvo = htmlOriginal.Text;
            gcData.height = Height < 215 ? 215 : Height;
            gcData.widght = Width < 460 ? 460 : Width;
            gcData.positionX = Location.X;
            gcData.positionY = Location.Y;
            SGDBHelper.saveGC(gcData);
        }
        public void getTZ()
        {
            TZ tz = SGDBHelper.getTZ();
            if (tz.textZoom != null) {
                float zoom = float.Parse(tz.textZoom, System.Globalization.NumberStyles.Float);
                htmlOriginal.ZoomFactor = zoom;
            }
            validateZoomButtons();
        }
        public void validateZoomButtons()
        {
            float zoom = htmlOriginal.ZoomFactor;
            if (zoom == 1) {
                button3.Enabled = true;
                button3.BackgroundImage = Properties.Resources.ZoomIn;
                button4.Enabled = false;
                button4.BackgroundImage = Properties.Resources.ZoomOut_Disabled;
            } else if (zoom == 5) {
                button3.Enabled = false;
                button3.BackgroundImage = Properties.Resources.ZoomIn_Disabled;
                button4.Enabled = true;
                button4.BackgroundImage = Properties.Resources.ZoomOut;
            } else if (zoom > 1 && zoom < 5) {
                button3.Enabled = true;
                button3.BackgroundImage = Properties.Resources.ZoomIn;
                button4.Enabled = true;
                button4.BackgroundImage = Properties.Resources.ZoomOut;

            }
        }
        public void updater() {
            EngineUpdate.verifyUpdate(softwareVersion);
        }
        #endregion


    }
}
