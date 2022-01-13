using ClientECommerce.Models;
using ClientECommerce.Models.ViewModels;
using ClientECommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientECommerce.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ViewOrders(int pg = 1)
        {

            var repository = new OrderRepository();

            var ordersTask = await repository.GetOrderProductsAsync();

            const int pageSize = 3;
            if (pg < 1)
                pg = 1;

            int recsCount = ordersTask.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var result = ordersTask.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            return View(result);
        }
        public async Task<ActionResult> ViewGraph()
        {
            var repository = new OrderRepository();

            var ordersTask = await repository.GetOrderProductsAsync();

            var teamNames = ordersTask.Select(e => e.Team.Name).Distinct().ToList();
            var teamOrderNumbers = new List<int>();

            foreach (var teamName in teamNames)
            {
                var teamOrdersNumber = ordersTask.Where(e => e.Team.Name == teamName).Distinct().Count();
                teamOrderNumbers.Add(teamOrdersNumber);
            }
            this.ViewBag.TeamNames = teamNames;
            this.ViewBag.TeamOrderNumbers = teamOrderNumbers;

            return View();
        }

    }
}
