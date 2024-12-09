using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment;

public class _CommentList:ViewComponent
{
    CommentManager CommentManager = new CommentManager(new EfCommentDal());
    public IViewComponentResult Invoke(int id)
    {

        var values = CommentManager.TGetDestinationById(id).ToList();
        return View(values);
    }
}
