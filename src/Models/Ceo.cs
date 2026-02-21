using src.Requests;
using src.Requests.Extensions;

namespace src.Models;

public class Ceo : Approver
{
    public override void Approve(ExpenseRequest request)
    {
        Console.WriteLine("[Supervisor] Valor acima do meu limite, encaminhando...");
        Console.WriteLine("[Gerente] Valor acima do meu limite, encaminhando...");
        Console.WriteLine("[Diretor] Valor acima do meu limite, encaminhando...");
        Console.WriteLine("[CEO] Analisando pedido...");

        if (request.ValidateReceipt()
            && request.CheckBudget()
            && request.CheckPolicy()
            && request.CheckStrategicAlignment()
            && request.CheckBoardApproval()
        )
        {
            Console.WriteLine($"✅ [CEO] Despesa de R$ {request.Amount:N2} APROVADA");
            request.RegisterApproval("CEO");
        }
        else
        {
            Console.WriteLine($"❌ [CEO] Despesa REJEITADA");
        }
    }
}
