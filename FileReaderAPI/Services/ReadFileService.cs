using FileReaderAPI.Model;
using System.Globalization;
using System.Reflection.PortableExecutable;
using CsvHelper.Configuration;
using CsvHelper;
using CsvHelper.TypeConversion;
using System.Formats.Asn1;

namespace FileReaderAPI.Services
{
    public class ReadFileService
    {
        private List<Order> GetFileData()
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",;"
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
            return new List<Order>();
        }

        public List<Order> GetOrder(string id)
        {
            return new List<Order>();
        }
    }
}
