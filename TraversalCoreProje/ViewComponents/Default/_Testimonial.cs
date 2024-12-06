using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Views;

public class _Testimonial:ViewComponent

{
    private TestimonialManager testiManager = new TestimonialManager(new EfTestimonialDal());
    public IViewComponentResult Invoke()
    {
        var valuse = testiManager.TGetList();
        return View(valuse);
    }
    
}