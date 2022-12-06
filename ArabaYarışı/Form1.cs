namespace ArabaYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " CAR GAME ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbCar1.Left = pcbCar1.Left + r.Next(5,15);
            pcbCar2.Left = pcbCar2.Left + r.Next(5,17);
            pcbCar3.Left = pcbCar3.Left + r.Next(5,16);

            if (pcbCar1.Left > pcbCar2.Left && pcbCar1.Left > pcbCar3.Left)
            {
                lblDurum.Text = "1. car önde !";
            }
            else if (pcbCar2.Left > pcbCar1.Left &&
                pcbCar2.Left > pcbCar3.Left)
            {
                lblDurum.Text = "2. car önde !";
            }
            else if (pcbCar3.Left > pcbCar1.Left && pcbCar3.Left > pcbCar2.Left)
            {
                lblDurum.Text = "3. car önde !";
            }

            if (pcbCar1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("1. car kazandı");
            }
            else if (pcbCar2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("2. car kazandı");
            }
            else if (pcbCar3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("3.car kazandı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pcbCar1.Left = 100;
            pcbCar2.Left = 100;
            pcbCar3.Left = 100;
            lblDurum.Text = "";
        }
    }
}