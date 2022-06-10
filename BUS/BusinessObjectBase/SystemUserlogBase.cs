using DAO.DataLayer;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
     /// <summary>
     /// Base class for SystemUserlog.  Do not make changes to this class,
     /// instead, put additional code in the SystemUserlog class
     /// </summary>
     public class SystemUserlogBase : SystemUserlogModel
     {
         /// <summary>
         /// Gets or sets the Related SystemUser.  Related to column UserId
         /// </summary>
         public Lazy<UserModel> SystemUser
         {
             get
             {
                 int value;
                 bool hasValue = Int32.TryParse(UserId.ToString(), out value);

                 if (hasValue)
                     return new Lazy<UserModel>(() => SystemUserDataLayer.SelectByPrimaryKey(value));
                 else
                     return null;
             }
             set{ }
         } 


         /// <summary>
         /// Constructor
         /// </summary>
         public SystemUserlogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemUserlogModel SelectByPrimaryKey(int id)
         {
             return SystemUserlogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemUserlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemUserlogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemUserlog table by UserId
         /// </summary>
         public static int GetRecordCountByUserId(int userId)
         {
             return SystemUserlogDataLayer.GetRecordCountByUserId(userId);
         }

         /// <summary>
         /// Gets the total number of records in the SystemUserlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemUserlogDataLayer.GetRecordCountDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemUserlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemUserlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemUserlog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemUserlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records by UserId as a collection (List) of SystemUserlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeByUserId(int rows, int startRowIndex, out int totalRowCount, string sortByExpression, int userId)
         {
             totalRowCount = SystemUserlogDataLayer.GetRecordCountByUserId(userId);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemUserlogDataLayer.SelectSkipAndTakeByUserId(sortByExpression, startRowIndex, rows, userId);
         }

         /// <summary>
         /// Selects records by UserId as a collection (List) of SystemUserlog sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeByUserId(int rows, int startRowIndex, string sortByExpression, int userId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemUserlogDataLayer.SelectSkipAndTakeByUserId(sortByExpression, startRowIndex, rows, userId);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemUserlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemUserlogDataLayer.SelectSkipAndTakeDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemUserlog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemUserlogDataLayer.SelectSkipAndTakeDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemUserlog
         /// </summary>
         public static List<SystemUserlogModel> SelectAll()
         {
             return SystemUserlogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemUserlog sorted by the sort expression
         /// </summary>
         public static List<SystemUserlogModel> SelectAll(string sortExpression)
         {
            List<SystemUserlogModel> objSystemUserlogCol = SystemUserlogDataLayer.SelectAll();
             return SortByExpression(objSystemUserlogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemUserlog.
         /// </summary>
         public static List<SystemUserlogModel> SelectAllDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemUserlogDataLayer.SelectAllDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemUserlog sorted by the sort expression.
         /// </summary>
         public static List<SystemUserlogModel> SelectAllDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<SystemUserlogModel> objSystemUserlogCol = SystemUserlogDataLayer.SelectAllDynamicWhere(id, userId, action, modifiedDate, modifiedUserId, isDeleted);
             return SortByExpression(objSystemUserlogCol, sortExpression);
         }

         /// <summary>
         /// Selects all SystemUserlog by SystemUser, related to column UserId
         /// </summary>
         public static List<SystemUserlogModel> SelectSystemUserlogCollectionByUserId(int id)
         {
             return SystemUserlogDataLayer.SelectSystemUserlogCollectionByUserId(id);
         }

         /// <summary>
         /// Selects all SystemUserlog by SystemUser, related to column UserId, sorted by the sort expression
         /// </summary>
         public static List<SystemUserlogModel> SelectSystemUserlogCollectionByUserId(int id, string sortExpression)
         {
            List<SystemUserlogModel> objSystemUserlogCol = SystemUserlogDataLayer.SelectSystemUserlogCollectionByUserId(id);
             return SortByExpression(objSystemUserlogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Action columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemUserlogModel> SelectSystemUserlogDropDownListData()
         {
             return SystemUserlogDataLayer.SelectSystemUserlogDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemUserlogCollection by sort expression
         /// </summary>
         public static List<SystemUserlogModel> SortByExpression(List<SystemUserlogModel> objSystemUserlogCol, string sortExpression)
         {
             bool isSortDescending = sortExpression.ToLower().Contains(" desc");

             if (isSortDescending)
             {
                 sortExpression = sortExpression.Replace(" DESC", "");
                 sortExpression = sortExpression.Replace(" desc", "");
             }
             else
             {
                 sortExpression = sortExpression.Replace(" ASC", "");
                 sortExpression = sortExpression.Replace(" asc", "");
             }

             switch (sortExpression)
             {
                 case "Id":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ById);
                     break;
                 case "UserId":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ByUserId);
                     break;
                 case "Action":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ByAction);
                     break;
                 case "ModifiedDate":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ByModifiedDate);
                     break;
                 case "ModifiedUserId":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ByModifiedUserId);
                     break;
                 case "IsDeleted":
                     objSystemUserlogCol.Sort(SystemUserlogBase.ByIsDeleted);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objSystemUserlogCol.Reverse();

             return objSystemUserlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemUserlogModel objSystemUserlog = (SystemUserlogModel)this;
             return SystemUserlogDataLayer.Insert(objSystemUserlog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemUserlogModel objSystemUserlog = (SystemUserlogModel)this;
             SystemUserlogDataLayer.Update(objSystemUserlog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemUserlogDataLayer.Delete(id);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "Id";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares Id used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ById = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return x.Id.CompareTo(y.Id);
         };

         /// <summary>
         /// Compares UserId used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ByUserId = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return Nullable.Compare(x.UserId, y.UserId);
         };

         /// <summary>
         /// Compares Action used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ByAction = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return Nullable.Compare(x.Action, y.Action);
         };

         /// <summary>
         /// Compares ModifiedDate used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ByModifiedDate = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         };

         /// <summary>
         /// Compares ModifiedUserId used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ByModifiedUserId = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         };

         /// <summary>
         /// Compares IsDeleted used for sorting
         /// </summary>
         public static Comparison<SystemUserlogModel> ByIsDeleted = delegate(SystemUserlogModel x, SystemUserlogModel y)
         {
             return x.IsDeleted.CompareTo(y.IsDeleted);
         };

     }
}
