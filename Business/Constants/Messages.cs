using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürün listelendi";
        public static string ProductCountOfCategoryError = "En fazla 15 kategori olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün daha bulunmaktadır.Ürün ismini değiştiriniz";
        public static string CategoryLimitExceded = "Kategori limiti 15 den yükske olamaz, limit aşıldı eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "parola hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Sisteme Giriş Yapıldı";
    }
}