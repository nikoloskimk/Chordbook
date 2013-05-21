namespace VP_Songbook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelIntro = new System.Windows.Forms.Panel();
            this.panelAddSong = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddSongClear = new System.Windows.Forms.Button();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddText = new System.Windows.Forms.TextBox();
            this.cbAddSongCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnShowSongs = new System.Windows.Forms.Button();
            this.panelShowSongs = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.cbShowCategory = new System.Windows.Forms.ComboBox();
            this.rbKategorija = new System.Windows.Forms.RadioButton();
            this.rbSite = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbAutorName = new System.Windows.Forms.TextBox();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panelAddSong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelShowSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelAddCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIntro
            // 
            this.panelIntro.Location = new System.Drawing.Point(499, 38);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(200, 100);
            this.panelIntro.TabIndex = 0;
            // 
            // panelAddSong
            // 
            this.panelAddSong.Controls.Add(this.groupBox1);
            this.panelAddSong.Location = new System.Drawing.Point(443, 490);
            this.panelAddSong.Name = "panelAddSong";
            this.panelAddSong.Size = new System.Drawing.Size(189, 51);
            this.panelAddSong.TabIndex = 4;
            this.panelAddSong.VisibleChanged += new System.EventHandler(this.panelAddSong_VisibleChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddAuthor);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAddSongClear);
            this.groupBox1.Controls.Add(this.tbAddName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAddText);
            this.groupBox1.Controls.Add(this.cbAddSongCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 622);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади песна";
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(179, 19);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(373, 20);
            this.tbAddAuthor.TabIndex = 0;
            this.tbAddAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddAuthor_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(568, 575);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додади песна";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddSongClear
            // 
            this.btnAddSongClear.BackColor = System.Drawing.Color.Red;
            this.btnAddSongClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSongClear.ForeColor = System.Drawing.Color.White;
            this.btnAddSongClear.Location = new System.Drawing.Point(179, 575);
            this.btnAddSongClear.Name = "btnAddSongClear";
            this.btnAddSongClear.Size = new System.Drawing.Size(173, 41);
            this.btnAddSongClear.TabIndex = 10;
            this.btnAddSongClear.Text = "Испразни полиња";
            this.btnAddSongClear.UseVisualStyleBackColor = false;
            this.btnAddSongClear.Click += new System.EventHandler(this.btnAddSongClear_Click);
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(179, 44);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(373, 20);
            this.tbAddName.TabIndex = 1;
            this.tbAddName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Текст:";
            // 
            // tbAddText
            // 
            this.tbAddText.Location = new System.Drawing.Point(179, 106);
            this.tbAddText.Multiline = true;
            this.tbAddText.Name = "tbAddText";
            this.tbAddText.Size = new System.Drawing.Size(562, 463);
            this.tbAddText.TabIndex = 2;
            this.tbAddText.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddText_Validating);
            // 
            // cbAddSongCategory
            // 
            this.cbAddSongCategory.FormattingEnabled = true;
            this.cbAddSongCategory.Location = new System.Drawing.Point(179, 73);
            this.cbAddSongCategory.Name = "cbAddSongCategory";
            this.cbAddSongCategory.Size = new System.Drawing.Size(373, 21);
            this.cbAddSongCategory.TabIndex = 5;
            this.cbAddSongCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cbAddSongCategory_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Автор на песната:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Наслов на песната:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button8);
            this.panelButtons.Controls.Add(this.button7);
            this.panelButtons.Controls.Add(this.button6);
            this.panelButtons.Controls.Add(this.button5);
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.btnAddCategory);
            this.panelButtons.Controls.Add(this.btnAddSong);
            this.panelButtons.Controls.Add(this.btnShowSongs);
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(225, 660);
            this.panelButtons.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::VP_Songbook.Properties.Resources.guitar_help;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(9, 489);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(209, 81);
            this.button7.TabIndex = 6;
            this.button7.Text = "Помош";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::VP_Songbook.Properties.Resources.guitar_clock;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(9, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 81);
            this.button6.TabIndex = 5;
            this.button6.Text = "Листа на чекање";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::VP_Songbook.Properties.Resources.guitar_delete;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(9, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "Избриши песна";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::VP_Songbook.Properties.Resources.guitar_search;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "Преслушај акорди";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = global::VP_Songbook.Properties.Resources.guitar_write;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(9, 249);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(209, 81);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Додади категорија";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.ForeColor = System.Drawing.Color.White;
            this.btnAddSong.Image = global::VP_Songbook.Properties.Resources.guitar_add;
            this.btnAddSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSong.Location = new System.Drawing.Point(9, 89);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(209, 81);
            this.btnAddSong.TabIndex = 1;
            this.btnAddSong.Text = "Додади песна";
            this.btnAddSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnShowSongs
            // 
            this.btnShowSongs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSongs.ForeColor = System.Drawing.Color.White;
            this.btnShowSongs.Image = global::VP_Songbook.Properties.Resources.guitar_zoom;
            this.btnShowSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSongs.Location = new System.Drawing.Point(9, 11);
            this.btnShowSongs.Name = "btnShowSongs";
            this.btnShowSongs.Size = new System.Drawing.Size(209, 79);
            this.btnShowSongs.TabIndex = 0;
            this.btnShowSongs.Text = "Прикажи песни";
            this.btnShowSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowSongs.UseVisualStyleBackColor = false;
            this.btnShowSongs.Click += new System.EventHandler(this.btnShowSongs_Click);
            // 
            // panelShowSongs
            // 
            this.panelShowSongs.Controls.Add(this.btnRandom);
            this.panelShowSongs.Controls.Add(this.labelCategory);
            this.panelShowSongs.Controls.Add(this.cbShowCategory);
            this.panelShowSongs.Controls.Add(this.rbKategorija);
            this.panelShowSongs.Controls.Add(this.rbSite);
            this.panelShowSongs.Controls.Add(this.tbSearch);
            this.panelShowSongs.Controls.Add(this.label2);
            this.panelShowSongs.Controls.Add(this.button2);
            this.panelShowSongs.Controls.Add(this.button1);
            this.panelShowSongs.Controls.Add(this.tbText);
            this.panelShowSongs.Controls.Add(this.tbAutorName);
            this.panelShowSongs.Controls.Add(this.lbSongs);
            this.panelShowSongs.Controls.Add(this.label1);
            this.panelShowSongs.Location = new System.Drawing.Point(443, 380);
            this.panelShowSongs.Name = "panelShowSongs";
            this.panelShowSongs.Size = new System.Drawing.Size(317, 98);
            this.panelShowSongs.TabIndex = 3;
            this.panelShowSongs.VisibleChanged += new System.EventHandler(this.panelShowSongs_VisibleChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Red;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(19, 585);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(194, 37);
            this.btnRandom.TabIndex = 13;
            this.btnRandom.Text = "Случајна песна";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(19, 86);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 13);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Категорија:";
            this.labelCategory.Visible = false;
            // 
            // cbShowCategory
            // 
            this.cbShowCategory.FormattingEnabled = true;
            this.cbShowCategory.Location = new System.Drawing.Point(107, 79);
            this.cbShowCategory.Name = "cbShowCategory";
            this.cbShowCategory.Size = new System.Drawing.Size(212, 21);
            this.cbShowCategory.TabIndex = 11;
            this.cbShowCategory.Visible = false;
            this.cbShowCategory.SelectedIndexChanged += new System.EventHandler(this.cbShowCategory_SelectedIndexChanged);
            // 
            // rbKategorija
            // 
            this.rbKategorija.AutoSize = true;
            this.rbKategorija.Location = new System.Drawing.Point(107, 38);
            this.rbKategorija.Name = "rbKategorija";
            this.rbKategorija.Size = new System.Drawing.Size(124, 17);
            this.rbKategorija.TabIndex = 10;
            this.rbKategorija.Text = "Само од категорија";
            this.rbKategorija.UseVisualStyleBackColor = true;
            this.rbKategorija.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbSite
            // 
            this.rbSite.AutoSize = true;
            this.rbSite.Checked = true;
            this.rbSite.Location = new System.Drawing.Point(19, 38);
            this.rbSite.Name = "rbSite";
            this.rbSite.Size = new System.Drawing.Size(82, 17);
            this.rbSite.TabIndex = 9;
            this.rbSite.TabStop = true;
            this.rbSite.Text = "Сите песни";
            this.rbSite.UseVisualStyleBackColor = true;
            this.rbSite.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(421, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(551, 20);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пребарај песна:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(534, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Претходна песна";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(778, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Следна песна";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.White;
            this.tbText.Location = new System.Drawing.Point(325, 106);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(647, 472);
            this.tbText.TabIndex = 4;
            // 
            // tbAutorName
            // 
            this.tbAutorName.Location = new System.Drawing.Point(325, 80);
            this.tbAutorName.Name = "tbAutorName";
            this.tbAutorName.ReadOnly = true;
            this.tbAutorName.Size = new System.Drawing.Size(647, 20);
            this.tbAutorName.TabIndex = 2;
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(19, 106);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(300, 472);
            this.lbSongs.TabIndex = 1;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прикажи песни";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelAddCategory
            // 
            this.panelAddCategory.Controls.Add(this.groupBox2);
            this.panelAddCategory.Location = new System.Drawing.Point(88, 372);
            this.panelAddCategory.Name = "panelAddCategory";
            this.panelAddCategory.Size = new System.Drawing.Size(302, 185);
            this.panelAddCategory.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbAddCategory);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади категорија";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(303, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Додади категорија";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Име на категорија:";
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(153, 80);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(309, 20);
            this.tbAddCategory.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::VP_Songbook.Properties.Resources.guitar_close;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(9, 569);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 81);
            this.button8.TabIndex = 7;
            this.button8.Text = "Излез";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelAddSong);
            this.Controls.Add(this.panelShowSongs);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.panelAddCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Песнарка со акорди";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAddSong.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelShowSongs.ResumeLayout(false);
            this.panelShowSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelAddCategory.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnShowSongs;
        private System.Windows.Forms.Panel panelShowSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbAutorName;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Panel panelAddSong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAddText;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.ComboBox cbAddSongCategory;
        private System.Windows.Forms.Button btnAddSongClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbKategorija;
        private System.Windows.Forms.RadioButton rbSite;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox cbShowCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panelAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

