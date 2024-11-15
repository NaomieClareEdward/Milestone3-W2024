using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;
/* Course:        Web Programming 3
 * Assessment:    Milestone 3
 * Created By:    Naomie Edward 2242656
 * Date:          11/15/2024
 * Class Name:    HomeController.cs
 * Description:   Serves as the main entry point, rendering the home page and handling error responses with a view model containing request details for troubleshooting.  
 */
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
