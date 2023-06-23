using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Turnaw.Engine.Tools;

namespace Project_Turnaw.Engine.MainForm
{
    internal class AdjustEngine
    {
        public static string AdjustHeader(int idTemplate)
        {
            HTML html = SGDBHelper.getHTMLData(idTemplate);
            string headerText = html.header;
            TAGs tgs = SGDBHelper.getTAGs(idTemplate);

            bool existTagInText = true;
            while (existTagInText)
            {
                bool identifiedTag = false;
                foreach (TAG tg in tgs.tags)
                {
                    if (headerText.Contains(tg.tag))
                        identifiedTag = true;
                    headerText = headerText.Replace(tg.tag, tg.textoASubstituir);
                }
                if (!identifiedTag)
                    existTagInText = false;
            }

            return headerText;
        }

        public static string AdjustText(string textoOriginal, int idTemplate) {
            HTML html           = SGDBHelper.getHTMLData(idTemplate);
            string textoFinal   = AdjustHeader(idTemplate);
            string beta         = textoOriginal;
            TAGs tgs            = SGDBHelper.getTAGs(idTemplate);

            bool existTagInText = true;
            while (existTagInText)
            {
                bool identifiedTag = false;
                foreach (TAG tg in tgs.tags) {
                    if (beta.Contains(tg.tag))
                        identifiedTag   = true;
                    beta    = beta.Replace(tg.tag, tg.textoASubstituir);
                }
                if (!identifiedTag)
                    existTagInText  = false;
            }

            textoFinal += beta;
            textoFinal += AdjustFooter(idTemplate);
            return textoFinal;
        }

        public static string AdjustFooter(int idTemplate)
        {
            HTML html = SGDBHelper.getHTMLData(idTemplate);
            string footerText = html.footer;
            TAGs tgs = SGDBHelper.getTAGs(idTemplate);

            bool existTagInText = true;
            while (existTagInText)
            {
                bool identifiedTag = false;
                foreach (TAG tg in tgs.tags)
                {
                    if (footerText.Contains(tg.tag))
                        identifiedTag = true;
                    footerText = footerText.Replace(tg.tag, tg.textoASubstituir);
                }
                if (!identifiedTag)
                    existTagInText = false;
            }

            return footerText;
        }

    }
}
