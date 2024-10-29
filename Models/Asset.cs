namespace VueFinanceNET.Models;

public class Asset
{
    public static Guid Guid { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}