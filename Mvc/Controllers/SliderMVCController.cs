/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.1.0.22
</auto-generated>
------------------------------------------------------------------------------ */

using SFDev2022.Mvc.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SFDev2022.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "SliderMVC", Title = "Slider MVC", SectionName = "SFDev2022")]
	public class SliderMVCController : Controller, IPersonalizable
	{
		// GET: SliderMVC
		public ActionResult Index()
		{
			var items = RetrieveCollectionOfParallaxItems();
			var model = new SliderMVCModel(items);
			
			return View(model);
		}

		public IQueryable<DynamicContent> RetrieveCollectionOfParallaxItems()
		{
			var providerName = "OpenAccessProvider";
			DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
			Type parallaxitemType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Carousel.Slide");

			var myCollection = dynamicModuleManager.GetDataItems(parallaxitemType).Where(p => p.Status == ContentLifecycleStatus.Live);

			return myCollection;
		}

		protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }

	}
}