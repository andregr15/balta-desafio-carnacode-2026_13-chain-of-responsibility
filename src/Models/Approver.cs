namespace src.Models;

using src.Requests;

public abstract class Approver
{
    protected Approver? Next;

    public Approver SetNext(Approver next)
    {
        Next = next;
        return next;
    }

    public abstract void Approve(ExpenseRequest request);
}
