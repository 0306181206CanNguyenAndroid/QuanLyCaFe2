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
     /// Base class for PProducttype.  Do not make changes to this class,
     /// instead, put additional code in the PProducttype class
     /// </summary>
     public class PProducttypeBase : PProducttypeModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PProducttypeBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProducttypeModel SelectByPrimaryKey(int id)
         {
             return PProducttypeDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PProducttype table
         /// </summary>
         public static int GetRecordCount()
         {
             return PProducttypeDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PProducttype table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
             return PProducttypeDataLayer.GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProducttype sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PProducttypeDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProducttype sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProducttypeDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProducttype sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return PProducttypeDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProducttype sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProducttypeDataLayer.SelectSkipAndTakeDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProducttype
         /// </summary>
         public static List<PProducttypeModel> SelectAll()
         {
             return PProducttypeDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProducttype sorted by the sort expression
         /// </summary>
         public static List<PProducttypeModel> SelectAll(string sortExpression)
         {
            List<PProducttypeModel> objPProducttypeCol = PProducttypeDataLayer.SelectAll();
             return SortByExpression(objPProducttypeCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProducttype.
         /// </summary>
         public static List<PProducttypeModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
             return PProducttypeDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProducttype sorted by the sort expression.
         /// </summary>
         public static List<PProducttypeModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<PProducttypeModel> objPProducttypeCol = PProducttypeDataLayer.SelectAllDynamicWhere(id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
             return SortByExpression(objPProducttypeCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PProducttypeModel> SelectPProducttypeDropDownListData()
         {
             return PProducttypeDataLayer.SelectPProducttypeDropDownListData();
         }

         /// <summary>
         /// Sorts the PProducttypeCollection by sort expression
         /// </summary>
         public static List<PProducttypeModel> SortByExpression(List<PProducttypeModel> objPProducttypeCol, string sortExpression)
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
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ById);
             //        break;
             //    case "Name":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByName);
             //        break;
             //    case "CreatedDate":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPProducttypeCol.Sort(Cms.BusinessObject.PProducttype.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPProducttypeCol.Reverse();

             return objPProducttypeCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PProducttypeModel objPProducttype = (PProducttypeModel)this;
             return PProducttypeDataLayer.Insert(objPProducttype);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PProducttypeModel objPProducttype = (PProducttypeModel)this;
             PProducttypeDataLayer.Update(objPProducttype);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PProducttypeDataLayer.Delete(id);
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
         //public static Comparison<PProducttype> ById = delegate(PProducttype x, PProducttype y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByName = delegate(PProducttype x, PProducttype y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByCreatedDate = delegate(PProducttype x, PProducttype y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByModifiedDate = delegate(PProducttype x, PProducttype y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByCreatedUserId = delegate(PProducttype x, PProducttype y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByModifiedUserId = delegate(PProducttype x, PProducttype y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PProducttype> ByIsDeleted = delegate(PProducttype x, PProducttype y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
