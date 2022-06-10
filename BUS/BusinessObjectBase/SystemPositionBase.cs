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
     /// Base class for SystemPosition.  Do not make changes to this class,
     /// instead, put additional code in the SystemPosition class
     /// </summary>
     public class SystemPositionBase : SystemPositionModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemPositionBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemPositionModel SelectByPrimaryKey(int id)
         {
             return SystemPositionDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemPosition table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemPositionDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemPosition table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted)
         {
             return SystemPositionDataLayer.GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPosition sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemPositionDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPosition sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPosition sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPosition sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money or decimal data type.  E.g. SalaryPerHourTotal
         /// </summary>
         public static SystemPositionModel SelectTotals()
         {
             return SystemPositionDataLayer.SelectTotals();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemPosition
         /// </summary>
         public static List<SystemPositionModel> SelectAll()
         {
             return SystemPositionDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemPosition sorted by the sort expression
         /// </summary>
         public static List<SystemPositionModel> SelectAll(string sortExpression)
         {
            List<SystemPositionModel> objSystemPositionCol = SystemPositionDataLayer.SelectAll();
             return SortByExpression(objSystemPositionCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPosition.
         /// </summary>
         public static List<SystemPositionModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted)
         {
             return SystemPositionDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPosition sorted by the sort expression.
         /// </summary>
         public static List<SystemPositionModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted, string sortExpression)
         {
            List<SystemPositionModel> objSystemPositionCol = SystemPositionDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);
             return SortByExpression(objSystemPositionCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemPositionModel> SelectSystemPositionDropDownListData()
         {
             return SystemPositionDataLayer.SelectSystemPositionDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemPositionCollection by sort expression
         /// </summary>
         public static List<SystemPositionModel> SortByExpression(List<SystemPositionModel> objSystemPositionCol, string sortExpression)
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
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ById);
             //        break;
             //    case "Name":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByName);
             //        break;
             //    case "CreatedDate":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByModifiedUserId);
             //        break;
             //    case "SalaryPerHour":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.BySalaryPerHour);
             //        break;
             //    case "IsDeleted":
             //        objSystemPositionCol.Sort(Cms.BusinessObject.SystemPosition.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemPositionCol.Reverse();

             return objSystemPositionCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemPositionModel objSystemPosition = (SystemPositionModel)this;
             return SystemPositionDataLayer.Insert(objSystemPosition);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemPositionModel objSystemPosition = (SystemPositionModel)this;
             SystemPositionDataLayer.Update(objSystemPosition);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemPositionDataLayer.Delete(id);
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
         //public static Comparison<SystemPosition> ById = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByName = delegate(SystemPosition x, SystemPosition y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByCreatedDate = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByModifiedDate = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByCreatedUserId = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByModifiedUserId = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares SalaryPerHour used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> BySalaryPerHour = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return Nullable.Compare(x.SalaryPerHour, y.SalaryPerHour);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemPosition> ByIsDeleted = delegate(SystemPosition x, SystemPosition y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
