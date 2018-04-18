﻿using RentoBuddy.Models.HotelViewModels;
using RentoBuddy.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentoBuddy.Models.CartViewModels
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public CustomerModel CustomerModel { get; set; }

        public List<ProductModel> ProductModel { get; set; }

        public int RentalPeriodInMonths { get; set; }

        public double TotalRentalDeposit { get; set; }

        public double TotalRentAmount { get; set; }

        public double TotalCostForOrder { get; set; }

        public double TaxesApplied { get; set; }
    }
}