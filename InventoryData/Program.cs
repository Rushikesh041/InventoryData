using InventoryData.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        InventoryManager inventoryManager = new InventoryManager();
        inventoryManager.CalculateInventoryValue();
    }
}