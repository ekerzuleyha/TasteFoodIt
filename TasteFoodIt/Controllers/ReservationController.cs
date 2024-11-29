using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class ReservationController : Controller
    {
        TasteContext context = new TasteContext();

        public ActionResult ReservationList()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }

        public ActionResult RezervationStatusOnayla(int id)
        {
            var value = context.Reservations.Find(id);
            value.ReservationStatus = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult RezervationStatusBeklet(int id)
        {
            var value = context.Reservations.Find(id);
            value.ReservationStatus = "Beklemede";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult RezervationStatusIptalEt(int id)
        {
            var value = context.Reservations.Find(id);
            value.ReservationStatus = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        [HttpPost]
        public ActionResult CreateReservation(Reservation r)
        {
            context.Reservations.Add(r);
            context.SaveChanges();
            return RedirectToAction("NavbarReservation","Default");
        }

        public ActionResult DeleteReservation(int id)
        {
            var value = context.Reservations.Find(id);
            context.Reservations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        [HttpGet]
        public ActionResult UpdateReservation(int id)
        {
            var value = context.Reservations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateReservation(Reservation r)
        {
            var value = context.Reservations.Find(r.ReservationId);
            value.Name = r.Name;
            value.Email = r.Email;
            value.Phone = r.Phone;
            value.ReservationDate = r.ReservationDate;
            value.GuestCount = r.GuestCount;
            value.Time = r.Time;
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
    }
}