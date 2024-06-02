namespace dizi_ile_dama_tahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Satranç Tahtasý";
            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 70;
                    button[i, j].Height = 70;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    this.Controls.Add(button[i, j]);
                    left += 70;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                }
                top += 70;
                left = 0;
            }

        }
    }
}