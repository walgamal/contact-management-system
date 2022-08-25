using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EpitecCMSApp.Server.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class ContactController : ControllerBase
     {
          private readonly DataContext _context;
          public ContactController(DataContext context)
          {
               _context = context;
          }

          [HttpGet]
          public async Task<ActionResult<List<Contact>>> GetContacts()
          {
               var contacts = await _context.Contacts.ToListAsync();
               return Ok(contacts);
          }

          [HttpGet("{id}")]
          public async Task<ActionResult<Contact>> GetSingleContact(Guid id)
          {
               var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(id));
               if (contact == null)
               {
                    return NotFound("Sorry, this contact does not exist!");
               }
               return Ok(contact);
          }

          [HttpPost]
          public async Task<ActionResult<List<Contact>>> CreateContact(Contact contact)
          {
               _context.Contacts.Add(contact);
               await _context.SaveChangesAsync();

               return Ok(await GetDbContacts());
          }

          [HttpPut("{id}")]
          public async Task<ActionResult<List<Contact>>> UpdateContact(Contact contact, Guid id)
          {
               var dbContact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(id));
               if(dbContact == null)
               {
                    return NotFound("Sorry, no hero here!");
               }

               dbContact.firstName = contact.firstName;
               dbContact.lastName = contact.lastName;
               dbContact.phoneNum = contact.phoneNum;
               dbContact.birthDate = contact.birthDate;

               await _context.SaveChangesAsync();

               return Ok(await GetDbContacts());
          }

          [HttpDelete("{id}")]
          public async Task<ActionResult<List<Contact>>> DeleteContact(Guid id)
          {
               var dbContact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(id));
               if (dbContact == null)
               {
                    return NotFound("Sorry, no hero here!");
               }

               _context.Contacts.Remove(dbContact);

               await _context.SaveChangesAsync();

               return Ok(await GetDbContacts());
          }

          private async Task<List<Contact>> GetDbContacts()
          {
               return await _context.Contacts.ToListAsync();
          }
     }
}
