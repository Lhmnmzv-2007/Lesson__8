using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Dtos.Teacher;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;

namespace Sys_Lesson8.Repositories.Concretes;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(DbContext context) : base(context)
    {
    }
    
}
