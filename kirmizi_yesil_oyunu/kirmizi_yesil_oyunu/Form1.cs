namespace kirmizi_yesil_oyunu
{
    public partial class Form1 : Form
    {
        private const int gridSize = 5; // 5x5 bir kare tablo oluþturuyoruz
        private Button[,] gridButtons = new Button[gridSize, gridSize];
        private bool[,] isRed = new bool[gridSize, gridSize];

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            const int buttonSize = 50;
            const int spacing = 10;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    var button = new Button();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));
                    button.BackColor = Color.White;
                    button.Click += Square_Click;

                    gridButtons[i, j] = button;
                    isRed[i, j] = false;

                    Controls.Add(button);
                }
            }
        }

        private void Square_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int row = -1, col = -1;

            // Hangi butona týklandýðýný bulalým
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (gridButtons[i, j] == button)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1) break;
            }

            // Rastgele olarak kýrmýzý veya yeþil renk ata
            Random random = new Random();
            if (!isRed[row, col])
            {
                if (random.Next(2) == 0)
                {
                    button.BackColor = Color.Red;
                    isRed[row, col] = true;
                    CheckLoss();
                }
                else
                {
                    button.BackColor = Color.Green;
                }
            }
        }

        private void CheckLoss()
        {
            int redCount = 0;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (isRed[i, j]) redCount++;
                }
            }

            if (redCount >= 3)
            {
                MessageBox.Show("Oyunu kaybettiniz!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetGame();
            }
        }

        private void ResetGame()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    gridButtons[i, j].BackColor = Color.White;
                    isRed[i, j] = false;
                }
            }
        }
    }
}
