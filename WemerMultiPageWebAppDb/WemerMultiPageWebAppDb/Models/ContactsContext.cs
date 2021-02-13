using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WemerMultiPageWebAppDb.Models
{
    public class ContactsContext:DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                           new Contact
                           {
                               ContactId = 1,
                               Name = "Glenn",
                               PhoneNumber = "(515)-210-8346",
                               Adress = "201 Hazel Street Van Meter Iowa 50261",
                               Note = "Dad"
                           },
                           new Contact
                           {
                               ContactId = 2,
                               Name = "Colby",
                               PhoneNumber = "(515)-478-4955",
                               Adress = "201 Hazel Street Van Meter Iowa 50261",
                               Note = "Me"
                           },
                           new Contact
                           {
                               ContactId = 3,
                               Name = "kim",
                               PhoneNumber = "(515)-210-8347",
                               Adress = "201 Hazel Street Van Meter Iowa 50261",
                               Note = "Mom"
                           }
                           );
        }
    }
}
