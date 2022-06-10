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
     /// Base class for PProductlog.  Do not make changes to this class,
     /// instead, put additional code in the PProductlog class
     /// </summary>
     public class PProductlogBase : PProductlogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PProductlogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProductlogModel SelectByPrimaryKey(int id)
         {
             return PProductlogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PProductlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return PProductlogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PProductlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PProductlogDataLayer.GetRecordCountDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProductlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PProductlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProductlog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProductlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductlogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProductlog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductlogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProductlog
         /// </summary>
         public static List<PProductlogModel> SelectAll()
         {
             return PProductlogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProductlog sorted by the sort expression
         /// </summary>
         public static List<PProductlogModel> SelectAll(string sortExpression)
         {
            List<PProductlogModel> objPProductlogCol = PProductlogDataLayer.SelectAll();
             return SortByExpression(objPProductlogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProductlog.
         /// </summary>
         public static List<PProductlogModel> SelectAllDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PProductlogDataLayer.SelectAllDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProductlog sorted by the sort expression.
         /// </summary>
         public static List<PProductlogModel> SelectAllDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortExpression)
         {
            List<PProductlogModel> objPProductlogCol = PProductlogDataLayer.SelectAllDynamicWhere(id, note, productId, action, createdDate, createdUserId, isDeleted);
             return SortByExpression(objPProductlogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PProductlogModel> SelectPProductlogDropDownListData()
         {
             return PProductlogDataLayer.SelectPProductlogDropDownListData();
         }

         /// <summary>
         /// Sorts the PProductlogCollection by sort expression
         /// </summary>
         public static List<PProductlogModel> SortByExpression(List<PProductlogModel> objPProductlogCol, string sortExpression)
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
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ById);
             //        break;
             //    case "Note":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByNote);
             //        break;
             //    case "ProductId":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByProductId);
             //        break;
             //    case "Action":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByAction);
             //        break;
             //    case "CreatedDate":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByCreatedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByCreatedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPProductlogCol.Sort(Cms.BusinessObject.PProductlog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPProductlogCol.Reverse();

             return objPProductlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PProductlogModel objPProductlog = (PProductlogModel)this;
             return PProductlogDataLayer.Insert(objPProductlog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PProductlogModel objPProductlog = (PProductlogModel)this;
             PProductlogDataLayer.Update(objPProductlog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PProductlogDataLayer.Delete(id);
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
         //public static Comparison<PProductlog> ById = delegate(PProductlog x, PProductlog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Note used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByNote = delegate(PProductlog x, PProductlog y)
         //{
         //    string value1 = x.Note ?? String.Empty;
         //    string value2 = y.Note ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares ProductId used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByProductId = delegate(PProductlog x, PProductlog y)
         //{
         //    return Nullable.Compare(x.ProductId, y.ProductId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByAction = delegate(PProductlog x, PProductlog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByCreatedDate = delegate(PProductlog x, PProductlog y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByCreatedUserId = delegate(PProductlog x, PProductlog y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PProductlog> ByIsDeleted = delegate(PProductlog x, PProductlog y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
