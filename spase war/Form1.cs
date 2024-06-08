namespace spase_war
{
    public partial class Form1 : Form
    {
        public Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }


        //btn_startgame
        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            form2.NamePlayer.Text = txt_NamePlayer.Text;
            this.Hide();
            form2.Show();

        }


        //btn_exitgame
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //void_keydown_form1
        private void keydown_cklick_btn(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_StartGame.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_Exit.PerformClick();
            }
        }


        //btn_select_havapima1
        private void button1_Click(object sender, EventArgs e)
        {

            form2.Havapima_Player.Image = H1.Image;

            bH1.Enabled = false;
            bH2.Enabled = false;
            bH3.Enabled = false;
        }


        //btn_select_havapima2
        private void bH2_Click(object sender, EventArgs e)
        {
            form2.Havapima_Player.Image = pictureBox2.Image;

            bH1.Enabled = false;
            bH2.Enabled = false;
            bH3.Enabled = false;
        }


        //btn_select_havapima3
        private void bH3_Click(object sender, EventArgs e)
        {
            form2.Havapima_Player.Image = pictureBox3.Image;

            bH1.Enabled = false;
            bH2.Enabled = false;
            bH3.Enabled = false;
        }


        //btn_select_tir1
        private void button6_Click(object sender, EventArgs e)
        {
            form2.label1.Text = "\\tir3.png";

            t1h.Enabled = false;
            t2h.Enabled = false;
            t3h.Enabled = false;
        }


        //btn_select_tir1
        private void button5_Click(object sender, EventArgs e)
        {
            form2.label1.Text = "\\tir1.png";

            t1h.Enabled = false;
            t2h.Enabled = false;
            t3h.Enabled = false;

        }


        //btn_select_tir1
        private void button4_Click(object sender, EventArgs e)
        {
            form2.label1.Text = "\\tir2.png";

            t1h.Enabled = false;
            t2h.Enabled = false;
            t3h.Enabled = false;

        }
    }
}
