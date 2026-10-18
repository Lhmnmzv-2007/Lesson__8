using Sys_Lesson8.Models;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Generics;

namespace Sys_Lesson8.Repositories.Concretes;

public class TCardRepository : GenericRepository<TCard>, ITCardRepository
{
    public TCardRepository(DbContext context) : base(context)
    {
    }
}
