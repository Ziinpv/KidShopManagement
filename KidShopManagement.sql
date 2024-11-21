use [KidShopManagement]

go
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductStuffs_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductStuffs_ProductCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO

select*from Category
Select*from Product
CREATE PROCEDURE InsertProduct
@ID int output,
@Name nvarchar(3000), 
@Size nvarchar(3000),
@Quantity nvarchar(3000), 
@ProductCategoryID int, 
@Price int,  
@Image varbinary(max)
AS
	INSERT INTO Product(Name, Size, Quantity,ProductCategoryID, Price,  Image)
	VALUES ( @Name,@Size, @Quantity, @ProductCategoryID, @Price,  @Image)

	SELECT @ID = SCOPE_IDENTITY()

go

CREATE PROCEDURE [UpdateProduct]
@ID int output,
@Name nvarchar(3000), 
@Size nvarchar(3000),
@Quantity nvarchar(3000), 
@ProductCategoryID int, 
@Price int,  
@Image varbinary(max)
AS
UPDATE [Product]
SET
[Name] = @Name,
[Size]=@Size,
[Quantity]=@Quantity,
[ProductCategoryID] = @ProductCategoryID,
[Price]=@Price,
[Image]=@Image
WHERE ID = @ID
IF @@ERROR <> 0
RETURN 0
ELSE
RETURN 1
GO
--------------------------------------------------------
--Thủ tục lấy tất cả dữ liệu bảng Category
CREATE PROCEDURE [dbo].[Category_GetAll]
AS
SELECT * FROM Category
------------------------------------------
--Thủ tục lấy tất cả dữ liệu bảng Product
 CREATE OR ALTER PROCEDURE [dbo].[Product_GetAll]
AS
SELECT * FROM Product
------------------------------------------
-- Thủ tục thêm, xóa, sửa bảng Category
 CREATE OR ALTER PROCEDURE [dbo].[Category_InsertUpdateDelete]
 @ID int output, -- Biến ID tự tăng, khi thêm xong phải lấy ra
 @Name nvarchar(200),
 @Type int,
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
INSERT INTO [Category] ([Name],[Type])
VALUES (@Name, @Type)
SET @ID = @@identity -- Thiết lập ID tự tăng
END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
BEGIN
UPDATE [Category] SET [Name] = @Name, [Type]=@Type
WHERE [ID] = @ID
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM [Category] WHERE [ID] = @ID
END
------------------------------------------
-- Thủ tục thêm, xóa, sửa bảng Product
CREATE OR ALTER PROCEDURE [dbo].[Product_InsertUpdateDelete]
 @ID int output, -- Biến ID tự tăng, khi thêm xong phải lấy ra
 @Name nvarchar(1000),
 @Quantity nvarchar(100),
 @ProductCategoryID int,
 @Price int,
 @Image varbinary(max),
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
IF @Action = 0 -- Nếu Action = 0, thêm dữ liệu
BEGIN
 INSERT INTO [Product]
([Name],[Quantity],[ProductCategoryID],[Price],[Image])
 VALUES (@Name, @Quantity,@ProductCategoryID,@Price,@Image)
 SET @ID = @@identity -- Thiết lập ID tự tăng
END 
ELSE IF @Action = 1 -- Nếu Action = 1, cập nhật dữ liệu
BEGIN
 UPDATE [Product]
 SET [Name] = @Name,
 [Quantity]=@Quantity,
 [ProductCategoryID]=@ProductCategoryID,
 [Price]=@Price,
 [Image]=@Image
 WHERE [ID] = @ID
END
ELSE IF @Action = 2 -- Nếu Action = 2, xóa dữ liệu
BEGIN
 DELETE FROM [Product] WHERE [ID] = @ID
END

