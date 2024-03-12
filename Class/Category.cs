using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(50)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //kategori ile heding arasında ilişki kuracağız:(bire çok ilişki ilk bunu yaptık sonra heding tarafına gidiyoruz)
        public ICollection<Heading> headings { get; set; }

        public int SILEN_KULLANICI { get; set; }
        public int SILINDI { get; set; }
        public DateTime SILINME_TARIHI { get; set; }
    }
}