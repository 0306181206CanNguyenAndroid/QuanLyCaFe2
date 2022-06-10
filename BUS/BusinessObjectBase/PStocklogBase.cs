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
     /// Base class for PStocklog.  Do not make changes to this class,
     /// instead, put additional code in the PStocklog class
     /// </summary>
     public class PStocklogBase : PStocklogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PStocklogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PStocklogModel SelectByPrimaryKey(int id)
         {
             return PStocklogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PStocklog table
         /// </summary>
         public static int GetRecordCount()
         {
             return PStocklogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PStocklog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PStocklogDataLayer.GetRecordCountDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStocklog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PStocklogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStocklog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PStocklogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStocklog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return PStocklogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStocklog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PStocklogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PStocklog
         /// </summary>
         public static List<PStocklogModel> SelectAll()
         {
             return PStocklogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PStocklog sorted by the sort expression
         /// </summary>
         public static List<PStocklogModel> SelectAll(string sortExpression)
         {
            List<PStocklogModel> objPStocklogCol = PStocklogDataLayer.SelectAll();
             return SortByExpression(objPStocklogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStocklog.
         /// </summary>
         public static List<PStocklogModel> SelectAllDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PStocklogDataLayer.SelectAllDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStocklog sorted by the sort expression.
         /// </summary>
         public static List<PStocklogModel> SelectAllDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortExpression)
         {
            List<PStocklogModel> objPStocklogCol = PStocklogDataLayer.SelectAllDynamicWhere(id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);
             return SortByExpression(objPStocklogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PStocklogModel> SelectPStocklogDropDownListData()
         {
             return PStocklogDataLayer.SelectPStocklogDropDownListData();
         }

         /// <summary>
         /// Sorts the PStocklogCollection by sort expression
         /// </summary>
         public static List<PStocklogModel> SortByExpression(List<PStocklogModel> objPStocklogCol, string sortExpression)
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
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ById);
             //        break;
             //    case "Note":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByNote);
             //        break;
             //    case "StockId":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByStockId);
             //        break;
             //    case "Action":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByAction);
             //        break;
             //    case "QuantityOld":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByQuantityOld);
             //        break;
             //    case "QuantityAdd":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByQuantityAdd);
             //        break;
             //    case "CreatedDate":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByCreatedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByCreatedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPStocklogCol.Sort(Cms.BusinessObject.PStocklog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPStocklogCol.Reverse();

             return objPStocklogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PStocklogModel objPStocklog = (PStocklogModel)this;
             return PStocklogDataLayer.Insert(objPStocklog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PStocklogModel objPStocklog = (PStocklogModel)this;
             PStocklogDataLayer.Update(objPStocklog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PStocklogDataLayer.Delete(id);
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
         //public static Comparison<PStocklog> ById = delegate(PStocklog x, PStocklog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Note used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByNote = delegate(PStocklog x, PStocklog y)
         //{
         //    string value1 = x.Note ?? String.Empty;
         //    string value2 = y.Note ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares StockId used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByStockId = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.StockId, y.StockId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByAction = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares QuantityOld used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByQuantityOld = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.QuantityOld, y.QuantityOld);
         //};

         ///// <summary>
         ///// Compares QuantityAdd used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByQuantityAdd = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.QuantityAdd, y.QuantityAdd);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByCreatedDate = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByCreatedUserId = delegate(PStocklog x, PStocklog y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PStocklog> ByIsDeleted = delegate(PStocklog x, PStocklog y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
