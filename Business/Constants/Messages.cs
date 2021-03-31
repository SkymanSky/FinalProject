using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Prodcut name invalid";
        public static string MaintenanceTime="Maintenance Time";
        public static string ProductsListed="Products Listed";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı.";
    }
}
