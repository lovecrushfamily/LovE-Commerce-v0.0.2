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
--select Account
create proc sp_selectAccount
as begin
select * from user_.Account
end



--2
create proc sp_selectCategory
as begin
select * from system_.Category
end


--3
create proc sp_selectStaff as
begin
	select * from CensorStaff
end


--4
create proc sp_selectComment
as begin
	select * from system_.Comment
	end


--5
create proc sp_selectCustomer
as begin select * from user_.Customer end


--6
create proc sp_selectMessage as
begin select * from system_.Message_ end


--7
create proc  sp_selectNotification as begin
select * from system_.Notification_ end


--8
create proc sp_selectOrder as begin
select * from production.Order_ end



--9
create proc sp_selectOrderDetail as begin
select * from production.OrderDetail end


--10
create proc sp_selectProduct
as begin select * from production.Product end


---11
create proc sp_selectShop as begin 
select * from production.Shop end


--12
create proc sp_selectShoppingCart as begin
select * from system_.ShopppingCart end



--13
create proc sp_selectVoucher as begin
select * from production.Voucher end












