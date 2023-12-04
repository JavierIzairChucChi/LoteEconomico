class Program
{
    static void Main()
    {
        Console.WriteLine("Programa que ejecuta el Lote Económico de Producción.");
        Console.WriteLine();
        Console.WriteLine("Una empresa que fabrica partes pequeñas necesita determinar la cantidad de partes pequeñas \nque debe producir en cada pedido para minimizar sus costos totales de inventario.");
        Console.WriteLine("\nCalcule el tamaño del lote económico de producción.\n");
        // Datos del problema
        int demandaAnual = 2000;
        double costoProduccion = 5.0;
        double costoMantenimiento = 1.5;

        // Cálculo del tamaño del lote económico de producción
        double tamanoLoteEconomico = Math.Sqrt(2 * demandaAnual * costoProduccion / costoMantenimiento);

        Console.WriteLine($"Demanda Anual: {demandaAnual}");
        Console.WriteLine($"Costo de Producción por unidad: {costoProduccion}");
        Console.WriteLine($"Costo de Mantenimiento: {costoMantenimiento}");
        Console.WriteLine($"\nEl tamaño del lote económico de producción es: {tamanoLoteEconomico} unidades");

        //Cálculo del costo total de inventario
        double costoTotal = costoProduccion * (demandaAnual / tamanoLoteEconomico) + (demandaAnual * costoProduccion) + 0.5 * tamanoLoteEconomico * costoMantenimiento;

        Console.WriteLine($"El costo total de inventario es: {costoTotal}");
    }
}

