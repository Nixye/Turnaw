using Project_Turnaw.Engine.GerenciaAparenciaForm;
using Project_Turnaw.Engine.GerenciaCorForm;
using Project_Turnaw.Engine.Tools;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class ConfiguracaoCor : Form
    {
        public ConfiguracaoCor()
        {
            InitializeComponent();
        }

        Color lastSelectedTextColor = Color.Black;

        private void button2_Click(object sender, EventArgs e) {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = MyDialog.Color.Name;
        }
        private void ConfiguracaoCor_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
            textBox1.Text = EngineGerenciaCor.getCLR().colorValue;
            textBox2.Text = EngineGerenciaCor.getTCLR().textColorValue;
            lastSelectedTextColor = EngineGerenciaCor.getTextColor();
            getTransparencyData();
            getAllFonts();
            definirTootips();
            tabPage1.Font = Font;
            tabPage2.Font = Font;
            tabPage3.Font = Font;
            tabPage1.BackColor = BackColor;
            tabPage2.BackColor = BackColor;
            tabPage3.BackColor = BackColor;
            tabPage1.ForeColor = ForeColor;
            tabPage2.ForeColor = ForeColor;
            tabPage3.ForeColor = ForeColor;
        }
        public void definirTootips() {
            toolTip1.SetToolTip(button2, "Selecione uma cor dentre várias, quando selecionado aparecerá no campo ao lado.");
        }
        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (textBox1.Text == textBox2.Text) {
                MessageBox.Show("A cor do texto não pode ser a mesma cor da aplicação, escolha uma cor diferente.", "Aviso (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) {
                MessageBox.Show("Informe as cores de fundo e a cor de texto.", "Aviso (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDown1.Value < 1  || numericUpDown1.Value > 100) {
                MessageBox.Show("Informe um valor entre 1 e 100 no valor de transparência.", "Aviso (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text)) {
                MessageBox.Show("Informe uma fonte.", "Aviso (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDown2.Value < 1 || numericUpDown2.Value > 100) {
                MessageBox.Show("Informe um tamanho de fonte entre 1 a 100.", "Aviso (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool saveColors = saveColor();
            bool saveTransp = saveTransparency();
            bool saveFont = saveTextFont();
            if (saveColors && saveTransp && saveFont) MessageBox.Show("Configuração de aparência Salva.\nReinicie a aplicação para surtir efeito.", "Informação (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Erro ao tentar salvar.", "Error (ಥ﹏ಥ)", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e) {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = false;
            MyDialog.Color = lastSelectedTextColor;
            if (MyDialog.ShowDialog() == DialogResult.OK) {
                textBox2.Text = MyDialog.Color.Name;
                lastSelectedTextColor = MyDialog.Color;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            updateFont();
        }

        #region[Tools]
        public void getAllFonts() {
            TextFont fontSaved = EngineGerenciaAparencia.getTextFont();
            using (InstalledFontCollection col = new InstalledFontCollection()) {
                comboBox1.Items.Clear();
                foreach (FontFamily font in col.Families) {
                    comboBox1.Items.Add(font.Name);
                }
            }
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(fontSaved.font);
            numericUpDown2.Value = Convert.ToDecimal(fontSaved.size);
            if (fontSaved.bold == 1) checkBox1.Checked = true;
            else checkBox1.Checked = false;
            if (fontSaved.italic == 1) checkBox2.Checked = true;
            else checkBox2.Checked = false;
        }
        public void getTransparencyData() {
            TSP tsp = EngineGerenciaAparencia.getTSP();
            numericUpDown1.Value = tsp.transparencyValue;
        }
        public bool saveTransparency() {
            TSP tsp = new TSP() { transparencyValue = Convert.ToInt32(numericUpDown1.Value) };
            return EngineGerenciaAparencia.save(tsp);
        }
        public bool saveColor() {
            CLR clr = new CLR() { colorValue = textBox1.Text };
            return EngineGerenciaAparencia.save(clr);
        }
        public bool saveTextFont() {
            TCLR tclr = new TCLR() { textColorValue = textBox2.Text };
            int bold = 0;
            if (checkBox1.Checked) bold = 1;
            int italic = 0;
            if (checkBox2.Checked) italic = 1;
            TextFont textFont = new TextFont() { font = comboBox1.Text, size = Convert.ToInt32(numericUpDown2.Value), bold = bold, italic = italic };
            bool saveTextColor = EngineGerenciaAparencia.save(tclr);
            bool saveTextFont = EngineGerenciaAparencia.save(textFont);
            if (saveTextColor && saveTextFont) return true;
            return false;
        }
        public void updateFont() {
            bool negrito = checkBox1.Checked;
            bool italico = checkBox2.Checked;
            int tamanho = Convert.ToInt32(numericUpDown2.Value);
            EngineColorAndTransp.defineTextFont(this, comboBox1.Text, tamanho, negrito, italico);
        }

        #endregion

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            updateFont();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            updateFont();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            updateFont();
        }
    }
}
