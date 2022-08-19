using System.Linq;
using WebboardMVC.Models.db;

namespace WebboardMVC.ViewModels
{
    public class KratooCommentsViewModel
    {
        public Kratoo Kratoo { get; set; }
        public IQueryable<Comment> CommentsLists { get; set; }
    }
}
