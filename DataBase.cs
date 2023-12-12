using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace M1FruitAndVegetables;

internal class DataBase
{
    private readonly string sqliteFile = Path.Combine("data source=FruitsAndVegetables.sqlite");
    private const string PROVIDER_INVARIANT_NAME = "Microsoft.Data.Sqlite";
    private DbProviderFactory dbProviderFactory;
    private DbConnection connection;


    public DataBase()
    {
        DbProviderFactories.RegisterFactory(PROVIDER_INVARIANT_NAME, /*  */ SqliteFactory.Instance);
        dbProviderFactory = DbProviderFactories.GetFactory(PROVIDER_INVARIANT_NAME);
        connection = dbProviderFactory.CreateConnection();
        connection.ConnectionString = sqliteFile;


    }

    public async Task PrintAllInfo(DataGridView dataGridView1, ComboBox comboBox1, Label time)
    {
        DataTable t = DbProviderFactories.GetFactoryClasses();
        comboBox1.Items.Clear();

        foreach (DataRow dr in t.Rows)
        {
            comboBox1.Items.Add(dr["InvariantName"]);
        }

        dataGridView1.DataSource = string.Empty;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAllNamesFruitsAndVegetables(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Name FROM AllFruitsAndVegetables";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAllColors(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Color FROM AllFruitsAndVegetables GROUP BY Color";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadMaxCaloric(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();

        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Name, Type, Color, MAX(Caloric) AS Caloric FROM AllFruitsAndVegetables";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadMinCaloric(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();

        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Name, Type, Color, MIN(Caloric) AS Caloric FROM AllFruitsAndVegetables";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAverageCaloric(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT COALESCE('Average Caloric', 'Average Caloric') AS Name,  AVG(Caloric) AS Caloric FROM AllFruitsAndVegetables";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAmountOfVegetables(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();

        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT COALESCE('Vegetables', null) AS Type,  Count(Type) AS Number FROM AllFruitsAndVegetables WHERE Type = 'Vegetable'";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAmountOfFruits(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT COALESCE('Fruits', null) AS Type,  Count(Type) AS Number FROM AllFruitsAndVegetables WHERE Type = 'Fruit'";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAllForColor(DataGridView dataGridView1, string inputColor, RadioButton radioButton, Label time)
    {
        if (radioButton.Checked)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();
            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT COALESCE('Fruits and Vegetables', null) AS Type,  Count(Color) AS Number FROM AllFruitsAndVegetables WHERE Color = @color";

            var parametr = command.CreateParameter();
            parametr.ParameterName = "@color";
            parametr.Value = inputColor;
            command.Parameters.Add(parametr);

            using DbDataReader reader = await command.ExecuteReaderAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
            DataTable dataTable = new();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

    }

    public async Task LoadAmountForColors(DataGridView dataGridView1, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Color,  Count(Color) AS Number FROM AllFruitsAndVegetables GROUP BY Color";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task LoadAllForGivenColor(DataGridView dataGridView1, string inputColor, RadioButton radioButton, Label time)
    {
        if (radioButton.Checked)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Color = @color";

            var parametr = command.CreateParameter();
            parametr.ParameterName = "@color";
            parametr.Value = inputColor;
            command.Parameters.Add(parametr);

            using DbDataReader reader = await command.ExecuteReaderAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
            DataTable dataTable = new();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

    }

    public async Task LoadAllForLess(DataGridView dataGridView1, int inputCalories, RadioButton radioButton, Label time)
    {
        if (radioButton.Checked)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Caloric < @calories";
            var parametr = command.CreateParameter();
            parametr.ParameterName = "@calories";
            parametr.Value = inputCalories;
            command.Parameters.Add(parametr);

            using DbDataReader reader = await command.ExecuteReaderAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
            DataTable dataTable = new();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }
    }

    public async Task LoadAllForMore(DataGridView dataGridView1, int inputCalories, RadioButton radioButton, Label time)
    {
        if (radioButton.Checked)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Caloric > @calories";
            var parametr = command.CreateParameter();
            parametr.ParameterName = "@calories";
            parametr.Value = inputCalories;
            command.Parameters.Add(parametr);

            using DbDataReader reader = await command.ExecuteReaderAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
            DataTable dataTable = new();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

    }

    public async Task LoadAllForCalorieRange(DataGridView dataGridView1, int first, int second, RadioButton radioButton, Label time)
    {
        if (radioButton.Checked)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();
            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE (Caloric > @caloriesFirst AND Caloric < @caloriesSecond) OR (Caloric < @caloriesFirst AND Caloric > @caloriesSecond)";

            var parametr1 = command.CreateParameter();
            parametr1.ParameterName = "@caloriesFirst";
            parametr1.Value = first;
            var parametr2 = command.CreateParameter();
            parametr2.ParameterName = "@caloriesSecond";
            parametr2.Value = second;
            command.Parameters.Add(parametr1);
            command.Parameters.Add(parametr2);

            using DbDataReader reader = await command.ExecuteReaderAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
            DataTable dataTable = new();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

    }

    public async Task InsertDataAsync(string name, string type, string color, int caloric, Label time)
    {
        if (name == "" || type == "" || color == "" || caloric == 0)
        {
            MessageBox.Show("Incorrectly filled inputs.");
        }
        else
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO AllFruitsAndVegetables (Name, Type, Color, Caloric) VALUES (@name, @type, @color, @caloric)";
            var parametr1 = command.CreateParameter();
            parametr1.ParameterName = "@name";
            parametr1.Value = name;
            var parametr2 = command.CreateParameter();
            parametr2.ParameterName = "@type";
            parametr2.Value = type;
            var parametr3 = command.CreateParameter();
            parametr3.ParameterName = "@color";
            parametr3.Value = color;
            var parametr4 = command.CreateParameter();
            parametr4.ParameterName = "@caloric";
            parametr4.Value = caloric;
            command.Parameters.Add(parametr1);
            command.Parameters.Add(parametr2);
            command.Parameters.Add(parametr3);
            command.Parameters.Add(parametr4);

            await command.ExecuteNonQueryAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
        }

    }

    public async Task UpdateDataAsync(int id, string name, string type, string color, int caloric, Label time)
    {
        if (name == "" || type == "" || color == "" || caloric == 0)
        {
            MessageBox.Show("Incorrectly filled inputs.");
        }
        else
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await connection.OpenAsync();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE AllFruitsAndVegetables SET Name = @name, Type = @type, Color = @color, Caloric = @caloric WHERE Id = @id";

            var parametr1 = command.CreateParameter();
            parametr1.ParameterName = "@name";
            parametr1.Value = name;
            var parametr2 = command.CreateParameter();
            parametr2.ParameterName = "@type";
            parametr2.Value = type;
            var parametr3 = command.CreateParameter();
            parametr3.ParameterName = "@color";
            parametr3.Value = color;
            var parametr4 = command.CreateParameter();
            parametr4.ParameterName = "@caloric";
            parametr4.Value = caloric;
            var parametr5 = command.CreateParameter();
            parametr5.ParameterName = "@id";
            parametr5.Value = id;
            command.Parameters.Add(parametr1);
            command.Parameters.Add(parametr2);
            command.Parameters.Add(parametr3);
            command.Parameters.Add(parametr4);
            command.Parameters.Add(parametr5);

            await command.ExecuteNonQueryAsync();
            stopwatch.Stop();
            time.Text = stopwatch.Elapsed.ToString() + " sec";
        }
    }

    public async Task DeleteDataAsync(int id, Label time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await connection.OpenAsync();

        DbCommand command = connection.CreateCommand();
        command.CommandText = "DELETE FROM AllFruitsAndVegetables WHERE Id = @id";

        var parametr1 = command.CreateParameter();
        parametr1.ParameterName = "@id";
        parametr1.Value = id;
        command.Parameters.Add(parametr1);

        await command.ExecuteNonQueryAsync();
        stopwatch.Stop();
        time.Text = stopwatch.Elapsed.ToString() + " sec";
    }
}
