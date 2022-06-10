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
     /// Base class for PImportgoods.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoods class
     /// </summary>
     public class PImportgoodsBase : PImportgoodsModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PImportgoodsBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PImportgoodsModel SelectByPrimaryKey(int id)
         {
             return PImportgoodsDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoods table
         /// </summary>
         public static int GetRecordCount()
         {
             return PImportgoodsDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoods table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status)
         {
             return PImportgoodsDataLayer.GetRecordCountDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoods sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PImportgoodsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoods sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoods sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTakeDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsDataLayer.SelectSkipAndTakeDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoods sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTakeDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsDataLayer.SelectSkipAndTakeDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PImportgoods
         /// </summary>
         public static List<PImportgoodsModel> SelectAll()
         {
             return PImportgoodsDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PImportgoods sorted by the sort expression
         /// </summary>
         public static List<PImportgoodsModel> SelectAll(string sortExpression)
         {
            List<PImportgoodsModel> objPImportgoodsCol = PImportgoodsDataLayer.SelectAll();
             return SortByExpression(objPImportgoodsCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoods.
         /// </summary>
         public static List<PImportgoodsModel> SelectAllDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status)
         {
             return PImportgoodsDataLayer.SelectAllDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoods sorted by the sort expression.
         /// </summary>
         public static List<PImportgoodsModel> SelectAllDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status, string sortExpression)
         {
            List<PImportgoodsModel> objPImportgoodsCol = PImportgoodsDataLayer.SelectAllDynamicWhere(id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);
             return SortByExpression(objPImportgoodsCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and GoodsNumber columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PImportgoodsModel> SelectPImportgoodsDropDownListData()
         {
             return PImportgoodsDataLayer.SelectPImportgoodsDropDownListData();
         }

         /// <summary>
         /// Sorts the PImportgoodsCollection by sort expression
         /// </summary>
         public static List<PImportgoodsModel> SortByExpression(List<PImportgoodsModel> objPImportgoodsCol, string sortExpression)
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
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ById);
             //        break;
             //    case "GoodsNumber":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByGoodsNumber);
             //        break;
             //    case "GoodsCode":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByGoodsCode);
             //        break;
             //    case "Note":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByNote);
             //        break;
             //    case "CreatedDate":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByModifiedUserId);
             //        break;
             //    case "ImportQuantity":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByImportQuantity);
             //        break;
             //    case "IsDeleted":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPImportgoodsCol.Sort(Cms.BusinessObject.PImportgoods.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPImportgoodsCol.Reverse();

             return objPImportgoodsCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PImportgoodsModel objPImportgoods = (PImportgoodsModel)this;
             return PImportgoodsDataLayer.Insert(objPImportgoods);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PImportgoodsModel objPImportgoods = (PImportgoodsModel)this;
             PImportgoodsDataLayer.Update(objPImportgoods);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PImportgoodsDataLayer.Delete(id);
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
         //public static Comparison<PImportgoods> ById = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares GoodsNumber used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByGoodsNumber = delegate(PImportgoods x, PImportgoods y)
         //{
         //    string value1 = x.GoodsNumber ?? String.Empty;
         //    string value2 = y.GoodsNumber ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares GoodsCode used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByGoodsCode = delegate(PImportgoods x, PImportgoods y)
         //{
         //    string value1 = x.GoodsCode ?? String.Empty;
         //    string value2 = y.GoodsCode ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Note used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByNote = delegate(PImportgoods x, PImportgoods y)
         //{
         //    string value1 = x.Note ?? String.Empty;
         //    string value2 = y.Note ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByCreatedDate = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByModifiedDate = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByCreatedUserId = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByModifiedUserId = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares ImportQuantity used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByImportQuantity = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.ImportQuantity, y.ImportQuantity);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByIsDeleted = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PImportgoods> ByStatus = delegate(PImportgoods x, PImportgoods y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
