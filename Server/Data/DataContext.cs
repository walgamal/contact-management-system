

namespace EpitecCMSApp.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Contact>().HasData(
                    new Contact { Id = Guid.NewGuid(), lastName = "Algamal", firstName = "Wasim", phoneNum = "3133984347", birthDate = new DateTime(2001, 04, 28) },
				new Contact { Id = Guid.NewGuid(), lastName = "Smith", firstName = "John", phoneNum = "5556667777", birthDate = new DateTime(2002, 12, 05) },
				new Contact { Id = Guid.NewGuid(), lastName = "Blokovitch", firstName = "Bill", phoneNum = "1234567890", birthDate = new DateTime(1988, 08, 10) },
				new Contact { Id = Guid.NewGuid(), lastName = "Hyde", firstName = "Sam", phoneNum = "11123456789", birthDate = new DateTime(1997, 09, 04) }
               );
		}
		public DbSet<Contact> Contacts { get; set; }

	}
}
