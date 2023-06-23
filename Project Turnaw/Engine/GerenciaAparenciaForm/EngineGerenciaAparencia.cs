using Project_Turnaw.Engine.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Turnaw.Engine.GerenciaAparenciaForm
{
    internal class EngineGerenciaAparencia
    {
        public static bool save(TSP tspData) {
            return SGDBHelper.saveTSP(tspData);
        }
        public static bool save(TextFont textFontData)
        {
            return SGDBHelper.saveTextFont(textFontData);
        }
        public static bool save(CLR clrData)
        {
            return SGDBHelper.saveCLR(clrData);
        }
        public static bool save(TCLR tclrData)
        {
            return SGDBHelper.saveTCLR(tclrData);
        }
        public static TSP getTSP() {
            return SGDBHelper.getTSP();
        }
        public static CLR getCLR()
        {
            return SGDBHelper.getCLR();
        }
        public static TextFont getTextFont()
        {
            return SGDBHelper.getTextFont();
        }
        public static TCLR getTCLR()
        {
            return SGDBHelper.getTCLR();
        }
        public static Color getBackColor()
        {
            CLR clr = getCLR();
            return Color.FromName(clr.colorValue);
        }
        public static Color getTextColor()
        {
            TCLR tclr = getTCLR();
            return Color.FromName(tclr.textColorValue);
        }
    }
}
