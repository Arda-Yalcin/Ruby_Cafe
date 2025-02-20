namespace Ruby_Cafe
{
    partial class Ruby_Cafe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ruby_Cafe));
            panel1 = new Panel();
            lblMoney = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            lbCart = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            pbPanCake = new PictureBox();
            pbHotDog = new PictureBox();
            pbPizza = new PictureBox();
            pbHamburger = new PictureBox();
            pbCupCake = new PictureBox();
            pbCheese = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPanCake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHotDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCupCake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCheese).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblMoney);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 260);
            panel1.TabIndex = 0;
            // 
            // lblMoney
            // 
            lblMoney.Dock = DockStyle.Bottom;
            lblMoney.ForeColor = Color.Coral;
            lblMoney.Location = new Point(0, 237);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(125, 23);
            lblMoney.TabIndex = 2;
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(0, 67);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Ruby_Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbCart);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(555, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 260);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(0, 215);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 2;
            button1.Text = "Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCart
            // 
            lbCart.BackColor = Color.LightGray;
            lbCart.BorderStyle = BorderStyle.None;
            lbCart.Dock = DockStyle.Top;
            lbCart.ForeColor = Color.Coral;
            lbCart.FormattingEnabled = true;
            lbCart.ItemHeight = 18;
            lbCart.Location = new Point(0, 35);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(129, 180);
            lbCart.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 35);
            label2.TabIndex = 0;
            label2.Text = "Sepet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbPanCake);
            panel3.Controls.Add(pbHotDog);
            panel3.Controls.Add(pbPizza);
            panel3.Controls.Add(pbHamburger);
            panel3.Controls.Add(pbCupCake);
            panel3.Controls.Add(pbCheese);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(125, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 260);
            panel3.TabIndex = 2;
            // 
            // pbPanCake
            // 
            pbPanCake.Cursor = Cursors.Hand;
            pbPanCake.Image = (Image)resources.GetObject("pbPanCake.Image");
            pbPanCake.Location = new Point(289, 125);
            pbPanCake.Name = "pbPanCake";
            pbPanCake.Size = new Size(141, 132);
            pbPanCake.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPanCake.TabIndex = 5;
            pbPanCake.TabStop = false;
            pbPanCake.Click += pbPanCake_Click;
            // 
            // pbHotDog
            // 
            pbHotDog.Cursor = Cursors.Hand;
            pbHotDog.Image = (Image)resources.GetObject("pbHotDog.Image");
            pbHotDog.Location = new Point(145, 125);
            pbHotDog.Name = "pbHotDog";
            pbHotDog.Size = new Size(144, 132);
            pbHotDog.SizeMode = PictureBoxSizeMode.CenterImage;
            pbHotDog.TabIndex = 4;
            pbHotDog.TabStop = false;
            pbHotDog.Click += pbHotDog_Click;
            // 
            // pbPizza
            // 
            pbPizza.Cursor = Cursors.Hand;
            pbPizza.Image = (Image)resources.GetObject("pbPizza.Image");
            pbPizza.Location = new Point(0, 125);
            pbPizza.Name = "pbPizza";
            pbPizza.Size = new Size(144, 132);
            pbPizza.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPizza.TabIndex = 3;
            pbPizza.TabStop = false;
            pbPizza.Click += pbPizza_Click;
            // 
            // pbHamburger
            // 
            pbHamburger.Cursor = Cursors.Hand;
            pbHamburger.Image = (Image)resources.GetObject("pbHamburger.Image");
            pbHamburger.Location = new Point(289, 0);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(141, 126);
            pbHamburger.SizeMode = PictureBoxSizeMode.CenterImage;
            pbHamburger.TabIndex = 2;
            pbHamburger.TabStop = false;
            pbHamburger.Click += pbHamburger_Click;
            // 
            // pbCupCake
            // 
            pbCupCake.Cursor = Cursors.Hand;
            pbCupCake.Image = (Image)resources.GetObject("pbCupCake.Image");
            pbCupCake.Location = new Point(145, 0);
            pbCupCake.Name = "pbCupCake";
            pbCupCake.Size = new Size(144, 126);
            pbCupCake.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCupCake.TabIndex = 1;
            pbCupCake.TabStop = false;
            pbCupCake.Click += pbCupCake_Click;
            // 
            // pbCheese
            // 
            pbCheese.Cursor = Cursors.Hand;
            pbCheese.Image = (Image)resources.GetObject("pbCheese.Image");
            pbCheese.Location = new Point(0, 0);
            pbCheese.Name = "pbCheese";
            pbCheese.Size = new Size(144, 126);
            pbCheese.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCheese.TabIndex = 0;
            pbCheese.TabStop = false;
            pbCheese.Click += pbCheese_Click;
            // 
            // Ruby_Cafe
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(684, 260);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ruby_Cafe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ruby_Cafe";
            Load += Ruby_Cafe_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPanCake).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHotDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCupCake).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCheese).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label lblMoney;
        private ListBox lbCart;
        private Label label2;
        private PictureBox pbPanCake;
        private PictureBox pbHotDog;
        private PictureBox pbPizza;
        private PictureBox pbHamburger;
        private PictureBox pbCupCake;
        private PictureBox pbCheese;
        private Button button1;
    }
}
