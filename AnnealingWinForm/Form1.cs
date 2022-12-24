using SimulatedAnnealing;

namespace AnnealingWinForm
{
    public partial class Form1 : Form
    {
        private Bitmap _graphBitmap;

        private Graphics _graphics;

        private double[,] _matrix;

        private GraphPainter _graphPainter;
        public Form1()
        {
            InitializeComponent();

            _graphBitmap = new Bitmap(graphPictureBox.Width, graphPictureBox.Height);

            _graphics = Graphics.FromImage(_graphBitmap);

            _graphPainter = new GraphPainter(_graphics, _graphBitmap);

            _matrix = new double[(int)countVertex.Value, (int)countVertex.Value];

            _graphPainter.DrawCompleteGraph((int)countVertex.Value);

            graphPictureBox.Image = _graphBitmap;

            InitializeMatrix();

            shortestPathLabel.Text = "";

            sumWeightLabel.Text = "";

            endedResultButton.Checked = true;
        }

        private void InitializeMatrix()
        {
            matrixGridView.RowCount = (int)countVertex.Value;

            matrixGridView.ColumnCount = (int)countVertex.Value;

            for (int i = 0; i < (int)countVertex.Value; i++)
            {
                matrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                matrixGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(0); j++)
                {
                    matrixGridView.Rows[i].Cells[j].Value = _matrix[i, j];

                    matrixGridView.Columns[j].Width = 40;

                    matrixGridView.Rows[i].Cells[j].ReadOnly = isSimmetricCheckBox.Checked && j <= i;;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minTemperatureNumeric.Maximum = maxTemperatureNumeric.Value;
        }

        private void maxTemperatureNumeric_ValueChanged(object sender, EventArgs e)
        {
            minTemperatureNumeric.Maximum = maxTemperatureNumeric.Value;
        }

        private void isSimmetricCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < _matrix.GetLength(0); j++)
                {
                    _matrix[j, i] = _matrix[i, j];
                }
            }

            InitializeMatrix();
        }

        private void randomWeightsButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int maxRandom = (int)maxRandomNumeric.Value;

            for (int i = 0; i < countVertex.Value; i++)
            {
                for (int j = 0; j < countVertex.Value; j++)
                {
                    if (i != j)
                    {
                        _matrix[i, j] = random.Next(maxRandom) + 1;
                    }

                    if (isSimmetricCheckBox.Checked && j <= i)
                    {
                        _matrix[j, i] = _matrix[i, j];
                    }
                }
            }

            InitializeMatrix();
        }

        private void maxRandomNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void countVertex_ValueChanged(object sender, EventArgs e)
        {
            _matrix = new double[(int)countVertex.Value, (int)countVertex.Value];

            _graphPainter.DrawCompleteGraph((int)countVertex.Value);

            graphPictureBox.Image = _graphBitmap;

            InitializeMatrix();
        }

        private void matrixGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            int column = e.ColumnIndex;

            if (row < 0 || column < 0)
            {
                return;
            }

            var oldValue = _matrix[row, column];

            int newValue = 0;

            if (int.TryParse(matrixGridView.Rows[row].Cells[column].Value.ToString(), out newValue)
                && newValue > 0)
            {
                _matrix[row, column] = newValue;
            }
            else
            {
                matrixGridView.Rows[row].Cells[column].Value = oldValue;
            }

            if (isSimmetricCheckBox.Checked)
            {
                matrixGridView.Rows[column].Cells[row].Value = matrixGridView.Rows[row].Cells[column].Value;
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            AnnealingMethod annealing = new AnnealingMethod();

            startButton.Enabled = false;

            var result = await Task.Run(() => annealing.GetResult(
                _matrix,
                (double)maxTemperatureNumeric.Value,
                (double)minTemperatureNumeric.Value,
                (double)cRatioNumeric.Value));

            if (iterationResultButton.Checked)
            {
                await Task.Run(async () =>
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        await Task.Delay((int)animationNumeric.Value);

                        _graphPainter.DrawCompleteGraph((int)countVertex.Value);

                        _graphPainter.DrawCycle(result[i].Path);

                        graphPictureBox.Image = _graphBitmap;
                    }
                });
            }

            _graphPainter.DrawCompleteGraph((int)countVertex.Value);

            _graphPainter.DrawCycle(result.Last().Path);

            graphPictureBox.Image = _graphBitmap;

            startButton.Enabled = true;

            shortestPathLabel.Text = String.Join("->", result.Last().Path.Select(v => v + 1).ToList());

            sumWeightLabel.Text = ((int)annealing.EnergyFunc(_matrix, result.Last().Path)).ToString();
        }
    }
}