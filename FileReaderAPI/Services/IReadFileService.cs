using CsvHelper;
using FileReaderAPI.Model;
using System.Globalization;

namespace FileReaderAPI.Services
{
    public interface IReadFileService
    {
        public List<Order> GetFileData();

        public List<Order> GetAll();

        public Order GetOrder(string id);
    }
}
