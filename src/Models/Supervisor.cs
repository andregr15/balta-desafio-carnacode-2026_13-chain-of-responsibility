namespace src.Models;

using src.Requests;
using src.Requests.Extensions;

public class Supervisor : Approver
{
    public override void Approve(ExpenseRequest request)
    {
        if (request.Amount <= 100)
        {
            Console.WriteLine("[Supervisor] Analisando pedido...");

            if (request.ValidateReceipt() && request.CheckBudget())
            {
                Console.WriteLine($"✅ [Supervisor] Despesa de R$ {request.Amount:N2} APROVADA");
                request.RegisterApproval("Supervisor");
            }
            else
            {
                Console.WriteLine($"❌ [Supervisor] Despesa REJEITADA - Documentação inválida");

            }
        }
        else
            Next?.Approve(request);
    }
}
