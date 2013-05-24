using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VP_Songbook.Properties;
using System.Diagnostics;

namespace VP_Songbook
{
    public partial class Form1 : Form
    {
        Panel[] Panels;
        Controller Kontroler;

        public Form1()
        {
            CheckConnection();
            InitializeComponent();
            this.DoubleBuffered = true;
            Panels = new Panel[8];
            Panels[0] = panelIntro;
            Panels[0].Location = new Point(0, 0);
            Panels[0].Width = this.Width;
            Panels[0].Height = this.Height;
            Panels[1] = panelButtons;
            Panels[1].Location = new Point(0, 0);
            //   Panels[1].Width = this.Width;
            //   Panels[1].Height = this.Height;
            Panels[2] = panelShowSongs;
            Panels[2].Location = new Point(225, 0);
            Panels[2].Width = this.Width - 225;
            Panels[2].Height = this.Height;
            Panels[3] = panelAddSong;
            Panels[3].Location = new Point(225, 0);
            Panels[3].Width = this.Width - 225;
            Panels[3].Height = this.Height;
            Panels[4] = panelAddCategory;
            Panels[4].Location = new Point(225, 0);
            Panels[4].Width = this.Width - 225;
            Panels[4].Height = this.Height;
            Panels[5] = panelWaitList;
            Panels[5].Location = new Point(225, 0);
            Panels[5].Width = this.Width - 225;
            Panels[5].Height = this.Height;
            Panels[6] = panelRemoveSong;
            Panels[6].Location = new Point(225, 0);
            Panels[6].Width = this.Width - 225;
            Panels[6].Height = this.Height;
            Panels[7] = panelListenChords;
            Panels[7].Location = new Point(225, 0);
            Panels[7].Width = this.Width - 225;
            Panels[7].Height = this.Height;

            Kontroler = new Controller(Panels, lbSongs, cbShowCategory, cbAddSongCategory,lbRemoveSong, cbWaitSongCategory,lbWaitSong);

        }
        //проверка на исправност на конекција
        private void CheckConnection()
        {
            
            try
            {
                songbookEntities2 testcontext = new songbookEntities2();
                testcontext.songs.Execute(System.Data.Objects.MergeOption.NoTracking);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Process.GetCurrentProcess().Kill();
            }
        }

////////////////////////////Panels[1] - Навигационо мени ///////////////////////////////////
        private void btnMenuAddSong_Click(object sender, EventArgs e)
        {
            lblSuccessfull.Text = "";
            Kontroler.ShowPanel(3);
        }
        private void btnMenuShowSongs_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(2);
        }
        private void btnMenuAddCategory_Click(object sender, EventArgs e)
        {
            lblSuccCategory.Text = "";
            Kontroler.ShowPanel(4);
        }
        private void btnMenuWaitList_Click(object sender, EventArgs e)
        {
            lblWaitAdd.Text = "";
            lblWaitSongSuccess.Text = "";
            Kontroler.ShowPanel(5);
        }
        private void btnMenuRemoveSong_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(6);
        }
        private void btnMenuListenChords_Click(object sender, EventArgs e)
        {
            Kontroler.ShowPanel(7);
        }
        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            FormHelp pomos = new FormHelp();
            pomos.ShowDialog();
        }
        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


////////////////////////////Panels[2] - Прикажи песни ///////////////////////////////////
        //навигација (наназад) низ листата на песни
        private void btnPreviousSong_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex != -1)
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
        }
        //навигација (нанапред) низ листата на песни
        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex != -1)
            {
                lbSongs.SelectedIndex = (lbSongs.SelectedIndex + 1) % lbSongs.Items.Count;
            }
        }
        //прикажување на рандом песна
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (lbSongs.Items.Count != 0)
            {
                Random r = new Random();
                lbSongs.SelectedIndex = r.Next(0, lbSongs.Items.Count);
            }
        }
        //избор на песна од листата
        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSongs.SelectedIndex != -1)
            {
                song s = (song)lbSongs.SelectedItem;
                tbAutorName.Text = s.author + " - " + s.name;
                tbText.Text = s.text;
            }
            else
            {
                tbAutorName.Text = "";
                tbText.Text = "";
            }
        }
        //пребарување низ листата на песни
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Kontroler.UpdateSongs(tbSearch.Text, rbKategorija.Checked);
        }
        //промена на категорија
        private void cbShowCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kontroler.UpdateSongs("", true);
        }
        //приказ без категории
        private void rbSite_CheckedChanged(object sender, EventArgs e)
        {
            labelCategory.Hide();
            cbShowCategory.Hide();
            Kontroler.UpdateSongs();
        }
        //приказ со категории
        private void rbKategorija_CheckedChanged(object sender, EventArgs e)
        {
            labelCategory.Show();
            cbShowCategory.Show();
            cbShowCategory.SelectedIndex = -1;
            Kontroler.UpdateSongs();
            Kontroler.UpdateCategories();
        }


