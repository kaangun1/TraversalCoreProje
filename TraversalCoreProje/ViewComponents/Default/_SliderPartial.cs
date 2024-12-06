using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Views;

public class _SliderPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}