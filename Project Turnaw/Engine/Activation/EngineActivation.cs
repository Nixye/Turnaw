using MySql.Data.MySqlClient;
using Project_Turnaw.Engine.Tools;
using System;
using System.Data;

namespace Project_Turnaw.Engine.Activation
{
    internal class EngineActivation
    {
        private static MySqlConnection conn = null;
        private static readonly string mysqlIP = "mysql744.umbler.com";
        private static readonly string keyDatabase = "turnawdb";
        private static readonly string mysqlUser = "lnixyadmin";
        private static readonly string mysqlPass = "Codex_47-L";
        private static readonly string mysqlPort = "41890";

        public static bool firstActivation(KD keyData) {
            try {
                conn = keyCon();
                string sql = "SELECT status, expirationDate, machineName, permanetKey FROM ptwkeys WHERE ptwkey='" + keyData.key + "' and email = '" + keyData.email + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                bool isActive = false;
                DateTime dataExpiracao = DateTime.UtcNow;
                string machineName = Environment.MachineName;
                string machineNameSaved = null;
                int isPermanentKey = 0;
                while (rdr.Read()) {
                    isActive = Convert.ToBoolean(rdr["status"]);
                    dataExpiracao = Convert.ToDateTime(rdr["expirationDate"]);
                    machineNameSaved = Convert.ToString(rdr["machineName"]);
                    isPermanentKey = Convert.ToInt32(rdr["permanetKey"]);
                }
                PK pkData = new PK() { permanentKey = isPermanentKey };
                SGDBHelper.savePK(pkData);
                if (isActive && DateTime.UtcNow < dataExpiracao) {
                    if (!string.IsNullOrEmpty(machineNameSaved)) {
                        if (machineName == machineNameSaved)
                            return true;
                    } else {
                        saveMachineName(keyData);
                        return true;
                    }
                }
            } catch { }
            return false;
        }
        public static bool validateKey(KD keyData) {
            PK pkData = SGDBHelper.getPK();
            if (pkData.permanentKey == 1)
                return true;
            try {
                conn = keyCon();
                string sql = "SELECT status, expirationDate, machineName, permanetKey FROM ptwkeys WHERE ptwkey='" + keyData.key + "' and email = '" + keyData.email + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                bool isActive = false;
                DateTime dataExpiracao = DateTime.UtcNow;
                string machineName = Environment.MachineName;
                string machineNameSaved = null;
                int isPermanentKey = 0;
                while (rdr.Read()) {
                    isActive = Convert.ToBoolean(rdr["status"]);
                    dataExpiracao = Convert.ToDateTime(rdr["expirationDate"]);
                    machineNameSaved = Convert.ToString(rdr["machineName"]);
                    isPermanentKey = Convert.ToInt32(rdr["permanetKey"]);
                }
                if (isPermanentKey != pkData.permanentKey) {
                    pkData = new PK() { permanentKey = isPermanentKey };
                    SGDBHelper.savePK(pkData);
                }
                if (isActive && DateTime.UtcNow < dataExpiracao) {
                    if (!string.IsNullOrEmpty(machineNameSaved)) {
                        if (machineName == machineNameSaved) {
                            return true;
                        }
                    } else {
                        saveMachineName(keyData);
                        return true;
                    }
                }
            } catch { }
            return false;
        }
        public static bool activateKey(KD keyData) {
            if (validateKey(keyData))
                return SGDBHelper.saveKD(keyData);
            return false;
        }
        public static KD getKeyData() {
            return SGDBHelper.getKD();
        }

        #region [Tools]
        private static MySqlConnection keyCon() {
            try {
                if (conn != null && conn.State == ConnectionState.Open) {
                    conn.Close();
                }
            } catch{}

            conn = new MySqlConnection("server=" + mysqlIP + ";Port="+ mysqlPort + ";database=" + keyDatabase + ";uid=" + mysqlUser + "; pwd=" + mysqlPass + ";SslMode=Preferred;");
            try { conn.Open(); }
            catch { return conn; }
            return conn;
        }
        public static void saveMachineName(KD keyData) {
            conn = keyCon();
            string sql = "update ptwkeys set machineName = '"+ Environment.MachineName + "' where ptwkey='" + keyData.key + "' and email = '" + keyData.email + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public static bool validaPremium()
        {
            return true;
            //PK pkData = SGDBHelper.getPK();
            //KD keyData = getKeyData();
            //if (pkData.permanentKey == 1)
            //if (keyData.status == 1) {
            //    if (validateKey(keyData)) {
            //        return true;
            //    }
            //    keyData.status = 0;
            //    SGDBHelper.saveKD(keyData);
            //}
            //return false;
        }
        public static bool validaGenericPremium()
        {
            return true;
            //PK pkData = SGDBHelper.getPK();
            //KD keyData = getKeyData();
            //if (pkData.permanentKey == 1)
            //    return true;
            //if (keyData.status == 1)
            //    return true;
            //return false;
        }
        #endregion
    }

}
