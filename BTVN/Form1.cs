namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void scaleToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scaleToFit.Checked = true;
            stretchToFit.Checked = false;
            actualSize.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void stretchToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scaleToFit.Checked = false;
            stretchToFit.Checked = true;
            actualSize.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void actualSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scaleToFit.Checked = false;
            stretchToFit.Checked = false;
            actualSize.Checked = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                toolStripLabel1.Text = ofd.FileName;
                toolStripLabel2.Text = pictureBox1.Image.Width.ToString() +"x"+ pictureBox1.Image.Height.ToString();
            }

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}