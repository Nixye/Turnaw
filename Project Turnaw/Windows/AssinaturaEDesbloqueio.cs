using Project_Turnaw.Engine.Tools;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project_Turnaw.Windows
{
    public partial class AssinaturaEDesbloqueio : Form
    {
        public AssinaturaEDesbloqueio() {
            InitializeComponent();
        }

        private void AssinaturaEDesbloqueio_Load(object sender, EventArgs e) {
            EngineColorAndTransp.defineCT_PremiumSimple(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
