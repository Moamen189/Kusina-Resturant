using Microsoft.AspNetCore.Mvc;


using System.Net.Mail;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.ActionResults;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoProject3.umbraco.models;

namespace UmbracoProject3.Controllers
{
  
    public class ContactFormController : SurfaceController
    {
        public ContactFormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }



        [HttpPost]
        public IActionResult SubmitForm(ContentForm model)
        {
            if (ModelState.IsValid)
            {
                //MailMessage mailMessage = new MailMessage(model.Email, "admin@admin.com");
                //mailMessage.Subject = model.Subject;
                //mailMessage.Body = model.Message;

                //SmtpClient smtpClient = new SmtpClient("127.0.0.1", 51719);
                //smtpClient.Send(mailMessage);
                TempData["ContactResult"] = "Mas been sent .......";
                return RedirectToCurrentUmbracoPage();
            }
            //return View();

            return CurrentUmbracoPage();

        }
    }
}
