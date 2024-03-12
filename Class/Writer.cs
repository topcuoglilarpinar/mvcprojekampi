using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }

        //bu tabloda ilişkilendirme yapıcaz yazar işin bir tarafında başlık çok tarafta bire çok ilişki yani:

        public ICollection<Heading> Headings { get; set; }

        //başka bir ilişki:

         public ICollection<Content> Contents { get; set; }


        //sonradan ekledğimiz migrationları eklemek için terminale add-migration mig1  (migriton nedir arayüzdeki işlerin sql e eklenmesi.


        public int SILEN_KULLANICI { get; set; }
        public int SILINDI { get; set; }
        public DateTime SILINME_TARIHI { get; set; }

    }
}