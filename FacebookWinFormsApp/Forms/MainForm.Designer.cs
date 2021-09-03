
namespace FacebookWinFormsApp
{
    public partial class MainForm
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabFriendsAndGroups;
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendarBirthday = new FacebookWinFormsApp.Proxy.MonthCalendarProxy();
            this.radioButtonCloseFriend = new System.Windows.Forms.RadioButton();
            this.radioButtonFarFriend = new System.Windows.Forms.RadioButton();
            this.buttonMakeBirthday = new System.Windows.Forms.Button();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelFriendLastName = new System.Windows.Forms.Label();
            this.labelFriendGender = new System.Windows.Forms.Label();
            this.labelFriendFirstName = new System.Windows.Forms.Label();
            this.labelFriendBirthday = new System.Windows.Forms.Label();
            this.tabCustomPost = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewMessagesLbl = new System.Windows.Forms.Label();
            this.listBoxCustomPosts = new System.Windows.Forms.ListBox();
            this.buttonEditCustomPost = new System.Windows.Forms.Button();
            this.buttonRemoveFromPostList = new System.Windows.Forms.Button();
            this.buttonClearAllCustomPost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEditPostText = new System.Windows.Forms.Label();
            this.textBoxCustomPost = new System.Windows.Forms.TextBox();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonSaveCustomPostToList = new System.Windows.Forms.Button();
            this.tabFinance = new System.Windows.Forms.TabPage();
            this.labelSearchStock = new System.Windows.Forms.Label();
            this.textBoxSearchStock = new System.Windows.Forms.TextBox();
            this.pictureBoxStock = new System.Windows.Forms.PictureBox();
            this.labelStockIpo = new System.Windows.Forms.Label();
            this.labelStockChanges = new System.Windows.Forms.Label();
            this.buttonFetchStockDetails = new System.Windows.Forms.Button();
            this.labelStockPrice = new System.Windows.Forms.Label();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPhotosComments = new System.Windows.Forms.ListBox();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxSortPostsByOrder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.webBrowserPages = new System.Windows.Forms.WebBrowser();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.checkBoxDarkMode = new System.Windows.Forms.CheckBox();
            this.buttonChooseCustomedPost = new System.Windows.Forms.Button();
            this.pictureBoxWeatherPredict = new System.Windows.Forms.PictureBox();
            this.labelWeatherDetails = new System.Windows.Forms.Label();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.labelTemperatureInFahrnheit = new System.Windows.Forms.Label();
            this.labelTemperatureInCelcius = new System.Windows.Forms.Label();
            this.labelPredictWeather = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.buttonFetchWeatherDetails = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonRemoveFromList = new System.Windows.Forms.TabControl();
            tabFriendsAndGroups = new System.Windows.Forms.TabPage();
            tabFriendsAndGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabCustomPost.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStock)).BeginInit();
            this.tabAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherPredict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.buttonRemoveFromList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFriendsAndGroups
            // 
            tabFriendsAndGroups.AutoScroll = true;
            tabFriendsAndGroups.BackColor = System.Drawing.Color.LightCyan;
            tabFriendsAndGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabFriendsAndGroups.Controls.Add(this.splitContainer5);
            tabFriendsAndGroups.Controls.Add(this.splitContainer4);
            tabFriendsAndGroups.Location = new System.Drawing.Point(4, 25);
            tabFriendsAndGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabFriendsAndGroups.Name = "tabFriendsAndGroups";
            tabFriendsAndGroups.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabFriendsAndGroups.Size = new System.Drawing.Size(1130, 595);
            tabFriendsAndGroups.TabIndex = 5;
            tabFriendsAndGroups.Text = "Friends & Groups";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(6, 323);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer5.Panel1.Controls.Add(this.listBoxGroups);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer5.Panel2.Controls.Add(this.imageNormalPictureBox);
            this.splitContainer5.Panel2.Controls.Add(this.buttonFetchGroups);
            this.splitContainer5.Size = new System.Drawing.Size(1075, 262);
            this.splitContainer5.SplitterDistance = 354;
            this.splitContainer5.TabIndex = 15;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.AllowDrop = true;
            this.listBoxGroups.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.HorizontalScrollbar = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(5, 2);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(315, 244);
            this.listBoxGroups.TabIndex = 1;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageNormalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(60, 35);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(144, 139);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 16;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFetchGroups.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchGroups.Location = new System.Drawing.Point(3, 206);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(328, 36);
            this.buttonFetchGroups.TabIndex = 15;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.listBoxFriends);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer4.Panel2.Controls.Add(this.monthCalendarBirthday);
            this.splitContainer4.Panel2.Controls.Add(this.radioButtonCloseFriend);
            this.splitContainer4.Panel2.Controls.Add(this.radioButtonFarFriend);
            this.splitContainer4.Panel2.Controls.Add(this.buttonMakeBirthday);
            this.splitContainer4.Panel2.Controls.Add(this.labelFriendEmail);
            this.splitContainer4.Panel2.Controls.Add(this.buttonFetchFriends);
            this.splitContainer4.Panel2.Controls.Add(this.pictureBoxFriend);
            this.splitContainer4.Panel2.Controls.Add(this.labelFriendLastName);
            this.splitContainer4.Panel2.Controls.Add(this.labelFriendGender);
            this.splitContainer4.Panel2.Controls.Add(this.labelFriendFirstName);
            this.splitContainer4.Panel2.Controls.Add(this.labelFriendBirthday);
            this.splitContainer4.Size = new System.Drawing.Size(1081, 307);
            this.splitContainer4.SplitterDistance = 333;
            this.splitContainer4.TabIndex = 3;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxFriends.DataSource = this.friendListBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 6);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(320, 292);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.ValueMember = "Id";
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // monthCalendarBirthday
            // 
            this.monthCalendarBirthday.Location = new System.Drawing.Point(411, 11);
            this.monthCalendarBirthday.Name = "monthCalendarBirthday";
            this.monthCalendarBirthday.TabIndex = 22;
            // 
            // radioButtonCloseFriend
            // 
            this.radioButtonCloseFriend.AutoSize = true;
            this.radioButtonCloseFriend.Location = new System.Drawing.Point(534, 231);
            this.radioButtonCloseFriend.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCloseFriend.Name = "radioButtonCloseFriend";
            this.radioButtonCloseFriend.Size = new System.Drawing.Size(108, 21);
            this.radioButtonCloseFriend.TabIndex = 21;
            this.radioButtonCloseFriend.Text = "Close Friend";
            this.radioButtonCloseFriend.UseVisualStyleBackColor = true;
            this.radioButtonCloseFriend.CheckedChanged += new System.EventHandler(this.radioButtonCloseFriend_CheckedChanged);
            // 
            // radioButtonFarFriend
            // 
            this.radioButtonFarFriend.AutoSize = true;
            this.radioButtonFarFriend.Checked = true;
            this.radioButtonFarFriend.Location = new System.Drawing.Point(411, 231);
            this.radioButtonFarFriend.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFarFriend.Name = "radioButtonFarFriend";
            this.radioButtonFarFriend.Size = new System.Drawing.Size(94, 21);
            this.radioButtonFarFriend.TabIndex = 20;
            this.radioButtonFarFriend.TabStop = true;
            this.radioButtonFarFriend.Text = "Far Friend";
            this.radioButtonFarFriend.UseVisualStyleBackColor = true;
            this.radioButtonFarFriend.CheckedChanged += new System.EventHandler(this.radioButtonFarFriend_CheckedChanged);
            // 
            // buttonMakeBirthday
            // 
            this.buttonMakeBirthday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMakeBirthday.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMakeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMakeBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMakeBirthday.Location = new System.Drawing.Point(388, 258);
            this.buttonMakeBirthday.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonMakeBirthday.Name = "buttonMakeBirthday";
            this.buttonMakeBirthday.Size = new System.Drawing.Size(299, 36);
            this.buttonMakeBirthday.TabIndex = 19;
            this.buttonMakeBirthday.Text = "Make Birthday";
            this.buttonMakeBirthday.UseVisualStyleBackColor = false;
            this.buttonMakeBirthday.Click += new System.EventHandler(this.buttonMakeBirthday_Click);
            // 
            // labelFriendEmail
            // 
            this.labelFriendEmail.AutoSize = true;
            this.labelFriendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendEmail.Location = new System.Drawing.Point(215, 151);
            this.labelFriendEmail.Name = "labelFriendEmail";
            this.labelFriendEmail.Size = new System.Drawing.Size(57, 17);
            this.labelFriendEmail.TabIndex = 13;
            this.labelFriendEmail.Text = "Email: ";
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFetchFriends.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchFriends.Location = new System.Drawing.Point(17, 258);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(328, 36);
            this.buttonFetchFriends.TabIndex = 14;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFriend.Location = new System.Drawing.Point(51, 33);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(144, 139);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 1;
            this.pictureBoxFriend.TabStop = false;
            // 
            // labelFriendLastName
            // 
            this.labelFriendLastName.AutoSize = true;
            this.labelFriendLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendLastName.Location = new System.Drawing.Point(215, 62);
            this.labelFriendLastName.Name = "labelFriendLastName";
            this.labelFriendLastName.Size = new System.Drawing.Size(95, 17);
            this.labelFriendLastName.TabIndex = 10;
            this.labelFriendLastName.Text = "Last Name: ";
            // 
            // labelFriendGender
            // 
            this.labelFriendGender.AutoSize = true;
            this.labelFriendGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendGender.Location = new System.Drawing.Point(215, 122);
            this.labelFriendGender.Name = "labelFriendGender";
            this.labelFriendGender.Size = new System.Drawing.Size(72, 17);
            this.labelFriendGender.TabIndex = 12;
            this.labelFriendGender.Text = "Gender: ";
            // 
            // labelFriendFirstName
            // 
            this.labelFriendFirstName.AutoSize = true;
            this.labelFriendFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendFirstName.Location = new System.Drawing.Point(215, 33);
            this.labelFriendFirstName.Name = "labelFriendFirstName";
            this.labelFriendFirstName.Size = new System.Drawing.Size(96, 17);
            this.labelFriendFirstName.TabIndex = 9;
            this.labelFriendFirstName.Text = "First Name: ";
            // 
            // labelFriendBirthday
            // 
            this.labelFriendBirthday.AutoSize = true;
            this.labelFriendBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendBirthday.Location = new System.Drawing.Point(215, 92);
            this.labelFriendBirthday.Name = "labelFriendBirthday";
            this.labelFriendBirthday.Size = new System.Drawing.Size(80, 17);
            this.labelFriendBirthday.TabIndex = 11;
            this.labelFriendBirthday.Text = "BirthDay: ";
            // 
            // tabCustomPost
            // 
            this.tabCustomPost.AutoScroll = true;
            this.tabCustomPost.BackColor = System.Drawing.Color.LightCyan;
            this.tabCustomPost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCustomPost.Controls.Add(this.panel2);
            this.tabCustomPost.Controls.Add(this.panel1);
            this.tabCustomPost.Location = new System.Drawing.Point(4, 25);
            this.tabCustomPost.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomPost.Name = "tabCustomPost";
            this.tabCustomPost.Size = new System.Drawing.Size(1130, 595);
            this.tabCustomPost.TabIndex = 7;
            this.tabCustomPost.Text = "Custom Post";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewMessagesLbl);
            this.panel2.Controls.Add(this.listBoxCustomPosts);
            this.panel2.Controls.Add(this.buttonEditCustomPost);
            this.panel2.Controls.Add(this.buttonRemoveFromPostList);
            this.panel2.Controls.Add(this.buttonClearAllCustomPost);
            this.panel2.Location = new System.Drawing.Point(569, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 458);
            this.panel2.TabIndex = 7;
            // 
            // listViewMessagesLbl
            // 
            this.listViewMessagesLbl.AutoSize = true;
            this.listViewMessagesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewMessagesLbl.Location = new System.Drawing.Point(176, 7);
            this.listViewMessagesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listViewMessagesLbl.Name = "listViewMessagesLbl";
            this.listViewMessagesLbl.Size = new System.Drawing.Size(145, 17);
            this.listViewMessagesLbl.TabIndex = 9;
            this.listViewMessagesLbl.Text = "Your Custom Posts";
            // 
            // listBoxCustomPosts
            // 
            this.listBoxCustomPosts.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxCustomPosts.FormattingEnabled = true;
            this.listBoxCustomPosts.ItemHeight = 16;
            this.listBoxCustomPosts.Location = new System.Drawing.Point(19, 27);
            this.listBoxCustomPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCustomPosts.Name = "listBoxCustomPosts";
            this.listBoxCustomPosts.Size = new System.Drawing.Size(420, 372);
            this.listBoxCustomPosts.TabIndex = 8;
            this.listBoxCustomPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomPosts_SelectedIndexChanged);
            // 
            // buttonEditCustomPost
            // 
            this.buttonEditCustomPost.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEditCustomPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEditCustomPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditCustomPost.Location = new System.Drawing.Point(197, 430);
            this.buttonEditCustomPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditCustomPost.Name = "buttonEditCustomPost";
            this.buttonEditCustomPost.Size = new System.Drawing.Size(89, 28);
            this.buttonEditCustomPost.TabIndex = 7;
            this.buttonEditCustomPost.Text = "Edit";
            this.buttonEditCustomPost.UseVisualStyleBackColor = false;
            this.buttonEditCustomPost.Click += new System.EventHandler(this.buttonEditCustomPost_Click);
            // 
            // buttonRemoveFromPostList
            // 
            this.buttonRemoveFromPostList.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRemoveFromPostList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRemoveFromPostList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemoveFromPostList.Location = new System.Drawing.Point(19, 430);
            this.buttonRemoveFromPostList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveFromPostList.Name = "buttonRemoveFromPostList";
            this.buttonRemoveFromPostList.Size = new System.Drawing.Size(105, 28);
            this.buttonRemoveFromPostList.TabIndex = 4;
            this.buttonRemoveFromPostList.Text = "Remove";
            this.buttonRemoveFromPostList.UseVisualStyleBackColor = false;
            this.buttonRemoveFromPostList.Click += new System.EventHandler(this.buttonRemoveCustomPost_Click);
            // 
            // buttonClearAllCustomPost
            // 
            this.buttonClearAllCustomPost.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearAllCustomPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonClearAllCustomPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearAllCustomPost.Location = new System.Drawing.Point(343, 430);
            this.buttonClearAllCustomPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearAllCustomPost.Name = "buttonClearAllCustomPost";
            this.buttonClearAllCustomPost.Size = new System.Drawing.Size(96, 28);
            this.buttonClearAllCustomPost.TabIndex = 5;
            this.buttonClearAllCustomPost.Text = "Clear List";
            this.buttonClearAllCustomPost.UseVisualStyleBackColor = false;
            this.buttonClearAllCustomPost.Click += new System.EventHandler(this.buttonRemoveAllCustomPosts_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEditPostText);
            this.panel1.Controls.Add(this.textBoxCustomPost);
            this.panel1.Controls.Add(this.buttonClearText);
            this.panel1.Controls.Add(this.buttonSaveCustomPostToList);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 388);
            this.panel1.TabIndex = 6;
            // 
            // labelEditPostText
            // 
            this.labelEditPostText.AutoSize = true;
            this.labelEditPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEditPostText.Location = new System.Drawing.Point(117, 5);
            this.labelEditPostText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditPostText.Name = "labelEditPostText";
            this.labelEditPostText.Size = new System.Drawing.Size(160, 17);
            this.labelEditPostText.TabIndex = 4;
            this.labelEditPostText.Text = "Edit Your Posts Here";
            // 
            // textBoxCustomPost
            // 
            this.textBoxCustomPost.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxCustomPost.Location = new System.Drawing.Point(5, 32);
            this.textBoxCustomPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomPost.Multiline = true;
            this.textBoxCustomPost.Name = "textBoxCustomPost";
            this.textBoxCustomPost.Size = new System.Drawing.Size(412, 243);
            this.textBoxCustomPost.TabIndex = 3;
            // 
            // buttonClearText
            // 
            this.buttonClearText.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonClearText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearText.Location = new System.Drawing.Point(280, 313);
            this.buttonClearText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(139, 28);
            this.buttonClearText.TabIndex = 2;
            this.buttonClearText.Text = "Clear";
            this.buttonClearText.UseVisualStyleBackColor = false;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // buttonSaveCustomPostToList
            // 
            this.buttonSaveCustomPostToList.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveCustomPostToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSaveCustomPostToList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveCustomPostToList.Location = new System.Drawing.Point(5, 313);
            this.buttonSaveCustomPostToList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveCustomPostToList.Name = "buttonSaveCustomPostToList";
            this.buttonSaveCustomPostToList.Size = new System.Drawing.Size(139, 28);
            this.buttonSaveCustomPostToList.TabIndex = 1;
            this.buttonSaveCustomPostToList.Text = "Save";
            this.buttonSaveCustomPostToList.UseVisualStyleBackColor = false;
            this.buttonSaveCustomPostToList.Click += new System.EventHandler(this.buttonSaveCustomPostToList_Click);
            // 
            // tabFinance
            // 
            this.tabFinance.BackColor = System.Drawing.Color.LightCyan;
            this.tabFinance.Controls.Add(this.labelSearchStock);
            this.tabFinance.Controls.Add(this.textBoxSearchStock);
            this.tabFinance.Controls.Add(this.pictureBoxStock);
            this.tabFinance.Controls.Add(this.labelStockIpo);
            this.tabFinance.Controls.Add(this.labelStockChanges);
            this.tabFinance.Controls.Add(this.buttonFetchStockDetails);
            this.tabFinance.Controls.Add(this.labelStockPrice);
            this.tabFinance.Location = new System.Drawing.Point(4, 25);
            this.tabFinance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFinance.Name = "tabFinance";
            this.tabFinance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFinance.Size = new System.Drawing.Size(1130, 595);
            this.tabFinance.TabIndex = 6;
            this.tabFinance.Text = "Finance";
            // 
            // labelSearchStock
            // 
            this.labelSearchStock.AutoSize = true;
            this.labelSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearchStock.Location = new System.Drawing.Point(192, 46);
            this.labelSearchStock.Name = "labelSearchStock";
            this.labelSearchStock.Size = new System.Drawing.Size(109, 34);
            this.labelSearchStock.TabIndex = 15;
            this.labelSearchStock.Text = "Search Stock \r\nBy Symbol:";
            // 
            // textBoxSearchStock
            // 
            this.textBoxSearchStock.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxSearchStock.Location = new System.Drawing.Point(331, 43);
            this.textBoxSearchStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchStock.Multiline = true;
            this.textBoxSearchStock.Name = "textBoxSearchStock";
            this.textBoxSearchStock.Size = new System.Drawing.Size(339, 34);
            this.textBoxSearchStock.TabIndex = 14;
            // 
            // pictureBoxStock
            // 
            this.pictureBoxStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxStock.Location = new System.Drawing.Point(725, 139);
            this.pictureBoxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxStock.Name = "pictureBoxStock";
            this.pictureBoxStock.Size = new System.Drawing.Size(165, 138);
            this.pictureBoxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStock.TabIndex = 13;
            this.pictureBoxStock.TabStop = false;
            // 
            // labelStockIpo
            // 
            this.labelStockIpo.AutoSize = true;
            this.labelStockIpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStockIpo.Location = new System.Drawing.Point(192, 234);
            this.labelStockIpo.Name = "labelStockIpo";
            this.labelStockIpo.Size = new System.Drawing.Size(80, 17);
            this.labelStockIpo.TabIndex = 12;
            this.labelStockIpo.Text = "Stock Ipo:";
            // 
            // labelStockChanges
            // 
            this.labelStockChanges.AutoSize = true;
            this.labelStockChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStockChanges.Location = new System.Drawing.Point(192, 183);
            this.labelStockChanges.Name = "labelStockChanges";
            this.labelStockChanges.Size = new System.Drawing.Size(76, 17);
            this.labelStockChanges.TabIndex = 11;
            this.labelStockChanges.Text = "Changes:";
            // 
            // buttonFetchStockDetails
            // 
            this.buttonFetchStockDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchStockDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchStockDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchStockDetails.Location = new System.Drawing.Point(373, 276);
            this.buttonFetchStockDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchStockDetails.Name = "buttonFetchStockDetails";
            this.buttonFetchStockDetails.Size = new System.Drawing.Size(147, 44);
            this.buttonFetchStockDetails.TabIndex = 9;
            this.buttonFetchStockDetails.Text = "Fetch Stock Details";
            this.buttonFetchStockDetails.UseVisualStyleBackColor = false;
            this.buttonFetchStockDetails.Click += new System.EventHandler(this.buttonFetchStockDetails_Click);
            // 
            // labelStockPrice
            // 
            this.labelStockPrice.AutoSize = true;
            this.labelStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStockPrice.Location = new System.Drawing.Point(192, 139);
            this.labelStockPrice.Name = "labelStockPrice";
            this.labelStockPrice.Size = new System.Drawing.Size(53, 17);
            this.labelStockPrice.TabIndex = 8;
            this.labelStockPrice.Text = "Stock:";
            // 
            // tabAlbums
            // 
            this.tabAlbums.Controls.Add(this.splitContainer3);
            this.tabAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Size = new System.Drawing.Size(1130, 595);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 2);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer3.Panel1.Controls.Add(this.listBoxAlbums);
            this.splitContainer3.Panel1.Controls.Add(this.buttonFetchAlbums);
            this.splitContainer3.Panel1.Controls.Add(this.listBoxPhotos);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer3.Panel2.Controls.Add(this.buttonLike);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxPhoto);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxPhotosComments);
            this.splitContainer3.Size = new System.Drawing.Size(1109, 585);
            this.splitContainer3.SplitterDistance = 429;
            this.splitContainer3.TabIndex = 9;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(5, 34);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(375, 132);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchAlbums.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFetchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(0, 552);
            this.buttonFetchAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(429, 33);
            this.buttonFetchAlbums.TabIndex = 8;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 16;
            this.listBoxPhotos.Location = new System.Drawing.Point(5, 247);
            this.listBoxPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(376, 164);
            this.listBoxPhotos.TabIndex = 4;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(155, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Albums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(155, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Photos";
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLike.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLike.Location = new System.Drawing.Point(405, 186);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(87, 33);
            this.buttonLike.TabIndex = 10;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(244, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(151, 33);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(217, 185);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 3;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(244, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // listBoxPhotosComments
            // 
            this.listBoxPhotosComments.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxPhotosComments.FormattingEnabled = true;
            this.listBoxPhotosComments.ItemHeight = 16;
            this.listBoxPhotosComments.Location = new System.Drawing.Point(16, 245);
            this.listBoxPhotosComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPhotosComments.Name = "listBoxPhotosComments";
            this.listBoxPhotosComments.Size = new System.Drawing.Size(580, 164);
            this.listBoxPhotosComments.TabIndex = 5;
            // 
            // tabPosts
            // 
            this.tabPosts.Controls.Add(this.splitContainer2);
            this.tabPosts.Location = new System.Drawing.Point(4, 25);
            this.tabPosts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Size = new System.Drawing.Size(1130, 595);
            this.tabPosts.TabIndex = 2;
            this.tabPosts.Text = "Posts";
            this.tabPosts.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxSortPostsByOrder);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer2.Panel1.Controls.Add(this.buttonFetchPosts);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxPosts);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxComments);
            this.splitContainer2.Size = new System.Drawing.Size(1109, 585);
            this.splitContainer2.SplitterDistance = 381;
            this.splitContainer2.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(92, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Search Auto Complete";
            // 
            // checkBoxSortPostsByOrder
            // 
            this.checkBoxSortPostsByOrder.AutoSize = true;
            this.checkBoxSortPostsByOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxSortPostsByOrder.Location = new System.Drawing.Point(4, 70);
            this.checkBoxSortPostsByOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSortPostsByOrder.Name = "checkBoxSortPostsByOrder";
            this.checkBoxSortPostsByOrder.Size = new System.Drawing.Size(213, 21);
            this.checkBoxSortPostsByOrder.TabIndex = 51;
            this.checkBoxSortPostsByOrder.Text = "Sort Post By Name Order";
            this.checkBoxSortPostsByOrder.UseVisualStyleBackColor = true;
            this.checkBoxSortPostsByOrder.CheckedChanged += new System.EventHandler(this.checkBoxSortPostsByOrder_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-464, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(4, 30);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(329, 22);
            this.textBoxSearch.TabIndex = 48;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchPosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchPosts.Location = new System.Drawing.Point(0, 557);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(381, 28);
            this.buttonFetchPosts.TabIndex = 4;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(4, 103);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(329, 340);
            this.listBoxPosts.TabIndex = 3;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxComments
            // 
            this.listBoxComments.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(0, 0);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(724, 585);
            this.listBoxComments.TabIndex = 50;
            // 
            // tabPages
            // 
            this.tabPages.BackColor = System.Drawing.Color.LightCyan;
            this.tabPages.Controls.Add(this.splitContainer1);
            this.tabPages.Location = new System.Drawing.Point(4, 25);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPages.Size = new System.Drawing.Size(1130, 595);
            this.tabPages.TabIndex = 1;
            this.tabPages.Text = "Pages";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(7, 7);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxLikedPages);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLikedPages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserPages);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 473);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 3;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(335, 445);
            this.listBoxLikedPages.TabIndex = 2;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLikedPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikedPages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLikedPages.Location = new System.Drawing.Point(0, 445);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(335, 28);
            this.buttonLikedPages.TabIndex = 1;
            this.buttonLikedPages.Text = "Fetch Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // webBrowserPages
            // 
            this.webBrowserPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPages.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowserPages.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPages.Name = "webBrowserPages";
            this.webBrowserPages.Size = new System.Drawing.Size(678, 473);
            this.webBrowserPages.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabProfile.BackColor = System.Drawing.Color.LightCyan;
            this.tabProfile.Controls.Add(this.checkBoxDarkMode);
            this.tabProfile.Controls.Add(this.buttonChooseCustomedPost);
            this.tabProfile.Controls.Add(this.pictureBoxWeatherPredict);
            this.tabProfile.Controls.Add(this.labelWeatherDetails);
            this.tabProfile.Controls.Add(this.labelLastUpdate);
            this.tabProfile.Controls.Add(this.labelTemperatureInFahrnheit);
            this.tabProfile.Controls.Add(this.labelTemperatureInCelcius);
            this.tabProfile.Controls.Add(this.labelPredictWeather);
            this.tabProfile.Controls.Add(this.labelCity);
            this.tabProfile.Controls.Add(this.labelCountry);
            this.tabProfile.Controls.Add(this.buttonFetchWeatherDetails);
            this.tabProfile.Controls.Add(this.buttonPost);
            this.tabProfile.Controls.Add(this.textBoxPost);
            this.tabProfile.Controls.Add(this.labelEmail);
            this.tabProfile.Controls.Add(this.labelGender);
            this.tabProfile.Controls.Add(this.labelBirthday);
            this.tabProfile.Controls.Add(this.labelLastName);
            this.tabProfile.Controls.Add(this.labelFirstName);
            this.tabProfile.Controls.Add(this.buttonLogOut);
            this.tabProfile.Controls.Add(this.pictureBoxProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 25);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(4);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(4);
            this.tabProfile.Size = new System.Drawing.Size(1130, 595);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            // 
            // checkBoxDarkMode
            // 
            this.checkBoxDarkMode.AutoSize = true;
            this.checkBoxDarkMode.Location = new System.Drawing.Point(162, 441);
            this.checkBoxDarkMode.Name = "checkBoxDarkMode";
            this.checkBoxDarkMode.Size = new System.Drawing.Size(99, 21);
            this.checkBoxDarkMode.TabIndex = 22;
            this.checkBoxDarkMode.Text = "Dark Mode";
            this.checkBoxDarkMode.UseVisualStyleBackColor = true;
            this.checkBoxDarkMode.CheckedChanged += new System.EventHandler(this.checkBoxDarkMode_CheckedChanged);
            // 
            // buttonChooseCustomedPost
            // 
            this.buttonChooseCustomedPost.AutoSize = true;
            this.buttonChooseCustomedPost.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChooseCustomedPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonChooseCustomedPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChooseCustomedPost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChooseCustomedPost.Location = new System.Drawing.Point(891, 78);
            this.buttonChooseCustomedPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseCustomedPost.Name = "buttonChooseCustomedPost";
            this.buttonChooseCustomedPost.Size = new System.Drawing.Size(173, 41);
            this.buttonChooseCustomedPost.TabIndex = 21;
            this.buttonChooseCustomedPost.TabStop = false;
            this.buttonChooseCustomedPost.Text = "Template Posts";
            this.buttonChooseCustomedPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChooseCustomedPost.UseVisualStyleBackColor = false;
            this.buttonChooseCustomedPost.Click += new System.EventHandler(this.buttonChooseCustomedPost_Click);
            // 
            // pictureBoxWeatherPredict
            // 
            this.pictureBoxWeatherPredict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWeatherPredict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxWeatherPredict.ImageLocation = "";
            this.pictureBoxWeatherPredict.Location = new System.Drawing.Point(739, 167);
            this.pictureBoxWeatherPredict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWeatherPredict.Name = "pictureBoxWeatherPredict";
            this.pictureBoxWeatherPredict.Size = new System.Drawing.Size(152, 132);
            this.pictureBoxWeatherPredict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherPredict.TabIndex = 20;
            this.pictureBoxWeatherPredict.TabStop = false;
            this.pictureBoxWeatherPredict.Visible = false;
            // 
            // labelWeatherDetails
            // 
            this.labelWeatherDetails.AutoSize = true;
            this.labelWeatherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherDetails.Location = new System.Drawing.Point(528, 151);
            this.labelWeatherDetails.Name = "labelWeatherDetails";
            this.labelWeatherDetails.Size = new System.Drawing.Size(129, 17);
            this.labelWeatherDetails.TabIndex = 19;
            this.labelWeatherDetails.Text = "Weather Details:";
            this.labelWeatherDetails.Visible = false;
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(405, 320);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(0, 17);
            this.labelLastUpdate.TabIndex = 18;
            // 
            // labelTemperatureInFahrnheit
            // 
            this.labelTemperatureInFahrnheit.AutoSize = true;
            this.labelTemperatureInFahrnheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureInFahrnheit.Location = new System.Drawing.Point(325, 287);
            this.labelTemperatureInFahrnheit.Name = "labelTemperatureInFahrnheit";
            this.labelTemperatureInFahrnheit.Size = new System.Drawing.Size(198, 17);
            this.labelTemperatureInFahrnheit.TabIndex = 17;
            this.labelTemperatureInFahrnheit.Text = "Temperture in Fahrenheit:";
            this.labelTemperatureInFahrnheit.Visible = false;
            // 
            // labelTemperatureInCelcius
            // 
            this.labelTemperatureInCelcius.AutoSize = true;
            this.labelTemperatureInCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureInCelcius.Location = new System.Drawing.Point(325, 257);
            this.labelTemperatureInCelcius.Name = "labelTemperatureInCelcius";
            this.labelTemperatureInCelcius.Size = new System.Drawing.Size(172, 17);
            this.labelTemperatureInCelcius.TabIndex = 16;
            this.labelTemperatureInCelcius.Text = "Temperture in Celcius:";
            this.labelTemperatureInCelcius.Visible = false;
            // 
            // labelPredictWeather
            // 
            this.labelPredictWeather.AutoSize = true;
            this.labelPredictWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPredictWeather.Location = new System.Drawing.Point(325, 228);
            this.labelPredictWeather.Name = "labelPredictWeather";
            this.labelPredictWeather.Size = new System.Drawing.Size(64, 17);
            this.labelPredictWeather.TabIndex = 15;
            this.labelPredictWeather.Text = "Predict:";
            this.labelPredictWeather.Visible = false;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(325, 197);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 17);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City:";
            this.labelCity.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(325, 167);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(69, 17);
            this.labelCountry.TabIndex = 13;
            this.labelCountry.Text = "Country:";
            this.labelCountry.Visible = false;
            // 
            // buttonFetchWeatherDetails
            // 
            this.buttonFetchWeatherDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFetchWeatherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchWeatherDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchWeatherDetails.Location = new System.Drawing.Point(739, 319);
            this.buttonFetchWeatherDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchWeatherDetails.Name = "buttonFetchWeatherDetails";
            this.buttonFetchWeatherDetails.Size = new System.Drawing.Size(141, 65);
            this.buttonFetchWeatherDetails.TabIndex = 11;
            this.buttonFetchWeatherDetails.Text = "Refresh Weather Details ";
            this.buttonFetchWeatherDetails.UseVisualStyleBackColor = false;
            this.buttonFetchWeatherDetails.Visible = false;
            this.buttonFetchWeatherDetails.Click += new System.EventHandler(this.buttonFetchWeatherDetails_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(896, 32);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(120, 41);
            this.buttonPost.TabIndex = 10;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxPost.Location = new System.Drawing.Point(264, 32);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(625, 94);
            this.textBoxPost.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(24, 373);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 17);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(24, 343);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(72, 17);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(24, 314);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(80, 17);
            this.labelBirthday.TabIndex = 6;
            this.labelBirthday.Text = "BirthDay: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(24, 283);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(24, 254);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(96, 17);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name: ";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Location = new System.Drawing.Point(931, 558);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(195, 37);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Location = new System.Drawing.Point(27, 32);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(221, 186);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonRemoveFromList
            // 
            this.buttonRemoveFromList.Controls.Add(this.tabProfile);
            this.buttonRemoveFromList.Controls.Add(this.tabPages);
            this.buttonRemoveFromList.Controls.Add(this.tabPosts);
            this.buttonRemoveFromList.Controls.Add(this.tabAlbums);
            this.buttonRemoveFromList.Controls.Add(tabFriendsAndGroups);
            this.buttonRemoveFromList.Controls.Add(this.tabFinance);
            this.buttonRemoveFromList.Controls.Add(this.tabCustomPost);
            this.buttonRemoveFromList.Location = new System.Drawing.Point(13, 13);
            this.buttonRemoveFromList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveFromList.Name = "buttonRemoveFromList";
            this.buttonRemoveFromList.SelectedIndex = 0;
            this.buttonRemoveFromList.Size = new System.Drawing.Size(1138, 624);
            this.buttonRemoveFromList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1149, 636);
            this.Controls.Add(this.buttonRemoveFromList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            tabFriendsAndGroups.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabCustomPost.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFinance.ResumeLayout(false);
            this.tabFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStock)).EndInit();
            this.tabAlbums.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabPosts.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPages.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherPredict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.buttonRemoveFromList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCustomPost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label listViewMessagesLbl;
        private System.Windows.Forms.ListBox listBoxCustomPosts;
        private System.Windows.Forms.Button buttonEditCustomPost;
        private System.Windows.Forms.Button buttonRemoveFromPostList;
        private System.Windows.Forms.Button buttonClearAllCustomPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEditPostText;
        private System.Windows.Forms.TextBox textBoxCustomPost;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonSaveCustomPostToList;
        private System.Windows.Forms.TabPage tabFinance;
        private System.Windows.Forms.Label labelSearchStock;
        private System.Windows.Forms.TextBox textBoxSearchStock;
        private System.Windows.Forms.PictureBox pictureBoxStock;
        private System.Windows.Forms.Label labelStockIpo;
        private System.Windows.Forms.Label labelStockChanges;
        private System.Windows.Forms.Button buttonFetchStockDetails;
        private System.Windows.Forms.Label labelStockPrice;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPhotosComments;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox checkBoxSortPostsByOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.WebBrowser webBrowserPages;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Button buttonChooseCustomedPost;
        private System.Windows.Forms.PictureBox pictureBoxWeatherPredict;
        private System.Windows.Forms.Label labelWeatherDetails;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.Label labelTemperatureInFahrnheit;
        private System.Windows.Forms.Label labelTemperatureInCelcius;
        private System.Windows.Forms.Label labelPredictWeather;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Button buttonFetchWeatherDetails;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabControl buttonRemoveFromList;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.RadioButton radioButtonCloseFriend;
        private System.Windows.Forms.RadioButton radioButtonFarFriend;
        private System.Windows.Forms.Button buttonMakeBirthday;
        private Proxy.MonthCalendarProxy monthCalendarBirthday;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelFriendLastName;
        private System.Windows.Forms.Label labelFriendGender;
        private System.Windows.Forms.Label labelFriendFirstName;
        private System.Windows.Forms.Label labelFriendBirthday;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.CheckBox checkBoxDarkMode;
    }
}