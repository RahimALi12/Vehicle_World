using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Vehicle_World.Models;


namespace Vehicle_World.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string buyerId, string sellerId, string message)
        {
            await Clients.User(buyerId).SendAsync("ReceiveMessage", message);
            await Clients.User(sellerId).SendAsync("ReceiveMessage", message);
        }

        public override async Task OnConnectedAsync()
        {
            // Handle connection
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            // Handle disconnection
            await base.OnDisconnectedAsync(exception);
        }
    }






    //public class ChatHub : Hub
    //{
        //private readonly ApplicationDbContext _context;

        //public ChatHub(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //    public async Task SendMessage(string buyerId, string sellerId, string message)
        //    {
        //        // Save the message to the database
        //        var chatMessage = new Chat
        //        {
        //            BuyerId = buyerId,
        //            SellerId = sellerId,
        //            Message = message,
        //            Timestamp = DateTime.Now
        //        };

        //        _context.Chats.Add(chatMessage);
        //        await _context.SaveChangesAsync();

        //        // Notify the clients
        //        await Clients.Group(buyerId).SendAsync("ReceiveMessage", chatMessage);
        //        await Clients.Group(sellerId).SendAsync("ReceiveMessage", chatMessage);
        //    }

        //    public override Task OnConnectedAsync()
        //    {
        //        var userId = Context.UserIdentifier;
        //        if (!string.IsNullOrEmpty(userId))
        //        {
        //            Groups.AddToGroupAsync(Context.ConnectionId, userId);
        //        }

        //        return base.OnConnectedAsync();
        //    }
        //}



    //}

    }












