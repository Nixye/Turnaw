using Project_Turnaw.Engine.Tools;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class Sobre : Form
    {
        public Sobre() {
            InitializeComponent();
        }

        private void Sobre_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
        }
        private void label10_Click(object sender, EventArgs e) {
            Process.Start("https://techhorizon.space/?portfolios=turnaw");
        }
        private void label11_Click(object sender, EventArgs e) {
            Process.Start("https://discord.gg/qdfsgwwe6P");
        }
        private void label4_Click(object sender, EventArgs e) {
            Process.Start("https://techhorizon.space/?p=166");
        }
    }
}
