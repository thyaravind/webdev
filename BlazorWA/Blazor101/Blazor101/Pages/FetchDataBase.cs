using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;


namespace Blazor101.Pages
{
    public class FetchDataBase: ComponentBase
    {

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await HttpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }

        public FetchDataBase()
        {
        }
    }
}
