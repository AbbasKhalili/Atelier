using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Atelier.Customer.Models;
using System.Configuration;
using Atelier.Tools;

namespace Atelier.Customer.DAL
{
    public class CustomerDAL
    {
        public int GOInsertCustomer(CustomerModel obj)
        {
            int Indentity;
            var cnx = new SqlConnection();
            cnx.ConnectionString = new Connection().GetConnection();
            try
            {
                cnx.Open();
                string Fields = "FName,LName,Gender,NationalCode,Birthdate,Tel,Mobile,Email,Address,Descs,UserSave,DateSave";
                string Values = "'" + obj.FName.ToString() + "'," +
                                "'" + obj.LName.ToString() + "'," +
                                "" + ((int)obj.Gender).ToString() + "," +
                                "'" + obj.NationalCode.ToString() + "'," +
                                "'" + obj.Birthdate.ToString() + "'," +
                                "'" + obj.Tel.ToString() + "'," +
                                "'" + obj.Mobile.ToString() + "'," +
                                "'" + obj.Email.ToString() + "'," +
                                "'" + obj.Address.ToString() + "'," +
                                "'" + obj.Descs.ToString() + "'," +
                                "'" + System.Configuration.ConfigurationManager.AppSettings["UserActive"].ToString() + "'," +
                                "'" + System.Configuration.ConfigurationManager.AppSettings["TodayDate"].ToString() + "'";

                var sqlCmd = new SqlCommand("[dbo].[InsertionID]", cnx);
                SqlDataReader DBReader;
                sqlCmd.CommandType =  CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@t", "Customer"));
                sqlCmd.Parameters.Add(new SqlParameter("@f", Fields));
                sqlCmd.Parameters.Add(new SqlParameter("@v", Values));
                sqlCmd.Parameters.Add(new SqlParameter("@ST", "1"));
                DBReader = sqlCmd.ExecuteReader();
                DBReader.Read();
                Indentity = Convert.ToInt32(DBReader["identy"]);
                DBReader.Close();
            }
            finally
            {                
                cnx.Close();
            }

            return Indentity;
        }
    }
}