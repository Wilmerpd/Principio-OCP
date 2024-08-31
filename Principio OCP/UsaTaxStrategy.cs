using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_OCP
{
    public class UsaTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            // Lógica de cálculo de impuestos específica para USA
            decimal taxableIncome = income - deduction;
            // Ejemplo de cálculo de impuestos (real)
            return taxableIncome * 0.20m;
        }

    }
}
