using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Xml;


namespace spase_war
{
    public partial class Form2 : Form
    {
        WMPLib.WindowsMediaPlayer game = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer hakkaa = new WMPLib.WindowsMediaPlayer();

        public Form2()
        {
            InitializeComponent();


        }


        //Arry_picyurBox_Tir
        public PictureBox[] t = new PictureBox[1000];

        //meghdar_tir_havapimaplayer
        public int T = 1;

        //string_File_score
        public string pach = "aq.txt";
       
        //meghdar_score_killed
        public int n = 0;

        //meghdar_mode_morning_night
        public int m = 0;

        //meghdar_June
        public int J = 10;

        //meghdar_speed_havapimadoshman
        public int speed_Havapima = 0;

        //meghdar_bool_moderooh
        public bool Rooh = false;

        //meghdar_score
        public int time_Scor = 1;


        public int H = 0;

        //meghdar_bool_lblmoderooh
        public bool Mode_ROOH = false;

        //random_havapimadoshman
        public Random rnd1 = new Random();
        public Random rnd2 = new Random();
        public Random rnd3 = new Random();
        public Random rnd4 = new Random();

        //string_Addres_chosehavapima
        public string d1b = Environment.CurrentDirectory + "\\mode_enfajar.png";
        public string d1 = Environment.CurrentDirectory + "\\havapima-whit.png";
        public string d2 = Environment.CurrentDirectory + "\\havapima_tosi.png";


        //random Move _Havapimadoshman
        public Random rnd5 = new Random();
        public Random rnd6 = new Random();
        public Random rnd7 = new Random();
        public Random rnd8 = new Random();


        //random Bounds _Havapimadoshman && Havapima_Player
        public Random rnd9 = new Random();
        public Random rnd10 = new Random();
        public Random rnd11 = new Random();
        public Random rnd12 = new Random();


        //visible_all_picturbox
        void Visibel_picturBox()
        {
            ModeRooh.Visible = false;

            pic_monthen.Visible = false;
            pic_star1.Visible = false;
            pic_star2.Visible = false;
            pic_star2.Visible = false;
            pic_star9.Visible = false;
            pic_star8.Visible = false;
            pic_star6.Visible = false;
            pic_star5.Visible = false;
            pic_star21.Visible = false;
            pic_star20.Visible = false;
            pic_star2.Visible = false;
            pic_star19.Visible = false;
            pic_star17.Visible = false;
            pic_star16.Visible = false;
            pic_star13.Visible = false;
            pic_star12.Visible = false;
            pic_star11.Visible = false;
            pic_star1.Visible = false;
        }


        //void_music_gameover
        public void gwq()
        {
            game.URL = "Game-Over-Sound-Effect-4.mp3";
            game.controls.play();
        }


        //void_playmusic_gameover
        public void f()
        {
            hakkaa.URL = "Pistol Sound Effects One Shot.mp3";
            hakkaa.controls.play();
        }

        //void_playmusic_efect_tir
        public void mosic_tir()
        {
            game.URL = "Pistol Sound Effects One Shot.mp3";
            game.controls.play();
        }


        //void_txtfile_score
        public void fail()
        {
        if (File.Exists("saw.txt"))
        {
           string w =File.ReadAllText("saw.txt");
           int w3 = Convert.ToInt32(w);
           int l = Convert.ToInt32(Killed.Text);
        if (l >= w3)
        {

            File.WriteAllText("saw.txt", l.ToString());
        }
        else
        {
            File.CreateText("saw.txt");
            File.WriteAllText("saw.txt", Killed.Text);
        }
        }
        }


        //timer_visible_all_picturbox
        private void Timer_Visible_PicturBox(object sender, EventArgs e)
        {
            Visibel_picturBox();
        }


        //keydown_form2
        private void keydown_MoveHavapimaPlayer(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.A)
        {
            Havapima_Player.Left -= 20;
        }
        else if (e.KeyCode == Keys.D)
        {
             Havapima_Player.Left += 20;
        }
        else if (e.KeyCode == Keys.Space)
        {
                Place_picturtir();
                f();
        }
        else if (e.KeyCode == Keys.Escape)
        {
             this.Close();
        }
        else if (e.KeyCode == Keys.Left)
        {
              Havapima_Player.Left -= 20;
        }
        else if (e.KeyCode == Keys.Right)
        {
             Havapima_Player.Left += 20;
        }
        else if (e.KeyCode == Keys.H)
        {
             Mode_ROOH = true;
             timer1.Enabled = true;
             ModeRooh.Visible = true;
        }
        }


