namespace Romeo_cassaforte
{
    public partial class Form1 : Form
    {
        private cassaforte cassaforte1;
        private bool blocco = false;
        private bool aperto = false;
        public int contatore = 0;
        public Form1()
        {
            InitializeComponent();
            cassaforte1 = new cassaforte(0001, "lockmaster", "0001", 123456789012);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (contatore > 5)
            {
                blocco = true;
            }
            if(blocco ==true) 
            {
                label1.Text = "BLOCCATO";
                label1.ForeColor = Color.Red;
            }
            if(aperto ==false)
            {
                label1.Text = "CHIUSO";
                label1.ForeColor= Color.Black;
            }
            else
            {
                label1.Text = "APERTO";
                label1.ForeColor= Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cassaforte1.imposta(numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cassaforte1.apri(numericUpDown1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cassaforte1.sblocca(numericUpDown1.Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cassaforte1.chiudi();
        }
    }
}