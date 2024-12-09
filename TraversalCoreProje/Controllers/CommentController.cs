using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Views;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;

public class CommentController:Controller
{
    CommentManager commentManager = new CommentManager(new EfCommentDal());
    [HttpGet]
    public PartialViewResult AddComment()
    {
        return PartialView();
    }
[HttpPost]
    public IActionResult AddComment(Comment p)
    {
        p.CommentState = true;
        p.DestinationID = 3;
        commentManager.TAdd(p);
        return RedirectToAction("Index","Destination");
    }
    
}