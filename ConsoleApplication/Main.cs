namespace ClassLibrary.StructuralPatterns.Bridge;
using ClassLibrary.StructuralPatterns.Bridge.NCountry;
using ClassLibrary.StructuralPatterns.Bridge.GovernanceForms;
using ClassLibrary.StructuralPatterns.Bridge.Religion;

public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("App: Launched with the creating of governance and religion.");
        IGovernance governance = new MonarchyGovernance();
        IReligion religion = new ChristianityReligion();

        Console.WriteLine();

        Console.WriteLine("App: Launched with the creating of Country.");
        Country country = new Country("Utopia", governance, religion);

        Console.WriteLine();

        Console.WriteLine("App: Output initial state.");
        Console.WriteLine($"Country: {country.Name}");
        Console.WriteLine($"Governance: {country.GovernanceForm}");
        Console.WriteLine($"Religion: {country.Religion}");

        Console.WriteLine();

        Console.WriteLine("App: Change governance");
        country.SetGovernance(new DemocracyGovernance());
        country.SetReligion(new AtheismReligion());
        Console.WriteLine($"New Governance: {country.GovernanceForm}");
        Console.WriteLine($"New Religion: {country.Religion}");
    }
}