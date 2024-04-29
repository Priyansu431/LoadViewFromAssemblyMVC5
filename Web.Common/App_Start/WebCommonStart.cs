using LoadViewFromAssembly.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(WebCommon.App_Start.WebCommonStart), "Start")]
namespace WebCommon.App_Start
{
    public static class WebCommonStart
    {
        public static void Start()
        {
            LoadAssembly.LoaadAssemblyViewsAndController(Assembly.GetExecutingAssembly());
        }
    }
}
