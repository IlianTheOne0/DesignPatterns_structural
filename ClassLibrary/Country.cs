namespace ClassLibrary.StructuralPatterns.Bridge.NCountry;
using ClassLibrary.StructuralPatterns.Bridge.GovernanceForms;
using ClassLibrary.StructuralPatterns.Bridge.Religion;

public class Country
{
    private IGovernance _governance;
    private IReligion _religion;
    public string Name { get; set; }

    public Country(string name, IGovernance governance, IReligion religion) { Name = name; _governance = governance; _religion = religion; }

    public GovernanceForms GovernanceForm => _governance.GovernanceForm;
    public Religion Religion => _religion.Religion;

    public void SetGovernance(IGovernance governance) => _governance = governance;
    public void SetReligion(IReligion religion) => _religion = religion;
}