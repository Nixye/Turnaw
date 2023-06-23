using Project_Turnaw.Engine.Activation;
using Project_Turnaw.Engine.GerenciarTAGsForm;
using Project_Turnaw.Engine.Tools;
using System;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class gerenciarTAGs : Form
    {
        public gerenciarTAGs() {
            InitializeComponent();
        }
        bool emCadastro = false;

        private void novaTAGbtn_Click(object sender, EventArgs e) {
            string[] textSplited = comboTemplateHTMLVinculado.Text.Split(' ');
            try { int.Parse(textSplited[0]); } catch {
                MessageBox.Show("Selecione algum HTML.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!EngineActivation.validaGenericPremium()) {
                try {
                    if (getCountTAGsFromTemplate() == 5) {
                        MessageBox.Show("Você não é um assinante, e só poderá cadastrar 5 TAGs para cada template!\n Acesse o botão [Seja Premium] na tela principal para assinar, ou ativar o aplicativo.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                } catch { }
            }
            enablers(enablerType.novo);
        }
        private void saveTAGbtn_Click(object sender, EventArgs e) {
            string[] textSplited = comboTemplateHTMLVinculado.Text.Split(' ');
            int idHTMLTemplate = int.Parse(textSplited[0]);
            TAG tg = new TAG();
            tg.id = int.Parse(idTag.Text);
            tg.idHTML = idHTMLTemplate;
            tg.tag = TAGName.Text;
            tg.textoASubstituir = textoSubstituto.Text;
            if (string.IsNullOrEmpty(tg.tag)) {
                MessageBox.Show("Preencha o campo referente a TAG, por exemplo: \n\n [fala]", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (existsTagInTemplate(tg.tag)) {
                MessageBox.Show("Você já possui uma tag com este nome para este template.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tg.textoASubstituir)) {
                MessageBox.Show("Preencha o campo 'Substituir Por', com algum valor.", "Advertência (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (EngineGerenciarTAGs.saveTAG(tg)) {
                MessageBox.Show("Salvo com sucesso!", "Sucesso ^-^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTAGsFromTemplate();
                enablers(enablerType.salva);
                return;
            }
            MessageBox.Show("Erro ao tentar salvar!", "Erro -_-'", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cancelaTAGbtn_Click(object sender, EventArgs e) {
            enablers(enablerType.cancela);
        }
        private void excluirTAGbtn_Click(object sender, EventArgs e) {
            if (EngineGerenciarTAGs.deleteTAG(int.Parse(idTag.Text))) {
                MessageBox.Show("Excluído com sucesso!", "Sucesso ^-^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTAGsFromTemplate();
                enablers(enablerType.deleta);
                return;
            }
            MessageBox.Show("Erro ao tentar excluir!", "Erro -_-'", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void gridTags_CellClick(object sender, DataGridViewCellEventArgs e) {
            foreach (DataGridViewRow row in gridTags.SelectedRows) {
                if (row.Cells[0].Value == null)
                    return;
                idTag.Text = row.Cells[0].Value.ToString();
                TAG tg = EngineGerenciarTAGs.getTagData(int.Parse(idTag.Text));
                TAGName.Text = tg.tag;
                textoSubstituto.Text = tg.textoASubstituir;
                enablers(enablerType.selecionaTag);
            }
        }
        private void gerenciarTAGs_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
            groupBox1.ForeColor = ForeColor;
            groupBox1.BackColor = BackColor;
            groupBox2.ForeColor = ForeColor;
            groupBox2.BackColor = BackColor;
            textoSubstituto.ForeColor = ForeColor;
            textoSubstituto.BackColor = BackColor;
            getHTMLTemplates();
            setTooltips();
        }
        private void comboTemplateHTMLVinculado_SelectedIndexChanged(object sender, EventArgs e) {
            getTAGsFromTemplate();
            enablers(enablerType.cancela);
        }
        private void editTag_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in gridTags.SelectedRows) {
                if (row.Cells[0].Value == null)
                    return;
                idTag.Text = row.Cells[0].Value.ToString();
                TAG tg = EngineGerenciarTAGs.getTagData(int.Parse(idTag.Text));
                TAGName.Text = tg.tag;
                textoSubstituto.Text = tg.textoASubstituir;
                enablers(enablerType.edita);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) {
            ExportarTAGs expt = new ExportarTAGs();
            expt.ShowDialog();
        }

        #region [Tools]
        public void getHTMLTemplates() {
            HTMLs h = EngineGerenciarTAGs.getHTMLs();
            comboTemplateHTMLVinculado.Items.Clear();
            if (h.htmls.Count > 0) { foreach (HTML s in h.htmls) { comboTemplateHTMLVinculado.Items.Add(s.id + " > " + s.title); } }
        }
        public void getTAGsFromTemplate() {
            string[] textSplited = comboTemplateHTMLVinculado.Text.Split(' ');
            string idHTMLTemplate = textSplited[0];
            TAGs ts = EngineGerenciarTAGs.getTAGs(int.Parse(idHTMLTemplate));
            gridTags.Rows.Clear();
            foreach (TAG tg in ts.tags) {
                DataGridViewRow row = (DataGridViewRow)gridTags.Rows[0].Clone();
                row.Cells[0].Value = tg.id;
                row.Cells[1].Value = tg.tag;
                gridTags.Rows.Add(row);
            }
        }
        public int getCountTAGsFromTemplate() {
            string[] textSplited = comboTemplateHTMLVinculado.Text.Split(' ');
            TAGs ts = EngineGerenciarTAGs.getTAGs(int.Parse(textSplited[0]));
            int c = 0;
            try { c = ts.tags.Count; } catch { }
            return c;
        }
        public void setTooltips() {
            toolTip1.SetToolTip(novaTAGbtn, "Inicia o processo de criação de uma nova TAG para o template selecionado ao lado.");
            toolTip1.SetToolTip(excluirTAGbtn, "Exclui a TAG selecionada. **CUIDADO A TAG É EXCLUIDA IMEDIATAMENTE**");
            toolTip1.SetToolTip(cancelaTAGbtn, "Cancela a edição/criação de uma TAG, apagando os dados.");
            toolTip1.SetToolTip(saveTAGbtn, "Salva a edição/criação da TAG, se estiver com todos os campos preenchidos de acordo.");
        }
        private enum enablerType {
            novo, edita, deleta, cancela, salva, selecionaTag
        }
        private void enablers(enablerType type) {
            switch (type) { 
                case enablerType.novo:
                    idTag.Text = "-1";
                    gridTags.Enabled = false;
                    comboTemplateHTMLVinculado.Enabled = false;
                    novaTAGbtn.Enabled = false;
                    editTag.Enabled = false;
                    excluirTAGbtn.Enabled = false;
                    TAGName.Enabled = true; TAGName.Text = "";
                    textoSubstituto.ReadOnly = false; textoSubstituto.Text = "";
                    saveTAGbtn.Enabled = true;
                    cancelaTAGbtn.Enabled = true;
                    break;
                case enablerType.edita:
                    gridTags.Enabled = false;
                    comboTemplateHTMLVinculado.Enabled = false;
                    novaTAGbtn.Enabled = false;
                    editTag.Enabled = false;
                    excluirTAGbtn.Enabled = true;
                    TAGName.Enabled = true;
                    textoSubstituto.ReadOnly = false;
                    saveTAGbtn.Enabled = true;
                    cancelaTAGbtn.Enabled = true;
                    break;
                case enablerType.deleta:
                    gridTags.Enabled = true;
                    comboTemplateHTMLVinculado.Enabled = true;
                    novaTAGbtn.Enabled = true;
                    editTag.Enabled = false;
                    excluirTAGbtn.Enabled = false;
                    TAGName.Enabled = false; TAGName.Text = "";
                    textoSubstituto.Text = ""; textoSubstituto.ReadOnly = true;
                    saveTAGbtn.Enabled = false;
                    cancelaTAGbtn.Enabled = false;
                    break;
                case enablerType.cancela:
                    idTag.Text = "-1";
                    gridTags.Enabled = true; gridTags.ClearSelection();
                    comboTemplateHTMLVinculado.Enabled = true;
                    novaTAGbtn.Enabled = true;
                    editTag.Enabled = false;
                    excluirTAGbtn.Enabled = false;
                    TAGName.Enabled = false; TAGName.Text = "";
                    textoSubstituto.Text = ""; textoSubstituto.ReadOnly = true;
                    saveTAGbtn.Enabled = false;
                    cancelaTAGbtn.Enabled = false;
                    break;
                case enablerType.salva:
                    gridTags.Enabled = true;
                    comboTemplateHTMLVinculado.Enabled = true;
                    novaTAGbtn.Enabled = true;
                    editTag.Enabled = false;
                    excluirTAGbtn.Enabled = true;
                    TAGName.Enabled = false;
                    textoSubstituto.ReadOnly = true;
                    saveTAGbtn.Enabled = false;
                    cancelaTAGbtn.Enabled = false;
                    break;
                case enablerType.selecionaTag:
                    novaTAGbtn.Enabled = true;
                    editTag.Enabled = true;
                    excluirTAGbtn.Enabled = true;
                    TAGName.Enabled = false;
                    textoSubstituto.ReadOnly = true;
                    saveTAGbtn.Enabled = false;
                    cancelaTAGbtn.Enabled = false;
                    break;
            }
        }
        private bool existsTagInTemplate(string tag) {
            if (emCadastro) {
                string[] textSplited = comboTemplateHTMLVinculado.Text.Split(' ');
                int idHTMLTemplate = int.Parse(textSplited[0]);
                TAGs tags = SGDBHelper.getTAGs(idHTMLTemplate);
                foreach (TAG tg in tags.tags) {
                    if (tg.tag == tag)
                        return true;
                }
            }
            return false;
        }
        #endregion
    }
}
