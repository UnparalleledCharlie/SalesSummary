using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using SalesSummary.Models;
namespace SalesSummary.Services;

public class Sales : ISales
{
    private readonly ILogger<Sales> _logger;
    private readonly string _filePath;

    public Sales (ILogger<Sales> logger,  IConfiguration configuration)
    {
        _logger = logger;
        _filePath = configuration["SalesData:FilePath"] ?? "wwwroot/Data.csv";
    }
    
    public async Task<List<SalesRecord>> ReadSalesDataAsync()
    {
        try
        {
            using var csv = new CsvReader(new StreamReader(_filePath,  Encoding.UTF8),
                new CsvConfiguration(CultureInfo.InvariantCulture));
            var records = csv.GetRecords<SalesRecord>().ToList();
            return await Task.FromResult(records);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error reading CSV file: {ex.Message}");
            throw;
        }
    }
}

