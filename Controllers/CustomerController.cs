using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloAutoMapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public CustomerController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public CustomerDTO GetDto()
        {
            var customer = new Customer
            {
                FirstName = "Steve",
                LastName = "Jobs",
                Address = new Address
                {
                    Street = "123 Easy Street",
                    City = "Cupertino",
                    State = "California",
                    Country = "USA",
                    PostalCode = "90045"
                }
            };
            // var customers = new List<Customer>
            // {
            //     customer
            // };
            // var result = _mapper.Map<IEnumerable<CustomerViewDTO>>(customers);
            var result = _mapper.Map<CustomerDTO>(customer);
            return result;
        }

        [HttpGet]
        [Route("flat")]
        public CustomerViewDTO Get()
        {
            var customer = new Customer
            {
                FirstName = "Steve",
                LastName = "Jobs",
                Address = new Address
                {
                    Street = "123 Easy Street",
                    City = "Cupertino",
                    State = "California",
                    Country = "USA",
                    PostalCode = "90045"
                }
            };
            // var customers = new List<Customer>
            // {
            //     customer
            // };
            // var result = _mapper.Map<IEnumerable<CustomerViewDTO>>(customers);
            var result = _mapper.Map<CustomerViewDTO>(customer);
            return result;
        }
    }
}
