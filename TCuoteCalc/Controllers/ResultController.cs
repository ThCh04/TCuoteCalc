using Microsoft.AspNetCore.Mvc;

namespace TCuoteCalc.Controllers
{
    public class ResultController : Controller
    {
        private readonly ILogger<ResultController> _logger;

        public ResultController(ILogger<ResultController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult ResultView(string percentxt, int months, double amount)
        {
            double perc = 0;
            double totalamount = 0;
            double total = 0;

            if (string.IsNullOrEmpty(percentxt) == false)
            {
                switch (percentxt)
                {
                    case "22%":
                        perc = 0.22;
                        break;
                    case "12%":
                        perc = 0.12;
                        break;
                    case "8%":
                        perc = 0.08;
                        break;
                }
            }
            
            totalamount= amount +(amount*perc);
            total = Convert.ToInt32(totalamount/months);
            ViewBag.totalmonths= total;
            return View();
        }
    }
}
