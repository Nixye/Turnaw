using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Turnaw.Engine.Tools
{
    class HTMLs
    {
        public List<HTML> htmls { get; set; }
    }

    class HTML
    {
        public int id { get; set; }
        public string title { get; set; }
        public string header { get; set; }
        public string footer { get; set; }
    }

    class TAGs
    {
        public List<TAG> tags { get; set; }
    }

    class TAG 
    {
        public int id { get; set; }
        public int idHTML { get; set; }
        public string title { get; set; }
        public string tag { get; set; }
        public string textoASubstituir { get; set; }
    }

    class TSP {
        public int transparencyValue { get; set; }
    }

    class CLR {
        public string colorValue { get; set; }
    }

    class TCLR {
        public string textColorValue { get; set; }
    }

    class KD {
        public string email { get; set; }
        public string key { get; set; }
        public int status { get; set; }
    }

    class GC {
        public string ultimoHtml { get; set; }
        public string textoNSalvo { get; set; }
        public int widght { get; set; }
        public int height { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
    }

    class TZ {
        public string textZoom { get; set; }
    }

    class TextFont {
        public string font { get; set; }
        public int size { get; set; }
        public int bold { get; set; }
        public int italic { get; set; }
    }

    class PK {
        public int permanentKey { get; set; }
    }
}
