namespace Team_collaboration_1.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();

        Task<List<CustomersType>> GetCustomers();

        Task<List<EmployeesType>> GetEmployees();

        Task<List<SuppliersType>> GetSuppliers();
    }
}