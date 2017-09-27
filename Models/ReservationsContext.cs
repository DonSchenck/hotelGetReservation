using Microsoft.EntityFrameworkCore;

namespace hotelGetReservation.Models
{
	public class ReservationsContext : DbContext
	{
		public DbSet<Reservations> Reservations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string dbconn = System.Environment.GetEnvironmentVariable("hotel_dbconn");
			optionsBuilder.UseSqlServer(dbconn);
		}
	}
}