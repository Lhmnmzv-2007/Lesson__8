using Sys_Lesson8.Models;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Dtos.Teacher;

namespace Sys_Lesson8.Repositories.Concretes;

public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
{
    public TeacherRepository(DbContext context) : base(context)
    {

    }
    public async Task<List<TeacherWithDepartmentName>> GetAllTeacherWithDepartmentNameAsync()
    {
        var teachers = await _dbSet.ToListAsync();

        var result = _dbSet.Select(x => new TeacherWithDepartmentName()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            DepartmentName = x.IdDepNavigation.Name
        }).ToList();

        return result;
    }

}
