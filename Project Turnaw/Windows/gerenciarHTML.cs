using Project_Turnaw.Engine.Activation;
using Project_Turnaw.Engine.GerenciarHTMLForm;
using Project_Turnaw.Engine.Tools;
using System;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class gerenciarHTML : Form
    {
        public gerenciarHTML() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!EngineActivation.validaGenericPremium()) {
                try {
                    if (engineGHTMLF.getHTMLs().htmls.Count == 10) {
                        MessageBox.Show("Você não é um assinante, e só poderá cadastrar 10 Templates!\n Acesse o botão [Seja Premium] na tela principal para assinar, ou ativar o aplicativo.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                } catch { }
            }
            enablers(commands.novo);
            templateID.Text = "-1";
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            getHTMLsList();
            enablers(commands.cancela);
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboTemplatesSalvos.Text)) {
                enablers(commands.edita);
                string[] textSplited = comboTemplatesSalvos.Text.Split(' ');
                string idHTMLTemplate = textSplited[0];
                setHTMLDataInFields(idHTMLTemplate);
            }
            else
                MessageBox.Show("Selecione algum HTML.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void excluirbtn_Click(object sender, EventArgs e)
        {
            if (engineGHTMLF.deleteHTML(int.Parse(templateID.Text))) {
                MessageBox.Show("Excluído com sucesso!", "Sucesso ^-^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getHTMLsList();
                enablers(commands.deleta);
                return;
            }
            MessageBox.Show("Erro ao tentar excluir!", "Erro -_-'", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameHTMLTemp.Text)) {
                MessageBox.Show("Preencha o campo [Nome do Template HTML].", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HTML html = new HTML();
            html.id = int.Parse(templateID.Text);
            html.title = nameHTMLTemp.Text;
            html.header = headerText.Text;
            html.footer = footerText.Text;
            if (engineGHTMLF.saveNew(html)) {
                MessageBox.Show("Salvo com sucesso!", "Sucesso ^-^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getHTMLsList();
                enablers(commands.salva);
                return;
            }
            MessageBox.Show("Erro ao tentar salvar!", "Erro -_-'", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gerenciarHTML_Load(object sender, EventArgs e)
        {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
            groupBox1.ForeColor = ForeColor;
            groupBox1.BackColor = BackColor;
            tabPage1.BackColor = BackColor;
            tabPage1.ForeColor = ForeColor;
            tabPage2.BackColor = BackColor;
            tabPage2.ForeColor = ForeColor;
            headerText.BackColor = BackColor;
            headerText.ForeColor = ForeColor;
            footerText.BackColor = BackColor;
            footerText.ForeColor = ForeColor;
            getHTMLsList();
        }

        private void comboTemplatesSalvos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] textSplited = comboTemplatesSalvos.Text.Split(' ');
            string idHTMLTemplate = textSplited[0];
            if (!string.IsNullOrEmpty(idHTMLTemplate))
                setHTMLDataInFields(idHTMLTemplate);
            else {
                clearFields();
            }
        }

        #region[Tools]
        private void clearFields() {
            headerText.Text = "";
            footerText.Text = "";
            nameHTMLTemp.Text = "";
            comboTemplatesSalvos.Text = "";
            getHTMLsList();
        }
        private void getHTMLsList()
        {
            HTMLs hmls = engineGHTMLF.getHTMLs();
            comboTemplatesSalvos.Items.Clear();
            if (hmls.htmls != null) {
                if (hmls.htmls.Count > 0) { foreach (HTML s in hmls.htmls) { comboTemplatesSalvos.Items.Add(s.id + " > " + s.title); } }
            }
        }
        public void setHTMLDataInFields(string tempID)
        {
            HTML htmlData = new HTML();
            htmlData = engineGHTMLF.getHTMLData(int.Parse(tempID));
            nameHTMLTemp.Text = htmlData.title;
            headerText.Text = htmlData.header;
            footerText.Text = htmlData.footer;
            templateID.Text = htmlData.id.ToString();
        }
        public enum commands {
            novo, edita, deleta, cancela, salva
        }
        public void enablers(commands type) {
            switch (type) {
                case commands.novo:
                    novobtn.Enabled = false; //novobtn.BackgroundImage = new Bitmap(Properties.Resources.New_Disabled);
                    editarbtn.Enabled = false; //editarbtn.BackgroundImage = new Bitmap(Properties.Resources.Edit_Disabled);
                    excluirbtn.Enabled = false; //excluirbtn.BackgroundImage = new Bitmap(Properties.Resources.Delete_Disabled);
                    comboTemplatesSalvos.Enabled = false;
                    cancelarbtn.Enabled = true; //cancelarbtn.BackgroundImage = new Bitmap(Properties.Resources.Cancel_Enabled);
                    salvarbtn.Enabled = true; //salvarbtn.BackgroundImage = new Bitmap(Properties.Resources.Save_Enabled);
                    nameHTMLTemp.Enabled = true;
                    headerText.ReadOnly = false;
                    footerText.ReadOnly = false;
                    clearFields();
                    break;
                case commands.edita:
                    novobtn.Enabled = false; //novobtn.BackgroundImage = new Bitmap(Properties.Resources.New_Disabled);
                    editarbtn.Enabled = false; //editarbtn.BackgroundImage = new Bitmap(Properties.Resources.Edit_Disabled);
                    comboTemplatesSalvos.Enabled = false;
                    cancelarbtn.Enabled = true; //cancelarbtn.BackgroundImage = new Bitmap(Properties.Resources.Cancel_Enabled);
                    salvarbtn.Enabled = true; //salvarbtn.BackgroundImage = new Bitmap(Properties.Resources.Save_Enabled);
                    excluirbtn.Enabled = true; //excluirbtn.BackgroundImage = new Bitmap(Properties.Resources.Delete_Enabled);
                    nameHTMLTemp.Enabled = true;
                    headerText.ReadOnly = false;
                    footerText.ReadOnly = false;
                    break;
                case commands.deleta:
                    novobtn.Enabled = true; //novobtn.BackgroundImage = new Bitmap(Properties.Resources.New_enabled);
                    editarbtn.Enabled = true; //editarbtn.BackgroundImage = new Bitmap(Properties.Resources.Edit_Enabled);
                    comboTemplatesSalvos.Enabled = true;
                    cancelarbtn.Enabled = false; //cancelarbtn.BackgroundImage = new Bitmap(Properties.Resources.Cancel_Disabled);
                    salvarbtn.Enabled = false; //salvarbtn.BackgroundImage = new Bitmap(Properties.Resources.Save_Disabled);
                    excluirbtn.Enabled = false; //excluirbtn.BackgroundImage = new Bitmap(Properties.Resources.Delete_Disabled);
                    nameHTMLTemp.Enabled = false;
                    headerText.ReadOnly = true;
                    footerText.ReadOnly = true;
                    clearFields();
                    break;
                case commands.cancela:
                    novobtn.Enabled = true; //novobtn.BackgroundImage = new Bitmap(Properties.Resources.New_enabled);
                    editarbtn.Enabled = true; //editarbtn.BackgroundImage = new Bitmap(Properties.Resources.Edit_Enabled);
                    comboTemplatesSalvos.Enabled = true;
                    cancelarbtn.Enabled = false; //cancelarbtn.BackgroundImage = new Bitmap(Properties.Resources.Cancel_Disabled);
                    salvarbtn.Enabled = false; //salvarbtn.BackgroundImage = new Bitmap(Properties.Resources.Save_Disabled);
                    excluirbtn.Enabled = false; //excluirbtn.BackgroundImage = new Bitmap(Properties.Resources.Delete_Disabled);
                    nameHTMLTemp.Enabled = false;
                    headerText.ReadOnly = true;
                    footerText.ReadOnly = true;
                    clearFields();
                    break;
                case commands.salva:
                    novobtn.Enabled = true; //novobtn.BackgroundImage = new Bitmap(Properties.Resources.New_enabled);
                    editarbtn.Enabled = true; //editarbtn.BackgroundImage = new Bitmap(Properties.Resources.Edit_Enabled);
                    comboTemplatesSalvos.Enabled = true;
                    cancelarbtn.Enabled = false; //cancelarbtn.BackgroundImage = new Bitmap(Properties.Resources.Cancel_Disabled);
                    salvarbtn.Enabled = false; //salvarbtn.BackgroundImage = new Bitmap(Properties.Resources.Save_Disabled);
                    excluirbtn.Enabled = false; //excluirbtn.BackgroundImage = new Bitmap(Properties.Resources.Delete_Disabled);
                    nameHTMLTemp.Enabled = false;
                    headerText.ReadOnly = true;
                    footerText.ReadOnly = true;
                    clearFields();
                    break;
            }
        }
        #endregion

    }
}
