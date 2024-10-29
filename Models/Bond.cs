namespace VueFinanceNET.Models;

public class Bond : Asset
{
    public DateOnly Date { get; set; }
    public decimal Value { get; set; }
    public decimal Rate { get; set; }
    public int Days { get; set; }
    public decimal Tax { get; set; }
}