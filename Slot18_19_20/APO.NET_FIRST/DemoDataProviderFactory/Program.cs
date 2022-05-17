using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace DemoDataProviderFactory
{
    class Program
    {
        // get connection string from appsetting.json
        static string GetConnectionString() { 
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }

        // end GetConnectionString
        static void ViewProducts() {
            DbProviderFactory factory = SqlClientFactory.Instance;
            // get connection object
            using DbConnection connection = factory.CreateConnection();
            if (connection == null) {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            
            // make command object
            DbCommand command = factory.CreateCommand();
            if (command == null) {
                Console.WriteLine($"Unable to create the command object.");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID, ProductName From Products";

            //Print out data with data reader
            using DbDataReader dataReader = command.ExecuteReader();
            Console.WriteLine("***** Product List *****");
            while (dataReader.Read()) {
                Console.WriteLine($"ProductID: {dataReader["ProductId"]}, " + $"ProductName: {dataReader["ProductName"]}.");
            }
        }

        // end ViewProducts
        static void Main(string[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }
    }
}
