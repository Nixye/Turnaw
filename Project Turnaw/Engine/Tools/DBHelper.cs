using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Turnaw.Engine.Tools
{
    internal class DBHelper
    {
        private static SQLiteConnection sqliteConnection;
        public DBHelper() { }
        private static string source = Environment.CurrentDirectory + @"\projectTurnawDB.sqlite";
        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + source + "; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite()
        {
            try {
                if (!File.Exists(source))
                    SQLiteConnection.CreateFile(source);
            }
            catch { throw; }
        }
        public static void CriarTabelaSQlite()
        {
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS HTMLs(id INTEGER PRIMARY KEY AUTOINCREMENT, Title Varchar(50), Header TEXT, Footer TEXT)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TAGs(id INTEGER PRIMARY KEY AUTOINCREMENT, idHTML int, TAG TEXT, textToTAG TEXT)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TSP(transparencyValue INTEGER)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS CLR(colorValue TEXT)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TCLR(textColorValue TEXT)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS KD(email TEXT, ptwkey TEXT, status INTEGER)"; //Status = 1[ComPremium] 0[SemPremium]
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS GC(ultimoHtml TEXT, textoNSalvo TEXT, widght INTEGER, height INTEGER, positionX INTEGER, positionY INTEGER)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TZ(textZoom text)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TextFont(font TEXT, size INTEGER, bold INTEGER, italic INTEGER)"; //Bold e Italic = 1[True] 0[False]
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS PK(permanentKey INTEGER)"; //1 [Key Salva é Permanente] | 0 [Key é Mensal]
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }



            TSP tsp = SGDBHelper.getTSP();
            if (tsp.transparencyValue == 0) {
                tsp = new TSP() { transparencyValue = 100 };
                SGDBHelper.saveTSP(tsp, true);
            }
            CLR clr = SGDBHelper.getCLR();
            if (clr.colorValue == null) {
                clr = new CLR() { colorValue = "Silver" };
                SGDBHelper.saveCLR(clr, true);
            }
            TCLR tclr = SGDBHelper.getTCLR();
            if (tclr.textColorValue == null) {
                tclr = new TCLR() { textColorValue = "WindowText" };
                SGDBHelper.saveTCLR(tclr, true);
            }
            KD keyData = SGDBHelper.getKD();
            if (keyData.key == null) {
                keyData = new KD() { email = "", key = "", status = 0 };
                SGDBHelper.saveKD(keyData, true);
            }
            GC gcData = SGDBHelper.getGC();
            try {
                if (gcData.height == 0) {
                    gcData = new GC() { ultimoHtml = "", textoNSalvo = "", widght = 0, height = 0, positionX = 0, positionY = 0 };
                    SGDBHelper.saveGC(gcData, true);
                }
            } catch {
                gcData = new GC() { ultimoHtml = "", textoNSalvo = "", widght = 0, height = 0, positionX = 0, positionY = 0 };
                SGDBHelper.saveGC(gcData, true);
            }
            TZ tz = SGDBHelper.getTZ();
            if (tz.textZoom == null) {
                tz = new TZ() { textZoom = "1" };
                SGDBHelper.saveTZ(tz, true);
            }
            TextFont textFontData = SGDBHelper.getTextFont();
            if (textFontData.font == null) {
                textFontData = new TextFont() { font = "Comic Sans MS", size = 8, bold = 1, italic = 0 };
                SGDBHelper.saveTextFont(textFontData, true);
            }
            PK pkData = SGDBHelper.getPK();
            if (pkData == null) {
                pkData = new PK() { permanentKey = 1 };
                SGDBHelper.savePK(pkData, true);
            }
        }
    }
}
