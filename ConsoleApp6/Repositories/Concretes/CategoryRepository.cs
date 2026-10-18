using Sys_Lesson8.Models;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Generics;
using Sys_Lesson8.DbContexts;

namespace Sys_Lesson8.Repositories.Concretes;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private LibraryContext dbContext;

    public CategoryRepository(DbContext context) : base(context)
    {
    }

    public CategoryRepository(LibraryContext dbContext)
    {
        this.dbContext = dbContext;
    }
}
