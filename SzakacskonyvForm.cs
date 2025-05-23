using MySql.Data.MySqlClient;

namespace CSHARP25052101;

public partial class SzakacskonyvForm : Form
{

    private Dictionary<string, string> kategoriak = new()
    {
        { "l", "leves" },
        { "k", "készétel" },
        { "é", "édesség" },
        { "f", "fõzelék" },
    };

    public SzakacskonyvForm()
    {
        InitializeComponent();
        this.Load += SzakacskonyvForm_Load;
        txtKereses.TextChanged += TxtKereses_TextChanged;
        dgvEtelek.CellClick += DgvEtelek_CellClick;
    }

    private void DgvEtelek_CellClick(object? sender, DataGridViewCellEventArgs e)
        => rtbElkeszites.Text = 
        (string)dgvEtelek["colElkeszites", e.RowIndex].Value;

    private void TxtKereses_TextChanged(object? sender, EventArgs e)
        => Lekerdezes();

    private void SzakacskonyvForm_Load(object? sender, EventArgs e)
        => Lekerdezes();

    private void Lekerdezes()
    {
        dgvEtelek.Rows.Clear();
        rtbElkeszites.Clear();

        using MySqlConnection conn = new("server=127.0.0.1;database=szakacskonyv;uid=root;pwd=;");
        conn.Open();

        MySqlCommand command = new(
            "SELECT " +
            "etelek.nev AS etel," +
            " etelek.elkeszitesiido AS ido," +
            " etelek.besorolas AS kategoria," +
            " alapanyagok.nev AS alapanyag," +
            " hozzavalok.mennyiseg, " +
            "alapanyagok.mennyegyseg AS egyseg, " +
            "etelek.leiras AS elkeszites " +
            "FROM etelek INNER JOIN hozzavalok ON etelek.etelid = hozzavalok.etelid INNER JOIN alapanyagok ON alapanyagok.anyagid = hozzavalok.anyagid " +
            $"WHERE etelek.nev LIKE '{txtKereses.Text}%' " +
            "ORDER BY etelek.nev ASC;", conn);

        MySqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            dgvEtelek.Rows.Add(
                (string)reader["etel"],
                (int)reader["ido"],
                kategoriak[(string)reader["kategoria"]],
                (string)reader["alapanyag"],
                (int)reader["mennyiseg"],
                (string)reader["egyseg"],
                (string)reader["elkeszites"]);
        }
    }
}
