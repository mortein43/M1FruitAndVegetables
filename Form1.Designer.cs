namespace M1FruitAndVegetables
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            radioAll = new RadioButton();
            allNames = new RadioButton();
            allColors = new RadioButton();
            maxCaloric = new RadioButton();
            minCaloric = new RadioButton();
            averageCalorie = new RadioButton();
            amountOfVegetables = new RadioButton();
            amountOfFruits = new RadioButton();
            radioButton1 = new RadioButton();
            inputColors = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            amountForColors = new RadioButton();
            allOfGivenColor = new RadioButton();
            label3 = new Label();
            inputCalories = new ComboBox();
            less = new RadioButton();
            more = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            calorieRange = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            insertName = new TextBox();
            insertType = new TextBox();
            insertColor = new TextBox();
            buttonInsert = new Button();
            insertCaloric = new NumericUpDown();
            label7 = new Label();
            updateId = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            updateName = new TextBox();
            updateType = new TextBox();
            updateColor = new TextBox();
            buttonUpdate = new Button();
            updateCaloric = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            deleteById = new NumericUpDown();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label12 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)insertCaloric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateCaloric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteById).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(966, 206);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 1;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Location = new Point(12, 74);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(60, 19);
            radioAll.TabIndex = 2;
            radioAll.TabStop = true;
            radioAll.Text = "AllInfo";
            radioAll.UseVisualStyleBackColor = true;
            radioAll.CheckedChanged += radioAll_CheckedChanged;
            // 
            // allNames
            // 
            allNames.AutoSize = true;
            allNames.Location = new Point(12, 99);
            allNames.Name = "allNames";
            allNames.Size = new Size(77, 19);
            allNames.TabIndex = 3;
            allNames.TabStop = true;
            allNames.Text = "All names";
            allNames.UseVisualStyleBackColor = true;
            allNames.CheckedChanged += allNames_CheckedChanged;
            // 
            // allColors
            // 
            allColors.AutoSize = true;
            allColors.Location = new Point(12, 124);
            allColors.Name = "allColors";
            allColors.Size = new Size(74, 19);
            allColors.TabIndex = 4;
            allColors.TabStop = true;
            allColors.Text = "All colors";
            allColors.UseVisualStyleBackColor = true;
            allColors.CheckedChanged += allColors_CheckedChanged;
            // 
            // maxCaloric
            // 
            maxCaloric.AutoSize = true;
            maxCaloric.Location = new Point(109, 74);
            maxCaloric.Name = "maxCaloric";
            maxCaloric.Size = new Size(86, 19);
            maxCaloric.TabIndex = 5;
            maxCaloric.TabStop = true;
            maxCaloric.Text = "Max caloric";
            maxCaloric.UseVisualStyleBackColor = true;
            maxCaloric.CheckedChanged += maxCaloric_CheckedChanged;
            // 
            // minCaloric
            // 
            minCaloric.AutoSize = true;
            minCaloric.Location = new Point(109, 99);
            minCaloric.Name = "minCaloric";
            minCaloric.Size = new Size(84, 19);
            minCaloric.TabIndex = 6;
            minCaloric.TabStop = true;
            minCaloric.Text = "Min caloric";
            minCaloric.UseVisualStyleBackColor = true;
            minCaloric.CheckedChanged += minCaloric_CheckedChanged;
            // 
            // averageCalorie
            // 
            averageCalorie.AutoSize = true;
            averageCalorie.Location = new Point(109, 124);
            averageCalorie.Name = "averageCalorie";
            averageCalorie.Size = new Size(106, 19);
            averageCalorie.TabIndex = 7;
            averageCalorie.TabStop = true;
            averageCalorie.Text = "Average calorie";
            averageCalorie.UseVisualStyleBackColor = true;
            averageCalorie.CheckedChanged += averageCalorie_CheckedChanged;
            // 
            // amountOfVegetables
            // 
            amountOfVegetables.AutoSize = true;
            amountOfVegetables.Location = new Point(258, 74);
            amountOfVegetables.Name = "amountOfVegetables";
            amountOfVegetables.Size = new Size(142, 19);
            amountOfVegetables.TabIndex = 8;
            amountOfVegetables.TabStop = true;
            amountOfVegetables.Text = "Amount of vegetables";
            amountOfVegetables.UseVisualStyleBackColor = true;
            amountOfVegetables.CheckedChanged += amountOfVegetables_CheckedChanged;
            // 
            // amountOfFruits
            // 
            amountOfFruits.AutoSize = true;
            amountOfFruits.Location = new Point(258, 99);
            amountOfFruits.Name = "amountOfFruits";
            amountOfFruits.Size = new Size(113, 19);
            amountOfFruits.TabIndex = 9;
            amountOfFruits.TabStop = true;
            amountOfFruits.Text = "Amount of fruits";
            amountOfFruits.UseVisualStyleBackColor = true;
            amountOfFruits.CheckedChanged += amountOfFruits_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(258, 124);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "All for color";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // inputColors
            // 
            inputColors.FormattingEnabled = true;
            inputColors.Items.AddRange(new object[] { "Yellow", "Red", "Green", "Brown", "White" });
            inputColors.Location = new Point(258, 36);
            inputColors.Name = "inputColors";
            inputColors.Size = new Size(121, 23);
            inputColors.TabIndex = 11;
            inputColors.SelectedIndexChanged += allOfGivenColor_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "Colors:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 13;
            label2.Text = "Provaider:";
            // 
            // amountForColors
            // 
            amountForColors.AutoSize = true;
            amountForColors.Location = new Point(258, 149);
            amountForColors.Name = "amountForColors";
            amountForColors.Size = new Size(122, 19);
            amountForColors.TabIndex = 14;
            amountForColors.TabStop = true;
            amountForColors.Text = "Amount for colors";
            amountForColors.UseVisualStyleBackColor = true;
            amountForColors.CheckedChanged += amountForColors_CheckedChanged;
            // 
            // allOfGivenColor
            // 
            allOfGivenColor.AutoSize = true;
            allOfGivenColor.Location = new Point(258, 174);
            allOfGivenColor.Name = "allOfGivenColor";
            allOfGivenColor.Size = new Size(124, 19);
            allOfGivenColor.TabIndex = 15;
            allOfGivenColor.TabStop = true;
            allOfGivenColor.Text = "All of a given color";
            allOfGivenColor.UseVisualStyleBackColor = true;
            allOfGivenColor.CheckedChanged += allOfGivenColor_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 16;
            label3.Text = "Calories";
            // 
            // inputCalories
            // 
            inputCalories.FormattingEnabled = true;
            inputCalories.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            inputCalories.Location = new Point(445, 36);
            inputCalories.Name = "inputCalories";
            inputCalories.Size = new Size(121, 23);
            inputCalories.TabIndex = 17;
            inputCalories.SelectedIndexChanged += more_CheckedChanged;
            inputCalories.SelectedIndexChanged += less_CheckedChanged;
            // 
            // less
            // 
            less.AutoSize = true;
            less.Location = new Point(445, 74);
            less.Name = "less";
            less.Size = new Size(47, 19);
            less.TabIndex = 18;
            less.TabStop = true;
            less.Text = "Less";
            less.UseVisualStyleBackColor = true;
            less.CheckedChanged += less_CheckedChanged;
            // 
            // more
            // 
            more.AutoSize = true;
            more.Location = new Point(445, 99);
            more.Name = "more";
            more.Size = new Size(53, 19);
            more.TabIndex = 19;
            more.TabStop = true;
            more.Text = "More";
            more.UseVisualStyleBackColor = true;
            more.CheckedChanged += more_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 205);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += calorieRange_CheckedChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(75, 205);
            numericUpDown2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 23);
            numericUpDown2.TabIndex = 21;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += calorieRange_CheckedChanged;
            // 
            // calorieRange
            // 
            calorieRange.AutoSize = true;
            calorieRange.Location = new Point(139, 207);
            calorieRange.Name = "calorieRange";
            calorieRange.Size = new Size(95, 19);
            calorieRange.TabIndex = 22;
            calorieRange.TabStop = true;
            calorieRange.Text = "Calorie range";
            calorieRange.UseVisualStyleBackColor = true;
            calorieRange.CheckedChanged += calorieRange_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 9);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 23;
            label4.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 9);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 39);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 25;
            label6.Text = "Insert:";
            // 
            // insertName
            // 
            insertName.Location = new Point(608, 57);
            insertName.Name = "insertName";
            insertName.PlaceholderText = "Name";
            insertName.Size = new Size(100, 23);
            insertName.TabIndex = 26;
            // 
            // insertType
            // 
            insertType.Location = new Point(608, 86);
            insertType.Name = "insertType";
            insertType.PlaceholderText = "Type";
            insertType.Size = new Size(100, 23);
            insertType.TabIndex = 27;
            // 
            // insertColor
            // 
            insertColor.Location = new Point(608, 115);
            insertColor.Name = "insertColor";
            insertColor.PlaceholderText = "Color";
            insertColor.Size = new Size(100, 23);
            insertColor.TabIndex = 28;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(608, 173);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(100, 23);
            buttonInsert.TabIndex = 30;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // insertCaloric
            // 
            insertCaloric.Location = new Point(608, 144);
            insertCaloric.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            insertCaloric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            insertCaloric.Name = "insertCaloric";
            insertCaloric.Size = new Size(100, 23);
            insertCaloric.TabIndex = 31;
            insertCaloric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(797, 44);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 32;
            label7.Text = "Update:";
            // 
            // updateId
            // 
            updateId.Location = new Point(797, 62);
            updateId.Name = "updateId";
            updateId.Size = new Size(48, 23);
            updateId.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 149);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 34;
            label8.Text = "Caloric:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(771, 64);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 34;
            label9.Text = "Id:";
            // 
            // updateName
            // 
            updateName.Location = new Point(797, 91);
            updateName.Name = "updateName";
            updateName.PlaceholderText = "Name";
            updateName.Size = new Size(100, 23);
            updateName.TabIndex = 35;
            // 
            // updateType
            // 
            updateType.Location = new Point(797, 120);
            updateType.Name = "updateType";
            updateType.PlaceholderText = "Type";
            updateType.Size = new Size(100, 23);
            updateType.TabIndex = 36;
            // 
            // updateColor
            // 
            updateColor.Location = new Point(797, 149);
            updateColor.Name = "updateColor";
            updateColor.PlaceholderText = "Color";
            updateColor.Size = new Size(100, 23);
            updateColor.TabIndex = 37;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(798, 207);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(99, 23);
            buttonUpdate.TabIndex = 39;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // updateCaloric
            // 
            updateCaloric.Location = new Point(797, 178);
            updateCaloric.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            updateCaloric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            updateCaloric.Name = "updateCaloric";
            updateCaloric.Size = new Size(100, 23);
            updateCaloric.TabIndex = 40;
            updateCaloric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(745, 180);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 34;
            label10.Text = "Caloric:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(604, 213);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 41;
            label11.Text = "Delete:";
            // 
            // deleteById
            // 
            deleteById.Location = new Point(555, 231);
            deleteById.Name = "deleteById";
            deleteById.Size = new Size(44, 23);
            deleteById.TabIndex = 42;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(529, 233);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 34;
            label12.Text = "Id:";
            // 
            // button1
            // 
            button1.Location = new Point(605, 231);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 43;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 472);
            Controls.Add(button1);
            Controls.Add(deleteById);
            Controls.Add(label11);
            Controls.Add(updateCaloric);
            Controls.Add(buttonUpdate);
            Controls.Add(updateColor);
            Controls.Add(updateType);
            Controls.Add(updateName);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(updateId);
            Controls.Add(label7);
            Controls.Add(insertCaloric);
            Controls.Add(buttonInsert);
            Controls.Add(insertColor);
            Controls.Add(insertType);
            Controls.Add(insertName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(calorieRange);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(more);
            Controls.Add(less);
            Controls.Add(inputCalories);
            Controls.Add(label3);
            Controls.Add(allOfGivenColor);
            Controls.Add(amountForColors);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputColors);
            Controls.Add(radioButton1);
            Controls.Add(amountOfFruits);
            Controls.Add(amountOfVegetables);
            Controls.Add(averageCalorie);
            Controls.Add(minCaloric);
            Controls.Add(maxCaloric);
            Controls.Add(allColors);
            Controls.Add(allNames);
            Controls.Add(radioAll);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)insertCaloric).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateId).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateCaloric).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteById).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private RadioButton radioAll;
        private RadioButton allNames;
        private RadioButton allColors;
        private RadioButton maxCaloric;
        private RadioButton minCaloric;
        private RadioButton averageCalorie;
        private RadioButton amountOfVegetables;
        private RadioButton amountOfFruits;
        private RadioButton radioButton1;
        private ComboBox inputColors;
        private Label label1;
        private Label label2;
        private RadioButton amountForColors;
        private RadioButton allOfGivenColor;
        private Label label3;
        private ComboBox inputCalories;
        private RadioButton less;
        private RadioButton more;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private RadioButton calorieRange;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox insertName;
        private TextBox insertType;
        private TextBox insertColor;
        private Button buttonInsert;
        private NumericUpDown insertCaloric;
        private Label label7;
        private NumericUpDown updateId;
        private Label label8;
        private Label label9;
        private TextBox updateName;
        private TextBox updateType;
        private TextBox updateColor;
        private Button buttonUpdate;
        private NumericUpDown updateCaloric;
        private Label label10;
        private Label label11;
        private NumericUpDown deleteById;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label12;
        private Button button1;
    }
}
