namespace CSHARP25052101
{
    public partial class SzakacskonyvForm : Form
    {

        /*SELECT etelek.nev, etelek.elkeszitesiido, etelek.besorolas, alapanyagok.nev, hozzavalok.mennyiseg, alapanyagok.mennyegyseg FROM etelek INNER JOIN hozzavalok ON etelek.etelid = hozzavalok.etelid INNER JOIN alapanyagok ON alapanyagok.anyagid = hozzavalok.anyagid ORDER BY etelek.nev ASC;*/
        public SzakacskonyvForm()
        {
            InitializeComponent();
        }
    }
}
