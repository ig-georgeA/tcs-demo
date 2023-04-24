using System.Text.Json;

namespace Team_collaboration_1.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly IWebHostEnvironment _env;

        public NorthwindService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<OrdersType>> GetOrders()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/northwind-orders.json";
            if (!File.Exists(path))
            {
                return new List<OrdersType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<OrdersType>>(data, options));
        }

        public async Task<List<CustomersType>> GetCustomers()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/northwind-customers.json";
            if (!File.Exists(path))
            {
                return new List<CustomersType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<CustomersType>>(data, options));
        }

        public async Task<List<EmployeesType>> GetEmployees()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/northwind-employees.json";
            if (!File.Exists(path))
            {
                return new List<EmployeesType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<EmployeesType>>(data, options));
        }

        public async Task<List<SuppliersType>> GetSuppliers()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/northwind-suppliers.json";
            if (!File.Exists(path))
            {
                return new List<SuppliersType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<SuppliersType>>(data, options));
        }
    }
}