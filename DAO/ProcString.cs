using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class ProcString
    {
        #region Bills

        public static string procNameBill_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";
        public static string procNameBill_GetRecordCount = "[dbo].[PBill_GetRecordCount]";
        public static string procNameBill_InBill = "[dbo].[PCustomer_InBill]";
        public static string procNameBill_GetRecordCountDynamicWhere = "[dbo].[PBill_GetRecordCountWhereDynamic]";
        //public static string procNameBill_SelectShared = "[dbo].[PBill_SelectShared]";
        public static string procNameBill_SelectSkipAndTake = "[dbo].[PBill_SelectSkipAndTake]";
        public static string procNameBill_SelectSkipAndTakeDynamicWhere = "[dbo].[PBill_SelectSkipAndTakeWhereDynamic]";
        public static string procNameBill_SelectTotal = "[dbo].[PBill_SelectTotals]";
        public static string procNameBill_SelectAll = "[dbo].[PBill_SelectAll]";
        public static string procNameBill_SelectAllWhereDynamic = "[dbo].[PBill_SelectAllWhereDynamic]";
        public static string procNameBill_SelectDropDownListData = "[dbo].[PBill_SelectDropDownListData]";
        public static string procNameBill_Insert = "[dbo].[PBill_Insert]";
        public static string procNameBill_Update = "[dbo].[PBill_Update]";
        public static string procNameBill_Delete = "[dbo].[PBill_Delete]";

        #endregion

        #region P_BillDetails

        public static string procNameBillDetail_SelectByPrimaryKey = "[dbo].[PBilldetail_SelectByPrimaryKey]";
        public static string procNameBillDetail_GetRecordCount = "[dbo].[PBilldetail_GetRecordCount]";
        public static string procNameBillDetail_GetRecordCountDynamicWhere = "[dbo].[PBilldetail_GetRecordCountWhereDynamic]";
        //public static string procNameBillDetail_SelectShared = "[dbo].[PBilldetail_SelectShared]";
        public static string procNameBillDetail_SelectSkipAndTake = "[dbo].[PBilldetail_SelectSkipAndTake]";
        public static string procNameBillDetail_SelectSkipAndTakeDynamicWhere = "[dbo].[PBilldetail_SelectSkipAndTakeWhereDynamic]";
        public static string procNameBillDetail_SelectTotal = "[dbo].[PBilldetail_SelectTotals]";
        public static string procNameBillDetail_SelectAll = "[dbo].[PBilldetail_SelectAll]";
        public static string procNameBillDetail_SelectAllWhereDynamic = "[dbo].[PBilldetail_SelectAllWhereDynamic]";
        public static string procNameBillDetail_SelectDropDownListData = "[dbo].[PBilldetail_SelectDropDownListData]";
        public static string procNameBillDetail_Insert = "[dbo].[PBilldetail_Insert]";
        public static string procNameBillDetail_Update = "[dbo].[PBilldetail_Update]";
        public static string procNameBillDetail_Delete = "[dbo].[PBilldetail_Delete]";

        #endregion

        #region P_BillLogs

        public static string procNameBillLog_SelectByPrimaryKey = "[dbo].[PBillLog_SelectByPrimaryKey]";
        public static string procNameBillLog_GetRecordCount = "[dbo].[PBillLog_GetRecordCount]";
        public static string procNameBillLog_GetRecordCountDynamicWhere = "[dbo].[PBillLog_GetRecordCountWhereDynamic]";
        public static string procNameBillLog_SelectShared = "[dbo].[PBillLog_SelectSkipAndTake]";
        public static string procNameBillLog_SelectSkipAndTake = "[dbo].[PBillLog_SelectSkipAndTakeWhereDynamic]";
        public static string procNameBillLog_SelectSkipAndTakeDynamicWhere = "[dbo].[PBillLog_SelectSkipAndTakeWhereDynamic]";
        public static string procNameBillLog_SelectTotal = "[dbo].[PBillLog_SelectTotals]";
        public static string procNameBillLog_SelectAll = "[dbo].[PBillLog_SelectAll]";
        public static string procNameBillLog_SelectAllWhereDynamic = "[dbo].[PBillLog_SelectAllWhereDynamic]";
        public static string procNameBillLog_SelectDropDownListData = "[dbo].[PBillLog_SelectDropDownListData]";
        public static string procNameBillLog_Insert = "[dbo].[PBillLog_Insert]";
        public static string procNameBillLog_Update = "[dbo].[PBillLog_Update]";
        public static string procNameBillLog_Delete = "[dbo].[PBillLog_Delete]";

        #endregion

        #region none

        #endregion

        #region P_Customers

        public static string procNameCustomer_SelectByPrimaryKey = "[dbo].[PCustomer_SelectByPrimaryKey]";
        public static string procNameCustomer_GetRecordCount = "[dbo].[PCustomer_GetRecordCount]";
        public static string procNameCustomer_GetRecordCountDynamicWhere = "[dbo].[PCustomer_GetRecordCountWhereDynamic]";
        public static string procNameCustomer_SelectShared = "[dbo].[PCustomer_SelectSkipAndTake]";
        public static string procNameCustomer_SelectSkipAndTake = "[dbo].[PCustomer_SelectSkipAndTakeWhereDynamic]";
        public static string procNameCustomer_SelectSkipAndTakeDynamicWhere = "[dbo].[PCustomer_SelectSkipAndTakeWhereDynamic]";
        public static string procNameCustomer_SelectTotal = "[dbo].[PCustomer_SelectTotals]";
        public static string procNameCustomer_SelectAll = "[dbo].[PCustomer_SelectAll]";
        public static string procNameCustomer_SelectAllWhereDynamic = "[dbo].[PCustomer_SelectAllWhereDynamic]";
        public static string procNameCustomer_SelectDropDownListData = "[dbo].[PCustomer_SelectDropDownListData]";
        public static string procNameCustomer_Insert = "[dbo].[PCustomer_Insert]";
        public static string procNameCustomer_Update = "[dbo].[PCustomer_Update]";
        public static string procNameCustomer_Delete = "[dbo].[PCustomer_Delete]";

        #endregion

        #region P_ImportGoods

        public static string procNameImportGoods_SelectByPrimaryKey = "[dbo].[PImportGoods_SelectByPrimaryKey]";
        public static string procNameImportGoods_GetRecordCount = "[dbo].[PImportGoods_GetRecordCount]";
        public static string procNameImportGoods_GetRecordCountDynamicWhere = "[dbo].[PImportGoods_GetRecordCountWhereDynamic]";
        public static string procNameImportGoods_SelectShared = "[dbo].[PImportGoods_SelectSkipAndTake]";
        public static string procNameImportGoods_SelectSkipAndTake = "[dbo].[PImportGoods_SelectSkipAndTakeWhereDynamic]";
        public static string procNameImportGoods_SelectSkipAndTakeDynamicWhere = "[dbo].[PImportGoods_SelectSkipAndTakeWhereDynamic]";
        public static string procNameImportGoods_SelectTotal = "[dbo].[PImportGoods_SelectTotals]";
        public static string procNameImportGoods_SelectAll = "[dbo].[PImportGoods_SelectAll]";
        public static string procNameImportGoods_SelectAllWhereDynamic = "[dbo].[PImportGoods_SelectAllWhereDynamic]";
        public static string procNameImportGoods_SelectDropDownListData = "[dbo].[PImportGoods_SelectDropDownListData]";
        public static string procNameImportGoods_Insert = "[dbo].[PImportGoods_Insert]";
        public static string procNameImportGoods_Update = "[dbo].[PImportGoods_Update]";
        public static string procNameImportGoods_Delete = "[dbo].[PImportGoods_Delete]";

        #endregion

        #region P_ImportGoodsDetails

        public static string procNameImportGoodsDetail_SelectByPrimaryKey = "[dbo].[PImportGoodsDetail_SelectByPrimaryKey]";
        public static string procNameImportGoodsDetail_GetRecordCount = "[dbo].[PImportGoodsDetail_GetRecordCount]";
        public static string procNameImportGoodsDetail_GetRecordCountDynamicWhere = "[dbo].[PImportGoodsDetail_GetRecordCountWhereDynamic]";
        public static string procNameImportGoodsDetail_SelectShared = "[dbo].[PImportGoodsDetail_SelectSkipAndTake]";
        public static string procNameImportGoodsDetail_SelectSkipAndTake = "[dbo].[PImportGoodsDetail_SelectSkipAndTakeWhereDynamic]";
        public static string procNameImportGoodsDetail_SelectSkipAndTakeDynamicWhere = "[dbo].[PImportGoodsDetail_SelectSkipAndTakeWhereDynamic]";
        public static string procNameImportGoodsDetail_SelectTotal = "[dbo].[PImportGoodsDetail_SelectTotals]";
        public static string procNameImportGoodsDetail_SelectAll = "[dbo].[PImportGoodsDetail_SelectAll]";
        public static string procNameImportGoodsDetail_SelectAllWhereDynamic = "[dbo].[PImportGoodsDetail_SelectAllWhereDynamic]";
        public static string procNameImportGoodsDetail_SelectDropDownListData = "[dbo].[PImportGoodsDetail_SelectDropDownListData]";
        public static string procNameImportGoodsDetail_Insert = "[dbo].[PImportGoodsDetail_Insert]";
        public static string procNameImportGoodsDetail_Update = "[dbo].[PImportGoodsDetail_Update]";
        public static string procNameImportGoodsDetail_Delete = "[dbo].[PImportGoodsDetail_Delete]";

        #endregion

        #region P_Manufacturers

        public static string procNameManufacturer_SelectByPrimaryKey = "[dbo].[PManufacturer_SelectByPrimaryKey]";
        public static string procNameManufacturer_GetRecordCount = "[dbo].[PManufacturer_GetRecordCount]";
        public static string procNameManufacturer_GetRecordCountDynamicWhere = "[dbo].[PManufacturer_GetRecordCountWhereDynamic]";
        public static string procNameManufacturer_SelectShared = "[dbo].[PManufacturer_SelectSkipAndTake]";
        public static string procNameManufacturer_SelectSkipAndTake = "[dbo].[PManufacturer_SelectSkipAndTakeWhereDynamic]";
        public static string procNameManufacturer_SelectSkipAndTakeDynamicWhere = "[dbo].[PManufacturer_SelectSkipAndTakeWhereDynamic]";
        public static string procNameManufacturer_SelectTotal = "[dbo].[PManufacturer_SelectTotals]";
        public static string procNameManufacturer_SelectAll = "[dbo].[PManufacturer_SelectAll]";
        public static string procNameManufacturer_SelectAllWhereDynamic = "[dbo].[PManufacturer_SelectAllWhereDynamic]";
        public static string procNameManufacturer_SelectDropDownListData = "[dbo].[PManufacturer_SelectDropDownListData]";
        public static string procNameManufacturer_Insert = "[dbo].[PManufacturer_Insert]";
        public static string procNameManufacturer_Update = "[dbo].[PManufacturer_Update]";
        public static string procNameManufacturer_Delete = "[dbo].[PManufacturer_Delete]";

        #endregion

        #region P_ManufacturerLogs

        public static string procNameManufacturerLog_SelectByPrimaryKey = "[dbo].[PManufacturerLog_SelectByPrimaryKey]";
        public static string procNameManufacturerLog_GetRecordCount = "[dbo].[PManufacturerLog_GetRecordCount]";
        public static string procNameManufacturerLog_GetRecordCountDynamicWhere = "[dbo].[PManufacturerLog_GetRecordCountWhereDynamic]";
        public static string procNameManufacturerLog_SelectShared = "[dbo].[PManufacturerLog_SelectSkipAndTake]";
        public static string procNameManufacturerLog_SelectSkipAndTake = "[dbo].[PManufacturerLog_SelectSkipAndTakeWhereDynamic]";
        public static string procNameManufacturerLog_SelectSkipAndTakeDynamicWhere = "[dbo].[PManufacturerLog_SelectSkipAndTakeWhereDynamic]";
        public static string procNameManufacturerLog_SelectTotal = "[dbo].[PManufacturerLog_SelectTotals]";
        public static string procNameManufacturerLog_SelectAll = "[dbo].[PManufacturerLog_SelectAll]";
        public static string procNameManufacturerLog_SelectAllWhereDynamic = "[dbo].[PManufacturerLog_SelectAllWhereDynamic]";
        public static string procNameManufacturerLog_SelectDropDownListData = "[dbo].[PManufacturerLog_SelectDropDownListData]";
        public static string procNameManufacturerLog_Insert = "[dbo].[PManufacturerLog_Insert]";
        public static string procNameManufacturerLog_Update = "[dbo].[PManufacturerLog_Update]";
        public static string procNameManufacturerLog_Delete = "[dbo].[PManufacturerLog_Delete]";

        #endregion

        #region P_Products

        public static string procNameProduct_SelectByPrimaryKey = "[dbo].[Product_SelectByPrimaryKey]";
        public static string procNameProduct_GetRecordCount = "[dbo].[Product_GetRecordCount]";
        public static string procNameProduct_GetRecordCountDynamicWhere = "[dbo].[Product_GetRecordCountWhereDynamic]";
        public static string procNameProduct_SelectSkipAndTake = "[dbo].[Product_SelectSkipAndTake]";
        public static string procNameProduct_SelectSkipAndTakeDynamicWhere = "[dbo].[Product_SelectSkipAndTakeWhereDynamic]";
        public static string procNameProduct_SelectTotal = "[dbo].[Product_SelectTotals]";
        public static string procNameProduct_SelectAll = "[dbo].[Product_SelectAll]";
        public static string procNameProduct_SelectAllWhereDynamic = "[dbo].[Product_SelectAllWhereDynamic]";
        public static string procNameProduct_SelectDropDownListData = "[dbo].[Product_SelectDropDownListData]";
        public static string procNameProduct_Insert = "[dbo].[Product_Insert]";
        public static string procNameProduct_Update = "[dbo].[Product_Update]";
        public static string procProduct_Delete = "[dbo].[Product_Delete]";

        #endregion

        #region P_ProductTypes

        public static string procNameProductType_SelectByPrimaryKey = "[dbo].[ProductType_SelectByPrimaryKey]";
        public static string procNameProductType_SelectDropDownListData = "[dbo].[ProductType_SelectDropDownListData]";

        #endregion

        #region P_Stocks

        public static string procNameStock_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region P_StockLogs

        public static string procNameStockLog_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_AccessRights

        public static string procNameAccessRight_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_AccessRightGroups

        public static string procNameAccessRightGroup_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_AccessRightGroupDetails

        public static string procNameAccessRightGroupDetail_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_Decentralizations

        public static string procNameDecentralization_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_Positions

        public static string procNamePosition_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_PositionLogs

        public static string procNamePositionLog_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_Staffs

        public static string procNameStaff_SelectByPrimaryKey = "[dbo].[S_Staffs_SelectByPrimaryKey]";
        public static string procNameStaff_SelectByUserId = "[dbo].[SystemStaff_SelectByUserId]";

        #endregion

        #region S_StaffLogs

        public static string procNameStaffLog_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

        #region S_Users

        public static string procNameUser_SelectByPrimaryKey = "[dbo].[User_SelectByPrimaryKey]";
        public static string procNameUser_GetRecordCount = "[dbo].[User_GetRecordCount]";
        public static string procNameUser_GetRecordCountDynamicWhere = "[dbo].[User_GetRecordCountWhereDynamic]";
        public static string procNameUser_SelectSkipAndTake = "[dbo].[User_SelectSkipAndTake]";
        public static string procNameUser_SelectSkipAndTakeDynamicWhere = "[dbo].[User_SelectSkipAndTakeWhereDynamic]";
        public static string procNameUser_SelectTotal = "[dbo].[User_SelectTotals]";
        public static string procNameUser_SelectAll = "[dbo].[User_SelectAll]";
        public static string procNameUser_SelectAllWhereDynamic = "[dbo].[User_SelectAllWhereDynamic]";
        public static string procNameUser_SelectDropDownListData = "[dbo].[User_SelectDropDownListData]";
        public static string procNameUser_Insert = "[dbo].[SystemUser_Insert]";
        public static string procNameUser_Update = "[dbo].[SystemUser_Update]";
        public static string procNameUser_Delete = "[dbo].[SystemUser_Delete]";
        public static string procNameUser_SelectWithUserNameAndPass = "[dbo].[User_SelectWithUsernameAndPass]";

        #endregion

        #region S_UserLogs

        public static string procNameUserLog_SelectByPrimaryKey = "[dbo].[PBill_SelectByPrimaryKey]";

        #endregion

    }
}
