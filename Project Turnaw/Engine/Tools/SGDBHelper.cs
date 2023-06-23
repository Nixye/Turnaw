using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Project_Turnaw.Engine.Tools
{
    internal class SGDBHelper
    {
        public static bool saveHTML(HTML dadosHTML)
        {
            try
            {
                if(dadosHTML.id < 0)
                {
                    using (var cmd = DBHelper.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO HTMLs(Title,Header,Footer) values (@Title,@Header,@Footer)";
                        cmd.Parameters.AddWithValue("@Title", dadosHTML.title);
                        cmd.Parameters.AddWithValue("@Header", dadosHTML.header);
                        cmd.Parameters.AddWithValue("@Footer", dadosHTML.footer);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = DBHelper.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE HTMLs set Title = @Title, Header = @Header, Footer = @Footer Where id = @id";
                        cmd.Parameters.AddWithValue("@id", dadosHTML.id);
                        cmd.Parameters.AddWithValue("@Title", dadosHTML.title);
                        cmd.Parameters.AddWithValue("@Header", dadosHTML.header);
                        cmd.Parameters.AddWithValue("@Footer", dadosHTML.footer);
                        cmd.ExecuteNonQuery();
                    }
                }
            } catch { return false; }
            return true;
        }
        public static bool deleteHTML(int idHTML)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DBHelper.DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM HTMLs Where id=@Id";
                    cmd.Parameters.AddWithValue("@Id", idHTML);
                    cmd.ExecuteNonQuery();
                    TAGs tgs = getTAGs(idHTML);
                    foreach (TAG tg in tgs.tags) { deleteTAG(tg.id); }
                }
                return true;
            } catch { return false; }
        }
        public static HTML getHTMLData(int idHTML)
        {
            HTML html = new HTML();
            try
            {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM HTMLs Where id=" + idHTML;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        html.id = Convert.ToInt32(reader["id"]);
                        html.title = Convert.ToString(reader["Title"]);
                        html.header = Convert.ToString(reader["Header"]);
                        html.footer = Convert.ToString(reader["Footer"]);
                    }
                    return html;
                }
            } catch { return null; }
        }
        public static HTMLs getHTMLs()
        {
            List<HTML> HTMLs = new List<HTML>();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM HTMLs";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        HTML html = new HTML();
                        html.id = Convert.ToInt32(reader["id"]);
                        html.title = Convert.ToString(reader["Title"]);
                        html.header = Convert.ToString(reader["Header"]);
                        html.footer = Convert.ToString(reader["Footer"]);
                        HTMLs.Add(html);
                    }
                    return new HTMLs() { htmls = HTMLs };
                }
            } catch { return new HTMLs() { htmls = HTMLs }; }
        }


        public static bool saveTAG(TAG dadosTAG)
        {
            try
            {
                if (dadosTAG.id < 0)
                {
                    using (var cmd = DBHelper.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO TAGs(idHTML,TAG,textToTAG) values (@idHTML,@TAG,@textToTAG)";
                        cmd.Parameters.AddWithValue("@idHTML", dadosTAG.idHTML);
                        cmd.Parameters.AddWithValue("@TAG", dadosTAG.tag);
                        cmd.Parameters.AddWithValue("@textToTAG", dadosTAG.textoASubstituir);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = DBHelper.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE TAGs set TAG = @TAG, textToTAG = @textToTAG Where id = @id";
                        cmd.Parameters.AddWithValue("@id", dadosTAG.id);
                        cmd.Parameters.AddWithValue("@TAG", dadosTAG.tag);
                        cmd.Parameters.AddWithValue("@textToTAG", dadosTAG.textoASubstituir);
                        cmd.ExecuteNonQuery();
                    }
                }
            } catch { return false; }
            return true;
        }
        public static bool deleteTAG(int idTAG)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DBHelper.DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TAGs Where id=@Id";
                    cmd.Parameters.AddWithValue("@Id", idTAG);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } catch { return false; }
        }
        public static TAG getTAGData(int idTAG)
        {
            TAG Tag = new TAG();
            try
            {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TAGs Where id=" + idTAG;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Tag.id = Convert.ToInt32(reader["id"]);
                        Tag.idHTML = Convert.ToInt32(reader["idHTML"]);
                        Tag.tag = Convert.ToString(reader["TAG"]);
                        Tag.textoASubstituir = Convert.ToString(reader["textToTAG"]);
                    }
                    return Tag;
                }
            } catch { return null; }
        }
        public static TAGs getTAGs(int idTemplate)
        {
            List<TAG> Ts = new List<TAG>();
            try
            {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TAGs where idHTML = " + idTemplate;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TAG tag = new TAG();
                        tag.id = Convert.ToInt32(reader["id"]);
                        tag.idHTML = Convert.ToInt32(reader["idHTML"]);
                        tag.tag = Convert.ToString(reader["TAG"]);
                        tag.textoASubstituir = Convert.ToString(reader["textToTAG"]);
                        Ts.Add(tag);
                    }
                    return new TAGs() { tags = Ts };
                }
            } catch { return null; }
        }
    

        public static bool saveTSP(TSP tspData, bool insert = false)
        {
            try
            {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    if(insert)
                        cmd.CommandText = "INSERT INTO TSP(transparencyValue) VALUES (@transparencyValue);";
                    else
                        cmd.CommandText = "UPDATE TSP set transparencyValue = @transparencyValue;";
                    cmd.Parameters.AddWithValue("@transparencyValue", tspData.transparencyValue);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static TSP getTSP()
        {
            TSP tsp = new TSP();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TSP";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tsp.transparencyValue = Convert.ToInt32(reader["transparencyValue"]);
                    }
                    return tsp;
                }
            } catch { return tsp; }
        }


        public static bool saveCLR(CLR clrData, bool insert = false)
        {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert)
                        cmd.CommandText = "INSERT INTO CLR(colorValue) VALUES (@colorValue);";
                    else
                        cmd.CommandText = "UPDATE CLR set colorValue = @colorValue;";
                    cmd.Parameters.AddWithValue("@colorValue", clrData.colorValue);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static CLR getCLR()
        {
            CLR clr = new CLR();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM CLR";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        clr.colorValue = Convert.ToString(reader["colorValue"]); 
                    }
                    return clr;
                }
            } catch { return clr; }
        }

        public static bool saveTCLR(TCLR tclrData, bool insert = false)
        {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert)
                        cmd.CommandText = "INSERT INTO TCLR(textColorValue) VALUES (@textColorValue);";
                    else
                        cmd.CommandText = "UPDATE TCLR set textColorValue = @textColorValue;";
                    cmd.Parameters.AddWithValue("@textColorValue", tclrData.textColorValue);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static TCLR getTCLR()
        {
            TCLR tclr = new TCLR();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM TCLR";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tclr.textColorValue = Convert.ToString(reader["textColorValue"]);
                    }
                    return tclr;
                }
            } catch { return tclr; }
        }


        public static bool saveKD(KD keyData, bool insert = false)
        {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    if (insert)
                        cmd.CommandText = "INSERT INTO KD(email,ptwkey,status) VALUES (@email,@key,@status);";
                    else
                        cmd.CommandText = "UPDATE KD set email = @email, ptwkey = @key, status = @status;";
                    cmd.Parameters.AddWithValue("@email", keyData.email);
                    cmd.Parameters.AddWithValue("@key", keyData.key);
                    cmd.Parameters.AddWithValue("@status", keyData.status);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static KD getKD()
        {
            KD keyData = new KD();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM KD";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        keyData.email = Convert.ToString(reader["email"]);
                        keyData.key = Convert.ToString(reader["ptwkey"]);
                        keyData.status = Convert.ToInt32(reader["status"]);
                    }
                    return keyData;
                }
            } catch { return keyData; }
        }


        public static bool saveGC(GC gcData, bool insert = false)
        {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert)
                        cmd.CommandText = "INSERT INTO GC(ultimoHtml,textoNSalvo,widght,height,positionX,positionY) VALUES (@ultimoHtml,@textoNSalvo,@widght,@height,@positionX,@positionY);";
                    else
                        cmd.CommandText = "UPDATE GC set ultimoHtml = @ultimoHtml, textoNSalvo = @textoNSalvo, widght = @widght, height = @height, positionX = @positionX, positionY = @positionY;";
                    cmd.Parameters.AddWithValue("@ultimoHtml", gcData.ultimoHtml);
                    cmd.Parameters.AddWithValue("@textoNSalvo", gcData.textoNSalvo);
                    cmd.Parameters.AddWithValue("@widght", gcData.widght);
                    cmd.Parameters.AddWithValue("@height", gcData.height);
                    cmd.Parameters.AddWithValue("@positionX", gcData.positionX);
                    cmd.Parameters.AddWithValue("@positionY", gcData.positionY);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static GC getGC()
        {
            GC gcData = new GC();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM GC";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        gcData.ultimoHtml = Convert.ToString(reader["ultimoHtml"]);
                        gcData.textoNSalvo = Convert.ToString(reader["textoNSalvo"]);
                        gcData.widght = Convert.ToInt32(reader["widght"]);
                        gcData.height = Convert.ToInt32(reader["height"]);
                        gcData.positionX = Convert.ToInt32(reader["positionX"]);
                        gcData.positionY = Convert.ToInt32(reader["positionY"]);
                    }
                    return gcData;
                }
            } catch { return gcData; }
        }

        public static bool saveTZ(TZ tzData, bool insert = false)
        {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert)
                        cmd.CommandText = "INSERT INTO TZ(textZoom) VALUES (@textZoom);";
                    else
                        cmd.CommandText = "UPDATE TZ set textZoom = @textZoom;";
                    cmd.Parameters.AddWithValue("@textZoom", tzData.textZoom);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { return false; }
            return true;
        }
        public static TZ getTZ()
        {
            TZ tz = new TZ();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TZ";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        tz.textZoom = Convert.ToString(reader["textZoom"]);
                    return tz;
                }
            }
            catch { return tz; }
        }

        public static bool saveTextFont(TextFont textFontData, bool insert = false)
        {
            //TextFont(font TEXT, size INTEGER, bold INTEGER, italic INTEGER)
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert)
                        cmd.CommandText = "INSERT INTO TextFont(font,size,bold,italic) VALUES (@font,@size,@bold,@italic);";
                    else
                        cmd.CommandText = "UPDATE TextFont set font = @font, size = @size, bold = @bold, italic = @italic;";
                    cmd.Parameters.AddWithValue("@font", textFontData.font);
                    cmd.Parameters.AddWithValue("@size", textFontData.size);
                    cmd.Parameters.AddWithValue("@bold", textFontData.bold);
                    cmd.Parameters.AddWithValue("@italic", textFontData.italic);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static TextFont getTextFont() {
            //TextFont(font TEXT, size INTEGER, bold INTEGER, italic INTEGER)
            TextFont textFont = new TextFont();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM TextFont";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        textFont.font = Convert.ToString(reader["font"]);
                        textFont.size = Convert.ToInt32(reader["size"]);
                        textFont.bold = Convert.ToInt32(reader["bold"]);
                        textFont.italic = Convert.ToInt32(reader["italic"]);
                    }
                    return textFont;
                }
            } catch { return textFont; }
        }


        public static bool savePK(PK pkData, bool insert = false) {
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    if (insert) cmd.CommandText = "INSERT INTO PK(permanentKey) VALUES (@permanentKey);";
                    else cmd.CommandText = "UPDATE PK set permanentKey = @permanentKey;";
                    cmd.Parameters.AddWithValue("@permanentKey", pkData.permanentKey);
                    cmd.ExecuteNonQuery();
                }
            } catch { return false; }
            return true;
        }
        public static PK getPK() {
            PK pkData = new PK();
            try {
                using (var cmd = DBHelper.DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM PK";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    bool existKeyDefinition = false;
                    while (reader.Read()) {
                        pkData.permanentKey = Convert.ToInt32(reader["permanentKey"]);
                        existKeyDefinition = true;
                    }
                    if (existKeyDefinition)
                        return pkData;
                    return null;
                }
            } catch { return pkData; }
        }
    }

}
