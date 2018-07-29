using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {

        public string Phone()
        {
            return "+447588111202";
        }

        public string Address()
        {
            return "UK";
        }
    }
}
