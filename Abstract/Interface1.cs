using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPorjekampiEğitimi.Abstract
{
   public interface Interface1<T>
    {
        List<T> list();   //t ne ise bana onu getir kategori vermiştik öncesinde fakat sadece kategori gelir ve az gelir
        void Insert(T p);  
        void Update(T p);
        void Delete(T p);
    }
}
