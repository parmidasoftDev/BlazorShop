﻿namespace BlazorShop.WebClient.Services
{
    public class ClotheService : IClotheService
    {
        private readonly HttpClient _httpClient;
        private readonly IToastService _toastService;

        public ClotheService(HttpClient httpClient, IToastService toastService)
        {
            _httpClient = httpClient;
            _toastService = toastService;
        }

        public async Task<List<ClotheResponse>> GetClothes()
        {
            var authResult = await _httpClient.GetAsync("Clothes/clothes");
            if (authResult.IsSuccessStatusCode == false)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<List<ClotheResponse>>(
                authContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }

        public async Task<ClotheResponse> GetClothe(int id)
        {
            var authResult = await _httpClient.GetAsync($"Clothes/clothe/{id}");
            if (authResult.IsSuccessStatusCode == false)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ClotheResponse>(
                authContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }

        public async Task<RequestResponse> AddClothe(ClotheResponse clothe)
        {
            var response = await _httpClient.PostAsJsonAsync("Clothes/clothe", clothe);
            if (response.IsSuccessStatusCode == false)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The clothe was added.");
            return RequestResponse.Success();
        }

        public async Task<RequestResponse> UpdateClothe(ClotheResponse clothe)
        {
            var response = await _httpClient.PutAsJsonAsync("Clothes/clothe", clothe);
            if (response.IsSuccessStatusCode == false)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The clothe was updated.");
            return RequestResponse.Success();
        }

        public async Task<RequestResponse> DeleteClothe(int id)
        {
            var response = await _httpClient.DeleteAsync($"Clothes/clothe/{id}");
            if (response.IsSuccessStatusCode == false)
            {
                _toastService.ShowError("Something went wrong.");
                return null;
            }

            _toastService.ShowSuccess("The clothe was deleted.");
            return RequestResponse.Success();
        }
    }
}
