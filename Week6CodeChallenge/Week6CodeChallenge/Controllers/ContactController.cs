using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
[HttpGet]
        public ActionResult Index()
        {
            return PartialView(new Models.ContactForm());
        }

       
        [HttpPost]
        public ActionResult Index(Models.ContactForm contact)
        {
       
            MailMessage message = new MailMessage("theRobots@seedpaths.com", "forrestmbrink@gmail.com");
   
            message.Subject = "Message from " + contact.FirstName;
    
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Hey Bro, you have a new message.");
            sb.AppendLine();
            sb.AppendLine("From: " + contact.FirstName + " " + contact.LastName);
            sb.AppendLine("Their Email: " + contact.Email);
            sb.AppendLine();
            sb.AppendLine("The Message: " + contact.Comment);
            sb.AppendLine();
            sb.AppendLine("I love you,");
            sb.AppendLine(); 
            message.Body = sb.ToString();      
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Send(message);
            
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return PartialView();
        }

    }
}
