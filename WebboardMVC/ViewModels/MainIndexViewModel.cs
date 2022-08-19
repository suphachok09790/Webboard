using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebboardMVC.Models.db;

namespace WebboardMVC.ViewModels
{
    public class MainIndexViewModel
    {
        public DbSet<Category> CategoriesLists { get; set; }
        public IQueryable<Kratoo> KraoosLists { get; set; }


    }
}
