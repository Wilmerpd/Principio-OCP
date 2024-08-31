/*En el codigo pasado el problema era que se utilizaba una declaración 
 * switch para calcular el impuesto dependiendo del país. Si se agregan más países,
 * sería necesario modificar el método Calculate() y añadir nuevos case al switch. 
 * Esto viola el principio OCP, ya que la clase TaxCalculator no está cerrada para la modificación.
 * 
 * Para aplicar el principio de OCP, podemos utilizar el Patrón de Estrategia. 
 * Este patrón nos permitirá encapsular los algoritmos de cálculo de impuestos en clases separadas, 
 * de modo que la clase TaxCalculator pueda trabajar con cualquier país sin necesidad de cambiar su código.
*/


// Cliente selecciona la estrategia según el país
using Principio_OCP;

ITaxStrategy taxStrategy = new IndiaTaxStrategy();
TaxCalculator calculator = new TaxCalculator(taxStrategy);
decimal taxAmount = calculator.Calculate(100000, 10000);
Console.WriteLine($"Tax Amount for India: {taxAmount}");

// Para otro país, simplemente cambiamos la estrategia
taxStrategy = new UsaTaxStrategy();
calculator = new TaxCalculator(taxStrategy);
taxAmount = calculator.Calculate(100000, 10000);
Console.WriteLine($"Tax Amount for USA: {taxAmount}");

taxStrategy = new UKTaxStrategy();
calculator = new TaxCalculator(taxStrategy);
taxAmount = calculator.Calculate(50000, 1000);
Console.WriteLine($"Tax Amount for UK: {taxAmount}");
