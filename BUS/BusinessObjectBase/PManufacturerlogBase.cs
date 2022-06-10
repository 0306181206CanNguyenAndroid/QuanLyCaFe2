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
     /// Base class for PManufacturerlog.  Do not make changes to this class,
     /// instead, put additional code in the PManufacturerlog class
     /// </summary>
     public class PManufacturerlogBase : PManufacturerlogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PManufacturerlogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PManufacturerlogModel SelectByPrimaryKey(int id)
         {
             return PManufacturerlogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturerlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return PManufacturerlogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturerlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PManufacturerlogDataLayer.GetRecordCountDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturerlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PManufacturerlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturerlog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturerlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerlogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PManufacturerlog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PManufacturerlogDataLayer.SelectSkipAndTakeDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PManufacturerlog
         /// </summary>
         public static List<PManufacturerlogModel> SelectAll()
         {
             return PManufacturerlogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PManufacturerlog sorted by the sort expression
         /// </summary>
         public static List<PManufacturerlogModel> SelectAll(string sortExpression)
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = PManufacturerlogDataLayer.SelectAll();
             return SortByExpression(objPManufacturerlogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturerlog.
         /// </summary>
         public static List<PManufacturerlogModel> SelectAllDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
             return PManufacturerlogDataLayer.SelectAllDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturerlog sorted by the sort expression.
         /// </summary>
         public static List<PManufacturerlogModel> SelectAllDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortExpression)
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = PManufacturerlogDataLayer.SelectAllDynamicWhere(id, note, manuId, action, createdDate, createdUserId, isDeleted);
             return SortByExpression(objPManufacturerlogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PManufacturerlogModel> SelectPManufacturerlogDropDownListData()
         {
             return PManufacturerlogDataLayer.SelectPManufacturerlogDropDownListData();
         }

         /// <summary>
         /// Sorts the PManufacturerlogCollection by sort expression
         /// </summary>
         public static List<PManufacturerlogModel> SortByExpression(List<PManufacturerlogModel> objPManufacturerlogCol, string sortExpression)
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
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ById);
             //        break;
             //    case "Note":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByNote);
             //        break;
             //    case "ManuId":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByManuId);
             //        break;
             //    case "Action":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByAction);
             //        break;
             //    case "CreatedDate":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByCreatedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByCreatedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPManufacturerlogCol.Sort(Cms.BusinessObject.PManufacturerlog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPManufacturerlogCol.Reverse();

             return objPManufacturerlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PManufacturerlogModel objPManufacturerlog = (PManufacturerlogModel)this;
             return PManufacturerlogDataLayer.Insert(objPManufacturerlog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PManufacturerlogModel objPManufacturerlog = (PManufacturerlogModel)this;
             PManufacturerlogDataLayer.Update(objPManufacturerlog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PManufacturerlogDataLayer.Delete(id);
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
         //public static Comparison<PManufacturerlog> ById = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Note used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByNote = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    string value1 = x.Note ?? String.Empty;
         //    string value2 = y.Note ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares ManuId used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByManuId = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return Nullable.Compare(x.ManuId, y.ManuId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByAction = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByCreatedDate = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByCreatedUserId = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PManufacturerlog> ByIsDeleted = delegate(PManufacturerlog x, PManufacturerlog y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
