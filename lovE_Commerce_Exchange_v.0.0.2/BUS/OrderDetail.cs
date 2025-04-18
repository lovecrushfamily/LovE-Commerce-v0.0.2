﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetail  : DLL.OrderDetail_, Entity
    {
        public OrderDetail(DLL.OrderDetail_ orderDetail_)
        {
            OrderDetailId = orderDetail_.OrderDetailId;
            OrderId = orderDetail_.OrderId;
            ProductId = orderDetail_.ProductId;
            Quantity = orderDetail_.Quantity;
            UnitPrice = orderDetail_.UnitPrice;
            OrderDetailConfirmState = orderDetail_.OrderDetailConfirmState;
            Discount = orderDetail_.Discount;
            VoucherID = orderDetail_.VoucherID;
        }

        public void Add()
        {
            DAO.OrderDetail.Add(this);
        }
        public void UpdateShopConfirmation()
        {

        }
        public void Update()
        {
            DAO.OrderDetail.Update(this);
        }
        public void Delete()
        {
            DAO.OrderDetail.Delete(this);
        }

        public static OrderDetail[] GetOrderDetails()
        {
            return DAO.OrderDetail.Select().Select(c => new OrderDetail(c)).ToArray();
        }

        public OrderDetail SetConfirmStateOn()
        {
            OrderDetailConfirmState = true;
            return this;

        }

    }
}
