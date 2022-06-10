using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PBilldetailModel.  Do not make changes to this class,
     /// instead, put additional code in the PBilldetailModel class 
     /// </summary>
     public class PBilldetailModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets BillId 
         /// </summary> 
         public int? BillId { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductId 
         /// </summary> 
         public int? ProductId { get; set; } 

         /// <summary> 
         /// Gets or Sets Quantity 
         /// </summary> 
         public int? Quantity { get; set; } 

         /// <summary> 
         /// Gets or Sets UnitPrice 
         /// </summary> 
         public decimal? UnitPrice { get; set; } 

         /// <summary> 
         /// Gets or Sets UnitPriceTotal
         /// </summary> 
         public decimal UnitPriceTotal { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedDate 
         /// </summary> 
         public DateTime? CreatedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedDate 
         /// </summary> 
         public DateTime? ModifiedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedUserId 
         /// </summary> 
         public int? ModifiedUserId { get; set; } 

         /// <summary> 
         /// Gets or Sets IsDeleted 
         /// </summary> 
         public bool IsDeleted { get; set; } 

         /// <summary> 
         /// Gets or Sets Status 
         /// </summary> 
         public int? Status { get; set; } 

     }
}
