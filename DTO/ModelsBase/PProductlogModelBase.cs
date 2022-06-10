using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PProductlogModel.  Do not make changes to this class,
     /// instead, put additional code in the PProductlogModel class 
     /// </summary>
     public class PProductlogModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets Note 
         /// </summary> 
         public string Note { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductId 
         /// </summary> 
         public int? ProductId { get; set; } 

         /// <summary> 
         /// Gets or Sets Action 
         /// </summary> 
         public int? Action { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedDate 
         /// </summary> 
         public DateTime? CreatedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedUserId 
         /// </summary> 
         public int? CreatedUserId { get; set; } 

         /// <summary> 
         /// Gets or Sets IsDeleted 
         /// </summary> 
         public bool IsDeleted { get; set; } 

     }
}
