using src.Requests;
using src.Requests.Extensions;

namespace src.Models;

public class Manager : Approver
{
    public override void Approve(ExpenseRequest request)
    {
        if (request.Amount <= 500)
        {
            Console.WriteLine("[Supervisor] Valor acima do meu limite, encaminhando...");
            Console.WriteLine("[Gerente] Analisando pedido...");

            if (request.ValidateReceipt() && request.CheckBudget() &&
                request.CheckPolicy())
            {
                Console.WriteLine($"✅ [Gerente] Despesa de R$ {request.Amount:N2} APROVADA");
                request.RegisterApproval("Gerente");
            }
            else
            {
                Console.WriteLine($"❌ [Gerente] Despesa REJEITADA");

            }
        }
        else
            Next?.Approve(request);
    }
}
