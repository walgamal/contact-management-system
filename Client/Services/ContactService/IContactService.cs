

namespace EpitecCMSApp.Client.Services.ContactService
{
     public interface IContactService
     {
          List<Contact> Contacts { get; set; }
          Task GetContacts();
          Task<Contact> GetSingleContact(Guid id);
          Task CreateContact(Contact contact);
          Task UpdateContact(Contact contact);
          Task DeleteContact(Guid id);
     }
}
