public class Team
{
	[Key]
	public int TeamId { get; set; }
	[Required]
	public string Name { get; set; }

	public List<User> Members { get; set; }
}

public class TeamDBContext : DbContext
{
	public TeamDBContext() : base("DBConnectionString") { }
	public DbSet<Team> Teams { get; set; }
}

// TODO: add namespace 
// TODO: in web.config de adaugat resursele necesare (din curs 8)
// https://cezarabenegui.com/DAW/Curs-8.pdf