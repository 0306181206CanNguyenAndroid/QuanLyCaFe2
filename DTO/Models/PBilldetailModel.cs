using DTO.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{ 
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional PBilldetail Model code in this class.
     /// </summary>
     public class PBilldetailModel : PBilldetailModelBase
     {
        public string StaffName { get; set; }
        public string CustomerName { get; set; }
        public string TableCode { get; set; }
        public decimal UnitPriceTotal { get; set; }
        public decimal DiscountPrice { get; set; }
        public int? DiscountProduct { get; set; }
    } 
} 
