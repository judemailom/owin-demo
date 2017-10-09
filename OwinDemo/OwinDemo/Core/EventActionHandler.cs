using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Core
{
  public class EventActionHandler : IActionHandler
  {
    public string GetReAction(string action)
    {
      return "event action";
    }
  }
}