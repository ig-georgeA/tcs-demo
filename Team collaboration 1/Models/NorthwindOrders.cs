//namespace Team_collaboration_1.Data.Northwind; // Razor won't recognize third level namespace
namespace Team_collaboration_1.Northwind;

public class OrdersType
{
    public double OrderID { get; set; }
    public string CustomerID { get; set; }
    public double EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public double ShipVia { get; set; }
    public double Freight { get; set; }
    public string ShipName { get; set; }
    public ShipAddressType ShipAddress { get; set; }
}

public class ShipAddressType
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
