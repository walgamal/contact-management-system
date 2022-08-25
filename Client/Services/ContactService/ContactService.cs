using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EpitecCMSApp.Client.Services.ContactService
{
     public class ContactService : IContactService
     {
          private readonly HttpClient _http;
          private readonly NavigationManager _navigationManager;

          public ContactService(HttpClient http, NavigationManager navigationManager)
          {
               _http = http;
               _navigationManager = navigationManager;
          }
          public List<Contact> Contacts { get; set; } = new List<Contact>();

          private void SetContacts()
          {
               _navigationManager.NavigateTo("/");
          }

          public async Task<Contact> GetSingleContact(Guid id)
          {
               var result = await _http.GetFromJsonAsync<Contact>($"api/contact/{id}");
               if (result != null)
                    return result;
               throw new Exception("Contact not found!");
          }
          
          public async Task GetContacts()
          {
               var result = await _http.GetFromJsonAsync<List<Contact>>("api/contact");
               if (result != null)
                    Contacts = result;
          }

          public async Task CreateContact(Contact contact)
          {
               await _http.PostAsJsonAsync("api/contact", contact);
               SetContacts();
          }

          public async Task UpdateContact(Contact contact)
          {
               var result = await _http.PutAsJsonAsync($"api/contact/{contact.Id}", contact);
               SetContacts();
          }

          public async Task DeleteContact(Guid id)
          {
               await _http.DeleteAsync($"api/contact/{id}");
               SetContacts();
          }
     }
}
