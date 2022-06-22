use Cafe
go
create table [P_Table]
(
	[Id] int not null IDENTITY(1,1),
	[Code] varchar(10) null,
	[Description] nvarchar(30) null,
	[Type] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Table primary key(Id)
)

Create table P_Manufacturer
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[Address] nvarchar(500) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Manu primary key(Id)
)

Create table P_ManufacturerLog
(
	[Id] int not null IDENTITY(1,1),
	[Note] nvarchar(100) null,
	[ManuId] int null,
	[Action] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_ManufacturerLog primary key(Id),
)

 Create table P_ProductType
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	constraint pk_ProductType primary key(Id)
)

Create table P_Product
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[Description] nvarchar(500) null,
	[ManuId] int null,
	[ProductTypeId] int null, 
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	[Discount] int null ,
	[ProductCode] varchar(20) null,
	[Price] decimal(18,0) null ,
	constraint pk_Product primary key(Id),
)



Create table P_ProductLog
(
	[Id] int not null IDENTITY(1,1),
	[Note] nvarchar(100) null,
	[ProductId] int null,
	[Action] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_ProductLog primary key(Id),
)

Create table P_ImportGoods
(
	[Id] int not null IDENTITY(1,1),
	[GoodsNumber] varchar(100) null,
	[GoodsCode] varchar(100) null,
	[Note] nvarchar(200) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[ImportQuantity] int null,
	[IsDeleted] bit null,
	[Status] int null,
	constraint pk_ImportGoods primary key(Id)
)

Create table P_ImportGoodsDetail
(
	[Id] int not null IDENTITY(1,1),
	[ImportGoodsId] int null,
	[ProductInfo] int null,	
	[ManuDate] DateTime null,
	[ExpiryDate] DateTime null,
	[ProductNumber] varchar(100) null,
	[ProductCode] varchar(100) null,
	[ProductTypeId] int null, 
	[ImportQuantity] int null,
	[IsDeleted] bit null,
	[Status] int null,
	constraint pk_IGD primary key(Id),
)

Create table P_Stock
(
	[Id] int not null IDENTITY(1,1),
	[ProductInfo] int null,
	[Quantity] int null,
	[BatchOfGoodsId] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Stock primary key(Id),
)

Create table P_StockLog
(
	[Id] int not null IDENTITY(1,1),
	[Note] nvarchar(100) null,
	[StockId] int null,
	[Action] int null,
	[QuantityOld] int null,
	[QuantityAdd] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_StockLog primary key(Id),
)

Create table [System_AccessRights]
(
	[Id] int not null IDENTITY(1,1),
	[Code] int null,
	[Name] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_AccessRights primary key(Id)
)

Create table [System_AccessRightsGroup]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_AccessRightsGroup primary key(Id)
)

Create table [System_AccessRightsGroupdetail]
(
	[Id] int not null IDENTITY(1,1),
	[GroupId] int null,
	[AccessRightsApplyId] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_AccessRightsGroupDetail primary key(Id),
)

Create table [System_User]
(
	[Id] int not null IDENTITY(1,1),
	[UserName] varchar(50) null,
	[Pass] varchar(100) null,
	[Name] nvarchar(100) null,
	[Image] nvarchar(200) null,
	[AccessRightsGroup] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_User primary key(Id),
)

Create table [System_UserLog]
(
	[Id] int not null IDENTITY(1,1),
	[UserId] int null,
	[Action] int null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_UserLog primary key(Id),
	constraint fk_User_User foreign key(UserId) references [System_User](Id),
)

Create table [System_Position]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[SalaryPerHour] decimal(18,0) null,
	[IsDeleted] bit,
	constraint pk_Position primary key(Id)
)

Create table [System_PositionLog]
(
	[Id] int not null IDENTITY(1,1),
	[PositionId] int null,
	[Action] int null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_PositionLog primary key(Id),
)

Create table [System_Staff]
(
	[Id] int not null IDENTITY(1,1),
	[FirstName] nvarchar(40) null,
	[LastName] nvarchar(20) null,
	[FullName] nvarchar(60) null,
	[Birth] Datetime null,
	[Address] nvarchar(200) null,
	[Image] nvarchar(200) null,
	[Phone] varchar(20) null,
	[Email] varchar(50) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[PositionId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Staff primary key(Id),
)

Create table [System_Decentralization]
(
	[Id] int not null IDENTITY(1,1),
	[UserId] int null,
	[StaffId] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	constraint pk_Decentralization primary key(Id),
)

Create table [System_StaffLog]
(
	[Id] int not null IDENTITY(1,1),
	[StaffId] int null,
	[Action] int null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_StaffLog primary key(Id),
)

Create table P_Customer
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[Code] varchar(50) null,
	[Birth] Datetime null,
	[Address] nvarchar(200) null,
	[Phone] varchar(20) null,
	[Email] varchar(50) null,
	[Point] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Customer primary key(Id),
)

Create table P_Bill
(
	[Id] int not null IDENTITY(1,1),
	[TotalPrice] decimal(18,0) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[CustomerId] int null,
	[BillDetailId] int null,
	[Status] int null,
	[DeliveryAddress] nvarchar(50) null,
	constraint pk_Bill primary key(Id),
)
 
 Create table P_BillLog
(
	[Id] int not null IDENTITY(1,1),
	[BillId] int null,
	[Action] int null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit null,
	constraint pk_BillLog primary key(Id),
)

Create table P_BillDetail
(
	[Id] int not null IDENTITY(1,1),
	[BillId] int null,
	[TableId] int null,
	[ProductId] int null,
	[Quantity] int null,
	[UnitPrice] decimal(18,0) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	[Discount] int null,
	[DiscountPrice] decimal(18,0) null,
	constraint pk_BillDetail primary key(Id),
)

--drop table P_BillDetail
--drop table P_BillLog
--drop table P_Bill
--drop table P_Customer
--drop table [System_StaffLog]
--drop table [System_Decentralization]
--drop table [System_Staff]
--drop table [System_PositionLog]
--drop table [System_Position]
--drop table [System_UserLog]
--drop table [System_User]
--drop table [System_AccessRightsGroupdetail]
--drop table [System_AccessRightsGroup]
--drop table [System_AccessRights]
--drop table P_StockLog 
--drop table P_Stock 
--drop table P_ImportGoodsDetail
--drop table P_ImportGoods
--drop table P_ProductLog 
--drop table P_Product 
--drop table P_ProductType 
--drop table P_ManufacturerLog
--drop table P_Manufacturer

--sp_rename 'ten_bang.ten_cot_cu', 'ten_cot_moi', 'COLUMN';