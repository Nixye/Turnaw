using Project_Turnaw.Engine.GerenciarHTMLForm;
using Project_Turnaw.Engine.GerenciarTAGsForm;
using Project_Turnaw.Engine.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class ExportarTAGs : Form
    {
        public ExportarTAGs() {
            InitializeComponent();
        }

        private void ExportarTAGs_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
            HTMLs h = EngineGerenciarTAGs.getHTMLs();
            comboBox1.Items.Clear();
            gridTags.Rows.Clear();
            if (h.htmls.Count > 0)
                foreach (HTML s in h.htmls)
                    comboBox1.Items.Add(s.id + " > " + s.title);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            gridTags.Rows.Clear();
            string[] textSplited = comboBox1.Text.Split(' ');
            if (!string.IsNullOrEmpty(comboBox1.Text)) gridTags.Enabled = true;
            else gridTags.Enabled = false;
            int idHTMLTemplate = int.Parse(textSplited[0]);
            HTMLs h = EngineGerenciarTAGs.getHTMLs();
            if (h.htmls.Count > 0)
                foreach (HTML s in h.htmls) {
                    if (s.id != idHTMLTemplate) {
                        DataGridViewRow row = (DataGridViewRow)gridTags.Rows[0].Clone();
                        row.Cells[0].Value = s.id;
                        row.Cells[1].Value = s.title;
                        gridTags.Rows.Add(row);
                    }
                }
        }
        private void button1_Click(object sender, EventArgs e) {
            try {
                string[] textSplited = comboBox1.Text.Split(' ');
                int idHTMLTemplate = int.Parse(textSplited[0]);
                HTML origem = engineGHTMLF.getHTMLData(idHTMLTemplate);
                List<HTML> htmlsSelecionados = new List<HTML>();
                foreach (DataGridViewRow row in gridTags.SelectedRows) {
                    if (row.Cells[0].Value != null) {
                        HTML selecionado = engineGHTMLF.getHTMLData(int.Parse(row.Cells[0].Value.ToString()));
                        htmlsSelecionados.Add(selecionado);
                    }
                }
                bool allCopy = EngineGerenciarTAGs.duplicarTAGs(origem, htmlsSelecionados);
                if (allCopy) MessageBox.Show("Todas as TAGs foram copiadas para os HTMLs selecionados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Algumas TAGs não puderam ser copiadas, alguns motivos podem ser: \nVocê passou o limite de 5 Tags por template.\nA tag já existe no HTML destino!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch { }
        }
    }
}
