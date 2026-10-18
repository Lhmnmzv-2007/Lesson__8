using Sys_Lesson8.Models;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Generics;

namespace Sys_Lesson8.Repositories.Concretes;

public class PressRepository : GenericRepository<Press>, IPressRepository
{
    public PressRepository(DbContext context) : base(context)
    {
    }
}
