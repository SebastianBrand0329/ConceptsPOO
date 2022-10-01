using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    internal class CommissionEmployee : Employee
    {
        public float CommssionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommssionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje: {$"{CommssionPercentaje:P2}", 15}" +
                $"\n\tSales................: {$"{Sales:C2}", 15}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}", 15}";
        }
    }
}
