using Microsoft.AspNetCore.Mvc;
using IdentityServer.UI.Configuration;

namespace IdentityServer.UI.ViewComponents
{
    public class IdentityServerAdminLinkViewComponent : ViewComponent
    {
        private readonly IRootConfiguration _configuration;

        public IdentityServerAdminLinkViewComponent(IRootConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}