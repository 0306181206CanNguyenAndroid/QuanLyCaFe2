using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PStockModel.  Do not make changes to this class,
     /// instead, put additional code in the PStockModel class 
     /// </summary>
     public class PStockModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductInfo 
         /// </summary> 
         public int? ProductInfo { get; set; } 

         /// <summary> 
         /// Gets or Sets Quantity 
         /// </summary> 
         public int? Quantity { get; set; } 

         /// <summary> 
         /// Gets or Sets BatchOfGoodsId 
         /// </summary> 
         public int? BatchOfGoodsId { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedDate 
         /// </summary> 
         public DateTime? CreatedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedDate 
         /// </summary> 
         public DateTime? ModifiedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedUserId 
         /// </summary> 
         public int? CreatedUserId { get; set; } 

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
