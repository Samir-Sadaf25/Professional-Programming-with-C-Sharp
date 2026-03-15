using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.AnotherExample
{
    
    public class OrderService
    {
        private readonly OrderRepository _repository;
        private readonly EmailService _emailService;
        private readonly Logger _logger;
        
        public OrderService(OrderRepository repository, EmailService emailService, Logger logger)
        {
            _repository = repository;
            _emailService = emailService;
            _logger = logger;
        }
        public void CreateOrder(Order order)
        {
        
            _emailService.Send(order);
            _logger.Log(order);
            _repository.Save(order);
            //Now each class has one responsibility.
        }
    }
}
