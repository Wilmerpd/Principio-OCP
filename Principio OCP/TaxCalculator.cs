

namespace Principio_OCP
{
    //clase principal 
    public class TaxCalculator
    {
        private ITaxStrategy _taxStrategy;

        // Constructor que recibe la estrategia de cálculo de impuestos
        public TaxCalculator(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public decimal Calculate(decimal income, decimal deduction)
        {
            return _taxStrategy.CalculateTax(income, deduction);
        }
    }
}
