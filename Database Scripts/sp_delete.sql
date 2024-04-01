----/*
----------------------------------------------------------------------
----© 2024 LoveCrush  All Rights Reserved
----------------------------------------------------------------------
----Name   : LovE-Commerce
----Link   : 
----Version: v0.0.2
----------------------------------------------------------------------
----*/

-- delete Account
--1
create proc sp_deleteAccount(
@AccountID int) as 
begin
	delete user_.Account where AccountID = @AccountID
end



--2
create proc sp_deleteCategory(
@CategoryID int) as 
begin
	delete system_.Category where CategoryID = @CategoryID
end



--3
create proc sp_deleteComment(
@CommentID int ) as 
begin	
	delete system_.Comment where CommentID = @CommentID
end




--4
create proc  sp_deleteMessage(
@MessageID int ) as
begin
	delete system_.Message_ where MessageID = @MessageID
end

--5
create proc sp_deleteNotification(
@NotificationID int) as begin
	delete system_.Notification_ where NotificationID = @NotificationID
end


--6
create proc sp_deleteOrder(
@OrderID int) as begin
	delete production.Order_ where OrderID = @OrderID
end


--7
create proc sp_deleteOrderDetail(
@OrderDetailID int
) as begin	
	delete production.OrderDetail where OrderDetailID = @OrderDetailID
end


--8
create proc sp_deleteProduct(
@ProductID int )  as begin
	delete production.Product where ProductID = @ProductID
	end




	--9
create proc sp_deleteShop(
@ShopID int ) as begin 
	delete production.Shop where ShopID = @ShopID
end




--10
create proc sp_deleteShoppingCart(
@CustomerID int,
@ProductID int) as begin
	delete system_.ShopppingCart where CustomerID = @CustomerID and 
										ProductID = @ProductID
end





--11
create proc sp_deleteVoucher(
@VoucherID int) as begin
	delete  production.Voucher where VoucherID = @VoucherID
end



