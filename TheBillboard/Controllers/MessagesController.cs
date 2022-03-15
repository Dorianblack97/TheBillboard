using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageGateway _messageGateway;
        private readonly ILogger _logger;
        public MessagesController(IMessageGateway messageGateway, ILogger<MessagesController> logger)
        {
            _messageGateway = messageGateway;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var message = _messageGateway.GetMessages();
            return View(message);
        }
        public IActionResult Detail(int id)
        {
            var message = _messageGateway.GetMessage(id);
            return View(message);
        }

        public IActionResult Delete(int id)
        {
            _messageGateway.DeleteMessage(id);
            return View(id);
        }

        [HttpPost]
        public void Create([FromForm] Message message)
        {
            _logger.LogInformation($"Message received: {message.Title}");
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
