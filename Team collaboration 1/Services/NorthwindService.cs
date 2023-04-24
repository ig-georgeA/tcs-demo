using System.Net.Http.Json;

namespace Team_collaboration_1.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<OrdersType>> GetOrders()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-orders.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrdersType>>().ConfigureAwait(false);
            }

            return new List<OrdersType>();
        }

        public async Task<List<CustomersType>> GetCustomers()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-customers.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CustomersType>>().ConfigureAwait(false);
            }

            return new List<CustomersType>();
        }

        public async Task<List<EmployeesType>> GetEmployees()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-employees.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeesType>>().ConfigureAwait(false);
            }

            return new List<EmployeesType>();
        }

        public async Task<List<SuppliersType>> GetSuppliers()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-suppliers.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SuppliersType>>().ConfigureAwait(false);
            }

            return new List<SuppliersType>();
        }
    }
}