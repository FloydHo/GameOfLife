using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Timer timer;
        int cellSize = 4;
        int col;
        int row;
        int ran = 15;
        HashSet<(int x, int y)> aliveCellField = new HashSet<(int, int)>();

        bool isRunning = false;
        int generation = 0;

        public Form1()
        {
            var rand = new Random();

            InitializeComponent();


            //aliveCellField.Add((10, 10));
            //aliveCellField.Add((11, 11));
            //aliveCellField.Add((9, 12));
            //aliveCellField.Add((10, 12));
            //aliveCellField.Add((11, 12));
            InitializeField(rand);

            this.DoubleBuffered = true;
            DrawField.Paint += new PaintEventHandler(panel1_Paint);
            cellSizeBox.Text = cellSize.ToString();
            RandBox.Text = ran.ToString();

            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (sender, e) =>
            {

                UpdateCells();
            };
  
        }

        private void InitializeField(Random r)
        {
            generation = 0;
            GenerationCount.Text = generation.ToString();
            col = DrawField.Width / cellSize;
            row = DrawField.Height / cellSize;
            aliveCellField.Clear();

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (r.Next(101) > 100 - ran)
                    {
                        aliveCellField.Add((i, j));
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.AliceBlue, 1);
            Brush brush = Brushes.Aqua;

            foreach (var coor in aliveCellField)
                    //g.DrawRectangle(pen, x*cellSize, y*cellSize, 10, 10);
                    g.FillRectangle(brush, coor.x * cellSize+1, coor.y * cellSize+1, cellSize-2, cellSize-2);
        }

        void UpdateCells()
        {
            aliveCellField = GameOfLifeLogic(aliveCellField);
            DrawField.Invalidate();
            generation++;
            GenerationCount.Text = generation.ToString();
        }





        HashSet<(int x, int y)> GameOfLifeLogic(HashSet<(int x, int y)> oldCells)
        {
            int counter;
            HashSet<(int x, int y)> newCells = new HashSet<(int, int)>();
            HashSet<(int x, int y)> chanceOfBorn = new HashSet<(int, int)>();


            int[,] neighbor_cells = new int[,] { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 } };
            foreach (var cell in oldCells)
            {
                for (int i = 0; i < neighbor_cells.GetLength(0); i++)
                {
                    if (!oldCells.Contains((z_x(cell.x + neighbor_cells[i,0]), z_y(cell.y + neighbor_cells[i, 1]))))
                    {
                        chanceOfBorn.Add((z_x(cell.x + neighbor_cells[i, 0]), z_y(cell.y + neighbor_cells[i, 1])));
                    }
                }
            }

            foreach (var cell in oldCells)
            {
                counter = CountNeighbors(cell.x, cell.y, oldCells);
                if (counter == 2 || counter == 3)
                {
                    newCells.Add(cell);
                }
            }

            foreach (var cell in chanceOfBorn)
            {
                counter = CountNeighbors(cell.x, cell.y, oldCells);
                if (counter == 3)
                {
                    newCells.Add(cell);
                }
            }

            return newCells;
        }


        int CountNeighbors(int x, int y, HashSet<(int, int)> aliveCells)
        {
            int count = 0;

            int[,] neighbor_cells = new int[,]{ { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 } };
            for (int i = 0; i < neighbor_cells.GetLength(0); i++)
            {
                if (aliveCells.Contains((z_x(x + neighbor_cells[i, 0]), z_y(y + neighbor_cells[i, 1])))) count++;
            }

            return count;
        }

        int z_x(int x)
        {
            if (x < 0) x = col;
            else if (x > col) x = 0;
            return x;
        }

        int z_y(int y)
        {
            if (y < 0) y = row;
            else if (y > row) y = 0;
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cellSizeBox.Text, out int newSize))
            {
                cellSize = newSize;
                // Trigger das Neuzeichnen nach der Aktualisierung der Zellgröße
                DrawField.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }

            if (int.TryParse(RandBox.Text, out int newRand))
            {
                ran = newRand;
                // Trigger das Neuzeichnen nach der Aktualisierung der Zellgröße
                DrawField.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }

            if (isRunning) startStop_Click(sender, e);

            InitializeField(new Random());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                startStop.Text = "Start";
                timer.Stop();
                isRunning = false;
            }
            else
            {
                startStop.Text = "Pause";
                timer.Start();
                isRunning = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            aliveCellField.Clear();
            DrawField.Invalidate();
            timer.Stop();
            generation = 0;
            GenerationCount.Text = generation.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GenerationCount_Click(object sender, EventArgs e)
        {

        }

        private void cellSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            
        }
    }

}