////////////////////////////Panels[3] - Додади песна ///////////////////////////////////
        // копче за додавање на песна
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAddAuthor.Text.Trim().Length == 0 || tbAddName.Text.Trim().Length == 0 ||
                tbAddText.Text.Trim().Length == 0 || cbAddSongCategory.SelectedIndex == -1)
            {
                if (!ValidateChildren())
                    return;
            }
            else
            {
                category c = (category)cbAddSongCategory.SelectedItem;
                bool dali = Kontroler.AddSong(tbAddAuthor.Text, tbAddName.Text, tbAddText.Text, c.id_category);
                if (dali)
                {
                    lblSuccessfull.ForeColor = Color.Green;
                    lblSuccessfull.Text = "Успешно внесена песна!";
                    tbAddAuthor.Text = "";
                    tbAddName.Text = "";
                    tbAddText.Text = "";
                    cbAddSongCategory.SelectedIndex = -1;
                }
                else
                {
                    lblSuccessfull.ForeColor = Color.Red;
                    lblSuccessfull.Text = "Неуспешно внесена песна!";
                }
            }


        }
        //исчисти полиња
        private void btnAddSongClear_Click(object sender, EventArgs e)
        {
            tbAddAuthor.Text = "";
            tbAddName.Text = "";
            tbAddText.Text = "";
            lblSuccessfull.Text = "";
            cbAddSongCategory.SelectedIndex = -1;
        }
        //валидација при внесување на песна
        private void tbAddAuthor_Validating(object sender, CancelEventArgs e)
        {
            lblSuccessfull.Text = "";
            if (tbAddAuthor.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddAuthor, "Внесете име на авторот");
            }
            else
            {
                errorProvider1.SetError(tbAddAuthor, null);
            }
        }
        private void tbAddText_Validating(object sender, CancelEventArgs e)
        {
            lblSuccessfull.Text = "";
            if (tbAddText.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddText, "Внесете текст на песната");
            }
            else
            {
                errorProvider1.SetError(tbAddText, null);
            }
        }
        private void cbAddSongCategory_Validating(object sender, CancelEventArgs e)
        {
            lblSuccessfull.Text = "";
            if (cbAddSongCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbAddSongCategory, "Изберете категорија");
            }
            else
            {
                errorProvider1.SetError(cbAddSongCategory, null);
            }
        }
        private void tbAddName_Validating(object sender, CancelEventArgs e)
        {
            lblSuccessfull.Text = "";
            if (tbAddName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddName, "Внесете име на песната");
            }
            else
            {
                errorProvider1.SetError(tbAddName, null);
            }
        }


////////////////////////////Panels[4] - Избриши песна ///////////////////////////////////

        private void lbRemoveSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRemoveStatus.Text = "";
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (lbRemoveSong.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете песната?",
                    "Избриши песна?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool dali=Kontroler.RemoveSong();
                    if (dali)
                    {
                        lblRemoveStatus.ForeColor = Color.Green;
                        lblRemoveStatus.Text = "Песната е успешно избришана!";
                    }
                    else
                    {
                        lblRemoveStatus.ForeColor = Color.Red;
                        lblRemoveStatus.Text = "Настана грешка при бришењето на песната!";
                    }
                }
            }
        }

////////////////////////////Panels[5] - Додади категорија ////////////////////////////////
        //додавање на категорија
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            lblSuccCategory.Text = "";
            //direktno validacija
            if (tbAddCategory.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbAddCategory, "Внесете име на категоријата");
                return;
            }
            errorProvider1.SetError(tbAddCategory, null);
            bool dali = Kontroler.AddCategory(tbAddCategory.Text);
            if (dali)
            {
                lblSuccCategory.ForeColor = Color.Green;
                lblSuccCategory.Text = "Успешно внесена категорија!";
            }
            else
            {
                lblSuccCategory.ForeColor = Color.Red;
                lblSuccCategory.Text = "Неуспешно внесена категорија!";
            }
            tbAddCategory.Text = "";
        }

////////////////////////////Panels[6] - Листа на чекање ///////////////////////////////////


