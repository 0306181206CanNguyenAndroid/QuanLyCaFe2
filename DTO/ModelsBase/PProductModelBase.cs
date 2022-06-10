using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PProductModel.  Do not make changes to this class,
     /// instead, put additional code in the PProductModel class 
     /// </summary>
     public class PProductModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets Name 
         /// </summary> 
         public string Name { get; set; } 

         /// <summary> 
         /// Gets or Sets Description 
         /// </summary> 
         public string Description { get; set; } 

         /// <summary> 
         /// Gets or Sets ManuId 
         /// </summary> 
         public int? ManuId { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductTypeId 
         /// </summary> 
         public int? ProductTypeId { get; set; } 

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
