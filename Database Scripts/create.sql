/*
--------------------------------------------------------------------
© 2024 LoveCrush  All Rights Reserved
--------------------------------------------------------------------
Name   : LovE-Commerce
Link   : 
Version: v0.0.2
--------------------------------------------------------------------
*/

--create database
create database  LovE_Commerce_v2;
go
use LovE_Commerce_v2;
go
-- create schemas
create schema user_;
go
create schema system_;
go
create schema production;
go

--create Account table
create table user_.Account ( AccountID int identity (1,1) primary key,
							Username varchar(255) not null,
							Password_ varchar(255) not null,
							AuthenticatedEmail varchar(255) not null,
							Role_ varchar(255) not null,
							DateOfRegistry date not null,
							RememberLogin bit default 0 not null,
							Online_ bit default 0 not null);
go

create table user_.CensorStaff ( StaffID int primary key,
							StaffName varchar(255) not null,
							PhoneNumber varchar(255) not null,
							Image_ varchar(255) not null,
							DateOfBirth date not null,
							Gender bit not null,
							foreign key (StaffID) references user_.Account (AccountID)
							on delete cascade on update cascade);
go

create table user_.Customer ( CustomerID int primary key,
						CustomerName varchar(255) not null,
						Gender bit not null,
						PhoneNumber varchar(255) not null,
						Image_ varchar(255) not null,
						ShopOwner bit default 0 not null,
						DateOfBirth date not null,
						Address_ varchar(255) not null,
						foreign key (CustomerID) references user_.Account(AccountID)
						on delete cascade on update cascade);
go



create table system_.Category ( CategoryID int identity(1,1) primary key,
								CategoryName varchar(255) not null,
								AncestorID int default 0 not null,
								AttributeList varchar(255) default 'empty' not null)


create table production.Shop( ShopID int identity(1,1) primary key,
							ShopName varchar(255) not null,
							Description_ varchar(255) not null,
							Address_ varchar(255) not null,
							PhoneNumber varchar(255) not null,
							Date_ date not null,
							Image_ varchar(255) not null,
							OwnerID int references user_.Customer(CustomerID)
							on delete cascade on update cascade);


create table production.Product (ProductID int identity primary key,
								ProductName varchar(255) not null,
								Description_ varchar(max) not null,
								Price varchar(255) not null,
								CreatedDate date not null,
								Quantity int not null,
								AttributeList varchar(255) not null,
								MainImage varchar(255) not null,
								ExtraImageList varchar(255) not null,
								BannedState bit default 0 not null,
								ReviewState bit default 0 not null,
								CategoryID int default 0 references system_.Category(CategoryID) on update cascade,
								ShopID int references production.Shop(ShopID) 
								on delete cascade on update cascade,
								RatingStar tinyint not null default 0);


create table production.Voucher (VoucherID int identity(1,1) primary key,
									VoucherName varchar(255) not null,
									VoucherType bit not null,
									FixedAmount varchar(255) default 0 not null,
									MinAmount varchar(255) default 0 not null,
									PercentageDiscount varchar(255) default 0 not null,
									MaxAmount varchar(255) default 0 not null,
									Quanity int not null,
									StartedDay date not null,
									EndedDay date not null,
									ShopID int references production.Shop(ShopID) 
									on delete cascade on update cascade);

create table production.Order_ (OrderID int identity(1,1) primary key,
								CustomerID int references user_.Customer(CustomerID) 
								on delete cascade on update cascade,
								TotalAmount varchar(255) not null,
								DateOrder varchar(255) not null,
								CustomerOrderState bit default 1 not null,
								OrderConfirmState bit default 0 not null,
								ReceivedState bit default 0 not null)

create table production.OrderDetail (OrderDetailID int identity(1,1) primary key ,
									OrderID int references production.Order_(OrderID) 
									on delete cascade on update cascade,
									ProductID int references production.Product(ProductID),
									Quantity int not null,
									UnitPrice varchar(255) not null,	
									OrderDetailConfirmState bit default 0 not null,
									Discount varchar(255) not null,
									VoucherID int references production.Voucher(VoucherID))

create table system_.Notification_ (NotificationID int identity(1,1) primary key,
									ReceiverID int references user_.Customer(CustomerID) 
									on delete cascade on update cascade,
									Tittle varchar(255) not null,
									SeenState bit default 0 not null,
									Time_ date not null,
									Content varchar(255) not null);

create table system_.Message_ (MessageID int identity(1,1) primary key,
								SenderID int references user_.Customer(CustomerID),
								ReceiverID int references user_.Customer(CustomerID),
								Content varchar(255) not null,
								Date_ date not null,
								Time_ varchar(255) not null,
								SeenState bit not null default 0,
								IsRecall bit not null default 0);
								

create table system_.Comment (CommentID int identity(1,1) primary key,
								ProductID int references production.Product(ProductID) 
								on delete cascade on update cascade,
								CustomerID int references user_.Customer(CustomerID),
								-- handle event when delete customer, comment gone after that immediately
								Star tinyint not null,
								Content varchar(255) not null,
								DateOfComment Date not null,
								ResponseComment	bit not null);


create table system_.ShopppingCart (CustomerID int references user_.Customer(CustomerID) 
									on delete cascade on update cascade,
									ProductID int references production.Product(ProductID),
									-- create trigger delete shopping cart when product got deleted.
									primary key(CustomerID, ProductID));

