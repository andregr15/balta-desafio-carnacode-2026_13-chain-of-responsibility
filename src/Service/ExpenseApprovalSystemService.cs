using src.Models;
using src.Requests;

namespace src.Service;

public class ExpenseApprovalSystemService
{
    public void ProcessExpense(ExpenseRequest request)
    {
        Console.WriteLine($"\n=== Processando Despesa ===");
        Console.WriteLine($"Funcionário: {request.EmployeeName}");
        Console.WriteLine($"Valor: R$ {request.Amount:N2}");
        Console.WriteLine($"Propósito: {request.Purpose}");
        Console.WriteLine($"Departamento: {request.Department}\n");

        var supervisor = new Supervisor();
        var manager = new Manager();
        var director = new Director();
        var ceo = new Ceo();

        supervisor.SetNext(manager).SetNext(director).SetNext(ceo);

        supervisor.Approve(request);
    }
}
