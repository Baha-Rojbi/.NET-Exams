using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class InvitationController : Controller
    {
        //Injection par constructeur 
        IServiceInvite serviceInvite;
        IServiceFete serviceFete;
        IServiceInvitation serviceInvitation;

        public InvitationController(IServiceInvite serviceInvite, IServiceFete serviceFete, IServiceInvitation serviceInvitation)
        {
            this.serviceInvite = serviceInvite;
            this.serviceFete = serviceFete;
            this.serviceInvitation = serviceInvitation;
        }

        // GET: InvitationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InvitationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvitationController/Create
        public ActionResult Create()
        {
            ViewBag.Fete = new SelectList(serviceFete.GetAll(), "FeteId", "Description");
            ViewBag.Invite = new SelectList(serviceInvite.GetAll(), "InviteId", "Nom");

            return View();
        }

        // POST: InvitationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Invitation invitation)
        {
            try
            {
                serviceInvitation.Add(invitation);
                serviceInvitation.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvitationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvitationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvitationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvitationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
