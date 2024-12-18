using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Views;

public class _SubAbout:ViewComponent
{
    SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
    public IViewComponentResult Invoke()
    {
        var value = subAboutManager.TGetList();
        return View(value);
    }
}