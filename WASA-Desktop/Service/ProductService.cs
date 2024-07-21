﻿using Core.Entity;
using DTO.Product;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace WASA_Mobile.Service
{
    public static class ProductService
    {
        public static async Task<ProductEntity> SearchProduct(GetProductByCodeRequest request)
        {
            try
            {
                JsonContent content = JsonContent.Create(request);
                HttpClient httpClient = new();
                var response = await httpClient.PostAsync("https://onidem-wasa-api-c94a.twc1.net/Product/ShowByProductCode", content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadFromJsonAsync<ProductEntity>();
                    if (result!.ProductCode.Length > 0)
                    {
                        return result;
                    }
                }
                return new() { ProductCode = ""};
            }
            catch (Exception ex)
            {
                return new() { ProductCode = "" };
            }
        }

        public static async Task<IEnumerable<ProductEntity>> GetAllProducts()
        {
            try
            {
                JsonContent content = JsonContent.Create("");
                HttpClient httpClient = new();
                var response = await httpClient.PostAsync("https://onidem-wasa-api-c94a.twc1.net/Product/ShowAll", content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadFromJsonAsync<IEnumerable<ProductEntity>>();
                    if (result != null)
                    {
                        return result;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static async Task<ProductEntity> AddProduct(AddProductRequest request)
        {
            try
            {
                JsonContent content = JsonContent.Create(request);
                HttpClient httpClient = new();
                var response = await httpClient.PostAsync("https://onidem-wasa-api-c94a.twc1.net/Product/Add", content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadFromJsonAsync<ProductEntity>();
                    if (result!.ProductCode.Length > 0)
                    {
                        return result;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}