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
--Proc Customer

	create proc [dbo].[PCustomer_SelectByPrimaryKey](@id int)
as 
	begin
	SET NOCOUNT ON;
		select * from [dbo].[P_Customer]
		where [Id] = @id
	end
		go

	create proc [dbo].[PCustomer_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@code varchar(50) = null,
	@birth datetime = null,
	@address nvarchar(200) = null,
	@point int = null,
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
		select count(*) [count] from [dbo].P_Customer
		where(@id IS null or [Id] = @id) and
		(@name is null or [Name] = @name) and
		(@code is null or [Code] = @code) and
		(@point is null or [Point] = @point) and
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
	@point int = null,
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
		(@point is null or [Point] = @point) and
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
			when @sort is null or @sort = 'Id' then [Id] end,
		case when @sort = 'Id desc' then [Id] end desc,
		case when @sort = 'Name' then [Name] end,
		case when @sort = 'Name desc' then [Name] end desc,
		case when @sort = 'Code' then [Code] end,
		case when @sort = 'Code desc' then [Code] end desc,
		case when @sort = 'Point' then [Point] end,
		case when @sort = 'Point desc' then [Point] end desc,
		case when @sort = 'Address' then [Address] end,
		case when @sort = 'Email' then [Email] end,
		case when @sort = 'ModifiedDate' then [ModifiedDate]
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

	create proc [dbo].[PCustomer_Insert](
		@name nvarchar(50) = null,
		@code varchar(50) = null,
		@point int = null,
		@birth Datetime = null,
		@address nvarchar(200) = null,
		@phone varchar(20) = null,
		@email varchar(50) = null,
		@createdDate DateTime = null,
		@modifiedDate DateTime = null,
		@createdUserId int = null,
		@modifiedUserId int = null,
		@isDeleted bit = null,
		@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		declare @id int;
		Insert into [dbo].[P_Customer]([Name],[Code], [Point],[Birth],[Address],[Phone],[Email],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status]) 
		Values(@name,@code,@point,@birth,@address,@phone,@email,@createdDate,@modifiedDate,@createdUserId,@modifiedUserId,@isDeleted,@status)
		set @id = SCOPE_IDENTITY()
		return @id
	end
	go

	create proc [dbo].[PCustomer_Update](
		@id int,
		@name nvarchar(50) = null,
		@code varchar(50) = null,
		@point int = null,
		@birth Datetime = null,
		@address nvarchar(200) = null,
		@phone varchar(20) = null,
		@email varchar(50) = null,
		@createdDate DateTime = null,
		@modifiedDate DateTime = null,
		@createdUserId int = null,
		@modifiedUserId int = null,
		@isDeleted bit = null,
		@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[P_Customer]
		set [Name] = @name,
		[Code]=@code,
		[Point] = @point,
		[Birth]=@birth,
		[Address]=@address,
		[Phone]=@phone,
		[Email]=@email,
		[CreatedDate]=@createdDate,
		[ModifiedDate]=@modifiedDate,
		[CreatedUserId]=@createdUserId,
		[ModifiedUserId]=@modifiedUserId,
		[IsDeleted]=@isDeleted,
		[Status]=@status
		Where [Id] = @id
	end
	go

	create proc [dbo].[PCustomer_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[P_Customer]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[PCustomer_InBill](@id int)
	as
	begin 
	set NOCount on;
		select count(*) [count] from [dbo].[P_Bill]
		where ISNULL([IsDeleted],0) = 0 and [CustomerId] = @id and ISNULL([Status],0) != 3
	end
	go

--end Customer

--Proc Staff
create proc [dbo].[SystemStaff_SelectByPrimaryKey](@id int)
as 
	begin
	SET NOCOUNT ON;
		select * from [dbo].[System_Staff]
		where [Id] = @id
	end
go

create proc [dbo].[SystemStaff_SelectByUserId](@id int)
as
	begin
	Select * from [dbo].[System_Staff]
	where [Id] in
	(
		select [StaffId] from [dbo].[System_Decentralization]
		where Isnull([IsDeleted],0) = 0 and [UserId] = @id
	)
	end
go
--end Staff

CREATE PROC proc_logins(
@user nvarchar(50)=null,
@pass nvarchar(50)=null
)
as 
begin
	select [Id]
      ,[UserName]
      ,[Name]
      ,[Image]
      ,[AccessRightsGroup]
      ,[CreatedDate]
      ,[ModifiedDate]
      ,[CreatedUserId]
      ,[ModifiedUserId]
      ,[IsDeleted]
      ,[Status] from dbo.[System_User] where UserName =@user and Pass=@pass
end

CREATE PROC S_Them_Nhanvien
@Id int,
@FirstName nvarchar(40),
@LastName nvarchar(20),
@FullName nvarchar(60),
@Birth date,
@Address nvarchar(200),
@Image nvarchar(200),
@Phone varchar(20),
@Email varchar(50),
@CreatedDate date,
@ModifiedDate date,
@CreateUserId int,
@ModifiedUserId int,
@PositionId int,
@IsDeleted bit,
@Status int
as
insert into dbo.[System_Staff](Id,FirstName,LastName,FullName,Birth,Address,Image,Phone,Email,CreatedDate,ModifiedDate,CreatedUserId,ModifiedUserId,PositionId,IsDeleted,Status)
values(@Id,@FirstName,@LastName,@FullName,@Birth,@Address,@Image,@Phone,@Email,@CreatedDate,@ModifiedDate,@CreateUserId,@ModifiedUserId,@PositionId,@IsDeleted,@Status)

go

create proc [dbo].[SystemStaff_SelectByUserId](@id int)
as
	begin
	Select * from [dbo].[System_Staff]
	where [Id] in
	(
		select [StaffId] from [dbo].[System_Decentralization]
		where Isnull([IsDeleted],0) = 0 and [UserId] = @id
	)
	end
go
