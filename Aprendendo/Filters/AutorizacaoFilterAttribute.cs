using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aprendendo.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        //enquanto usuario esta acessando
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["usuario"];
            if(usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                            new { controller = "Login", action = "Index" }
                        )
                );
            }

            base.OnActionExecuting(filterContext);
        }
    }
}