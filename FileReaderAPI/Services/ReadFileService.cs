using CsvHelper;
using FileReaderAPI.Model;
using System.Globalization;

namespace FileReaderAPI.Services
{
    public class ReadFileService : IReadFileService
    {
        private readonly string _filePath;

        public ReadFileService(IConfiguration configuration)
        {
            _filePath = configuration.GetValue<string>("FileDataInfo");
        }
        public List<Order> GetFileData()
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ","
            };
            using (var reader = new StreamReader(_filePath))
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
