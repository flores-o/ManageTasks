public class Project
{
	[Key]
	public int ProjectId { get; set; }
	[Required]
	public string Name { get; set; }
	public string Description { get; set; }
	[Required]
	public int OrganizerId { get; set; }

	public User Organizer;
	
	public List<Task> Tasks { get; set; }
}

public class ProjectDBContext : DbContext
{
	public ProjectDBContext() : base("DBConnectionString") { }
	public DbSet<Project> Projects { get; set; }
}

// TODO: add namespace 
// TODO: in web.config de adaugat resursele necesare (din curs 8)
// TODO: add validations in front end
// https://cezarabenegui.com/DAW/Curs-8.pdf