namespace Winki.Clicker.D
{
    public partial class Form1 : Form
    {
        //Totall values;
        public int ts = 0;
        public int ps = 0;
        public int dg = 1;
        public int up = 500;

        //Value for determining the life of the boss; 
        public int ButtHP = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates different amounts of life to the boss.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int Button_HP(int x)
        {
            Random random = new();
            x = random.Next(1000, 100000);
            return x;
        }

        /// <summary>
        /// Game completion check.
        /// </summary>
        void End_Game()
        {
            if (ButtHP <= 0)
            {
                MessageBox.Show($@"You Win!

Your total score: {ts};
Points: {ps};
Damage: {dg};", "Endgame", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Total score: {ts}";
            label2.Text = $"Points: {ps}";
            label3.Text = $"Damage: {dg}";

            ButtHP = Button_HP(ButtHP);
            label4.Text = $"HP: {ButtHP}";
        }

        void Button1_Click(object sender, EventArgs e)
        {
            //Increasing values by one;
            ts++;
            label1.Text = $"Total score: {ts}";
            ps += dg;
            label2.Text = $"Points: {ps}";

            //Dicrease values by one;
            ButtHP -= dg;
            label4.Text = $"HP: {ButtHP}";


            //Call an end of game check;
            End_Game();
        }

        void Button2_Click(object sender, EventArgs e)
        {
            if (ps >= up - 1)
            {
                //Subtract the cost of the upgrade;
                ps -= up;
                label2.Text = $"Points: {ps}";

                //Increase the damage;
                dg *= 2;
                label3.Text = $"Damage: {dg}";

                //Raising the cost of upgrades;
                up *= 2;
            }
            else
            {
                MessageBox.Show($@"Your points: {ps};
Upgrade: {up};", "Not enough points!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Label2_DoubleClick(object sender, EventArgs e)
        {
            //Zeroing out the value of points;
            ps = 0;
            label2.Text = $"Points: {ps}";
        }
    }
}
