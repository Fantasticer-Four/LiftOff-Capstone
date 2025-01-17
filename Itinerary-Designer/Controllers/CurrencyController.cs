using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Exchange.Services;

namespace Exchange.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ExchangeRatesApiService _exchangeRatesApi;

        public CurrencyController(ExchangeRatesApiService exchangeRatesApi)
        {
            _exchangeRatesApi = exchangeRatesApi;
        }

        [HttpGet("currency")]
        public async Task<IActionResult> ConvertCurrency(string fromCurrency, string toCurrency, double amount)
        {
            
            using (var httpClient = new HttpClient())
        {
        string apiUrl = $"https://api.apilayer.com/exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={amount}";
        var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

    
        request.Headers.Add("apikey", "osBudYFRdkNVt6966P10CnRGMpEDIZK3");
        try
        {
            HttpResponseMessage response = await httpClient.SendAsync(request);


            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                return Ok(json);
            }
            else
            {
                return StatusCode(
                    (int)response.StatusCode,
                    "Error fetching data from external API"
                );
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
        }
        }
    }
}

