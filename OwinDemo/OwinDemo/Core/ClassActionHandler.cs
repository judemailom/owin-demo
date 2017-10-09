using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Core
{
  public class ClassActionHandler : IActionHandler
  {
    public string GetReAction(string action)
    {
      return "class action";
    }
  }
}