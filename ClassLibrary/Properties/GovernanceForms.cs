namespace ClassLibrary.CreationalPatterns.Bridge.GovernanceForms;

public enum GovernanceForms
{
    Monarchy,
    Democracy,
    Dictatorship
}

public interface IGovernance
{
    GovernanceForms GovernanceForm { get; }
}

public class MonarchyGovernance : IGovernance
{
    public GovernanceForms GovernanceForm => GovernanceForms.Monarchy;
}

public class DemocracyGovernance : IGovernance
{
    public GovernanceForms GovernanceForm => GovernanceForms.Democracy;
}

public class DictatorshipGovernance : IGovernance
{
    public GovernanceForms GovernanceForm => GovernanceForms.Dictatorship;
}