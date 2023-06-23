using Project_Turnaw.Engine.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Turnaw.Engine.GerenciaCorForm
{
    internal class EngineGerenciaCor
    {
        public static bool save(CLR clrData)
        {
            return SGDBHelper.saveCLR(clrData);
        }
        public static bool saveTextColor(TCLR tclrData)
        {
            return SGDBHelper.saveTCLR(tclrData);
        }
        public static CLR getCLR()
        {
            return SGDBHelper.getCLR();
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
        public static Color getTextColor() {
            TCLR tclr = getTCLR();
            return Color.FromName(tclr.textColorValue);
        }
    }
}
