using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vehicle_World.Models;

namespace Vehicle_World.Controllers
{
    public class ChatController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> StartChat(string sellerId)
        {
            // Get the logged-in buyer
            var buyer = await _userManager.GetUserAsync(User);
            if (buyer == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Validate sellerId and ensure the seller exists
            var seller = await _userManager.FindByIdAsync(sellerId);
            if (seller == null)
            {
                return NotFound("Seller not found.");
            }

            // Now redirect to your chat page, passing both buyer and seller IDs
            return RedirectToAction("Index", new { buyerId = buyer.Id, sellerId = seller.Id });
        }

        public IActionResult Index(string buyerId, string sellerId)
        {
            // You can handle the chat logic and display here
            // Return the view for the chat page
            ViewBag.BuyerId = buyerId;
            ViewBag.SellerId = sellerId;
            return View();
        }
    }
}
