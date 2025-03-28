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
                openFileDialog.Title = "Choose a picture to edit";
                openFileDialog.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Wszystkie pliki|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                if (radioButton1.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Refresh();

                }
                if (radioButton2.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox1.Refresh();

                }
                if (radioButton3.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox1.Refresh();

                }

            }
            else
            {
                MessageBox.Show("No picture");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap picture = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < picture.Height; y++)
                {
                    for (int x = 0; x < picture.Width; x++)
                    {
                        Color pixel = picture.GetPixel(x, y);
                        Color negatyw = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                        picture.SetPixel(x, y, negatyw);
                    }
                }

                pictureBox1.Image = picture;
            }
            else
            {
                MessageBox.Show("No picture");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Refresh();

            }
            else
            {
                MessageBox.Show("No picture");
            }
        }
    }
}
