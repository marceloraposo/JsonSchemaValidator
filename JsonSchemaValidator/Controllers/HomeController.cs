using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JsonSchemaValidator.Models;
using JsonSchemaValidator.Domain;
using JsonSchemaValidator.Extensions;

namespace JsonSchemaValidator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new Models.SchemaValidator();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Validator(Models.SchemaValidator model)
        {
            if(!ModelState.IsValid)
                return View("Index",model);

            IList<string> validations = null;

            try
            {
                Domain.SchemaValidator.ValidateSchema(model.Schema, model.Data, out validations);

                model.Errors = validations?.ToFormatedHtmlString();
            }
            catch (Exception exception)
            {
                model.Errors = exception.Message;
            }

            return View("Index",model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
