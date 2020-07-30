using System.IO;
using IniParser;
using IniParser.Model;

namespace Atelier.Tools
{
    public class Connection
    {
        public static string Atelier = @"D:\Atelier\Atelier\Atelier.ini";

        private string servername;
        private string password;
        private string database;
        private string userid;
            
        public string GetConnection()
        {
            GetIniDetail();                        
            string cnn = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};Connect Timeout=60;",
                                        servername, database, userid, password);
            return cnn;                
        }
        
        private void GetIniDetail()
        {
            FileIniDataParser fileIniData = new FileIniDataParser();
            if (!File.Exists(Atelier))
            {                
                IniData modifiedParsedData = new IniData();
                modifiedParsedData.Sections.AddSection("Sql");
                modifiedParsedData["Sql"]["ServerName"] = ".";
                modifiedParsedData["Sql"]["Password"] = "";
                modifiedParsedData["Sql"]["Database"] = "Master";
                modifiedParsedData["Sql"]["UserID"] = "sa";
                fileIniData.WriteFile(Atelier, modifiedParsedData);
            }
            else
            {
                IniData parsedData = fileIniData.ReadFile(Atelier);
                servername = parsedData["Sql"]["ServerName"];
                password = parsedData["Sql"]["Password"];
                database = parsedData["Sql"]["Database"];
                userid = parsedData["Sql"]["UserID"];
            }                       
        }
    }
}