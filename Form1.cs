namespace EjercicioGraficoLogo
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
            pictureBox1.CreateGraphics().Clear(Color.White);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Blue);

            papel.DrawRectangle(lapiz, 10, 20, 60, 60);
            papel.DrawRectangle(lapiz, 10, 20, 40, 40);
            papel.DrawRectangle(lapiz, 10, 20, 20, 20);

            papel.DrawRectangle(lapiz, 100, 100, 60, 60);
            papel.DrawRectangle(lapiz, 100, 100, 40, 40);
            papel.DrawRectangle(lapiz, 100, 100, 20, 20);

            papel.DrawLine(lapiz, 100, 50, 100, 10);
            papel.DrawLine(lapiz, 100, 10, 140, 50);
            papel.DrawLine(lapiz, 140, 50, 100, 50);

            papel.DrawLine(lapiz, 10, 100, 10, 160);
            papel.DrawLine(lapiz, 10, 160, 30, 160);
            papel.DrawLine(lapiz, 30, 160, 10, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.CreateGraphics().Clear(Color.White);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Blue);

            papel.DrawLine(lapiz, 20, 80, 70, 10);
            papel.DrawLine(lapiz, 70, 10, 120, 80);
            papel.DrawLine(lapiz, 20, 80, 120, 80);
        }
    }
}