        //Addres_fromfile_picturbox_tir_havapimaplayer
        void Place_picturtir()
        {
            T++;
            string Place = Environment.CurrentDirectory + label1.Text;
            t[T] = new PictureBox();
            t[T].Image = Image.FromFile(Place);
            t[T].SizeMode = PictureBoxSizeMode.Zoom;
            t[T].Location = new Point(Havapima_Player.Location.X + 35, Havapima_Player.Location.Y);
            t[T].Size = new Size(13, 35);
            this.Controls.Add(t[T]);

        }


        //void_bounds_tir_havapimadoshman
        void Barghord_Havapima_doshman()
        {
        for (int n = 2; n <= T; n++)
        {
            t[n].Top -= 10;

        if (t[n].Bounds.IntersectsWith(doshman_1.Bounds))
        {
            doshman_1.Image = Image.FromFile(d1b);

            timer4.Enabled = true;
            n = Convert.ToInt32(Killed.Text);
            n++;
            m++;
            Killed.Text = Convert.ToString(n);
        }
        else if (t[n].Bounds.IntersectsWith(doshman_2.Bounds))
        {
            doshman_2.Image = Image.FromFile(d1b);
            timer5.Enabled = true;
            n = Convert.ToInt32(Killed.Text);
            n++;
            m++;
            Killed.Text = Convert.ToString(n);
        }
        else if (t[n].Bounds.IntersectsWith(doshman_3.Bounds))
        {
             doshman_3.Image = Image.FromFile(d1b);
             timer6.Enabled = true;
             n = Convert.ToInt32(Killed.Text);
             n++;
             m++;
             Killed.Text = Convert.ToString(n);

        }
        else if (t[n].Bounds.IntersectsWith(doshman_4.Bounds))
        {
                    doshman_4.Image = Image.FromFile(d1b);
                    timer7.Enabled = true;
                    n = Convert.ToInt32(Killed.Text);
                    n++;
                    m++;
                    Killed.Text = Convert.ToString(n);
        }

        Controls.Add(t[n]);

        }
        }


        //timer_bounds_tir_havapimadoshman
        private void Move_Tir(object sender, EventArgs e)
        {
            Barghord_Havapima_doshman();
        }


        //void_move_havapima_bounds_havapimadoshman_visible_June
        private void move_havapimadoshman_Envent(object sender, EventArgs e)
        {

            doshman_1.Location = new Point(doshman_1.Location.X, doshman_1.Location.Y + J);
            Random rnd5 = new Random();

        if (doshman_1.Location.Y > 850)
        {
            doshman_1.Location = new Point(rnd5.Next(10, 1240), 0);
        }
        if (Mode_ROOH == false)
        {
        if (Havapima_Player.Bounds.IntersectsWith(doshman_2.Bounds))
        {
            Random rnd6 = new Random();
            doshman_2.Location = new Point(rnd6.Next(10, 1240), 0);
            H++;

        switch (H)
        {
                case 1:
                     pic_June1.Visible = false;
                     break;

                case 2:
                      pic_Jun2.Visible = false;
                      break;

                case 3:
                      timer_Move_Havapima_doshman.Enabled = false;
                      doshman_1.Location = new Point(859, 9);
                      doshman_2.Location = new Point(665, 9);
                      doshman_3.Location = new Point(454, 9);
                      doshman_4.Location = new Point(254, 9);
                      timer_Move_Tir.Enabled = false;
                      Move_Havapimadoshman.Enabled = false;
                      GameOver.Visible = true;
                      T = 10;
                      gwq();
                      fail();
                      H = 0;
                      break;
        }
        }
        }
        }


