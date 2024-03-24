using CsProjeDemo1.Entities;
using CsProjeDemo1.Entities.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presentation.DAL;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryDbContext _context;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new LibraryDbContext();
        }

        private async void SetKitaplar()
        {
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Kitaplar = await _context.Set<Kitap>().ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int uyeNo, string ad, string soyad)
        {
            var uye = new Uye(ad, soyad, uyeNo);
            await _context.Set<Uye>().AddAsync(uye);
            _context.SaveChanges();

            ViewBag.Kitaplar = await _context.Set<Kitap>().ToListAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OduncAl(string create_isbn, string create_uyeno)
        {
            // abi bir yandan buraya bakýyorum bir yandan bizim iþ yerinden biriyle görüþüyorum bitince ararým
            ViewBag.Kitaplar = await _context.Set<Kitap>().ToListAsync();

            int uyeNo = Convert.ToInt32(create_uyeno);

            var uye = await _context.Set<Uye>().Where(u => u.UyeNo == uyeNo).FirstOrDefaultAsync();
            if(uye == null)
                return View("Index");

            var kitap = await _context.Set<Kitap>().Where(k => k.ISBN == create_isbn).FirstOrDefaultAsync();
            if (kitap == null)
                return View("Index");

            uye.KitapOduncAl(kitap);
            _context.SaveChanges();

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
