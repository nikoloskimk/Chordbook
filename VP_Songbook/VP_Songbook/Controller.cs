using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using VP_Songbook.Properties;

namespace VP_Songbook
{
    public class Controller
    {
        Panel[] Panels;
        int kolku;
        Timer loadTimer;
        Graphics Graph;
        Bitmap bufl;
        Graphics g;
        Brush brushBlue;
        Brush brushRed;
        Brush brushDodgerBlue;

        public Controller(Panel[] panels)
        {
            Panels = panels;
            ShowPanel(0);
            kolku = 0;
            loadTimer = new Timer();
            
            loadTimer.Interval = 20;
            loadTimer.Tick += new EventHandler(timer_Tick);
            loadTimer.Start();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.GUITAR_INTRO);
            player.Play();
            Graph=Panels[0].CreateGraphics();
            bufl = new Bitmap(Panels[0].Width, Panels[0].Height);
            g = Graphics.FromImage(bufl);
            brushBlue = new SolidBrush(Color.Blue);
            brushDodgerBlue = new SolidBrush(Color.DodgerBlue);
            brushRed = new SolidBrush(Color.Red);
        }


        void timer_Tick(object sender, EventArgs e)
        {
            loadIntro(Panels[0]);                   // Alert the user
        }

        public void ShowPanel(int num)
        {
            for (int i = 0; i < Panels.Length; i++)
            {
                if (i == num)
                {
                    Panels[num].Show();

                }
                else
                {
                    Panels[i].Hide();
                }
            }
        }


        private void loadIntro(Panel panelIntro)
        {
            kolku++;
            if (kolku <100)
            {
                Panel pf = panelIntro;
                //Graph.Clear(Color.White);
                g.Clear(Color.White);

                g.DrawImage(Resources.gitara, 350, 30, 400, 400);

                    Font fond = new Font("Arial", 30);
                    int do_kade = 500 - kolku * 3;
                    if (do_kade < 290)
                    {
                        do_kade = 290;
                    }
                    g.DrawString("Песнарка со акорди", fond, brushBlue, new PointF(do_kade, 430));
                    Font fond2 = new Font("Arial", 20);
                    g.DrawString("Визуелно Програмирање 2012/13", fond2, brushRed, new PointF(270, 480));
                    Font fond3 = new Font("Arial", 16);
                    int finki = -40 + kolku;
                    if (finki > 20)
                    {
                        finki = 20;
                    }
                    g.DrawString("Факултет за информатички науки и компјутерско инжинерство (ФИНКИ) - Скопје", fond3, brushDodgerBlue, new PointF(60, finki));
                    

                    
                
                Graph.DrawImageUnscaled(bufl, 0, 0);
            //    pf.CreateGraphics().DrawImage(bufl, 0, 0);

            }
            else if (kolku==100)
            {
                ShowPanel(1);
            }
        }


        public void AddSong(String _author, String _name, String _text, int _id_category)
        {
            songbookEntities2 testcontext = new songbookEntities2();
            try
            {
                song pesna = new song
                {
                    id_song=1,
                    author=_author,
                    name=_name,
                    text=_text,
                    id_category=_id_category
                };
                testcontext.songs.AddObject(pesna);
                testcontext.SaveChanges();
              //  LoadToGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void AddCategory(String _category)
        {
            songbookEntities2 testcontext = new songbookEntities2();
            try
            {
                category kategorija = new category
                {
                    id_category=1,
                    name_category=_category
                };
                testcontext.categories.AddObject(kategorija);
                testcontext.SaveChanges();
                //  LoadToGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
