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
     /// Base class for SystemAccessrights.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrights class
     /// </summary>
     public class SystemAccessrightsBase : SystemAccessrightsModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemAccessrightsBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsModel SelectByPrimaryKey(int id)
         {
             return SystemAccessrightsDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrights table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemAccessrightsDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrights table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsDataLayer.GetRecordCountDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrights sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemAccessrightsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrights sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrights sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTakeDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsDataLayer.SelectSkipAndTakeDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrights sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSkipAndTakeDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsDataLayer.SelectSkipAndTakeDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrights
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAll()
         {
             return SystemAccessrightsDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrights sorted by the sort expression
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAll(string sortExpression)
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = SystemAccessrightsDataLayer.SelectAll();
             return SortByExpression(objSystemAccessrightsCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrights.
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAllDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsDataLayer.SelectAllDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrights sorted by the sort expression.
         /// </summary>
         public static List<SystemAccessrightsModel> SelectAllDynamicWhere(int? id, int? code, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<SystemAccessrightsModel> objSystemAccessrightsCol = SystemAccessrightsDataLayer.SelectAllDynamicWhere(id, code, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objSystemAccessrightsCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemAccessrightsModel> SelectSystemAccessrightsDropDownListData()
         {
             return SystemAccessrightsDataLayer.SelectSystemAccessrightsDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemAccessrightsCollection by sort expression
         /// </summary>
         public static List<SystemAccessrightsModel> SortByExpression(List<SystemAccessrightsModel> objSystemAccessrightsCol, string sortExpression)
         {
             //bool isSortDescending = sortExpression.ToLower().Contains(" desc");

             //if (isSortDescending)
             //{
             //    sortExpression = sortExpression.Replace(" DESC", "");
             //    sortExpression = sortExpression.Replace(" desc", "");
             //}
             //else
             //{
             //    sortExpression = sortExpression.Replace(" ASC", "");
             //    sortExpression = sortExpression.Replace(" asc", "");
             //}

             //switch (sortExpression)
             //{
             //    case "Id":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ById);
             //        break;
             //    case "Code":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByCode);
             //        break;
             //    case "Name":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByName);
             //        break;
             //    case "CreatedDate":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objSystemAccessrightsCol.Sort(Cms.BusinessObject.SystemAccessrights.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemAccessrightsCol.Reverse();

             return objSystemAccessrightsCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemAccessrightsModel objSystemAccessrights = (SystemAccessrightsModel)this;
             return SystemAccessrightsDataLayer.Insert(objSystemAccessrights);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemAccessrightsModel objSystemAccessrights = (SystemAccessrightsModel)this;
             SystemAccessrightsDataLayer.Update(objSystemAccessrights);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemAccessrightsDataLayer.Delete(id);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "Id";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         ///// <summary>
         ///// Compares Id used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ById = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Code used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByCode = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.Code, y.Code);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByName = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByCreatedDate = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByModifiedDate = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByCreatedUserId = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByModifiedUserId = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByIsDeleted = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrights> ByStatus = delegate(SystemAccessrights x, SystemAccessrights y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
