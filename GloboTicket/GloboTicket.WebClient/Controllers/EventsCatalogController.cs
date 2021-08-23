using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloboTicket.WebClient.Models.View;
namespace GloboTicket.WebClient.Controllers
{
    public class EventsCatalogController: Controller
    {
        public IActionResult Index()
        {
            return View(new EventListModel { });
        }

    }
}
