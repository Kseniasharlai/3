using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonDispatcher
{
    public static class JsonHandler
    {
        public static List<Item> LoadData(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}");
                    return new List<Item>();
                }

                var json = File.ReadAllText(filePath);
                var items = JsonConvert.DeserializeObject<List<Item>>(json);

                if (items == null || items.Count == 0)
                {
                    Console.WriteLine("The file is empty or the data cannot be deserialized.");
                }

                return items ?? new List<Item>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return new List<Item>();
            }
        }
        
        public static void SaveData(List<Item> items, string filePath)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}