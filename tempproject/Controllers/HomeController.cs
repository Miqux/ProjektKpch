using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tempproject.BlobStoragesda;
using tempproject.Models;

namespace tempproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlobStorageService _blobStorage;
        public HomeController(IBlobStorageService blobStorage)
        {
            _blobStorage = blobStorage;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _blobStorage.GetAllBlobFiles());
        }

        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile files)
        {
            await _blobStorage.UploadBlobFileAsync(files);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string blobName)
        {
            await _blobStorage.DeleteDocumentAsync(blobName);
            return RedirectToAction("Index", "Home");
        }
    }
}
