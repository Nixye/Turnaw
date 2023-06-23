using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Turnaw.Windows;

namespace Project_Turnaw.Engine.MainForm
{
    internal class OpenOtherForms
    {
        public static void openGerenciarTags() {
            gerenciarTAGs gerTAG = new gerenciarTAGs();
            gerTAG.ShowDialog();
        }
        public static void openGerenciaCor() {
            ConfiguracaoCor confCor = new ConfiguracaoCor();
            confCor.ShowDialog();
        }
        public static void openGerenciaSobre() {
            Sobre s = new Sobre();
            s.ShowDialog();
        }
        public static void openAssinatura() {
            AssinaturaEDesbloqueio a = new AssinaturaEDesbloqueio();
            a.ShowDialog();
        }
    }
}
