using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VP_Songbook.Properties;

namespace VP_Songbook
{
    public partial class Form1 : Form
    {
        Panel[] Panels;
        Controller Kontroler;

        public Form1()
        {
            InitializeComponent();
            Panels = new Panel[5];
            Panels[0] = panelIntro;
            Panels[0].Location = new Point(0, 0);
            Panels[0].Width = this.Width;
            Panels[0].Height = this.Height;
            Panels[1] = panelButtons;
            Panels[1].Location = new Point(0, 27);
            Panels[1].Width = this.Width;
            Panels[1].Height = this.Height - 27;
            Panels[2] = panelShowSongs;
            Panels[2].Location = new Point(0, 27);
            Panels[2].Width = this.Width;
            Panels[2].Height = this.Height - 27;
            Panels[3] = panelAddSong;
            Panels[3].Location = new Point(0, 27);
            Panels[3].Width = this.Width;
            Panels[3].Height = this.Height - 27;
            Panels[4] = panelAddCategory;
            Panels[4].Location = new Point(0, 27);
            Panels[4].Width = this.Width;
            Panels[4].Height = this.Height - 27;
            Kontroler = new Controller(Panels);
            
        }

        private void btnShowSongs_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(2);
        }

        private void LoadToList()
        {
             
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // zosto ne pominuva na site validacijata???
            if (tbAddAuthor.Text.Trim().Length == 0 || tbAddName.Text.Trim().Length == 0 ||
                tbAddText.Text.Trim().Length == 0 || cbAddSongCategory.SelectedIndex==-1)
            {
                if(!ValidateChildren())
                return;
            }
            else
            {
                category c = (category)cbAddSongCategory.SelectedItem;
                Kontroler.AddSong(tbAddAuthor.Text, tbAddName.Text, tbAddText.Text, c.id_category);
                tbAddAuthor.Text = "";
                tbAddName.Text = "";
                tbAddText.Text = "";
                cbAddSongCategory.SelectedIndex = -1;
            }
            

        }

        // prikazi paneli
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(3);
        }
        private void naPocetna_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(1);
        }

        private void panelShowSongs_VisibleChanged(object sender, EventArgs e)
        {
            songbookEntities2 TestContext = new songbookEntities2();
            var load = from g in TestContext.songs select g;

            if (load != null)
            {
                lbSongs.DataSource = load.ToList();
            }
        }

        private void panelAddSong_VisibleChanged(object sender, EventArgs e)
        {
            if (cbAddSongCategory.SelectedIndex == -1)
            {
                songbookEntities2 TestContext = new songbookEntities2();
                var load = from g in TestContext.categories select g;

                if (load != null)
                {
                    cbAddSongCategory.DataSource = load.ToList();
                    cbAddSongCategory.SelectedIndex = -1;
                }
            }
        }



        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex != -1)
            {
                song s = (song)lbSongs.SelectedItem;
                tbAutorName.Text = s.author+" - "+s.name;
                tbText.Text = s.text;
            }
        }


        private void tbAddAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddAuthor.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddAuthor, "Внесете име на авторот");
            }
            else
            {
                errorProvider1.SetError(tbAddAuthor, "");
            }
        }


        private void tbAddText_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddText.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddText, "Внесете текст на песната");
            }
            else
            {
                errorProvider1.SetError(tbAddText, "");
            }
        }

        private void cbAddSongCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cbAddSongCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbAddSongCategory, "Изберете категорија");
            }
            else
            {
                errorProvider1.SetError(cbAddSongCategory, "");
            }
        }

        private void tbAddName_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddName, "Внесете име на песната");
            }
            else
            {
                errorProvider1.SetError(tbAddName, "");
            }
        }

        private void btnAddSongClear_Click(object sender, EventArgs e)
        {
            tbAddAuthor.Text = "";
            tbAddName.Text = "";
            tbAddText.Text = "";
            cbAddSongCategory.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbSongs.SelectedIndex = (lbSongs.SelectedIndex + 1) % lbSongs.Items.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex == 0)
            {
                lbSongs.SelectedIndex = lbSongs.Items.Count - 1;
            }
            else
            {
                lbSongs.SelectedIndex -= 1;
            }
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbKategorija.Checked == false)
            {
                // baraj od site pesni
                songbookEntities2 testcontext = new songbookEntities2();
                String a = tbSearch.Text;
                var load = from g in testcontext.songs where g.name.Contains(a) || g.author.Contains(a) select g;
                lbSongs.DataSource = load;
            }
            else
            {
                //baraj od pesnite od taa kategorija
                songbookEntities2 testcontext = new songbookEntities2();
                String a = tbSearch.Text;
                category ca = cbShowCategory.SelectedItem as category;
                var load = from g in testcontext.songs where ca.id_category==g.id_category && (g.name.Contains(a) || g.author.Contains(a)) select g;
                lbSongs.DataSource = load;
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelCategory.Show();
            cbShowCategory.Show();

            songbookEntities2 TestContext = new songbookEntities2();
            var load = from g in TestContext.categories select g;

            if (load != null)
            {
                cbShowCategory.DataSource = load.ToList();
                cbShowCategory.SelectedIndex = -1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelCategory.Hide();
            cbShowCategory.Hide();

            songbookEntities2 TestContext = new songbookEntities2();
            var load = from g in TestContext.songs select g;

            if (load != null)
            {
                lbSongs.DataSource = load.ToList();
                cbShowCategory.SelectedIndex = -1;
            }
        }

        private void cbShowCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShowCategory.SelectedIndex != -1)
            {
                category ca = cbShowCategory.SelectedItem as category;
                songbookEntities2 TestContext = new songbookEntities2();
                var load = from g in TestContext.songs where ca.id_category == g.id_category select g;

                if (load != null)
                {
                    lbSongs.DataSource = load.ToList();
                }
            }
            else
            {
                songbookEntities2 TestContext = new songbookEntities2();
                var load = from g in TestContext.songs select g;

                if (load != null)
                {
                    lbSongs.DataSource = load.ToList();
                }
            }
        }

        private void крајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        // dodavanje kategorija
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(4);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (lbSongs.Items.Count != 0)
            {
                Random r = new Random();
                lbSongs.SelectedIndex = r.Next(0, lbSongs.Items.Count);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //direktno validacija
            if (tbAddCategory.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddCategory, "Внесете име на категоријата");
                return;
            }
            Kontroler.AddCategory(tbAddCategory.Text);
            tbAddCategory.Text = "";
            Kontroler.ShowPanel(1);
        }








        
    }
}
