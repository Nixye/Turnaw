using Project_Turnaw.Engine.Activation;
using Project_Turnaw.Engine.GerenciaAparenciaForm;
using Project_Turnaw.Engine.GerenciaCorForm;
using Project_Turnaw.Engine.GerenciaTransparenciaForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Turnaw.Engine.Tools
{
    internal class EngineColorAndTransp {
        private static void defineColorAndTransparency(Form f) {
            defineBackColor(f);
            defineTextColor(f);
            f.Opacity = Convert.ToDouble(EngineGerenciaTransparencia.getTSP().transparencyValue) / 100;
            defineTextFont(f);
        }
        private static void defineBackColor(Form f) {
            Color backColor = EngineGerenciaCor.getBackColor();
            string backColorName = EngineGerenciaCor.getCLR().colorValue;
            try {
                if (backColorName.Substring(0, 1).Equals("#"))
                    f.BackColor = ColorTranslator.FromHtml(backColorName);
                else
                    f.BackColor = backColor;
            } catch {
                try { f.BackColor = ColorTranslator.FromHtml("#" + EngineGerenciaCor.getCLR().colorValue); } catch { f.BackColor = ColorTranslator.FromHtml("#202124"); }
            }
        }
        private static void defineTextColor(Form f) {
            Color textColor = EngineGerenciaCor.getTextColor();
            string textColorName = EngineGerenciaCor.getTCLR().textColorValue;
            try {
                if (textColorName.Substring(0, 1).Equals("#"))
                    f.ForeColor = ColorTranslator.FromHtml(textColorName);
                else
                    f.ForeColor = textColor;
            } catch {
                try { f.ForeColor = ColorTranslator.FromHtml("#" + EngineGerenciaCor.getCLR().colorValue); } catch { f.ForeColor = ColorTranslator.FromHtml("#202124"); }
            }
        }
        private static void defineTextFont(Form f) {
            TextFont textFont = EngineGerenciaAparencia.getTextFont();
            bool negrito = textFont.bold == 1 ? true : false;
            bool italico = textFont.italic == 1 ? true : false;
            if (negrito && italico) {
                f.Font = new Font(textFont.font, textFont.size, FontStyle.Bold & FontStyle.Italic);
                return;
            }
            if (negrito && !italico) {
                f.Font = new Font(textFont.font, textFont.size, FontStyle.Bold);
                return;
            }
            if (!negrito && italico) {
                f.Font = new Font(textFont.font, textFont.size, FontStyle.Italic);
                return;
            }
            f.Font = new Font(textFont.font, textFont.size, FontStyle.Regular);
        }
        public static void defineTextFont(Form f, string fontName, int size, bool bold, bool italic) {
            bool negrito = bold;
            bool italico = italic;
            if (negrito && italico) {
                f.Font = new Font(fontName, size, FontStyle.Bold & FontStyle.Italic);
                return;
            }
            if (negrito && !italico) {
                f.Font = new Font(fontName, size, FontStyle.Bold);
                return;
            }
            if (!negrito && italico) {
                f.Font = new Font(fontName, size, FontStyle.Italic);
                return;
            }
            f.Font = new Font(fontName, size, FontStyle.Regular);
        }

        public static bool defineCT_PremiumSimple(Form f) {
            bool isPremium = EngineActivation.validaGenericPremium();
            if (isPremium) {
                defineColorAndTransparency(f);
                return true;
            } else {
                return false;
            }
        }
        public static bool defineCT_PremiumAdvanced(Form f) {
            bool isPremium = EngineActivation.validaPremium();
            if (isPremium) {
                defineColorAndTransparency(f);
                return true;
            } else {
                return false;
            }
        }
    }
}
