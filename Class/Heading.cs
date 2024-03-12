using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }



        //kategori de bulunan CategoryID yi buraya yazıyoruz bağlayacağız diye
        public int CategoryID { get; set; }
        //bu yukarda tanımladığımız özellik ilişki içersisinde olup olmadığını belirlemek için:
        public virtual Category Category { get; set; }


        //heading ile content arasında ilişki var burdan yapmaya başlıyoruz
        public ICollection<Content> Contents { get; set; }

        //writerin ilişkisi:
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public int SILEN_KULLANICI { get; set; }
        public int SILINDI { get; set; }
        public DateTime SILINME_TARIHI { get; set; }

    }
}