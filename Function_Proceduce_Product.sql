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
--store procedure Product
	create proc [dbo].[Product_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[P_Product] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Product_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@manuId int = null,
	@productCode varchar(20) = null,
	@discount int = null,
	@price decimal(18,0) = null,
	@productTypeId int = null,
	@createdDate datetime = null,
	@modifiedDate datetime = null,
	@createdUserId int = null,
	@modifiedUserId int = null,
	@isDeleted bit = null,
	@status int = null
)
as 
	begin
	SET NOCOUNT ON;
	select * from [dbo].[P_Product]
	where (@id IS null or [Id] = @id) and
	(@price is null or [Price] = @price) and
	(@name is null or [Name] = @name) and
	(@manuId is null or [ManuId] = @manuId) and
	(@productCode is null or [ProductCode] = @productCode) and
	(@description is null or [Description] = @description) and
	(@productTypeId is null or [ProductTypeId] = @productTypeId) and
	(@discount is null or [Discount] = @discount) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	order by [Name]
	end
	go

	create proc [dbo].[Product_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[P_Product]
	end
	go

	create proc [dbo].[Product_SelectSkipAndTakeWhereDynamic](
@id int = null,
@name nvarchar(100) = null,
@description nvarchar(100) = null,
@manuId int = null,
@productCode varchar(20) = null,
@discount int = null,
@price decimal(18,0) = null,
@productTypeId int = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@status int = null,
@sort varchar(50) = null,
@numberOfRows int,
@start int)
as 
	begin
	SET NOCOUNT ON;
	select * from [dbo].[P_Product]
	where (@id IS null or [Id] = @id) and
	(@price is null or [Price] = @price) and
	(@manuId is null or [ManuId] = @manuId) and
	(@productCode is null or [ProductCode] = @productCode) and
	(@description is null or [Description] = @description) and
	(@productTypeId is null or [ProductTypeId] = @productTypeId) and
	(@discount is null or [Discount] = @discount) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	order by 
	case when (@sort is null or @sort = 'Id') then [Id] end,
	case when (@sort = 'Id desc') then [Id] end desc,
	case when @sort = 'Price' then [Price] end,
	case when @sort = 'Price desc' then [Price] end desc,
	case when @sort = 'ModifiedDate' then [ModifiedDate]
		when @sort = 'CreatedUserId' then [CreatedUserId]
		when @sort = 'ManuId' then [ManuId]
		when @sort = 'ModifiedUserId' then [ModifiedUserId]
		when @sort = 'IsDeleted' then [IsDeleted]
		when @sort = 'Status' then [Status]
	end
	offset     @start ROWS       -- skip s rows
	FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
	end
	go

	create proc [dbo].[Product_GetRecordCountWhereDynamic](
@id int = null,
@name nvarchar(100) = null,
@description nvarchar(100) = null,
@manuId int = null,
@productCode varchar(20) = null,
@discount int = null,
@price decimal(18,0) = null,
@productTypeId int = null,
@createdDate datetime = null,
@modifiedDate datetime = null,
@createdUserId int = null,
@modifiedUserId int = null,
@isDeleted bit = null,
@status int = null)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[P_Product]
	where (@id IS null or [Id] = @id) and
	(@price is null or [Price] = @price) and
	(@manuId is null or [ManuId] = @manuId) and
	(@productCode is null or [ProductCode] = @productCode) and
	(@description is null or [Description] = @description) and
	(@productTypeId is null or [ProductTypeId] = @productTypeId) and
	(@discount is null or [Discount] = @discount) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[Product_Insert](
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@manuId int = null,
	@productCode varchar(20) = null,
	@discount int = null,
	@price decimal(18,0) = null,
	@productTypeId int = null,
	@createdDate datetime = null,
	@modifiedDate datetime = null,
	@createdUserId int = null,
	@modifiedUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		declare @id int;
		Insert into [dbo].[P_Product]
		([Name],[Description],[ManuId],[ProductTypeId],[Discount],[ProductCode],[Price],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status]) 
		Values(@name,@description,@manuId,@productTypeId,@discount,@productCode,@price,@createdDate,@modifiedDate,@createdUserId,@modifiedUserId,@isDeleted,@status)
		set @id = SCOPE_IDENTITY()
		return @id
	end
	go

	create proc [dbo].[Product_Update](
	@id int,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@manuId int = null,
	@productCode varchar(20) = null,
	@discount int = null,
	@price decimal(18,0) = null,
	@productTypeId int = null,
	@createdDate datetime = null,
	@modifiedDate datetime = null,
	@createdUserId int = null,
	@modifiedUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[P_Product]
		set [Name]=@name,[Description]=@description,[ManuId]=@manuId,[ProductTypeId]=@productTypeId,
		[Discount]=@discount,[ProductCode]=@productCode,[Price]=@price
		,[CreatedDate]=@createdDate,[ModifiedDate]=@modifiedDate,
		[CreatedUserId]=@createdUserId,[ModifiedUserId]=@modifiedUserId,
		[IsDeleted]=@isDeleted,[Status]=@status 
	end
	go

	create proc [dbo].[Product_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[P_Product]		
		Where [Id] = @id
	end
	go

--end Product

/*ProductType*/

create proc [dbo].[ProductType_SelectByPrimaryKey](@id int)
as
begin
	select * from [dbo].[P_ProductType]
	where [Id] = @id
end
go

create proc [dbo].[ProductType_SelectDropDownListData]
as
	begin
		select * from [dbo].[P_ProductType]
		where ISNULL([IsDeleted],0) = 0
	end
go