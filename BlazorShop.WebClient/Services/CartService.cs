﻿namespace BlazorShop.WebClient.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;
        private readonly IToastService _toastService;

        public event Action OnChange;

        public CartService(HttpClient httpClient, IToastService toastService)
        {
            _httpClient = httpClient;
            _toastService = toastService;
        }

        public async Task<RequestResponse> AddCart(CartResponse cart)
        {
            var response = await _httpClient.PostAsJsonAsync($"Carts/cart", cart);
            if (!response.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess(cart.Name, "The item was added to cart:");
            OnChange.Invoke();
            return RequestResponse.Success();
        }

        public async Task<RequestResponse> DeleteCart(int id)
        {
            var response = await _httpClient.DeleteAsync($"Carts/cart/{id}");
            if (!response.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The item was deleted from the cart.");
            return RequestResponse.Success();
        }

        public async Task<RequestResponse> EmptyCart()
        {
            var response = await _httpClient.DeleteAsync($"Carts/carts");
            if (!response.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The items from the cart were removed.");
            OnChange.Invoke();
            return RequestResponse.Success();
        }

        public async Task<CartResponse> GetCart(int id)
        {
            var authResult = await _httpClient.GetAsync($"Carts/cart/{id}");
            if (!authResult.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<CartResponse>(
                authContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }

        public async Task<int> GetCartCounts()
        {
            var authResult = await _httpClient.GetAsync("Carts/count");
            if (!authResult.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return 0;
            }

            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<int>(
                authContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }

        public async Task<List<CartResponse>> GetCarts()
        {
            var authResult = await _httpClient.GetAsync("Carts/carts");
            if (!authResult.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<List<CartResponse>>(
                authContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }

        public async Task<RequestResponse> UpdateCart(CartResponse cart)
        {
            var response = await _httpClient.PutAsJsonAsync($"Carts/cart", cart);
            if (!response.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The cart was updated.");
            OnChange.Invoke();
            return RequestResponse.Success();
        }

        public async Task<string> Checkout()
        {
            var response = await _httpClient.PostAsJsonAsync("Payments/checkout", await GetCarts());
            var url = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The checkout operation was successfully made.");
            return url;
        }
    }
}
