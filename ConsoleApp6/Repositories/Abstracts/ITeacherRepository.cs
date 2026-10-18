using Sys_Lesson8.Dtos.Student;
using Sys_Lesson8.Dtos.Teacher;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;


namespace Sys_Lesson8.Repositories.Abstracts;

public interface ITeacherRepository : IGenericRepository<Teacher>
{
    Task<List<TeacherWithDepartmentName>> GetAllTeacherWithDepartmentNameAsync();
}
