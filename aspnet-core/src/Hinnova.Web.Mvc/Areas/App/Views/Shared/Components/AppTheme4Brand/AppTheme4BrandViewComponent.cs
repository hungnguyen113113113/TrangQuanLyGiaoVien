﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hinnova.Web.Areas.App.Models.Layout;
using Hinnova.Web.Session;
using Hinnova.Web.Views;

namespace Hinnova.Web.Areas.App.Views.Shared.Components.AppTheme4Brand
{
    public class AppTheme4BrandViewComponent : HinnovaViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
