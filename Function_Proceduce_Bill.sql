
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
		where [Id] = @id
	end
	go

create proc [dbo].[PBill_SelectByCode](@code varchar(10))
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[P_Bill] 
		where [Code] = @code and ISNULL([IsDeleted],0) = 0
	end
go

create proc [dbo].[PBilldetail_GetRecordCount]
as 
begin
SET NOCOUNT ON;
	select count(*) [count] from [dbo].[P_BillDetail]
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
@status int = null,
@deliveryAddress nvarchar(50) = null,
@code varchar(10) = null,
@customerId int = null,
@sort varchar(50) = null,
@numberOfRows int,
@start int)
as 
	begin
	SET NOCOUNT ON;
	select * from [dbo].[P_Bill]
	where (@id IS null or [Id] = @id) and
	(@totalPrice is null or [TotalPrice] = @totalPrice) and
	(@code is null or [Code] = @code) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@customerId is null or [CustomerId] = @customerId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)and
	(@deliveryAddress is null or [DeliveryAddress] = @deliveryAddress)
	order by 
	case when (@sort is null or @sort = 'Id') then [Id] end,
	case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'TotalPrice' then [TotalPrice]
		when @sort = 'ModifiedDate' then [ModifiedDate]
		when @sort = 'CreatedUserId' then [CreatedUserId]
		when @sort = 'Code' then [Code]
		when @sort = 'CustomerId' then [CustomerId]
		when @sort = 'ModifiedUserId' then [ModifiedUserId]
		when @sort = 'DeliveryAddress' then [DeliveryAddress]
		when @sort = 'IsDeleted' then [IsDeleted]
		when @sort = 'Status' then [Status]
	end
	offset  @start ROWS       -- skip s rows
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
@status int = null,
@deliveryAddress nvarchar(50) = null,
@code varchar(10) = null,
@customerId int = null
)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[P_Bill]
	where (@id IS null or [Id] = @id) and
	(@totalPrice is null or [TotalPrice] = @totalPrice) and
	(@code is null or [Code] = @code) and
	(@createdDate is null or [CreatedDate] = @createdDate) and
	(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
	(@createdUserId is null or [CreatedUserId] = @createdUserId) and
	(@customerId is null or [CustomerId] = @customerId) and
	(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
	(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
	(@status is null or ISNULL([Status],0) = @status)and
	(@deliveryAddress is null or [DeliveryAddress] = @deliveryAddress)
	end
	go

	create proc [dbo].[PBill_Insert](
	@code varchar(10) = null,
	@totalPrice decimal(18,0) = null,
	@createdDate datetime = null,
	@modifiedDate datetime = null,
	@createdUserId int = null,
	@modifiedUserId int = null,
	@isDeleted bit = null,
	@status int = null,
	@deliveryAddress nvarchar(50) = null,
	@customerId int = null
	)
	as
	begin
		SET NOCOUNT ON;
		declare @id int;
		Insert into [dbo].[P_Bill]
		([Code],[TotalPrice],[CustomerId],[DeliveryAddress],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status]) 
		Values(@code,@totalPrice,@customerId,@deliveryAddress,@createdDate,@modifiedDate,@createdUserId,@modifiedUserId,@isDeleted,@status)
		set @id = SCOPE_IDENTITY()
		return @id
	end
	go

	create proc [dbo].[PBill_Update](
	@id int,
	@totalPrice decimal(18,0) = null,
	@createdDate datetime = null,
	@modifiedDate datetime = null,
	@createdUserId int = null,
	@modifiedUserId int = null,
	@isDeleted bit = null,
	@status int = null,
	@deliveryAddress nvarchar(50) = null,
	@customerId int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[P_Bill]
		set [TotalPrice]=@totalPrice,
		[CustomerId]=@customerId,[DeliveryAddress]=@deliveryAddress
		,[CreatedDate]=@createdDate,[ModifiedDate]=@modifiedDate,
		[CreatedUserId]=@createdUserId,[ModifiedUserId]=@modifiedUserId,
		[IsDeleted]=@isDeleted,[Status]=@status 
	end
	go

	create proc [dbo].[PBill_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[P_Bill]		
		Where [Id] = @id
	end
	go

--end Bill

-- BillDetail
	create proc [dbo].[PBilldetail_SelectByPrimaryKey](@id int)
	as 
		begin
		SET NOCOUNT ON;
			select* from [dbo].[P_Billdetail] 
			where [Id] = @id
		end
	go

	create proc [dbo].[PBilldetail_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[P_BillDetail]
	end
	go

	create proc [dbo].[PBilldetail_SelectSkipAndTakeWhereDynamic]
	(
	@id int = null,
	@billId int = null,
    @productId int = null,
	@quantity int = null,
	@unitPrice decimal(18,0) = null,
	@tableId int = null,
	@discount int = null,
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
		select * from [dbo].[P_BillDetail]
		where (@id IS null or [Id] = @id) and
		(@productId IS null or [ProductId] = @productId) and
		(@billId IS null or [BillId] = @billId) and
		(@tableId IS null or [TableId] = @tableId) and
		(@unitPrice is null or [UnitPrice] = @unitPrice) and
		(@discount is null or [Discount] = @discount) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by 
		case 
			when @sort is null or @sort = 'Id' then [Id]
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

	create proc [dbo].[PBilldetail_GetRecordCountWhereDynamic]
	(
	@id int = null,
	@billId int = null,
    @productId int = null,
	@quantity int = null,
	@unitPrice decimal(18,0) = null,
	@tableId int = null,
	@discount int = null,
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
		select count(*) [count] from [dbo].[P_BillDetail]
		where (@id IS null or [Id] = @id) and
		(@productId IS null or [ProductId] = @productId) and
		(@billId IS null or [BillId] = @billId) and
		(@tableId IS null or [TableId] = @tableId) and
		(@unitPrice is null or [UnitPrice] = @unitPrice) and
		(@discount is null or [Discount] = @discount) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@modifiedDate is null or [ModifiedDate] = @modifiedDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@modifiedUserId is null or [ModifiedUserId] = @modifiedUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		end
	go

	create proc [dbo].[PBilldetail_Insert]
	(
	@billId int = null,
    @productId int = null,
	@quantity int = null,
	@unitPrice decimal(18,0) = null,
	@tableId int = null,
	@discount int = null,
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
		Insert into [dbo].[P_BillDetail]
		(BillId,ProductId,Quantity,UnitPrice,TableId,Discount,[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status]) 
		Values(@billId,@productId,@quantity,@unitPrice,@tableId,@discount,@createdDate,@modifiedDate,@createdUserId,@modifiedUserId,@isDeleted,@status)
		set @id = SCOPE_IDENTITY()
		return @id
	end
	go

	create proc [dbo].[PBilldetail_Update](
	@id int,
	@billId int = null,
    @productId int = null,
	@quantity int = null,
	@unitPrice decimal(18,0) = null,
	@tableId int = null,
	@discount int = null,
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
		Update [dbo].[P_BillDetail]
		set BillId=@billId,ProductId=@productId,Quantity=@quantity,UnitPrice=@unitPrice,
		TableId=@tableId,Discount=@discount
		,[CreatedDate]=@createdDate,[ModifiedDate]=@modifiedDate,
		[CreatedUserId]=@createdUserId,[ModifiedUserId]=@modifiedUserId,
		[IsDeleted]=@isDeleted,[Status]=@status
		Where [Id] = @id
	end
	go

	create proc [dbo].[PBilldetail_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[P_BillDetail]		
		Where [Id] = @id
	end
	go
-- end BillDetail