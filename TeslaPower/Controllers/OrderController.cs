using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeslaPower.Models;
using System.Data.Entity;
namespace TeslaPower.Controllers
{
    public class OrderController : Controller
    {
        TeslaEntities te = new TeslaEntities();
        public ViewResult Index()
        {
            var orders = te.Orders;
            return View(orders);
        }
        [HttpGet]
        public ViewResult NewOrder()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult NewOrder(Order od)
        {
            te.Orders.Add(od);
            te.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult ViewOrder()
        {
            ViewBag.poNo = new SelectList(te.Orders, "poNo", "poNo");
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult ViewOrder(Order od)
        {
            return RedirectToAction("ViewOrderById", new { id = od.poNo });
        }
        public ViewResult ViewOrderById(int id)
        {
            ViewBag.poNo = new SelectList(te.Orders, "poNo", "poNo");
            var od = te.Orders.Find(id);
            return View(od);
        }
        [HttpPost]
        public ViewResult ViewOrderById(Order od)
        {
            ViewBag.poNo = new SelectList(te.Orders, "poNo", "poNo");
            Order obj = te.Orders.Find(od.poNo);
            return View(obj);
        }
        public ActionResult EditOrder(int id)
        {
            var od = te.Orders.Find(id);
            return View(od);
        }
        [HttpPost]
        public ActionResult EditOrder(Order od)
        {
            te.Entry(od).State = EntityState.Modified;
            te.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult ViewItem(int poNo)
        {
            OrderItems orderitem = new OrderItems();
            orderitem.order = te.Orders.Find(poNo);
            orderitem.items = te.Items.Where(i => i.poNo == poNo).ToList();
            return View(orderitem);
        }
        [HttpGet]
        public ViewResult AddItem(int poNo)
        {
            ViewBag.DiNo = new SelectList(te.Designs, "DiNo", "DiNo");
            OrderItems orderitem = new OrderItems();
            orderitem.order = te.Orders.Find(poNo);
            return View(orderitem);
        }
        [HttpPost]
        public RedirectToRouteResult AddItem(OrderItems oi)
        {
            Item item = oi.items[0];
            item.poNo = oi.order.poNo;
            te.Items.Add(item);
            te.SaveChanges();
            return RedirectToAction("ViewItem", new { poNo = oi.order.poNo });
        }
        [HttpGet]
        public ViewResult EditItem(int id)
        {
            ViewBag.DiNo = new SelectList(te.Designs, "DiNo", "DiNo");
            var item = te.Items.Find(id);
            return View(item);
        }

        [HttpPost]
        public RedirectToRouteResult EditItem(Item I)
        {
            te.Entry(I).State = EntityState.Modified;
            te.SaveChanges();
            return RedirectToAction("ViewItem", new { poNo = I.poNo });
        }
    }
}