namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {
    /// <summary>
    /// Interface IChartRenderer
    /// </summary>
    public interface IChartRenderer
    {
        DbChart Chart { get; set; }
        DotAccessData Data { get; set; }
        DotAccessData Options { get; set; }
        string GetContainer(int width, int height);
        string GetScript(int width, int height);
    }
} // End Partial class
