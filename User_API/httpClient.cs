using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace User_API
{
    public partial class mainFrm
    {

        private async void DoPATCH(string userID, string URL, string endPoint)
        {
            try
            {
                string nURL = URL + endPoint + userID;

                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), nURL))
                    {
                        var response = await httpClient.SendAsync(request);

                        string result = await response.Content.ReadAsStringAsync();

                        var logoutResponse = JsonSerializer.Deserialize<httpResponse>(result);

                        MessageBox.Show(logoutResponse?.message ?? "No message received");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void DoPOST(string email, string givenName, string lastName, string roleID, string locationID, string URL, string endPoint)
        {
            try
            {

                string nURL = URL + endPoint;

                string json = "{"
                                +"\"email\": \""+ email + "\","
                                +"\"userType\": \"STAFF\","
                                +"\"givenName\": \""+ givenName + "\","
                                +"\"lastName\": \""+ lastName + "\","
                                +"\"userRoles\": ["
                                +"{"    
                                +"\"id\": "+ roleID
                                + "}"
                                +"],"
                                +"\"location\": {"
                                +    "\"id\": "+ locationID
                                + "}"
                                +"}";

                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), nURL))
                    {

                        request.Content = new StringContent(json);
                        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        var response = await httpClient.SendAsync(request);

                        string result = await response.Content.ReadAsStringAsync();

                        var logoutResponse = JsonSerializer.Deserialize<httpResponse>(result);

                        MessageBox.Show(logoutResponse?.message ?? "No message received");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
