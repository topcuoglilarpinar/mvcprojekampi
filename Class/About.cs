using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }
        public int SILEN_KULLANICI { get; set; }
        public int SILINDI { get; set; }
        public DateTime SILINME_TARIHI { get; set; }

        //terminale enable-migrations yazıp sql e contextler otomatik gelsin diye
        //sonra update-database yaz terminale



    }
}