using src.Requests;
using src.Requests.Extensions;

namespace src.Models;

public class Director : Approver
{
    public override void Approve(ExpenseRequest request)
    {
        if (request.Amount <= 5000)
        {
            // Diretor pode aprovar
            Console.WriteLine("[Supervisor] Valor acima do meu limite, encaminhando...");
            Console.WriteLine("[Gerente] Valor acima do meu limite, encaminhando...");
            Console.WriteLine("[Diretor] Analisando pedido...");

            if (request.ValidateReceipt()
                && request.CheckBudget()
                && request.CheckPolicy()
                && request.CheckStrategicAlignment()
            )
            {
                Console.WriteLine($"✅ [Diretor] Despesa de R$ {request.Amount:N2} APROVADA");
                request.RegisterApproval("Diretor");
            }
            else
            {
                Console.WriteLine($"❌ [Diretor] Despesa REJEITADA");
            }
        }
        else
            Next?.Approve(request);
    }
}
