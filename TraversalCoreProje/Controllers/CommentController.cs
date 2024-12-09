using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    public PartialViewResult AddComment(Comment p)
    {
        p.CommentState = true;
        commentManager.TAdd(p);
        return PartialView();
    }
    
}