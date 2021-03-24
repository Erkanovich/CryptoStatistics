using CryptoStatistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        private static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1: Show GFX settings configurations");
            Console.WriteLine("2: Show session history");
            Console.WriteLine("3: Add GFX settings configuration");
            Console.WriteLine("4: Start a new session");
            Console.WriteLine("5: End session");
            var selected = Console.ReadKey().KeyChar.ToString();
            switch (selected)
            {
                case "1":
                    ShowGfxSettings();
                    break;
                case "2":
                    ShowSessionHistory();
                    break;
                case "3":
                    AddGfxSettings();
                    break;
                case "4":
                    StartNewSession();
                    break;
                case "5":
                    EndSession();
                    break;

                default:
                    ShowMainMenu();
                    break;
            }
        }

        private static void ShowGfxSettings()
        {
            Console.Clear();
            List<GfxSettings> gfxSettings;
            using (var context = new CryptoStatisticsContext())
            {
                gfxSettings = context.GfxSettings.ToList();
            }
            
            foreach (var gfxSetting in gfxSettings)
            {
                Console.WriteLine($"Id: {gfxSetting.Id}");
                Console.WriteLine($"Name: {gfxSetting.Name}");
                Console.WriteLine($"ClockFrequency: {gfxSetting.ClockFrequency}");
                Console.WriteLine($"Voltage: {gfxSetting.Voltage}");
                Console.WriteLine($"MemoryFrequency: {gfxSetting.MemoryFrequency}");
                Console.WriteLine($"Wattage: {gfxSetting.Wattage}");
            }
        }

        private static void ShowSessionHistory()
        {
            throw new NotImplementedException();
        }

        private static void AddGfxSettings()
        {
            Console.Clear();
            
            var gfxSettings = new GfxSettings();
            //Validate input
            Console.WriteLine("Name of setting: ");
            gfxSettings.Name = Console.ReadLine();
            Console.WriteLine("ClockFrequency of setting: ");
            gfxSettings.ClockFrequency = int.Parse(Console.ReadLine());
            Console.WriteLine("Voltage of setting: ");
            gfxSettings.Voltage = int.Parse(Console.ReadLine());
            Console.WriteLine("MemoryFrequency of setting: ");
            gfxSettings.MemoryFrequency = int.Parse(Console.ReadLine());
            Console.WriteLine("Wattage of setting: ");
            gfxSettings.Wattage = int.Parse(Console.ReadLine());

            try
            {
                using (var context = new CryptoStatisticsContext())
                {
                    context.GfxSettings.Add(gfxSettings);
                    context.SaveChanges();
                }
                ShowMainMenu();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void StartNewSession()
        {
            throw new NotImplementedException();
        }

        private static void EndSession()
        {
            throw new NotImplementedException();
        }
    }
}
