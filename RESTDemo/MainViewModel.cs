using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RESTDemo
{
    public class MainViewModel
    {
        HttpClient client;
        JsonSerializerOptions _serializerOptions;
        string baseUrl = "https://64008f0d29deaba5cb3a5609.mockapi.io";
        public MainViewModel()
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }

        // Get all the Records
        public ICommand AddUserCommand =>
            new Command(async () =>
            {
                var url = $"{baseUrl}/users";
                var response =
                    await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    //var content = await response.Content.ReadAsStringAsync();
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        var data =
                        await JsonSerializer
                        .DeserializeAsync<List<User>>(responseStream, _serializerOptions);
                    }
                }
            });
    }
}
