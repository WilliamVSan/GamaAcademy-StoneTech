using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class Calculos
    {
        public float CalcularPerca(float compra, float venda) 
        {
            if(compra > venda) 
            { 
                float margemDeLucro = (compra - venda) / compra;
                float porcentagemDePerca = margemDeLucro * 100;
                return porcentagemDePerca; 
            }
            else
            {
                return 0;
            }
            
        }

    }
  
}
