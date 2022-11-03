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
            foreach (var Rice in inventoryData.Rice)
            {
                Console.Write("Name : " + Rice.Name + "\n" +
                "Weight : " + Rice.Weight + "\n" +
                "PricePerKG : " + Rice.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Rice.Name} is : {Rice.Weight * Rice.PricePerKG} \n");
            }
            foreach (var Wheats in inventoryData.Wheats)
            {
                Console.Write("Name : " + Wheats.Name + "\n" +
                "Weight : " + Wheats.Weight + "\n" +
                "PricePerKG : " + Wheats.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Wheats.Name} is : {Wheats.Weight * Wheats.PricePerKG} \n");
            }
            foreach (var Pulses in inventoryData.Pulses)
            {
                Console.Write("Name : " + Pulses.Name + "\n" +
                "Weight : " + Pulses.Weight + "\n" +
                "PricePerKG : " + Pulses.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Pulses.Name} is : {Pulses.Weight * Pulses.PricePerKG} \n");
            }

            Console.WriteLine("Data: \n"+jsonData);
        }
    }
}
