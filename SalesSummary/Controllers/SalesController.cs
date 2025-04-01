using Microsoft.AspNetCore.Mvc;
using SalesSummary.Services;

namespace SalesSummary.Controllers;

public class SalesController : Controller
{
    private readonly ISales _iSales;
    
    public SalesController(ISales salesService)
    {
        _iSales = salesService;
    }
    
    public async Task<IActionResult> Index()
    {
        var salesData = await _iSales.ReadSalesDataAsync();
        if (salesData.Count == 0) 
        {
            return NotFound("No sales data available.");
        }
        return View(salesData);
    }
}