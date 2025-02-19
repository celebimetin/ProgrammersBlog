﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı.!";
                return "Böyle bir kategori bulunamadı.!";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarılı bir şekilde eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
        }

        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler bulunamadı.";
                return "Böyle bir makele bulunamadı.";
            }

            public static string Add(string articleName)
            {
                return $"{articleName} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string articleName)
            {
                return $"{articleName} başlıklı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string articleName)
            {
                return $"{articleName} başlıklı makale başarıyla silinmiştir.";
            }

            public static string HardDelete(string articleName)
            {
                return $"{articleName} başlıklı makale başarıyla veritabanından silinmiştir.";
            }
        }
    }
}