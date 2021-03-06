﻿using StorageMaster.Entities.Products;
using System;

namespace Logger.Models.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(string productType, double price)
        {
            Product product = null;
            switch (productType)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                default:
                    throw new InvalidOperationException("Ivalid product type");
            }
            return product;
        }
    }
}
