using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Transportation.MVC.Areas.User.Controller
{
    public class RezervasyonController : Controllers
    {
        // GET: RezervasyonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RezervasyonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RezervasyonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RezervasyonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RezervasyonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RezervasyonController/Edit/5
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

        // GET: RezervasyonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RezervasyonController/Delete/5
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
