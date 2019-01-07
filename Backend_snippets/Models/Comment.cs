public class Comment
{
	[Key]
	public int CommentId { get; set; }
	[Required]
	public string Text { get; set; }
	[Required]
	public int AuthorId { get; set; }

	public User Author;
}

public class CommentDBContext : DbContext
{
	public CommentDBContext() : base("DBConnectionString") { }
	public DbSet<Comment> Comments { get; set; }
}

// TODO: add namespace 
// TODO: in web.config de adaugat resursele necesare (din curs 8)
// TODO: add validations in front end
// https://cezarabenegui.com/DAW/Curs-8.pdf