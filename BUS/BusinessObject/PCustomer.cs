using BUS.BusinessObjectBase;
using DAO.DataLayer;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObject
{ 
     /// <summary>
     /// This file will not be overwritten.  You can put 
     /// additional PCustomer Business Layer code in this class. 
     /// </summary>
     public class PCustomer : PCustomerBase 
     { 
         // constructor 
         public PCustomer() 
         { 
         }
         public static int InsertOrUpdate(bool type,PCustomerModel kh)
        {
            if(type)
            {
                return PCustomer.Insert(kh);
            }
            else
            {
                Update(kh);
            }
            return 0;
        }
     } 
} 
