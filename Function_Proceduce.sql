--create function selectGia(@tensp nvarchar(50))
--returns int
--as
--	begin
--	declare @gia int
--	Select @gia=don_gia
--	from sanpham
--	where tensp = @tensp
--	return @gia
--	end

use Cafe
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure Bill
create proc [dbo].[PBill_SelectByPrimaryKey](@id int)
as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[P_Bill] 
		where [Id] = @id and ISNULL([IsDeleted],0) = 0
	end
go

create proc [dbo].[PBill_GetRecordCount](@id int)
as 
	begin
	SET NOCOUNT ON;
		select count(*) from [dbo].[P_Bill]
		where ISNULL([IsDeleted],0) = 0
	end
go

create proc [dbo].[PBill_SelectSkipAndTakeWhereDynamic](
@id int = null,
@totalPrice decimal(18,0) = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@billDetailId int = null,
@status int = null,
@sort varchar(50) = null,
@numberOfRows int,
@start int)
as 
	begin
	SET NOCOUNT ON;
	select * from [dbo].[P_Bill]
	where (@id IS null or [Id] = @id) and
	(@totalPrice is null or [TotalPrice] = @totalPrice) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	order by 
	case 
		when @sort is null or @sort = 'Id' then [Id]
		when @sort = 'TotalPrice' then [TotalPrice]
		when @sort = 'CreatedDate' then [CreatedDate]
		when @sort = 'ModifiedDate' then [ModifiedDate]
		when @sort = 'CreatedUserId' then [CreatedUserId]
		when @sort = 'ModifiedUserId' then [ModifiedUserId]
		when @sort = 'IsDeleted' then [IsDeleted]
		when @sort = 'Status' then [Status]
	end
	offset     @start ROWS       -- skip s rows
	FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
	end
go

create proc [dbo].[PBill_GetRecordCountWhereDynamic](
@id int = null,
@totalPrice decimal(18,0) = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@billDetailId int = null,
@status int = null,
@sort varchar(50))
as 
	begin
	SET NOCOUNT ON;
	select count(*) from [dbo].[P_Bill]
	where (@id IS null or [Id] = @id) and
	(@totalPrice is null or [TotalPrice] = @totalPrice) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	end
go
--end Bill

--Proc Customer
create proc [dbo].[PCustomer_SelectByPrimaryKey](@id int)
as 
	begin
	SET NOCOUNT ON;
		select * from [dbo].P_Customer
		where [Id] = @id and ISNULL([IsDeleted],0)=0
	end
	go

create proc [dbo].[PCustomer_GetRecordCountWhereDynamic](
@id int = null,
@name nvarchar(50) = null,
@code varchar(50) = null,
@birth datetime = null,
@address nvarchar(200) = null,
@phone varchar(20) = null,
@email varchar(50) = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@status int = null
)
as
begin
	SET NOCOUNT On;
	select COUNT(*) from [dbo].P_Customer
	where(@id IS null or [Id] = @id) and
	(@name is null or [Name] = @name) and
	(@code is null or [Code] = @code) and
	(@birth is null or [Birth] = @birth) and
	(@address is null or [Address] = @address) and
	(@phone is null or [Phone] = @phone) and
	(@email is null or [Email] = @email) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
end
go

create proc [dbo].[PCustomer_SelectSkipAndTakeWhereDynamic](
@id int = null,
@name nvarchar(50) = null,
@code varchar(50) = null,
@birth datetime = null,
@address nvarchar(200) = null,
@phone varchar(20) = null,
@email varchar(50) = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@status int = null,
@sort varchar(50) = null,
@numberOfRows int,
@start int
)
as
begin
	SET NOCOUNT On;
	select * from [dbo].P_Customer
	where(@id IS null or [Id] = @id) and
	(@name is null or [Name] = @name) and
	(@code is null or [Code] = @code) and
	(@birth is null or [Birth] = @birth) and
	(@address is null or [Address] = @address) and
	(@phone is null or [Phone] = @phone) and
	(@email is null or [Email] = @email) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	order by 
	case 
		when @sort is null or @sort = 'Id' then [Id]
		when @sort = 'Id desc' then [Id] end desc,
		case when @sort = 'Name' then [Name]
		when @sort = 'Name desc' then [Name] end desc,
		case when @sort = 'Code' then [Code]
		when @sort = 'Code desc' then [Code] end desc,
		case when @sort = 'Address' then [Address] end,
		case when @sort = 'Email' then [Email] end,
		case when @sort = 'CreatedDate' then [CreatedDate]
		when @sort = 'ModifiedDate' then [ModifiedDate]
		when @sort = 'CreatedUserId' then [CreatedUserId]
		when @sort = 'CreatedUserId desc' then [CreatedUserId] end desc,
		case when @sort = 'ModifiedUserId' then [ModifiedUserId]
		when @sort = 'ModifiedUserId desc' then [ModifiedUserId] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted]
		when @sort = 'Status' then [Status]
	end
	offset     @start ROWS       -- skip s rows
	FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