        //timer_move_havapimadoshman_bounds_havapimadoshamn_visibleJune_havapimaplayer
        private void timer_Havapimadoshman(object sender, EventArgs e)
        {

            //Move_Random_doshman Ha

            doshman_1.Location = new Point(doshman_1.Location.X, doshman_1.Location.Y + J);
            doshman_2.Location = new Point(doshman_2.Location.X, doshman_2.Location.Y + J);
            doshman_3.Location = new Point(doshman_3.Location.X, doshman_3.Location.Y + J);
            doshman_4.Location = new Point(doshman_4.Location.X, doshman_4.Location.Y + J);

            if (doshman_1.Location.Y > 850)
            {
                doshman_1.Location = new Point(rnd5.Next(100, 1240), 0);
            }
            else if (doshman_2.Location.Y > 850)
            {
                doshman_2.Location = new Point(rnd6.Next(100, 1240), 0);
            }
            else if (doshman_3.Location.Y > 850)
            {
                doshman_3.Location = new Point(rnd7.Next(100, 1240), 0);
            }
            else if (doshman_4.Location.Y > 850)
            {
                doshman_4.Location = new Point(rnd8.Next(10, 1240), 0);
            }

            //doshman_1
            if (Mode_ROOH == false)
            {
            if (Havapima_Player.Bounds.IntersectsWith(doshman_1.Bounds))
            {
                doshman_1.Location = new Point(rnd9.Next(10, 1240), 0);

                 H++;

            switch (H)
            {
                   case 1:
                         pic_June1.Visible = false;
                         break;

                   case 2:
                         pic_June2.Visible = false;
                         break;

                   case 3:
                         pic_June3.Visible = false;
                         Move_Havapimadoshman.Enabled = false;
                         GameOver.Visible = true;
                         doshman_1.Location = new Point(859, 9);
                         doshman_2.Location = new Point(665, 9);
                         doshman_3.Location = new Point(454, 9);
                         doshman_4.Location = new Point(254, 9);
                         gwq();
                         fail();
                         timer_Move_Tir.Enabled = false;
                         T = 10;
                         H = 0;
                         button1.Visible = true;
                         this.KeyPreview = false;
                         break;

            }
            }

            //doshman_2

            else if (Havapima_Player.Bounds.IntersectsWith(doshman_2.Bounds))
            {
                 doshman_2.Location = new Point(rnd10.Next(10, 1240), 0);

                 H++;

            switch (H)
            {
                  case 1:
                       pic_June1.Visible = false;
                       break;

                  case 2:
                        pic_June2.Visible = false;
                         break;

                  case 3:
                       pic_June3.Visible = false;
                       Move_Havapimadoshman.Enabled = false;
                       GameOver.Visible = true;
                       doshman_1.Location = new Point(859, 9);
                       doshman_2.Location = new Point(665, 9);
                       doshman_3.Location = new Point(454, 9);
                       doshman_4.Location = new Point(254, 9);
                       T = 10;
                       gwq();
                       fail();
                       timer_Move_Tir.Enabled = false;
                       H = 0;
                       button1.Visible = true;
                       this.KeyPreview = false;
                       break;
            }
            }

            //doshman_3

            else if (Havapima_Player.Bounds.IntersectsWith(doshman_3.Bounds))
            {
                  doshman_3.Location = new Point(rnd11.Next(10, 1240), 0);

                  H++;

            switch (H)
            {
                  case 1:
                       pic_June1.Visible = false;
                       break;

                  case 2:
                       pic_June2.Visible = false;
                       break;

                  case 3:
                       pic_June3.Visible = false;
                       Move_Havapimadoshman.Enabled = false;
                       GameOver.Visible = true;
                       doshman_1.Location = new Point(859, 9);
                       doshman_2.Location = new Point(665, 9);
                       doshman_3.Location = new Point(454, 9);
                       doshman_4.Location = new Point(254, 9);
                       T = 10;
                       gwq();
                       fail();
                       timer_Move_Tir.Enabled = false;
                       H = 0;
                       button1.Visible = true;
                       this.KeyPreview = false;
                       break;
            }
            }

            //doshman_4

            else if (Havapima_Player.Bounds.IntersectsWith(doshman_4.Bounds))
            {
                  doshman_4.Location = new Point(rnd12.Next(10, 1240), 0);

                  H++;

            switch (H)
            {
                    case 1:
                         pic_June1.Visible = false;
                         break;

                    case 2:
                         pic_June2.Visible = false;
                         break;

                    case 3:
                          pic_June3.Visible = false;
                          Move_Havapimadoshman.Enabled = false;
                          GameOver.Visible = true;
                          doshman_1.Location = new Point(859, 9);
                          doshman_2.Location = new Point(665, 9);
                          doshman_3.Location = new Point(454, 9);
                          doshman_4.Location = new Point(254, 9);
                          T = 10;
                          H = 0;
                          gwq();
                          fail();
                          timer_Move_Tir.Enabled = false;
                          button1.Visible = true;
                          this.KeyPreview = false;
                          break;
            }
            }
            }
        }


