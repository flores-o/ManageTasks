public class Task
{
	[Key]
	public int TaskId { get; set; }
	[Required]
	public string Name { get; set; }
	public string Description { get; set; }
	[Required]
	public int ProjectId { get; set; }
	[Required]
	public int AssigneeId { get; set; }

	// TODO: cum fac enum??? sau tabel one to many??
	[Required]
	public int Status { get; set; }

	// https://stackoverflow.com/questions/5658216/entity-framework-code-first-date-field-creation
	// To save ony date, without time
	// [DataType(DataType.Date)]
    // [Display(Name = "Date of Birth")]
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

	public User Assignee;
	public Project Project;

	public List<Comment> Comments { get; set; }

}

public class TaskDBContext : DbContext
{
	public TaskDBContext() : base("DBConnectionString") { }
	public DbSet<Task> Tasks { get; set; }
}

// TODO: add namespace 
// TODO: in web.config de adaugat resursele necesare (din curs 8)
// TODO: add validations in front end
// https://cezarabenegui.com/DAW/Curs-8.pdf