using Core.Entities.Concrete;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime="Maintenance Time";
        public static string ProductsListed="Products Listed";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı.";
        public static string AuthorizationDenied="Erişim Engellendi";
        public static string UserRegistered="Kullanıcı kaydı başarılı";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError ="Şifre hatası";
        internal static string SuccessfulLogin="Giriş başarılı";
        internal static string UserAlreadyExists="Bu email adresiyle bir kullanıcı var.";
        internal static string AccessTokenCreated="Access Token Oluşturuldu.";
    }
}
