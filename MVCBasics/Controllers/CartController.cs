using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class CartController : Controller
    {
        TruyumContext _context;
        public CartController()
        {
            _context = new TruyumContext();
        }
        // GET: Cart
        public ActionResult Index()
        {
            var Cartlist = _context.Cart.FirstOrDefault(c => c.UserId == 1);
            var list = new List<MenuItem>();
            if (Cartlist.ItemList != null)
            {
                list = Cartlist.ItemList.ToList();
            }
            return View(list);
        }
        public ActionResult Add(int id)
        {
            // if cart for User(1) is empty
            if (_context.Cart.FirstOrDefault(c => c.UserId == 1) == null)
            {
                _context.Cart.Add(new Cart() { UserId = 1 });
                _context.SaveChanges();
            }
            // else go on!!!!!
            var item = _context.MenuItems.Find(id);
            item.CartId = _context.Cart.FirstOrDefault(c => c.UserId == 1).Id;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var item = _context.MenuItems.Find(id);
            item.CartId = null;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}