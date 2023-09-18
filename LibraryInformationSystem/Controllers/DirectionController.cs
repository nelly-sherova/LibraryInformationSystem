using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryInformationSystem.Controllers
{
    public class DirectionController : Controller
    {
        // GET: DirectionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DirectionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DirectionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DirectionController/Create
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

        // GET: DirectionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DirectionController/Edit/5
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

        // GET: DirectionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DirectionController/Delete/5
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
