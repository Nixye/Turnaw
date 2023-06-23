using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Project_Turnaw.Engine.Update
{
    internal class EngineUpdate
    {
        private static string updateDirectory = Environment.CurrentDirectory + @"\updates\";
        private static string ftpSite = "ftp://alderaan01.umbler.host";
        private static string user = "turnaw-web-com-br";
        private static string pass = "xr*E-?;2#p]lOLK";
        private static FtpWebRequest returnConnection() {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpSite);
            request.Credentials = new NetworkCredential(user, pass);
            return request;
        }
        private static FtpWebRequest returnConnection(string fileDownload) {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpSite + "/" + fileDownload);
            request.Credentials = new NetworkCredential(user, pass);
            return request;
        }
        public static void verifyUpdate(string actualVersion) {
            string localDownloadedVersion = verifyLocalFiles(actualVersion);
            if (localDownloadedVersion != actualVersion) {
                DialogResult dialogResult = MessageBox.Show("Você já baixou uma versão mais atualizada, deseja instalar?", "Questionamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    InstallNewVersion(localDownloadedVersion);
                    return;
                } else if(dialogResult == DialogResult.No) { return; }
            }
            FtpWebRequest request = returnConnection();
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            using (FtpWebResponse resp = (FtpWebResponse)request.GetResponse()) {
                Stream rs = resp.GetResponseStream();
                List<string> liArquivos = new List<string>();
                using (StreamReader reader = new StreamReader(rs)) {
                    liArquivos = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                }
                foreach (string updateF in liArquivos) {
                    string fileName = updateF;
                    string[] fileNameExplode = fileName.Split(' ');
                    string version = fileNameExplode[fileNameExplode.Length-1];
                    version = version.Replace(".exe", "");
                    if (ftpVersionIsNew(actualVersion, version)) {
                        DialogResult dialogResult = MessageBox.Show("Existe uma versão mais recente online, deseja efetuar o download?", "Questionamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes) {
                            downloadNewVersion(version);
                            return;
                        } else if (dialogResult == DialogResult.No) { return; }
                    }
                }
            }
        }
        public static void downloadNewVersion(string newVersion) {
            string versionName = "Project Turnaw Setup " + newVersion + ".exe";
            if (!Directory.Exists(updateDirectory))
                Directory.CreateDirectory(updateDirectory);
            if (!File.Exists(updateDirectory + versionName)) {
                FtpWebRequest request = returnConnection(versionName);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                var response = (FtpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                using (var memoryStream = new System.IO.MemoryStream()) {
                    responseStream.CopyTo(memoryStream);
                    var conteudoArquivo = memoryStream.ToArray();
                    File.WriteAllBytes(updateDirectory + versionName, conteudoArquivo);
                }
                MessageBox.Show("Download Finalizado com Sucesso!");
                response.Close();
            }
            DialogResult dialogResult = MessageBox.Show("Deseja instalar agora?", "Questionamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                InstallNewVersion(newVersion);
        }
        public static void InstallNewVersion(string newVersion) {
            string versionName = "Project Turnaw Setup " + newVersion + ".exe";
            Process.Start(updateDirectory + versionName);
            Environment.Exit(0);
        }
        public static string verifyLocalFiles(string actualVersion) {
            if (!Directory.Exists(updateDirectory)) {
                Directory.CreateDirectory(updateDirectory);
                return actualVersion;
            }
            List<string> filesInDirectory = Directory.GetFiles(updateDirectory).ToList();
            foreach (string updateF in filesInDirectory){
                string fileName = updateF;
                string[] fileNameExplode = fileName.Split(' ');
                string version = fileNameExplode[fileNameExplode.Length - 1];
                version = version.Replace(".exe", "");
                if (ftpVersionIsNew(actualVersion, version))
                    return version;
            }
            return actualVersion;
        }
        private static bool ftpVersionIsNew(string Actual, string ftpVersion) {
            string[] actualVersionData = Actual.Split('.');
            string[] ftpVersionData = ftpVersion.Split('.');
            int major = int.Parse(actualVersionData[0]); int ftpMajor = major;
            int minor = int.Parse(actualVersionData[1]); int ftpMinor = minor;
            int patch = int.Parse(actualVersionData[2]); int ftpPatch = patch;
            try {
                ftpMajor = int.Parse(ftpVersionData[0]);
                ftpMinor = int.Parse(ftpVersionData[1]);
                ftpPatch = int.Parse(ftpVersionData[2]);
                if (ftpMajor > major)
                    return true;
                else if (ftpMinor > minor)
                    return true;
                else if (ftpPatch > patch){
                    if (minor == ftpMinor && major == ftpMajor)
                        return true;
                }
            } catch { }
            return false;
        }


    }
}
