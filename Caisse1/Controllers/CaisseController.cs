using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caisse1.Controllers
{
    public class CaisseController : Controller
    {
        // GET: CaisseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CaisseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CaisseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaisseController/Create
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

        // GET: CaisseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CaisseController/Edit/5
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

        // GET: CaisseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CaisseController/Delete/5
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
