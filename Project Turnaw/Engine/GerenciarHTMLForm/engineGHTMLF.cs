using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Turnaw.Engine.Tools;

namespace Project_Turnaw.Engine.GerenciarHTMLForm
{
    internal class engineGHTMLF
    {
        public static bool saveNew(HTML dadosHTML)
        {
            return SGDBHelper.saveHTML(dadosHTML);
        }
        public static bool deleteHTML(int htmlID)
        {
            return SGDBHelper.deleteHTML(htmlID);
        }
        public static HTMLs getHTMLs()
        {
            return SGDBHelper.getHTMLs();
        }
        public static HTML getHTMLData(int id)
        {
            return SGDBHelper.getHTMLData(id);
        }
    }
}
