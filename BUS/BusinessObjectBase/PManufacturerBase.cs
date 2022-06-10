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
     /// Base class for PManufacturer.  Do not make changes to this class,
     /// instead, put additional code in the PManufacturer class
     /// </summary>
     public class PManufacturerBase : PManufacturerModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PManufacturerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PManufacturerModel SelectByPrimaryKey(int id)
         {
             return PManufacturerDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturer table
         /// </summary>
         public static int GetRecordCount()
         {
             return PManufacturerDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturer table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PManufacturerDataLayer.GetRecordCountDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturer sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PManufacturerDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturer sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturer sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerDataLayer.SelectSkipAndTakeDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturer sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerDataLayer.SelectSkipAndTakeDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PManufacturer
         /// </summary>
         public static List<PManufacturerModel> SelectAll()
         {
             return PManufacturerDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PManufacturer sorted by the sort expression
         /// </summary>
         public static List<PManufacturerModel> SelectAll(string sortExpression)
         {
            List<PManufacturerModel> objPManufacturerCol = PManufacturerDataLayer.SelectAll();
             return SortByExpression(objPManufacturerCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturer.
         /// </summary>
         public static List<PManufacturerModel> SelectAllDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PManufacturerDataLayer.SelectAllDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturer sorted by the sort expression.
         /// </summary>
         public static List<PManufacturerModel> SelectAllDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<PManufacturerModel> objPManufacturerCol = PManufacturerDataLayer.SelectAllDynamicWhere(id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objPManufacturerCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PManufacturerModel> SelectPManufacturerDropDownListData()
         {
             return PManufacturerDataLayer.SelectPManufacturerDropDownListData();
         }

         /// <summary>
         /// Sorts the PManufacturerCollection by sort expression
         /// </summary>
         public static List<PManufacturerModel> SortByExpression(List<PManufacturerModel> objPManufacturerCol, string sortExpression)
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
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ById);
             //        break;
             //    case "Name":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByName);
             //        break;
             //    case "Address":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByAddress);
             //        break;
             //    case "CreatedDate":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPManufacturerCol.Sort(Cms.BusinessObject.PManufacturer.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPManufacturerCol.Reverse();

             return objPManufacturerCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PManufacturerModel objPManufacturer = (PManufacturerModel)this;
             return PManufacturerDataLayer.Insert(objPManufacturer);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PManufacturerModel objPManufacturer = (PManufacturerModel)this;
             PManufacturerDataLayer.Update(objPManufacturer);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PManufacturerDataLayer.Delete(id);
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
         //public static Comparison<PManufacturer> ById = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByName = delegate(PManufacturer x, PManufacturer y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Address used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByAddress = delegate(PManufacturer x, PManufacturer y)
         //{
         //    string value1 = x.Address ?? String.Empty;
         //    string value2 = y.Address ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByCreatedDate = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByModifiedDate = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByCreatedUserId = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByModifiedUserId = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByIsDeleted = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PManufacturer> ByStatus = delegate(PManufacturer x, PManufacturer y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
