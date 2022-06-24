use Cafe
go
----- Nha cung cap -----
insert into [P_Manufacturer]([Name],[Address],[CreatedDate],[ModifiedDate],CreatedUserId,ModifiedUserId,IsDeleted,[Status])
values (N'Công ty mì Kokomi Nhật Bản',null,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,0)

--- Lich su chinh sua Nha cung cap -----
Insert Into 
[P_ManufacturerLog]([Note],[ManuId],[Action],[CreatedDate],[CreatedUserId],[IsDeleted])
values (N'Xóa',1,1,convert(datetime,'2021-07-03'),1,0)

--- Loai san pham  ---- 
insert into [P_ProductType]([Name],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted])
values (N'Trà',convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0)
insert into [P_ProductType]([Name],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted])
values (N'Cafe',convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0)
insert into [P_ProductType]([Name],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted])
values (N'Bánh',convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0)
insert into [P_ProductType]([Name],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted])
values (N'Nước ngọt',convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0)

--- San pham, mac hang ---
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Cafe đá',null,1,2,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,35000)
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Cafe sữa',null,1,2,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,37000)
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Cafe đen',null,1,2,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,39000)
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Bánh dâu',null,1,3,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,25000)
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Trà ô long',null,1,1,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,30000)
insert into [P_Product]([Name],[Description],[ManuId],[ProductTypeId],[CreatedDate],[CreatedUserId],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status],[Discount],[ProductCode],[Price])
values (N'Trà chanh',null,1,1,convert(datetime,'2021-07-03'),1,convert(datetime,'2021-07-03'),1,0,0,0,null,30000)

--- Lich su chinh sua San pham, mac hang ---
Insert Into 
[P_ProductLog] ([Note],[ProductId],[Action],[CreatedDate],[CreatedUserId],[IsDeleted])
values (N'Sửa tên', 1,3,convert(datetime,'2021-07-03'),1,0)

--- San pham, mac hang nhap kho---
--Insert Into 
--[P_ImportGoods] ([GoodsNumber],[GoodsCode],[Note],[CreatedDate],[ModifiedDate],[CreatedUserId],[ImportQuantity],[IsDeleted],[Status])
--values ('00152','MS452T',N'Nhập',convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,100,0,0)

--- Chi tiet nhap  kho ---
--Insert Into 
--[P_ImportGoodsDetail] ([ImportGoodsId],[ProductInfo],[ManuDate],[ExpiryDate],[ProductNumber],[ProductCode],[ProductTypeId],[ImportQuantity],[IsDeleted],[Status])
--values (1,1,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),'00152','MS452T',1,100,0,0)

----- San pham, mac hang ton kho ---
--insert into [P_Stock]([ProductInfo],[Quantity],[BatchOfGoodsId],CreatedDate,[ModifiedDate],CreatedUserId,ModifiedUserId,IsDeleted,[Status])
--values (1,100,null,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,0)

----- Lich su chinh sua kho---
--Insert Into 
--[P_StockLog] ([Note],[StockId],[Action],[QuantityOld],[QuantityAdd],[CreatedDate],[CreatedUserId],[IsDeleted])
--values (N'Nhập', 1,1,2,98,convert(datetime,'2021-07-03'),1,0)

----- Cac quyen he thong ---
--Insert Into 
--[System_AccessRights] ([Code],[Name],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
--values (2,N'Toàn quyền',convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,0)

----- Cac nhom quyen he thong ---
--Insert Into 
--[System_AccessRightsGroup] ([Name],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
--values (N'Administrator',convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,0)

----- Chi tiet nhom quyen he thong ---
--Insert Into 
--[System_AccessRightsGroupdetail] ([GroupId],[AccessRightsApplyId],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
--values (1,1,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,0)

--- Tai khoan ---
--Insert Into 
--[System_User](UserName,Pass,[Name],[Image],AccessRightsGroup,[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
--values(N'Admin','',N'Quản trị hệ thống','',null,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),null,0,0)

----- Lich su chinh sua  Tai khoan ---
--Insert Into 
--[System_UserLog] ([UserId],[Action],[ModifiedDate],[ModifiedUserId],[IsDeleted])
--values (1,2,convert(datetime,'2021-07-03'),1,0)

--- Chuc vu nhan vien ---
insert into [System_Position]([Name],CreatedDate,[ModifiedDate],[CreatedUserId],[ModifiedUserId],SalaryPerHour,IsDeleted)
values (N'Quản lý cửa hàng',convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,500000.00,0)

--- Lich su chinh sua  Chuc vu nhan vien ---
Insert Into 
[System_PositionLog] ([PositionId],[Action],[ModifiedDate],[ModifiedUserId],[IsDeleted])
values (1,2,convert(datetime,'2021-07-03'),1,0)

--- Thong tin Nhan vien ---
--Insert into [System_Staff]([FirstName],[LastName],[FullName],[Birth],[Address],[Image],[Phone],[Email],[CreatedDate]
--,[ModifiedDate],[CreatedUserId],[ModifiedUserId],PositionId,IsDeleted,[Status])
--values(N'Nguyễn Văn',N'A',N'Nguyễn Vặn A',convert(datetime,'1998-05-05'),N'Quận 1',null,null,'NguyenvanA@gmail.com'
--,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),null,null,null,0,0)

--- Cap quyen truy cap Tai khoan cho Nhan vien ---
Insert Into [System_Decentralization]([UserId],[StaffId],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted])
values (1,1,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0)

--- Lich su chinh sua  Thong tin Nhan vien ---
--Insert Into 
--[System_StaffLog] ([StaffId],[Action],[ModifiedDate],[ModifiedUserId],[IsDeleted])
--values (1,1,convert(datetime,'2021-07-03'),1,0)

----- Thong tin khach hang ---
--Insert Into 
--[P_Customer] ([Name],[Code],[Birth],[Address],[Phone],[Email],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[Status])
--values (N'Nguyễn Thị Xuân','12456',convert(datetime,'1998-12-06'),N'Phú Xuân, Hà Nội','0380941541','xuanthi22@gmail.com',convert(datetime,'2021-07-03'),
--	convert(datetime,'2021-07-03'),1,1,0,0)

----- Hoa don ---
--Insert Into 
--[P_Bill] ([TotalPrice],[CreatedDate],[ModifiedDate],[CreatedUserId],[ModifiedUserId],[IsDeleted],[BillDetailId],[Status])
--values (120000.00,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,1,0,1,0)

----- Lich su chinh sua  Hoa don ---
--Insert Into 
--[P_BillLog] ([BillId],[Action],[ModifiedDate],[ModifiedUserId],[IsDeleted])
--values (1,1,convert(datetime,'2021-07-03'),1,0)

----- Chi tiet Hoa don ---
--Insert Into 
--[P_BillDetail] ([BillId],[ProductId],[Quantity],[UnitPrice],[CreatedDate],[ModifiedDate],[ModifiedUserId],[IsDeleted],[Status])
--values (1,1,10,12000.00,convert(datetime,'2021-07-03'),convert(datetime,'2021-07-03'),1,0,0)

--DECLARE @numberOfRowsToSkip int = @start - 1;
--OFFSET @numberOfRowsToSkip ROWS
--FETCH NEXT @numberOfRows ROWS ONLY