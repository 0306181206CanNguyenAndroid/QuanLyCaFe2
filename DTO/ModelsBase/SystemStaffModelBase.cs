using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for SystemStaffModel.  Do not make changes to this class,
     /// instead, put additional code in the SystemStaffModel class 
     /// </summary>
     public class SystemStaffModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets FirstName 
         /// </summary> 
         public string FirstName { get; set; } 

         /// <summary> 
         /// Gets or Sets LastName 
         /// </summary> 
         public string LastName { get; set; } 

         /// <summary> 
         /// Gets or Sets FullName 
         /// </summary> 
         public string FullName { get; set; } 

         /// <summary> 
         /// Gets or Sets Birth 
         /// </summary> 
         public DateTime? Birth { get; set; } 

         /// <summary> 
         /// Gets or Sets Address 
         /// </summary> 
         public string Address { get; set; } 

         /// <summary> 
         /// Gets or Sets Image 
         /// </summary> 
         public string Image { get; set; } 

         /// <summary> 
         /// Gets or Sets Phone 
         /// </summary> 
         public string Phone { get; set; } 

         /// <summary> 
         /// Gets or Sets Email 
         /// </summary> 
         public string Email { get; set; } 

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
         /// Gets or Sets PositionId 
         /// </summary> 
         public int? PositionId { get; set; } 

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
