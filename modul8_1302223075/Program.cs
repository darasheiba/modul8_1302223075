// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
using modul8_1302223075;

class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = "/Users/darasheibamalikachoiriyyah/Projects/modul8_1302223075/modul8_1302223075/bank_transfer_config.json";
        BankTransferConfig config;

        using (FileStream fs = File.OpenRead(jsonFilePath))
        {
            config = JsonSerializer.Deserialize<BankTransferConfig>(fs);
        }
    }
}

