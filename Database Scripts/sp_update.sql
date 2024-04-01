----/*
----------------------------------------------------------------------
----© 2024 LoveCrush  All Rights Reserved
----------------------------------------------------------------------
----Name   : LovE-Commerce
----Link   : 
----Version: v0.0.2
----------------------------------------------------------------------
----*/

--1
-- update Accounnt
create proc sp_updateAccount(
@AccountID int,
@Password varchar(255),
@AuthenticatedEmail varchar(255),
@RememberLogin bit,
@Online bit
) as
begin
	update user_.Account set Password_ = @Password,
	AuthenticatedEmail = @AuthenticatedEmail,
	RememberLogin = @RememberLogin,
	Online_ = @Online
	where AccountID = @AccountID				
end




--2
create proc sp_updateCategory(
@CategoryID int,
@CategoryName varchar(255),
@AncestorID int,
@AttributeList varchar(255)) as 

begin
	update system_.Category set
	CategoryName = @CategoryName,
	AncestorID = @AncestorID,
	AttributeList = @AttributeList
	where CategoryID = @CategoryID
end




--3
create proc sp_updateStaff(
@StaffID int,
@StaffName varchar(255),
@PhoneNumber varchar(255),
@Image varchar(255),
@DateOfBirth varchar(255),
@Gender bit) as begin
	update CensorStaff set
	StaffName = @StaffName,
	PhoneNumber = @PhoneNumber,
	Image_ = @Image,
	DateOfBirth = @DateOfBirth,
	Gender = @Gender
	where StaffID =  @StaffID
end




--4 not update comment
-- Comment  cannot be updated


--5
create proc sp_updateCustomer
(@CustomerID int,
@CustomerName varchar(255),
@Gender bit,
@PhoneNumber varchar(255),
@Image varchar(255),
@DateOfBirth varchar(255),
@Address varchar(255))
as begin
	update user_.Customer set
	CustomerName = @CustomerName,
	Gender = @Gender,
	PhoneNumber = @PhoneNumber,
	Image_ = @Image,
	DateOfBirth = @DateOfBirth,
	Address_ = @Address
	where CustomerID = @CustomerID
end

--6
Create proc sp_updateMessage(
@MessageID int,
@SeenState bit,
@IsRecall bit) as begin
update system_.Message_ set 
IsRecall = @IsRecall, SeenState = @SeenState
where MessageID = @MessageID end


--7
create proc sp_updateNotification(
@NotificatonID int,
@SeenState bit)
as begin
update system_.Notification_ set SeenState = @SeenState
where NotificationID = @NotificatonID  end



-- 8
create proc sp_updateOrder(
@OrderID int,
@CustomerOrderState bit,
@OrderConfirmState bit,
@ReceivedState bit
) as begin	
	update production.Order_ set
	CustomerOrderState = @CustomerOrderState,
	OrderConfirmState = @OrderConfirmState,
	ReceivedState = @ReceivedState
	where OrderID = @OrderID
end


-- 9 
create proc sp_updateOrderDetail(
@OrderDetaiID int,
@OrderDetailConfirmState bit

) as begin
	update production.OrderDetail set
	OrderDetailConfirmState = @OrderDetailConfirmState
	where OrderDetailID = @OrderDetaiID
end




-- 10 
create proc sp_updateProduct(
@ProductID int,
@ProductName varchar(255),
@Description varchar(max),
@Price varchar(255),
@Quantity int,
@AttributeList varchar(255),
@MainImage varchar(255),
@ExtraImageList varchar(255),
@BanState bit,
@ReviewState bit,
@CategoryID int
) as begin
	update production.Product set
	ProductName =@ProductName,
	Description_ = @Description,
	Price = @Price,
	Quantity =@Quantity,
	AttributeList = @AttributeList,
	MainImage = @MainImage,
	ExtraImageList = @ExtraImageList,
	BannedState = @BanState,
	ReviewState = @ReviewState,
	CategoryID = @CategoryID
	where ProductID = @ProductID
end





--11
create proc sp_updateShop(
@ShopID int,
@ShopName varchar(255),
@Description varchar(255),
@Address varchar(255),
@PhoneNumber varchar(255),
@Image varchar(255))
as begin
	update production.Shop set
	ShopName =@ShopName,
	Description_ = @Description,
	Address_ = @Address,
	PhoneNumber =@PhoneNumber,
	Image_ =@Image
	where ShopID = @ShopID
end


---- 12
--shopping cart can not be updated

--13
--vouch er can not be updated






































