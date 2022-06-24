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
     /// additional PBill Business Layer code in this class. 
     /// </summary>
     public class PBill : PBillBase 
     { 
         // constructor 
         public PBill() 
         { 
         }

        public static bool checkExistCustomer(int Id)
        {
            if(PBillDataLayer.CustomerInBill(Id)>0)
                return true;
            return false;
        }
        private static string CreateCode()
        {
            return "B" + GetRecordCount();


        }
        public static int InsertBill(PBillModel bill)
        {
            bill.Code = CreateCode();
            var a = Insert(bill);
            if (a == 1)
            {
                PBillModel billCode = SelectByCode(bill.Code);
                foreach (PBilldetailModel b in bill.listBillDetail)
                {
                    b.BillId = billCode.Id;
                    PBilldetail.Insert(b);
                }
                return 1;
            }
            else
                return 0;
        }

    } 
} 
