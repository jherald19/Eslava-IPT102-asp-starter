using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jherald Eslava", StudentId = "21-1481", StudentAge = "20" },
            new StudentInfoModel { Name = "Jericho Delos Santos", StudentId = "12-3457", StudentAge = "20" },
            new StudentInfoModel { Name = "John Christoper Rosqueta", StudentId = "12-3456", StudentAge = "20"},
            new StudentInfoModel { Name = "Juan Miguel Moises", StudentId = "12-3455", StudentAge = "21" }
        };

        return View(studentInfoArray);
    }
}
