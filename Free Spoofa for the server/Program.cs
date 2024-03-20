using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {        // List of webhook URLs
        List<string> webhookUrls = new List<string>
        {
            //if you want more webhooks just copy the " "", " then just and the webhook url
            "webhook here", 
        };
        string message = "massage here";

        for (int i = 0; i < just type the number here; i++)
        {
            await SendMessageToWebhook(webhookUrls, message);
        }
    }

    static async Task SendMessageToWebhook(string webhookUrl, string message)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Create JSON payload
                string jsonPayload = $"{{\"content\": \"{message}\"}}";

                // Create HttpContent from JSON payload
                HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Send POST request to webhook URL
                HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

                // Check if request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Message sent successfully");
                }
                else
                {
                    Console.WriteLine($"Failed to send message: {response.StatusCode}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
