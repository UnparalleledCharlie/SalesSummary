using SalesSummary.Models;

namespace SalesSummary.Services;

public interface ISales
{
    Task<List<SalesRecord>> ReadSalesDataAsync();

}