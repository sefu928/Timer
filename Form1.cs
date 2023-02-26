namespace Wiki
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (i==0)
            {
                timer1.Interval = 1000;
                j = 60;
                timer1.Start();
            }
            i++;
            label2.Text = i.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            j--;
            
            if (j<1)
            {
                button1.Enabled= false;
                label3.Text = "0";
            }
            else
            {
                label3.Text = j.ToString();
            }
        }
    }
}