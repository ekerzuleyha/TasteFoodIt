using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Context
{
    //BU SINIFIN TABLOLARI TUTAN SINIF OLSUĞUNU BİLDİRMEMİZ GEREKEN SINIFI TANIMLAMAMIZ GEREKİYOR.
    //dbcontext : veritabanına yansıtacağımız tabloların olduğu sınıfı tutar 
    public class TasteContext:DbContext
    {
        //tabloları property oluşturup yansıtıcaz. türü dbcontextten gelen db set olacak,dbset in içine veritabanına yansıtmak istediğimiz tabloları yazıcaz. istediğimiz tablo.tabloa isimleri ilk baş gelmiyor neden .çünkü farklı klasördeler.     bunu eklemek gerek >>>>> using TasteFoodIt.Entities; çoğul abouts sql deki tablomuzun ismi , about ise c# daki sınıfın ismi ,tabloya baska bir isimde verilebilirama okuma açısından bu daha güzel.  
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OpenDayHour> OpenDayHours { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<ContactInformation> contactInformations{ get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}