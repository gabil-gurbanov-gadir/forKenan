using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;

namespace Vesperr.ViewComponents
{
    public class GetSetting:ViewComponent
    {
        private readonly VesperrContext _contex;

        public GetSetting(VesperrContext context)
        {
            _contex = context;
        }
        public IViewComponentResult Invoke()
        {
            SettingV settingV = _contex.SettingVs.ToList().FirstOrDefault();

            return View(settingV);
        }
    }
}
