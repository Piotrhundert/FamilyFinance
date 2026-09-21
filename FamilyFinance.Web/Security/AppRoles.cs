namespace FamilyFinance.Web.Security;

public static class AppRoles
{
    public const string Administrator = "Administrator";
    public const string Domownik = "Domownik";
    public const string Gosc = "Gość";

    public static IReadOnlyCollection<string> All { get; } =
    [
        Administrator,
        Domownik,
        Gosc
    ];
}
