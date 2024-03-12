using MvcPorjekampiEğitimi.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPorjekampiEğitimi.Abstract
{
   public interface ICategory
    {
        //crud işlemleri için metodları tanımlıcaz
        //nasıl tanımlanır veri türü ve isim verilir

        List<Category> list();
        void Insert(Category p);   //void geriye bir veri göndermez
        void Update(Category p);
        void Delete(Category p);
    }
}
