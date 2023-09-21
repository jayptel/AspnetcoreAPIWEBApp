using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AspnetcoreWebApp.Pages
{
    public class TasksModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public List<AspnetcoreAPIWEBApp.Task> Tasks { get; private set; } = new List<AspnetcoreAPIWEBApp.Task>();

        public TasksModel(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task OnGetAsync()
        {
            var apiUrl = _configuration["apiUrl"];

            try
            {
                Tasks = await _httpClient.GetFromJsonAsync<List<AspnetcoreAPIWEBApp.Task>>(apiUrl + "/api/tasks");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log or display an error message)
                // You can add error handling code here
            }

        }


    }
}