end
go

--end Customer

--Proc Staff
create proc [dbo].[S_Staffs_SelectByPrimaryKey](@id int)
as 
	begin
	SET NOCOUNT ON;
		select * from [dbo].System_Staff
		where [Id] = @id and ISNULL([IsDeleted],0)=0
	end
--end Staff

create proc SystemUser_Insert 
(@userName varchar(50) = null,
@pass varchar(100) = null,
@name nvarchar(100) = null,
@image nvarchar(200) = null,
@accessRightsGroup int = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null, @status int = null)
as
	begin
	SET NOCOUNT ON;
	declare @id int;
	Insert Into 
	[System_User](UserName,Pass,[Name],[Image],AccessRightsGroup,[CreatedDate],ModifiedDate,[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
	values (@userName,@pass,@name,@image,@accessRightsGroup,@createdDate,@modifiedDate,@createdUserId,@modifiedUserId,@isDeleted,@status)
	set @id = SCOPE_IDENTITY()
	return @id
	
	end
go


create proc SystemUser_Update (@id int,@userName varchar(50) = null,
@pass varchar(100) = null,
@name nvarchar(100) = null,
@image nvarchar(200) = null,
@accessRightsGroup int = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null, @status int = null)
as
	begin
	SET NOCOUNT ON;
	Update [System_User]
	set [UserName]=@userName,	[Pass]=@pass,[Name]=@name,	[Image]=@image,
	[AccessRightsGroup]=@accessRightsGroup,	[CreatedDate]=@createdDate,
	[ModifiedDate]=@modifiedDate,	[CreatedUserId]=@createdUserId,
	[ModifiedUserId]=@modifiedUserId,	[IsDeleted]=@isDeleted,  [Status]=@status
	where [Id] = @id
	
	return @id
	end
go

create proc SystemUser_Delete (@id int)
as
	begin
	SET NOCOUNT ON;
	Delete from [System_User]
	where [Id] = @id
	end
go

create proc User_SelectByPrimaryKey (@Id int)
as
	begin
	SET NOCOUNT ON;
	Select * from [System_User]
	where [Id] = @Id
	end
go

create proc User_SelectAll
as
	begin
	SET NOCOUNT ON;
	Select * from [System_User]
	end
go

create proc User_SelectAllDynamicWhere(
@Id int = null,
@userName varchar(50) = null,
@pass varchar(100) = null,
@name nvarchar(100) = null,
@image nvarchar(200) = null,
@accessRightsGroup int = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null, @status int = null,
@sort varchar(30) = null
)
as
	begin
	SET NOCOUNT ON;
	Select * from [System_User]
	where (@Id IS null or [Id] = @Id) and
	(@userName is null or [UserName] = @userName) and
	(@pass is null or [Pass] = @pass) and
	(@name is null or [Name] = @name) and
	(@image is null or [Image] = @image) and
	(@accessRightsGroup is null or @accessRightsGroup = [AccessRightsGroup]) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	order by 
	case 
		when @sort is null or @sort = 'Id' then [Id]
		when @sort = 'UserName' then [UserName] 
		when @sort = 'Pass' then [Pass]
		when @sort = 'Name' then [Name]
		when @sort = 'Image' then [Image]
		when @sort = 'AccessRightsGroup' then [AccessRightsGroup]
		when @sort = 'CreatedDate' then [CreatedDate]
		when @sort = 'ModifiedDate' then [ModifiedDate]
		when @sort = 'CreatedUserId' then [CreatedUserId]
		when @sort = 'ModifiedUserId' then [ModifiedUserId]
		when @sort = 'IsDeleted' then [IsDeleted]
		when @sort = 'Status' then [Status]
	end
	end
go

create proc User_SelectWithUsernameAndPass(
@userName varchar(50) = null,
@pass varchar(100) = null
)
as
	begin
	SET NOCOUNT ON;
	Select * from [System_User]
	where
	(@userName is null or [UserName] = @userName) and
	(@pass is null or [Pass] = @pass) and
	(ISNULL([IsDeleted],0) = 0) and
	(ISNULL([Status],0) = 0)
	end
go


CREATE PROC proc_logins(
@user nvarchar(50)=null,
@pass nvarchar(50)=null
)
as 
begin
	select * from dbo.[System_User] where UserName =@user and Pass=@pass
end
