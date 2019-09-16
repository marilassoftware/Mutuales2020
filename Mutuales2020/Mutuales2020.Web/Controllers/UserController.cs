using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mutuales2020.Web.Data.Entities;
using Mutuales2020.Web.Helpers;
using Mutuales2020.Web.Models;
using System.Threading.Tasks;

namespace Mutuales2020.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserHelper _userHelper;
        private readonly IMailHelper _mailHelper;

        public UserController(IUserHelper userHelper,
            IMailHelper mailHelper)
        {
            _userHelper = userHelper;
            _mailHelper = mailHelper;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddUserViewModel model)
        {
            var user = new User
            {
                Address = model.Address,
                Document = model.Document,
                Email = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Username
            };

            var result = await _userHelper.AddUserAsync(user, model.Password);
            if (result != IdentityResult.Success)
            {
                ModelState.AddModelError(string.Empty, "User with this mail already exists.");
                return View(model);
            }

            var myToken = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
            var tokenLink = Url.Action("ConfirmEmail", "Account", new
            {
                userid = user.Id,
                token = myToken
            }, protocol: HttpContext.Request.Scheme);

            _mailHelper.SendMail(model.Username, "Email confirmation",
                $"<table style = 'max-width: 600px; padding: 10px; margin:0 auto; border-collapse: collapse;'>" +
                $"  <tr>" +
                $"    <td style = 'background-color: #34495e; text-align: center; padding: 0'>" +
                $"       <a href = 'https://www.facebook.com/NuskeCIV/' >" +
                $"         <img width = '20%' style = 'display:block; margin: 1.5% 3%' src= 'https://veterinarianuske.com/wp-content/uploads/2016/10/line_separator.png'>" +
                $"       </a>" +
                $"  </td>" +
                $"  </tr>" +
                $"  <tr>" +
                $"  <td style = 'padding: 0'>" +
                $"     <img style = 'padding: 0; display: block' src = 'https://veterinarianuske.com/wp-content/uploads/2018/07/logo-nnske-blanck.jpg' width = '100%'>" +
                $"  </td>" +
                $"</tr>" +
                $"<tr>" +
                $" <td style = 'background-color: #ecf0f1'>" +
                $"      <div style = 'color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>" +
                $"            <h1 style = 'color: #e67e22; margin: 0 0 7px' > Hola </h1>" +
                $"                    <p style = 'margin: 2px; font-size: 15px'>" +
                $"                      El mejor Hospital Veterinario Especializado de la Ciudad de Morelia enfocado a brindar servicios médicos y quirúrgicos<br>" +
                $"                      aplicando las técnicas más actuales y equipo de vanguardia para diagnósticos precisos y tratamientos oportunos..<br>" +
                $"                      Entre los servicios tenemos:</p>" +
                $"      <ul style = 'font-size: 15px;  margin: 10px 0'>" +
                $"        <li> Urgencias.</li>" +
                $"        <li> Medicina Interna.</li>" +
                $"        <li> Imagenologia.</li>" +
                $"        <li> Pruebas de laboratorio y gabinete.</li>" +
                $"        <li> Estetica canina.</li>" +
                $"      </ul>" +
                $"  <div style = 'width: 100%;margin:20px 0; display: inline-block;text-align: center'>" +
                $"    <img style = 'padding: 0; width: 200px; margin: 5px' src = 'https://veterinarianuske.com/wp-content/uploads/2018/07/tarjetas.png'>" +
                $"  </div>" +
                $"  <div style = 'width: 100%; text-align: center'>" +
                $"    <h2 style = 'color: #e67e22; margin: 0 0 7px' >Email Confirmation </h2>" +
                $"    To allow the user,plase click in this link:</ br ></ br > " +
                $"    <a style ='text-decoration: none; border-radius: 5px; padding: 11px 23px; color: white; background-color: #3498db' href = \"{tokenLink}\">Confirm Email</a>" +
                $"    <p style = 'color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0' > Nuskë Clinica Integral Veterinaria 2019 </p>" +
                $"  </div>" +
                $" </td >" +
                $"</tr>" +
                $"</table>");

            ViewBag.Message = "The instructions to allow your user has been sent to email.";
            return View(model);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}