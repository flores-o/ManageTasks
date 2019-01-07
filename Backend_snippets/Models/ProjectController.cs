 public class ProjectController : Controller
 {
 	private ProjectDBContext db = new ProjectDBContext();
 	
 	public ActionResult Index()
 	{
 		var projects = from project in db.Projects
 		orderby project.Name
 		select project;
 		ViewBag.Projects = projects;
 		return View();
 	}
 	
 	public ActionResult Show(int id)
 	{
 		Project project = db.Projects.Find(id);
 		ViewBag.Project = project;
 		return View();
 	}

 	public ActionResult New()
 	{
 		return View();
 	}

 	[HttpPost]
 	public ActionResult New(Project project)
 	{
 		try
 		{
 			db.Projects.Add(project);
 			db.SaveChanges();
 			return RedirectToAction("Index");
		} catch (Exception e)
		{
			return View();
		}
	}

	public ActionResult Edit(int id)
	{
		Project project = db.Projects.Find(id);
		ViewBag.Project = project;
		return View();
	}

	[HttpPut]
	public ActionResult Edit(int id, Project requestProject)
	{
		try
		{
			Project project = db.Projects.Find(id);
			if (TryUpdateModel(project))
			{
				project.Name = requestProject.Name;
				db.SaveChanges();
			}
			return RedirectToAction("Index");
		} catch(Exception e) {
			return View();
		}
	}

	[HttpDelete]
	public ActionResult Delete(int id)
	{
		Project project = db.Projects.Find(id);
		db.Projects.Remove(project);
		db.SaveChanges();
		return RedirectToAction("Index");
	}
}