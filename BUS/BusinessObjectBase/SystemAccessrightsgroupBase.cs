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
     /// Base class for SystemAccessrightsgroup.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrightsgroup class
     /// </summary>
     public class SystemAccessrightsgroupBase : SystemAccessrightsgroupModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemAccessrightsgroupBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsgroupModel SelectByPrimaryKey(int id)
         {
             return SystemAccessrightsgroupDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroup table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemAccessrightsgroupDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroup table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsgroupDataLayer.GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroup sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemAccessrightsgroupDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroup sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroup sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroup sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrightsgroup
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAll()
         {
             return SystemAccessrightsgroupDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrightsgroup sorted by the sort expression
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAll(string sortExpression)
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = SystemAccessrightsgroupDataLayer.SelectAll();
             return SortByExpression(objSystemAccessrightsgroupCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroup.
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsgroupDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroup sorted by the sort expression.
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = SystemAccessrightsgroupDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objSystemAccessrightsgroupCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSystemAccessrightsgroupDropDownListData()
         {
             return SystemAccessrightsgroupDataLayer.SelectSystemAccessrightsgroupDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemAccessrightsgroupCollection by sort expression
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SortByExpression(List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol, string sortExpression)
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
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ById);
             //        break;
             //    case "Name":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByName);
             //        break;
             //    case "CreatedDate":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objSystemAccessrightsgroupCol.Sort(Cms.BusinessObject.SystemAccessrightsgroup.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemAccessrightsgroupCol.Reverse();

             return objSystemAccessrightsgroupCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemAccessrightsgroupModel objSystemAccessrightsgroup = (SystemAccessrightsgroupModel)this;
             return SystemAccessrightsgroupDataLayer.Insert(objSystemAccessrightsgroup);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemAccessrightsgroupModel objSystemAccessrightsgroup = (SystemAccessrightsgroupModel)this;
             SystemAccessrightsgroupDataLayer.Update(objSystemAccessrightsgroup);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemAccessrightsgroupDataLayer.Delete(id);
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
         //public static Comparison<SystemAccessrightsgroup> ById = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByName = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByCreatedDate = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByModifiedDate = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByCreatedUserId = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByModifiedUserId = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByIsDeleted = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroup> ByStatus = delegate(SystemAccessrightsgroup x, SystemAccessrightsgroup y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
