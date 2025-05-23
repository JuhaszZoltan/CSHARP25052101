namespace CSHARP25052101;
internal class Hozzavalo
{
    public string Nev { get; set; }
    public string Kategoria { get; set; }
    public int Mennyiseg { get; set; }
    public string Egyseg { get; set; }
    public override string ToString()
        => $"- {Mennyiseg} {Egyseg} {Nev}";
}
