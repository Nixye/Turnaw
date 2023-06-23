using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Turnaw.Engine.Activation;
using Project_Turnaw.Engine.Tools;

namespace Project_Turnaw.Engine.GerenciarTAGsForm
{
    internal class EngineGerenciarTAGs
    {
        public static HTMLs getHTMLs()
        {
            return SGDBHelper.getHTMLs();
        }
        public static TAGs getTAGs(int idTemplate)
        {
            return SGDBHelper.getTAGs(idTemplate);
        }
        public static TAG getTagData(int idTag)
        {
            return SGDBHelper.getTAGData(idTag);
        }
        public static bool saveTAG(TAG dadosTAG)
        {
            return SGDBHelper.saveTAG(dadosTAG);
        }
        public static bool deleteTAG(int idTag)
        {
            return SGDBHelper.deleteTAG(idTag);
        }
        public static bool duplicarTAGs(HTML htmlOrigen, List<HTML> htmlsDestino) {
            TAGs tagsHtmlOrigem = getTAGs(htmlOrigen.id);
            bool isPremium = EngineActivation.validaGenericPremium();
            bool allTagsCopy = true;
            foreach (HTML ht in htmlsDestino) {
                foreach (TAG tOr in tagsHtmlOrigem.tags) {
                    TAGs tagsHtmlDest = getTAGs(ht.id);
                    int qtdTagsExist = tagsHtmlDest.tags.Count;
                    if (!isPremium && qtdTagsExist > 5) {
                        allTagsCopy = false;
                    } else {
                        if (!existTagInHTML(tagsHtmlDest, tOr)) {
                            TAG newCopyTAG = new TAG() { id = -1, idHTML = ht.id, tag = tOr.tag, textoASubstituir = tOr.textoASubstituir };
                            saveTAG(newCopyTAG);
                        } else {
                            allTagsCopy = false;
                        }
                    }
                }
            }
            return allTagsCopy;
        }

        private static bool existTagInHTML(TAGs tagsValidate, TAG tagV) {
            foreach (TAG tag in tagsValidate.tags) {
                if (tag.tag == tagV.tag)
                    return true;
            }
            return false;
        }

    }
}
