using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data.SqlClient;
using System.Configuration;

namespace Atelier.Tools
{
    public class GetPersianDate
    {
        public string FixateFormat(string strDate)
        {
            string d = strDate.Substring(1, 2).ToString();
            string m = strDate.Substring(1, 2).ToString();
            string y = strDate.Substring(1, 4).ToString();
            strDate = y + "/" + m + "/" + d;
            /*if (System.Text.RegularExpressions.Regex.IsMatch(strDate, @"^(([1-9])|(0[1-9])|(1[0-2]))\/(([0-9])|([0-2][0-9])|(3[0-1]))\/(([0-9][0-9])|([1-2][0,9][0-9][0-9]))$"))
            {
            }*/
            return strDate;
        }

        public string GetTodayDate()
        {
            return System.Configuration.ConfigurationManager.AppSettings["Todaydate"];
        }

        public string SetTodayDate()
        {
            var cnx = new SqlConnection();
            cnx.ConnectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            var sql = new SqlCommand("SELECT Format(GETDATE(),'yyyy') AS y,Format(GETDATE(),'MM') AS m,Format(GETDATE(),'dd') AS d", cnx);
            cnx.Open();
            SqlDataReader sdr = sql.ExecuteReader();
            sdr.Read();
            DateTime date = new DateTime(Convert.ToInt32(sdr["y"]), Convert.ToInt16(sdr["m"]) ,Convert.ToInt16(sdr["d"]) );
            sdr.Close();
            cnx.Close();
            var calendar = new PersianCalendar();
            string y = calendar.GetYear(date).ToString();
            string m = calendar.GetMonth(date).ToString();
            string d = calendar.GetDayOfMonth(date).ToString();
            if (m.Length == 1) { m = "0" + m.ToString(); }
            if (d.Length == 1) { d = "0" + d.ToString(); }
            if (y.Length == 2) { y = "13" + y.ToString(); }                
            System.Configuration.ConfigurationManager.AppSettings["Todaydate"] = y + "/" + m + "/" + d;
            return y + "/" + m + "/" + d;
        }
    }
}