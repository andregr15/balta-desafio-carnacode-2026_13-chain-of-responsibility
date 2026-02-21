namespace src.Requests.Extensions;

public static class ExpenseRequestExtensions
{
    public static bool ValidateReceipt(this ExpenseRequest request)
    {
        Console.WriteLine("  → Validando nota fiscal...");
        return true; // Simulação
    }

    public static bool CheckBudget(this ExpenseRequest request)
    {
        Console.WriteLine($"  → Verificando orçamento do departamento {request.Department}...");
        return true; // Simulação
    }

    public static bool CheckPolicy(this ExpenseRequest request)
    {
        Console.WriteLine("  → Verificando conformidade com política...");
        return true; // Simulação
    }

    public static bool CheckStrategicAlignment(this ExpenseRequest request)
    {
        Console.WriteLine("  → Verificando alinhamento estratégico...");
        return true; // Simulação
    }

    public static bool CheckBoardApproval(this ExpenseRequest request)
    {
        Console.WriteLine("  → Verificando aprovação do conselho...");
        return true; // Simulação
    }

    public static void RegisterApproval(this ExpenseRequest request, string approver)
    {
        Console.WriteLine($"  → Registrando aprovação por {approver}...");
    }
}
