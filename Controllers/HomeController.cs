using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Juanito Cambalo", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Japhet Ruiz", StudentId = "S002", StudentAge = "21" },
            new StudentInfoModel { Name = "Just Bons", StudentId = "S003", StudentAge = "22" }
        };

        return View(studentInfoArray);
    }
}
