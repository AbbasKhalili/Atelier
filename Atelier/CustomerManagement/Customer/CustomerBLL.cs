using System;
using System.Collections.Generic;
using Atelier.Customer.Facade;
using Atelier.Customer.Models;

namespace Atelier.Customer.BLL
{
    public class Customer : ICustomer
    {
        public int InsertCustomer(CustomerModel obj)
        {
            if (obj.FName == null ) obj.FName = "";
            if (obj.LName == null) obj.LName = "";
            if (obj.Address == null) obj.Address = "";
            if (obj.Birthdate == null) obj.Birthdate = "";
            if (obj.DateSave == null) obj.DateSave = "";
            if (obj.Descs == null) obj.Descs = "";
            if (obj.Email == null) obj.Email = "";
            if (obj.Mobile == null) obj.Mobile = "";
            if (obj.NationalCode == null) obj.NationalCode = "";
            if (obj.Tel == null) obj.Tel = "";
            if (obj.UserSave == null) obj.UserSave = "";
            DAL.CustomerDAL ss = new DAL.CustomerDAL();
            
            return ss.GOInsertCustomer(obj);
        }
    }
}