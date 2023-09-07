using RestaurantWebOrder.Models;
using RestaurantWebOrder.Models.Domain;
using RestaurantWebOrder.EntityData;
using Microsoft.AspNetCore.Mvc;



namespace RestaurantWebOrder.Controllers
{
    public class OrderController : Controller
    {
        private readonly EntityDB entity;

        public OrderController(EntityDB entity)
        {
            this.entity = entity;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddOrderModel AddRequestOrder)
        {
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                CustomerName=AddRequestOrder.CustomerName,
                ItemName=AddRequestOrder.ItemName,
                ItemType=AddRequestOrder.ItemType,
            };
            await entity.Orders.AddAsync(order);
           await entity.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
