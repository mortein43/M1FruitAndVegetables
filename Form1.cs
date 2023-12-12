namespace M1FruitAndVegetables
{
    public partial class Form1 : Form
    {
        private DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();
            _ = db.PrintAllInfo(this.dataGridView1, this.comboBox1, this.label5);
            this.comboBox1.SelectedIndex = 0;
            this.radioAll.Checked = true;
            this.inputColors.SelectedIndex = 0;
            this.inputCalories.SelectedIndex = 0;
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.PrintAllInfo(this.dataGridView1, this.comboBox1, this.label5);
        }

        private void allNames_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllNamesFruitsAndVegetables(this.dataGridView1, this.label5);
        }

        private void allColors_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllColors(this.dataGridView1, this.label5);
        }

        private void maxCaloric_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadMaxCaloric(this.dataGridView1, this.label5);
        }

        private void minCaloric_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadMinCaloric(this.dataGridView1, this.label5);
        }

        private void averageCalorie_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAverageCaloric(this.dataGridView1, this.label5);
        }

        private void amountOfVegetables_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAmountOfVegetables(this.dataGridView1, this.label5);
        }

        private void amountOfFruits_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAmountOfFruits(this.dataGridView1, this.label5);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllForColor(this.dataGridView1, this.inputColors.Text, this.radioButton1, this.label5);
        }

        private void amountForColors_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAmountForColors(this.dataGridView1, this.label5);
        }

        private void allOfGivenColor_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllForGivenColor(this.dataGridView1, this.inputColors.Text, this.allOfGivenColor, this.label5);
        }

        private void less_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllForLess(this.dataGridView1, int.Parse(this.inputCalories.Text), this.less, this.label5);
        }

        private void more_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllForMore(this.dataGridView1, int.Parse(this.inputCalories.Text), this.more, this.label5);
        }

        private void calorieRange_CheckedChanged(object sender, EventArgs e)
        {
            _ = db.LoadAllForCalorieRange(this.dataGridView1, (int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value, this.calorieRange, this.label5);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            _ = db.InsertDataAsync(this.insertName.Text, this.insertType.Text, this.insertColor.Text, (int)this.insertCaloric.Value, this.label5);
            _ = db.PrintAllInfo(this.dataGridView1, this.comboBox1, this.label5);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _ = db.UpdateDataAsync((int)this.updateId.Value, this.updateName.Text, this.updateType.Text, this.updateColor.Text, (int)this.updateCaloric.Value, this.label5);
            _ = db.PrintAllInfo(this.dataGridView1, this.comboBox1, this.label5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = db.DeleteDataAsync((int)this.deleteById.Value, this.label5);
            _ = db.PrintAllInfo(this.dataGridView1, this.comboBox1, this.label5);
        }
    }
}
