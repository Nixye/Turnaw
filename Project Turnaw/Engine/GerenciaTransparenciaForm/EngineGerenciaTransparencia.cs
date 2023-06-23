using Project_Turnaw.Engine.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Turnaw.Engine.GerenciaTransparenciaForm
{
    internal class EngineGerenciaTransparencia
    {
        public static bool save(TSP tspData)
        {
            return SGDBHelper.saveTSP(tspData);
        }
        public static TSP getTSP()
        {
            return SGDBHelper.getTSP();
        }
    }
}
