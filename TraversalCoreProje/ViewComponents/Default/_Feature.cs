using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Views;

public class _Feature:ViewComponent
{
    private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
    public IViewComponentResult Invoke()
    {
       // var values = featureManager.TGetList();
       // ViewBag.image1=featureManager.get
        return View();
    }
    
}