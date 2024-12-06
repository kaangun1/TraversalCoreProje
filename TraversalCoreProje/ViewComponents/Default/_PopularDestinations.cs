using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Views;

public class _PopularDestinations:ViewComponent
{
     DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
   
    public IViewComponentResult Invoke()
    {
        var values = destinationManager.TGetList();
        return View(values);
    }
}