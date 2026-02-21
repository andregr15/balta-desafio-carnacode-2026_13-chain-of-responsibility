using src.Requests;
using src.Service;

Console.WriteLine("=== Sistema de Aprovação de Despesas ===");

var expenseSystemService = new ExpenseApprovalSystemService();

var expense1 = new ExpenseRequest("João Silva", 50.00m, "Material de escritório", "TI");
expenseSystemService.ProcessExpense(expense1);

var expense2 = new ExpenseRequest("Maria Santos", 350.00m, "Curso de capacitação", "RH");
expenseSystemService.ProcessExpense(expense2);

var expense3 = new ExpenseRequest("Pedro Oliveira", 2500.00m, "Notebook", "TI");
expenseSystemService.ProcessExpense(expense3);

var expense4 = new ExpenseRequest("Ana Costa", 15000.00m, "Servidor para datacenter", "TI");
expenseSystemService.ProcessExpense(expense4);