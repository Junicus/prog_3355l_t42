using System.Runtime.InteropServices.JavaScript;

namespace tarea_42;

public partial class MainForm : Form
{
    private readonly Dictionary<string, string[]> _airports;
    private readonly Dictionary<Route, decimal> _prices;

    public MainForm()
    {
        _airports = new Dictionary<string, string[]>
        {
            {
                "Puerto Rico",
                new[] { "San Juan - Luis Munoz Marin", "Ponce - Mercedita", "Mayaguez - Eugenio M. Hostos" }
            },
            {
                "USA",
                new[] { "New York - John F. Kennedy International Airport", "Florida - Miami International Airport", "Texas - Dallas-Fort Worth International Airport" }
            },
            {
                "Mexico",
                new[] { "Mexico City - Benito Juarez Airport", "Guadalajara - Miguel Hidalgo Airport", "Cancun - Cancun Airport" }
            }
        };
        _prices = new Dictionary<Route, decimal>
        {
            { new Route("Puerto Rico", "USA"), 500 },
            { new Route("Puerto Rico", "Mexico"), 800 },
            { new Route("USA", "Puerto Rico"), 400 },
            { new Route("USA", "Mexico"), 600 },
            { new Route("Mexico", "Puerto Rico"), 700 },
            { new Route("Mexico", "USA"), 600 }
        };

        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        lstPais.DataSource = _airports.Keys.ToList();
    }

    private void lstPais_SelectedValueChanged(object sender, EventArgs e)
    {
        lstCiudadAirport.DataSource = _airports[lstPais.SelectedValue.ToString()].ToList();
    }

    private void btnDeparture_Click(object sender, EventArgs e)
    {
        tbDeparturePais.Text = lstPais.SelectedValue.ToString();
        tbDepartureCiudadAirport.Text = lstCiudadAirport.SelectedValue.ToString();
    }

    private void btnArrival_Click(object sender, EventArgs e)
    {
        tbArrivalPais.Text = lstPais.SelectedValue.ToString();
        tbArrivalCiudadAirport.Text = lstCiudadAirport.SelectedValue.ToString();
    }

    private void btnCalcPrice_Click(object sender, EventArgs e)
    {
        if (tbDeparturePais.Text == tbArrivalPais.Text)
        {
            MessageBox.Show("Salida y Llegada no puede ser el mismo pais", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }


        var precio = _prices.Single(kvp =>
            kvp.Key.Departure == tbDeparturePais.Text && kvp.Key.Arrival == tbArrivalPais.Text);
        tbPrice.Text = precio.Value.ToString();
    }
}

public class Route
{
    public Route(string departure, string arrival)
    {
        Departure = departure;
        Arrival = arrival;
    }

    public string Departure { get; set; }
    public string Arrival { get; set; }
}
