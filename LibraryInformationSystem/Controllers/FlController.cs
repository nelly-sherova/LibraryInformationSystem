using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryInformationSystem.Controllers
{
    public class FlController : Controller
    {
        // GET: FlController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FlController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlController/Create
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

        // GET: FlController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlController/Edit/5
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

        // GET: FlController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlController/Delete/5
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
