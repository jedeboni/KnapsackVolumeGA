using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackGA
{
    public class Item
    {
        public String descricao; //  descrição do item
        public double peso; // peso do item
        public double valor; // valor do item
        public double volume; // volume do item


        public Item(String nome,  double p, double v, double vol)
        {
           descricao = nome;
            valor = v;
            peso = p;
            volume = vol;
        }
    }
}
