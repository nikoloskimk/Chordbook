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
        Timer loadTimer;
        Graphics Graph, buffGraph;
        Bitmap buffBmp;
        Brush brushBlue, brushRed, brushDodgerBlue; //креирање на референци за четките
        Font font1, font2, font3; //креирање на референци за фонтови
        songbookEntities2 testcontext; //
        Color backgColor;
        ListBox lbSongs,lbRemoveSong;
        ComboBox cbShowCategory;
        ComboBox cbAddSongCategory;
        public int currentCategory { get; set; }
        public int numbSteps { get; set; } //до каде сме со анимацијата

        public Controller(Panel[] panels, ListBox _lbSongs, ComboBox _cbShowCategory, ComboBox _cbAddSongCategory, ListBox _lbRemoveSong)
        {
            Panels = panels;
            lbSongs = _lbSongs;
            cbShowCategory = _cbShowCategory;
            cbAddSongCategory = _cbAddSongCategory;
            lbRemoveSong = _lbRemoveSong;
            currentCategory = -1;
            ShowPanel(0); // иницијално ги сокриваме сите панели
            Panels[1].Hide(); //како и панелот со мени
            Graph = Panels[0].CreateGraphics(); //платно за исцртување на интро панелот
            buffBmp = new Bitmap(Panels[0].Width, Panels[0].Height); //
            buffGraph = Graphics.FromImage(buffBmp); //платно кое го користиме како бафер
            numbSteps = 0; 
            backgColor = Color.FromArgb(250, 250, 200); // позадинска боја на интрото
            //креирање на четки и фонтови
            brushBlue = new SolidBrush(Color.Blue);
            brushDodgerBlue = new SolidBrush(Color.DodgerBlue);
            brushRed = new SolidBrush(Color.Red);
            font1 = new Font("Arial", 30);
            font2 = new Font("Arial", 20);
            font3 = new Font("Arial", 16);

            testcontext = new songbookEntities2();

            loadIntro();
            // стартување тајмерот
            loadTimer = new Timer();
            loadTimer.Interval = 50;
            loadTimer.Tick += new EventHandler(timer_Tick);
            loadTimer.Start();
            // стартување на интро звукот
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.intro);
            player.Play();

        }

        //на секој такт на тајмерот се повикува методот за анимација на интрото 
        void timer_Tick(object sender, EventArgs e)
        {
            loadIntro();
        }

        //овој метод овозможува исцртување на интро информациите за апликацијата
        //така што во секое негово повикување дел од текстот го придвижуваме 
        // и после одредено време, одкако ќе заврши анимацијата се прикажува почетното мени
        private void loadIntro()
        {
            numbSteps++;
            if (numbSteps < 100)
            {
                //прецртување на помошното платно
                buffGraph.Clear(backgColor);
                buffGraph.DrawImage(Resources.logo, 350, 60, 400, 400);
                int do_kade = 460 - numbSteps * 3;
                if (do_kade < 290) { do_kade = 290; }
                buffGraph.DrawString("Песнарка со акорди", font1, brushBlue, new PointF(do_kade, 460));
                buffGraph.DrawString("Визуелно Програмирање 2012/13", font2, brushRed, new PointF(270, 510));
                int finki = -40 + numbSteps;
                if (finki > 20) { finki = 20; }
                buffGraph.DrawString("Факултет за информатички науки и компјутерско инжинерство (ФИНКИ) - Скопје", font3, brushDodgerBlue, new PointF(60, finki));
                buffGraph.DrawString("Филип Николоски (111154)", font3, brushDodgerBlue, new PointF(705, 590));
                buffGraph.DrawString("Александра Пазаркоска (115049)", font3, brushDodgerBlue, new PointF(640, 620));
                //лепење на целата исцртана слика од помошното платно на платното на интро панелот
                Graph.DrawImageUnscaled(buffBmp, 0, 0); 
            }
            else
            {
                //ги ослободуваме ресурсите за четки и фонтови затоа што нема да исцртуваме ништо подоцна
                //го запираме тајмерот кој служеше само за почетната анимација
                brushBlue.Dispose();
                brushDodgerBlue.Dispose();
                brushRed.Dispose();
                font1.Dispose();
                font2.Dispose();
                font3.Dispose();
                loadTimer.Stop();
                // иницијално поставување на листите со песни и категории
                UpdateSongs();
                UpdateCategories();
                Panels[1].Show(); // прикажување на почетно мени
            }
        }

        //овој метод овозможува прикажување на само еден панел во одредено време со тоа што
        //за прикажување на интро панелот(0) и мени панелот(1) се грижиме ние самите
        public void ShowPanel(int num)
        {
            for (int i = 2; i < Panels.Length; i++)
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

        //метод за додавање на нова песна во базата
        public bool AddSong(String _author, String _name, String _text, int _id_category)
        {
            // мора да се осигураме дека сеуште имаме пристап до базата
            // доколку не јавуваме соодветна порака
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
                if (currentCategory == _id_category)
                {
                    UpdateSongs("", true);
                }
                else
                {
                    UpdateSongs(); // ажурирање на листата на песни
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                MessageBox.Show("Настана проблем при додавање на песната.\nПроверете ја вашата интернет конекција.","Грешка при внесување");
                return false;
            }
        }

        //метод за додавање на нова категорија во базата
        public bool AddCategory(String _category)
        {
            try
            {
                category kategorija = new category
                {
                    id_category=1,
                    name_category=_category
                };
                testcontext.categories.AddObject(kategorija);
                testcontext.SaveChanges();
                UpdateCategories(); // ажурирање на листата на категории
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                MessageBox.Show("Настана проблем при додавање на категоријата.\nПроверете ја вашата интернет конекција.", "Грешка при внесување");
                return false;
            }
        }

        //метод за ажурирање на листата на песни
        //го повикуваме на почетокот на апликацијата
        //како и секогаш кога правиме некава промена (додавање или бришење на песна)
        public void UpdateSongs()
        {
            int temp = lbSongs.SelectedIndex;
            int temp2 = lbRemoveSong.SelectedIndex;

            var load = from g in testcontext.songs select g;
            if (load != null)
            {
                lbSongs.DataSource = load.ToList();
                lbRemoveSong.DataSource = load.ToList();
                // ако е избришана таа песна која е селектирана во пребарај песни
                if (temp == temp2)
                {
                    lbSongs.SelectedIndex = -1;
                }
                else
                {
                    lbSongs.SelectedIndex = temp;
                }
                lbRemoveSong.SelectedIndex = -1;
            }
        }

        //преоптоварен метод за ажурање на листата на песни
        //кој што прикажува песни од дадена категорија
        //кој воедно го користиме и за пребарување низ песните со тоа што
        //доколку не правиме пребарување стрингот кој го испраќаме е празен
        //додека пак булеан променливата ни кажува дали пребаруваме само низ една категорија
        public void UpdateSongs(String str,bool check)
        {
            if (check == false)
            {
                // пребарување низ сите песни
                var load = from g in testcontext.songs where g.name.Contains(str) || g.author.Contains(str) select g;
                lbSongs.DataSource = load;
            }
            else
            {
                //пребарување низ песните само од соодветната категорија
                category ca = cbShowCategory.SelectedItem as category;
                var load = from g in testcontext.songs where ca.id_category == g.id_category && (g.name.Contains(str) || g.author.Contains(str)) select g;
                lbSongs.DataSource = load;
                        //
                lbSongs.SelectedIndex = -1;

            }
        }

        //освежување на информациите во категориите
        public void UpdateCategories()   {
            int temp = cbAddSongCategory.SelectedIndex;
            int temp2 = cbShowCategory.SelectedIndex;
            var load = from g in testcontext.categories select g;
            if (load != null)
            {
                cbAddSongCategory.DataSource = load.ToList();
                cbShowCategory.DataSource = load.ToList();
                cbAddSongCategory.SelectedIndex = temp;
                cbShowCategory.SelectedIndex = temp2;
            }

            //osvezuvanje na kategoriite kaj pregledaj pesna

            if (cbShowCategory.SelectedIndex != -1)
            {
                UpdateSongs("", true);
            }
            else
            {
                UpdateSongs();
            }

            
        }

        public bool RemoveSong()
        {
            song p = lbRemoveSong.SelectedItem as song;
            int songId = p.id_song;
            try
            {
                song pesna = testcontext.songs.First(i => i.id_song == songId);
                testcontext.songs.DeleteObject(pesna);
                testcontext.SaveChanges();
                UpdateSongs();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
