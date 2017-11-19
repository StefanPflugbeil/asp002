using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalloWeb.Controllers
{
  public class FahrtenbuchController : Controller
  {
    public string Index()
    {
      return "Fahrtenbuch";
    }
  }
}
