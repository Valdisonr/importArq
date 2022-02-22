using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sisBen
{
   public  class ItemProd
    {
        private int _codigo = 0;


        private string _descricao=string.Empty;

       
        private int _qtd = 0;


        private decimal _valor = 0;


        private decimal _vlTotal = 0;

      
        
       
       public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

       public string Descricao
       {
           get { return _descricao; }
           set { _descricao = value; }
       }

       public int Qtd
       {
           get { return _qtd; }
           set { _qtd = value; }
       }

       public decimal Valor
       {
           get { return _valor; }
           set { _valor = value; }
       }

       public decimal VlTotal
       {
           get { return _vlTotal; }
           set { _vlTotal = value; }
       }
    }
}
