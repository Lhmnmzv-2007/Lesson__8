using Sys_Lesson8.Models;
using Sys_Lesson8.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lesson8.Service;

public class StudentService
{
    private readonly UnitOfWork<Student> _uow;

    public StudentService(UnitOfWork<Student> uow)
    {
        _uow = uow;
    }

    public async Task TransactionOperations(Student STU, Student STA)
    {
        if (STU == null || STA == null) return;
        await _uow.BeginTransactionAsync();

        try
        {
            await _uow._repository.UpdateAsync(STU);

            await _uow._repository.AddAsync(STA);

            await _uow.SaveChangesAsync();
            await _uow.CommitTransactionAsync();

            Console.WriteLine("Emiliyyat tamamlandi");
        }
        catch (Exception ex)
        {
            await _uow.RollbackTransactionAsync();
            Console.WriteLine($"Xeta: {ex.Message}");
        }
    }
}
