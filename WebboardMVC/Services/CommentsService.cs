using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebboardMVC.Models.db;
namespace WebboardMVC.Services
{
    public class CommentsService
    {
        private readonly thaivbWebboardContext _db;

        public CommentsService(thaivbWebboardContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Comment>> CommentsByKid(int id)
        {
            IQueryable<Comment> cs = _db.Comments
               .OrderBy(c => c.CommentNo)
               .Where(i => i.IsShow == true)
               .Where(j => j.Kid == id);

            return await cs.ToListAsync();

        }
    }
}
