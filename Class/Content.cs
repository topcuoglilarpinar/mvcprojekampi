using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //ilişki için devam edilir
        public int HeadingID { get; set; } //headingin primerkeyi yazılır
        public virtual Heading Heading { get; set; }


        //yeniden bir ilişki:
        public int? WriterID { get; set; }  
        public virtual Writer Writer{ get; set; }


        public int SILEN_KULLANICI { get; set; }
        public int SILINDI { get; set; }
        public DateTime SILINME_TARIHI { get; set; }
    }
}