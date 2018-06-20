using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test.Models;

namespace test.Controllers
{
    public class CalculatorController : ApiController
    {
        // GET: api/Calculator
        public IEnumerable<Calculator> Get()
        {
            var calculatorList = new List<Calculator>();
            for (int i = 0; i < 11; i++)
            {
               var Calculator = new Calculator
                {
                    Location = $"Location {i}",
                    Degree = i * 20 / 15,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                calculatorList.Add(Calculator);
             
            }
            return calculatorList;
        }

        // GET: api/Calculator/5
        public Calculator Get(int id)
        {
            return new Calculator
            {
                Location = $"Location {id}",
                Degree = id * 20 / 15,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }


    }
}
