

namespace Principio_OCP
{
    // Interfaz para la estrategia de cálculo de impuestos
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal income, decimal deduction);
    }

    // Estrategia de cálculo de impuestos para India
    public class IndiaTaxStrategy : ITaxStrategy 
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            // Lógica de cálculo de impuestos específica para India
            decimal taxableIncome = income - deduction;
            // Ejemplo de cálculo de impuestos (real)
            return taxableIncome * 0.15m;
        }
    }
}
