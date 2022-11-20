using System.Net.Http.Json;

namespace PersonalSite.Pages
{
    public partial class Email
    {
        // Student model used with form
        public class EmailData
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Address { get; set; }

            public DateTime? CreatedOn { get; set; }
        }

        public class EmailApiClient
        {
            private readonly HttpClient httpClient;

            public EmailApiClient(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            // Some other methods....

            // Method to create new student record in database
            public async Task SendEmail(EmailData email)
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync<EmailData>("/email", email);
                }
                catch (Exception ex)
                {
                    // Log error
                }
            }
        }
    }
}
