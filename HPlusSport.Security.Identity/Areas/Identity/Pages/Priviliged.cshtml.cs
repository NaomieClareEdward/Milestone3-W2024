using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HPlusSport.Security.Identity.Areas.Identity.Pages
{
    [Authorize]
    public class PriviligedModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