        //timer_score_game
        private void score_Tick(object sender, EventArgs e)
        {
            int c = 1;
            c = Convert.ToInt32(Score_Number.Text);
            c++;
            Score_Number.Text = Convert.ToString(c);
        }

        //void_speed_havapimadoshman
        private void speed_doshman(object sender, EventArgs e)
        {
            J += 2;
        }

        //void_mode_morning_night
        private void Mode()
        {
            if (m % 20 == 0)
            {
                this.BackColor = Color.Black;
                pic_khorshid.Visible = false;
                pic_monthen.Visible = true;
                pic_star1.Visible = true;
                pic_star2.Visible = true;
                pic_star2.Visible = true;
                pic_star9.Visible = true;
                pic_star8.Visible = true;
                pic_star6.Visible = true;
                pic_star5.Visible = true;
                pic_star21.Visible = true;
                pic_star20.Visible = true;
                pic_star2.Visible = true;
                pic_star19.Visible = true;
                pic_star17.Visible = true;
                pic_star16.Visible = true;
                pic_star13.Visible = true;
                pic_star12.Visible = true;
                pic_star11.Visible = true;
                pic_star1.Visible = true;
                m = 0;
            }
            else if (m % 20 == 1)
            {
                this.BackColor = Color.Cyan;
                pic_khorshid.Visible = true;
                pic_monthen.Visible = false;
                pic_star1.Visible = false;
                pic_star2.Visible = false;
                pic_star2.Visible = false;
                pic_star9.Visible = false;
                pic_star8.Visible = false;
                pic_star6.Visible = false;
                pic_star5.Visible = false;
                pic_star21.Visible = false;
                pic_star20.Visible = false;
                pic_star2.Visible = false;
                pic_star19.Visible = false;
                pic_star17.Visible = false;
                pic_star16.Visible = false;
                pic_star13.Visible = false;
                pic_star12.Visible = false;
                pic_star11.Visible = false;
                pic_star1.Visible = false;
            }

        }


        //timer_roohmode
        private void timer1_Tick(object sender, EventArgs e)
        {
            Mode_ROOH = false;
            timer1.Enabled = false;
            ModeRooh.Visible = false;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

        }


        //void_btn_start_new_game
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "بازی مجدد";
            button1.Visible = false;
            Move_Havapimadoshman.Enabled = true;
            this.KeyPreview = true;
            lbl_hkew_rooh.Visible = false;
            GameOver.Visible = false;
            pic_June1.Visible = true;
            timer_Move_Tir.Enabled = true;
            pic_June2.Visible = true;
            pic_June3.Visible = true;
        }


        //void_agin_mode_morning_night
        private void timer3_Tick(object sender, EventArgs e)
        {
            int p = 2;
            int u = Convert.ToInt32(Killed.Text);

        if (u >= p)
        {
              p += 2;

        if (this.BackColor == Color.Cyan)
        {
            this.BackColor = Color.Black;
        }
        else if (this.BackColor == Color.Black)
        {
             this.BackColor = Color.Cyan;
        }

        }
        }


        //timer_mode_enfajar_doshman_1
        private void timer4_Tick(object sender, EventArgs e)
        {
            doshman_1.Location = new Point(rnd1.Next(10, 1240), 0);
            doshman_1.Image = Image.FromFile(d1);
            timer4.Enabled = false;
        }


        //timer_mode_enfajar_doshman_2
        private void timer5_Tick(object sender, EventArgs e)
        {
            doshman_2.Location = new Point(rnd2.Next(10, 1240), 0);
            doshman_2.Image = Image.FromFile(d2);
            timer5.Enabled = false;
        }


        //timer_mode_enfajar_doshman_3
        private void timer6_Tick(object sender, EventArgs e)
        {
            doshman_3.Location = new Point(rnd1.Next(10, 1240), 0);
            doshman_3.Image = Image.FromFile(d1);
            timer6.Enabled = false;
        }


        //timer_mode_enfajar_doshman_4
        private void timer7_Tick(object sender, EventArgs e)
        {
            doshman_4.Location = new Point(rnd1.Next(10, 1240), 0);
            doshman_4.Image = Image.FromFile(d1);
            timer7.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }


}



