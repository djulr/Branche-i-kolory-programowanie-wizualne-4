namespace Branche_i_kolowry___programowanie_wizualne4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz obraz";
                openFileDialog.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Wszystkie pliki|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) {

   

                Bitmap greenPic = new Bitmap(pictureBox1.Image);
                for (int x = 0; x <= greenPic.Width - 1; x++)
                {
                    for (int y = 0; y <= greenPic.Height - 1; y++)
                    {
                        if (greenPic.GetPixel(x, y).G < greenPic.GetPixel(x, y).R + greenPic.GetPixel(x, y).B)
                        {
                            greenPic.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                pictureBox1.Image = greenPic;
                pictureBox1.Refresh();
            }
            else
            {

                MessageBox.Show("No picture");
            }
        }
    }
}