////////////////////////////Panels[7] - Преслушај акорди ///////////////////////////////////
        //Дурски (major) акорди
        private void btnChordC_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.C1);
            player.Play();
            player.Dispose();
        }
        private void btnChordCS_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.CS);
            player.Play();
            player.Dispose();
        }
        private void btnChordD_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.D1);
            player.Play();
            player.Dispose();
        }
        private void btnChordDS_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.DS);
            player.Play();
            player.Dispose();
        }
        private void btnChordE_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.E1);
            player.Play();
            player.Dispose();
        }
        private void btnChordF_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.F1);
            player.Play();
            player.Dispose();
        }
        private void btnChordFS_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.FS);
            player.Play();
            player.Dispose();
        }
        private void btnChordG_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.G1);
            player.Play();
            player.Dispose();
        }
        private void btnChordGS_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.GS);
            player.Play();
            player.Dispose();
        }
        private void btnChordA_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.A1);
            player.Play();
            player.Dispose();
        }
        private void btnChordAS_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.AS);
            player.Play();
            player.Dispose();
        }
        private void btnChordH_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.H1);
            player.Play();
            player.Dispose();
        }
        //Молски (minor) акорди
        private void btnChordCm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Cm1);
            player.Play();
            player.Dispose();

        }
        private void btnChordCSm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.CSm);
            player.Play();
            player.Dispose();

        }
        private void btnChordDm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Dm1);
            player.Play();
            player.Dispose();
        }
        private void btnChordDSm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.DSm);
            player.Play();
            player.Dispose();

        }
        private void btnChordEm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Em1);
            player.Play();
            player.Dispose();
        }
        private void btnChordFm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Fm1);
            player.Play();
            player.Dispose();
        }
        private void btnChordFSm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.FSm);
            player.Play();
            player.Dispose();
        }
        private void btnChordGm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Gm1);
            player.Play();
            player.Dispose();

        }
        private void btnChordGSm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.GSm);
            player.Play();
            player.Dispose();
        }
        private void btnChordAm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Am1);
            player.Play();
            player.Dispose();
        }
        private void btnChordASm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.ASm);
            player.Play();
            player.Dispose();
        }
        private void btnChordHm_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.Hm1);
            player.Play();
            player.Dispose();
        }

        private void tbWaitSongAuthor_Validating(object sender, CancelEventArgs e)
        {
            lblWaitSongSuccess.Text = "";
            if (tbWaitSongAuthor.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbWaitSongAuthor, "Внесете име на авторот");
            }
            else
            {
                errorProvider1.SetError(tbWaitSongAuthor, null);
            }
        }

        private void tbWaitSongName_Validating(object sender, CancelEventArgs e)
        {
            lblWaitSongSuccess.Text = "";
            if (tbWaitSongName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbWaitSongName, "Внесете име на песна");
            }
            else
            {
                errorProvider1.SetError(tbWaitSongName, null);
            }
        }

        private void cbWaitSongCategory_Validating(object sender, CancelEventArgs e)
        {
            lblWaitSongSuccess.Text = "";
            if (cbWaitSongCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbWaitSongCategory, "Изберете категорија");
            }
            else
            {
                errorProvider1.SetError(cbWaitSongCategory, null);
            }
        }

        private void btnAddToWaitSong_Click(object sender, EventArgs e)
        {
            if (tbWaitSongAuthor.Text.Trim().Length == 0 || tbWaitSongName.Text.Trim().Length == 0 ||
                cbWaitSongCategory.SelectedIndex == -1)
            {
                if (!ValidateChildren())
                    return;
            }
            else
            {
                category c = (category)cbWaitSongCategory.SelectedItem;
                bool dali = Kontroler.AddWaitSong(tbWaitSongAuthor.Text, tbWaitSongName.Text, c.id_category);
                if (dali)
                {
                    lblWaitSongSuccess.ForeColor = Color.Green;
                    lblWaitSongSuccess.Text = "Успешно додадена песна во листата на чекање!";
                    tbWaitSongAuthor.Text = "";
                    tbWaitSongName.Text = "";
                    cbWaitSongCategory.SelectedIndex = -1;
                }
                else
                {
                    lblWaitSongSuccess.ForeColor = Color.Red;
                    lblWaitSongSuccess.Text = "Неуспешно додадена песна во листата на чекање!";
                }
            }
        }

        private void btnWaitSongRemove_Click(object sender, EventArgs e)
        {
            if (lbWaitSong.SelectedIndex != -1)
            {
                Kontroler.RemoveWaitSong();
            }
        }

        private void btnAddFromWaitToSongs_Click(object sender, EventArgs e)
        {
            if (tbWaitSong.Text.Trim().Length > 0 && lbWaitSong.SelectedIndex != -1)
            {
                waitsong c = (waitsong)lbWaitSong.SelectedItem;
                bool dali = Kontroler.AddSong(c.author_waitsong, c.name_waitsong, tbWaitSong.Text, c.id_category);
                if (dali)
                {
                    lblWaitAdd.ForeColor = Color.Green;
                    lblWaitAdd.Text = "Успешно внесена песна!";
                    tbWaitSong.Text = "";
                    Kontroler.RemoveWaitSong();
                }
                else
                {
                    lblWaitAdd.ForeColor = Color.Red;
                    lblWaitAdd.Text = "Неуспешно внесена песна!";
                }
            }
            else
            {
                lblWaitAdd.ForeColor = Color.Red;
                lblWaitAdd.Text = "Избери песна и внеси текст!";
            }
        }


// ///////////////////////// do ovde///////////////


        //ok
        
    }
}
