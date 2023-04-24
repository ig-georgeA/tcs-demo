//namespace Team_collaboration_1.Data.Northwind; // Razor won't recognize third level namespace
namespace Team_collaboration_1.Northwind;

public class SuppliersType
{
    public double SupplierID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public AddressType Address { get; set; }
}
