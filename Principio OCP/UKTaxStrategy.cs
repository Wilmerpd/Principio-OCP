
namespace Principio_OCP
{
    public class UKTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            // Lógica de cálculo de impuestos específica para UK
            decimal taxableIncome = income - deduction;
            // Ejemplo de cálculo de impuestos (real)
            return taxableIncome * 0.25m;
        }
    }
}
