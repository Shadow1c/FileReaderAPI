using FileReaderAPI.Model;
using System.Globalization;
using System.Reflection.PortableExecutable;
using CsvHelper.Configuration;
using CsvHelper;
using CsvHelper.TypeConversion;
using System.Formats.Asn1;

namespace FileReaderAPI.Services
{
    public class ReadFileService : IReadFileService
    {
        public List<Order> GetFileData()
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ","
            };
            using (var reader = new StreamReader("C:/Users/rysza/Desktop/TestingCSV/convertcsv.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Order>().ToList();
                return records;
            }
        }

        public List<Order> GetAll()
        {
                var allOrders = GetFileData();
                return allOrders;
            
        }

        public Order GetOrder(string id)
        {
            var OrderById = GetFileData();
            return OrderById.Single(order => order.Number == id);
        }
    }
}
