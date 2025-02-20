namespace Ruby_Cafe
{
    public partial class Ruby_Cafe : Form
    {
        //Para
        int Money = 1000;

        //deðerler
        int cheese = 150;
        int cubcake = 50;
        int hamburger = 120;
        int pizza = 180;
        int hotdog = 80;
        int pancake = 60;

        //Toplam Tutar
        int Top = 0;


        public Ruby_Cafe()
        {
            InitializeComponent();
        }

        private void Ruby_Cafe_Load(object sender, EventArgs e)
        {
            lblMoney.Text = Money.ToString() + " TL";
        }

        private void pbCheese_Click(object sender, EventArgs e)
        {
            Top += cheese;
            lbCart.Items.Add("Cheese ="+ cheese);
        }

        private void pbCupCake_Click(object sender, EventArgs e)
        {
            Top += cubcake;
            lbCart.Items.Add("CubCake ="+ cubcake );
        }

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            Top += hamburger;
            lbCart.Items.Add("Hamburger ="+hamburger);
        }

        private void pbPizza_Click(object sender, EventArgs e)
        {
            Top += pizza;
            lbCart.Items.Add("Pizza ="+pizza);
        }

        private void pbHotDog_Click(object sender, EventArgs e)
        {
            Top += hotdog;
            lbCart.Items.Add("HotDog ="+hotdog);
        }

        private void pbPanCake_Click(object sender, EventArgs e)
        {
            Top += pancake;
            lbCart.Items.Add("Pancake ="+pancake);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Top <= Money)
            {
                Money = Money - Top;

                lblMoney.Text = Money.ToString() + " TL";

                MessageBox.Show("Ödeme Baþarýlý.. Afiyet OLsun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbCart.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ödeme Baþarýsýz. Bakiye Yetersiz!","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }

        }
        
    }
}
