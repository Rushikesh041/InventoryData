using InventoryData.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InventoryData.Repository
{
    public class InventoryManager
    {
        public string FilePath = "R:\\VSCode\\Inventory\\InventoryData\\InventoryData\\Json\\InventoryData.json";
        public void CalculateInventoryValue()
        {
            var jsonData = File.ReadAllText(FilePath);
           
            var inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);
            Console.WriteLine(
                "Name : " + inventoryData.Rice.Name + "\n" +
                "Weight : " + inventoryData.Rice.Weight + "\n" +
                "PricePerKG : " + inventoryData.Rice.PricePerKG + "\n\n" +
                "Name : " + inventoryData.Wheats.Name + "\n" +
                "Weight : " + inventoryData.Wheats.Weight + "\n" +
                "PricePerKG : " + inventoryData.Wheats.PricePerKG + "\n\n" +
                "Name : " + inventoryData.Pulses.Name + "\n" +
                "Weight : " + inventoryData.Pulses.Weight + "\n" +
                "PricePerKG : " + inventoryData.Pulses.PricePerKG + "\n"
                );

            Console.WriteLine("Data: \n"+jsonData);
        }
    }
}
