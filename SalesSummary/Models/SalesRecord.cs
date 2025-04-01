using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace SalesSummary.Models;

public class SalesRecord
{
    
    public string Segment { get; set; } 
    public string Country { get; set; }

    public string Product { get; set; }
    [Name("Discount Band")]
    public string DiscountBand { get; set; }
    [Name("Units Sold")]
    public Decimal UnitSold { get; set; }
    [Name("Manufacturing Price")]
    public string ManufacturingPrice { get; set; }
    [Name("Sale Price")]
    public string SalePrice { get; set; }
    public DateTime Date { get; set; }
  
}

   	 