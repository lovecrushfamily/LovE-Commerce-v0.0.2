----/*
----------------------------------------------------------------------
----© 2024 LoveCrush  All Rights Reserved
----------------------------------------------------------------------
----Name   : LovE-Commerce
----Link   : 
----Version: v0.0.2
----------------------------------------------------------------------
----*/

 --insert into Account and return the inserted row ID
 --1
create proc sp_insertAccount(
@Username varchar(255),
@Password_ varchar(255),
@AuthenticatedEmail varchar(255),
@Role_ varchar(255)) as
begin
	insert into user_.Account(Username, Password_, AuthenticatedEmail, Role_,DateOfRegistry) 
	values (@Username,@Password_, @AuthenticatedEmail,@Role_,Cast(Getdate() as date));
	select cast(scope_identity() as int);
end	





--2
-- insert into Customer using accountID
create proc sp_insertCustomer(
@CustomerID int, --AccountID
@CustomerName varchar(255) ,
@Gender bit ,
@PhoneNumber varchar(255),
@Image_ varchar(255) ,
@DateOfBirth date ,
@Address_ varchar(255)
) as 
begin
	insert into user_.Customer(CustomerID, CustomerName, Gender, PhoneNumber, Image_, DateOfBirth, Address_) values 
	(@CustomerID, @CustomerName, @Gender, @PhoneNumber, @Image_, @DateOfBirth, @Address_)
end	





-- insert into Staff using AccountID
--3
create proc sp_insertStaff(
@StaffID int, --AccountID
@StaffName varchar(255) ,
@PhoneNumber varchar(255),
@Image_ varchar(255),
@DateOfBirth date ,
@Gender bit
) as 
begin
	insert into CensorStaff values 
	(@StaffID, @StaffName, @PhoneNumber, @Image_, @DateOfBirth, @Gender);
end	  





--4
-- insert into Category
create proc sp_insertCategory(
@CategoryName varchar(255),
@AncestorID int ,
@AttributeList varchar(255) 
) as 
begin
	insert into system_.Category values 
	(@CategoryName, @AncestorID, @AttributeList);
end




--5
--create shop
create proc sp_insertShop(
@ShopName varchar(255),
@Description_ varchar(255) ,
@Address_ varchar(255),
@PhoneNumber varchar(255) ,
@Image_ varchar(255) ,
@OwnerID int
) as 
begin
	insert into production.Shop(ShopName,Description_,Address_,PhoneNumber,Date_,Image_,OwnerID) values
	(@ShopName, @Description_, @Address_, @PhoneNumber,Cast(getdate() as date), @Image_, @OwnerID);
end






--6
-- create product
create proc sp_insertProduct(
@ProductID int ,
@ProductName varchar(255),
@Description_ varchar(max),
@Price varchar(255) ,
@Quantity int,
@AttributeList varchar(255),
@MainImage varchar(255),
@ExtraImageList varchar(255),
@CategoryID int,
@ShopID int 
) as 
begin
	insert into production.Product(ProductName, Description_, Price, CreatedDate, Quantity,	AttributeList, MainImage, ExtraImageList, CategoryID, ShopID) 
	values (@Productname, @Description_, @Price, Cast(getdate() as date), @Quantity, @AttributeList, @MainImage, @ExtraImageList, @CategoryID, @ShopID);
end





--7
-- insertinto Voucher
create proc sp_insertVoucher(
@VoucherName varchar(255) ,
@VoucherType bit ,
@FixedAmount varchar(255) ,
@MinAmount varchar(255) ,
@PercentageDiscount varchar(255),
@MaxAmount varchar(255),
@Quanity int ,
@StartedDay date ,
@EndedDay date ,
@ShopID int
) as 
begin
	insert into production.Voucher values
	(@VoucherName, @VoucherType, @FixedAmount, @MinAmount, @PercentageDiscount, @MaxAmount, @Quanity, @StartedDay, @EndedDay, @ShopID)
end




--8
 --insert into Order and return orderdetailID
create proc sp_insertOrder(
@CustomerID int,
@TotalAmount varchar(255)
) as 
begin
	insert into production.Order_(CustomerID, TotalAmount, DateOrder) values
	(@CustomerID, @TotalAmount, cast(getdate() as date));
	select cast(scope_identity() as int);
end




--9
--insert into OrderDetail
create proc sp_insertOrderDetail(
@OrderID int,
@ProductID int,
@Quantity int,
@UnitPrice varchar(255),	
@Discount varchar(255),
@VoucherID int
) as 
begin
	insert into production.OrderDetail(OrderID, ProductID, Quantity, UnitPrice, Discount, VoucherID) values
	(@OrderID, @ProductID, @Quantity, @UnitPrice, @Discount, @VoucherID)
end




--10
-- insert into Notification
create proc sp_insertNotification (
@ReceiverID int,
@Tittle varchar(255),
@Content varchar(255)
) as 
begin
	insert into system_.Notification_(ReceiverID, Tittle, Time_, Content) values
	(@ReceiverID, @Tittle, cast(getdate() as date), @Content);
end




--11
-- insert messgae
create proc sp_insertMessage(
@SenderID int ,
@ReceiverID int ,
@Content varchar(255)
) as 
begin
	insert into system_.Message_(SenderID, ReceiverID, Content, Date_, Time_) values 
	(@SenderID, @ReceiverID, @Content,cast(getdate() as date), convert(varchar, getdate(), 108))
end


--12
-- insert into Comment
create proc sp_insertComment(
@ProductID int,
@CustomerID int,
@Star tinyint ,
@Content varchar(255) ,
@ResponseComment bit 
) as 
begin
	insert into system_.Comment(ProductID, CustomerID, Star, Content, DateOfComment, ResponseComment) values
	(@ProductID, @CustomerID, @Star, @Content, cast(getdate() as date), @ResponseComment)
end





--13
-- insert into ShoppingCart
create proc sp_insertShoppingCart(
@CustomerID int ,
@ProductID int
) as 
begin
	insert into system_.ShopppingCart values
	(@CustomerID, @ProductID)

end
