using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "John Does", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Jane Smith", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Mike Johnson", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
