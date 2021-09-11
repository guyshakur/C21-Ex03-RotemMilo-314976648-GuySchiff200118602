using System;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWinFormsApp.WeatherFeature;
using FacebookWinFormsApp.FinanceFeature;
using FacebookWinFormsApp.CostumText;
using FacebookWinFormsApp.Builder;
using WPFCustomMessageBox;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Drawing;
using FacebookWinFormsApp.Command;
using FacebookWinFormsApp.Observer.Proxy;

namespace FacebookWinFormsApp
{
    public delegate void ColorSchemeNotifyerDelegate(bool i_Dark);

    public partial class MainForm : FormTheme
    {
        private readonly List<object> r_LastPostsCollection = new List<object>();
        private ColorSchemeNotifyerDelegate ColorSchemeNotifyerDelegate;
        public CommandInvoker CommandInvoker { get; set; }
        public LoginFacade LoginFacade { get; set; }


        public MainForm(User m_LoginUser):base(new ColorScheme(Color.Black, Color.GhostWhite))
        {
            CommandInvoker = new CommandInvoker();
            LoginFacade = new LoginFacade();
            LoginFacade.LoginUser = m_LoginUser;
            AddListener(enableOrDisableColorScheme);
            InitializeComponent();
        }

        public CustomText CustomText { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            fillCustomPostsBoxFromFile();
            fetchLoginDetails();
        }

        private void fetchLoginDetails()
        {
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = LoginFacade.LoginUser.PictureLargeURL));
            Text = $"{LoginFacade.LoginUser.FirstName} {LoginFacade.LoginUser.LastName}";
            new Thread(fetchSelfDetails).Start();

            try
            {
                fetchWeatherDetails(LoginFacade.LoginUser.Location.Name);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString());
                System.Windows.MessageBox.Show("Can't fetch weather details");
            }
        }

        private void fetchWeatherDetails(string i_CityLocation)
        {
            WeatherDetails weatherDetails = WeatherFeature.WeatherFeature.GetWeatherDetails(i_CityLocation);
            labelThemeCountry.Text = $"Country: {weatherDetails.Location.Country}";
            labelThemeCountry.Visible = true;
            labelLastUpdate.Text = $"Last Update: {weatherDetails.Location.LocalTime}";
            labelLastUpdate.Visible = true;
            labelThemeCity.Text = $"City: {weatherDetails.Location.City}";
            labelThemeCity.Visible = true;
            labelThemePredictWeather.Text = $"Predict: {weatherDetails.DailyPredict.Condition.PredictText}";
            labelThemePredictWeather.Visible = true;
            labelThemeTemperatureInCelcius.Text = $"Temperture in Celcius: {weatherDetails.DailyPredict.TempertureInCelsius}";
            labelThemeTemperatureInCelcius.Visible = true;
            labelThemeTemperatureInFahrnheit.Text = $"Temperture in Fahrenheit: {weatherDetails.DailyPredict.TempertureInFahrenheit}";
            labelThemeTemperatureInFahrnheit.Visible = true;
            pictureBoxWeatherPredict.ImageLocation = "Http:" + weatherDetails.DailyPredict.Condition.PredictIcon;
            pictureBoxWeatherPredict.Visible = true;
            buttonThemeFetchWeatherDetails.Visible = true;
            labelThemeWeatherDetails.Visible = true;
        }

        private void fetchSelfDetails()
        {
            labelThemeFirstName.Invoke(new Action(() => labelThemeFirstName.Text += LoginFacade.LoginUser.FirstName));
            labelThemeLastName.Invoke(new Action(() => labelThemeLastName.Text += LoginFacade.LoginUser.LastName));
            labelThemeEmail.Invoke(new Action(() => labelThemeEmail.Text += LoginFacade.LoginUser.Email));
            labelThemeGender.Invoke(new Action(() => labelThemeGender.Text += LoginFacade.LoginUser.Gender.ToString()));
            labelThemeBirthday.Invoke(new Action(() => labelThemeBirthday.Text += LoginFacade.LoginUser.Birthday));
        }

        private void fetchLikedPages()
        {
            listBoxThemeLikedPages.Invoke(new Action(() => listBoxThemeLikedPages.Items.Clear()));

            try
            {
                foreach (Page page in LoginFacade.LoginUser.LikedPages)
                {
                    listBoxThemeLikedPages.Invoke(new Action(() => listBoxThemeLikedPages.Items.Add(page.Name)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxThemeLikedPages.Items.Count == 0)
            {
                listBoxThemeLikedPages.Invoke(new Action(() => listBoxThemeLikedPages.Items.Add("There are no liked pages for this user")));
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginFacade.LogOut();
            //LoginPageForm formLoginPage = new LoginPageForm();
            //Hide();
            //formLoginPage.ShowDialog();
            Close();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            LoginFacade.LoginUser.ReFetch();
            listBoxThemePosts.Invoke(new Action(() => listBoxThemePosts.Items.Clear()));
            listBoxThemePosts.Invoke(new Action(() => listBoxThemePosts.DisplayMember = "Message"));
            try
            {
                foreach (Post post in LoginFacade.LoginUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxThemePosts.Invoke(new Action(() => listBoxThemePosts.Items.Add(post)));
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (LoginFacade.LoginUser.Posts.Count == 0)
            {
                System.Windows.MessageBox.Show("No Posts to retrieve.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchInPost(listBoxThemePosts.Text);
        }

        private void searchInPost(string i_StringToSearch)
        {
            if (listBoxThemePosts.Items.Count != 0)
            {
                int id = listBoxThemePosts.FindString(i_StringToSearch);

                if (id >= 0)
                {
                    listBoxThemePosts.SetSelected(id, true);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Please fetch posts before");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = LoginFacade.LoginUser.Posts[listBoxThemePosts.SelectedIndex];
            listBoxThemeComments.DisplayMember = "Message";
            listBoxThemeComments.DataSource = selected.Comments;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchInPost((sender as TextBox)?.Text);
        }

        private void checkBoxSortPostsByOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxThemePosts.Items.Count != 0 && (sender as CheckBox)?.Checked == true)
            {
                try
                {
                    r_LastPostsCollection.Clear();
                    foreach (Post post in listBoxThemePosts.Items)
                    {
                        r_LastPostsCollection.Add(post);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                listBoxThemePosts.Sorted = true;
            }
            else if (listBoxThemePosts.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("no posts");
            }
            else
            {
                listBoxThemePosts.Sorted = false;
                listBoxThemePosts.Items.Clear();
                foreach (object obj in r_LastPostsCollection)
                {
                    listBoxThemePosts.Items.Add(obj);
                }
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selected = LoginFacade.LoginUser.LikedPages[listBoxThemeLikedPages.SelectedIndex];
            new Thread(() => webBrowserPages.Navigate(selected.URL)).Start();
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(listBoxPhotosSelectedPhoto).Start();
        }

        private void listBoxPhotosSelectedPhoto()
        {
            if (listBoxThemePhotos.SelectedItem != null)
            {
                Photo selectedPhoto = listBoxThemePhotos.SelectedItem as Photo;
                if (selectedPhoto != null)
                {
                    pictureBoxPhoto.ImageLocation = selectedPhoto.PictureNormalURL;
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    listBoxThemePhotosComments.Invoke(new Action(() => listBoxThemePhotosComments.DataSource = selectedPhoto.Comments));
                }
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            listBoxThemeAlbums.Invoke(new Action(() => listBoxThemeAlbums.Items.Clear()));
            listBoxThemeAlbums.Invoke(new Action(() => listBoxThemeAlbums.DisplayMember = "Name"));

            try
            {
                foreach (Album album in LoginFacade.LoginUser.Albums)
                {
                    listBoxThemeAlbums.Invoke(new Action(() => listBoxThemeAlbums.Items.Add(album)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxThemeAlbums.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxThemePhotos.Items.Clear();
            listBoxThemePhotos.DisplayMember = "CreatedTime.ToString()";
            Album albumSelected = listBoxThemeAlbums.SelectedItem as Album;

            try
            {
                foreach (Photo photo in albumSelected.Photos)
                {
                    listBoxThemePhotos.Items.Add(photo);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxThemePhotos.Items.Count == 0)
            {
                MessageBox.Show("No photos to fetch");
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxThemePhotos.SelectedItem != null)
                {
                    Photo photo = listBoxThemePhotos.SelectedItem as Photo;
                    if (!photo.LikedBy.Contains(LoginFacade.LoginUser))
                    {
                        photo.Like();
                    }
                    else
                    {
                        photo.Unlike();
                    }
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("problem has been deteced with liking post. Contact FaceBook administrator.");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            postMessage();
        }

        private void postMessage()
        {
            try
            {
                LoginFacade.LoginUser.PostStatus(textBoxThemePost.Text);
                System.Windows.MessageBox.Show("Your post shared sucessfully");
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Your post can't be shared. Please contact facebook administrator ");
            }
            finally
            {
                textBoxThemePost.Text = string.Empty;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxThemeFriends.SelectedItem as User;
            new Thread(() => fetchFriendsDetails(friend)).Start();
        }

        private void fetchFriendsDetails(User i_Friend)
        {
            if (i_Friend != null)
            {
                labelFriendFirstName.Invoke(new Action(() => labelFriendFirstName.Text = $"First Name: {i_Friend.FirstName}"));
                labelFriendLastName.Invoke(new Action(() => labelFriendLastName.Text = $"Last Name: {i_Friend.LastName}"));
                labelFriendEmail.Invoke(new Action(() => labelFriendEmail.Text = $"Email: {i_Friend.Email}"));
                labelFriendGender.Invoke(new Action(() => labelFriendGender.Text = $"Gender: {i_Friend.Gender.ToString()}"));
                labelFriendBirthday.Invoke(new Action(() => labelFriendBirthday.Text = $"Birthday: {i_Friend.Birthday}"));
                pictureBoxFriend.Invoke(new Action(() => pictureBoxFriend.ImageLocation = i_Friend.PictureLargeURL));
                DateTime birthday = DateTime.ParseExact(i_Friend.Birthday, "MM/d/yyyy", null);
                monthCalendarBirthday.SetDate(birthday);
            }
        }

        private void buttonFetchWeatherDetails_Click(object sender, EventArgs e)
        {
            try
            {
                fetchWeatherDetails(LoginFacade.LoginUser.Location.Name);
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Can't fetch weather details");
            }
        }

        private void buttonFetchStockDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Stock searchStock = FinanceFeature.FinanceFeature.GetStocksDetails(textBoxSearchStock.Text);
                labelThemeStockPrice.Text = $"Price: {searchStock.Price.ToString()}";
                labelThemeStockIpo.Text = $"Stock Ipo: {searchStock.IpoDate}";
                labelThemeStockChanges.Text = $"Changes: {searchStock.Changes.ToString()}";
                pictureBoxStock.ImageLocation = searchStock.Image;
            }
            catch
            {
                System.Windows.MessageBox.Show("Invalid Stock Name");
            }
        }

        private void buttonSaveCustomPostToList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCustomPost.Text))
            {
                //CustomText.createMessageAndAddToList(textBoxCustomPost.Text);
                //listBoxCustomPosts.Items.Add(CustomText.TextMessage.ElementAt(CustomText.TextMessage.Count - 1));
                //CustomText.SaveToFile();
                //textBoxCustomPost.Clear();
                //new SaveCutsomPostCommand() { Client = CustomText, Message = textBoxCustomPost.Text }.Execute();
                CommandInvoker.SetCommand(new SaveCutsomPostCommand() { Client = CustomText, Message = textBoxCustomPost.Text });
                CommandInvoker.Execute();
                listBoxCustomPosts.Items.Add(CustomText.TextMessage.ElementAt(CustomText.TextMessage.Count - 1));
                textBoxCustomPost.Clear();
            }
        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCustomPost.Text))
            {
                textBoxCustomPost.Clear();
            }
        }

        private void buttonRemoveAllCustomPosts_Click(object sender, EventArgs e)
        {
            if (CustomText != null)
            {
                if (listBoxCustomPosts != null)
                {
                    listBoxCustomPosts.Items.Clear();
                    CommandInvoker.SetCommand(new RemoveAllCustomPostsCommand() { Client = CustomText });
                    CommandInvoker.Execute();
                }
            }
        }

        private void buttonRemoveCustomPost_Click(object sender, EventArgs e)
        {
            if (CustomText != null)
            {
                if (listBoxCustomPosts.SelectedItem != null)
                {
                    CommandInvoker.SetCommand(new RemoveCustomPostCommand() { Client = CustomText,ClientIndex=listBoxCustomPosts.SelectedIndex });
                    CommandInvoker.Execute();
                    //CustomText.RemoveMessageFromList(listBoxCustomPosts.SelectedIndex);
                    listBoxCustomPosts.Items.Remove(listBoxCustomPosts.SelectedItem);
                }
            }
        }

        private void fillCustomPostsBoxFromFile()
        {
            CustomText = CustomText.CustomTextInstance;
            try
            {
                CustomText = CustomText.LoadFile();

                foreach (string message in CustomText.TextMessage)
                {
                    listBoxCustomPosts.Items.Add(message);
                }
            }
            catch (Exception)
            {
                CustomText.SaveToFile();
            }
        }

        private void buttonEditCustomPost_Click(object sender, EventArgs e)
        {
            editPost();
        }

        private void editPost()
        {
            if (CustomText != null)
            {
                if (listBoxCustomPosts.SelectedItem != null)
                {
                    int index = listBoxCustomPosts.SelectedIndex;
                    textBoxCustomPost.Text = listBoxCustomPosts.SelectedItem.ToString();
                    textBoxCustomPost.Focus();
                    CustomText.RemoveMessageFromList(index);
                    listBoxCustomPosts.Items.RemoveAt(index);
                    CustomText.SaveToFile();
                }
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            if (LoginFacade.LoginUser.Friends != null)
            {
                try
                {
                    friendListBindingSource.DataSource = LoginFacade.LoginUser.Friends;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                if (listBoxThemeFriends.Items.Count == 0)
                {
                    MessageBox.Show("no Friends to fetch");
                }
            }
        }

        private void listBoxCustomPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomPosts != null && listBoxCustomPosts.SelectedItem != null)
            {
                string post = listBoxCustomPosts.SelectedItem.ToString();
                MessageBoxResult result = CustomMessageBox.ShowOKCancel(post, "Custom Post", "Edit Template", "Use Template To post");

                if (result == MessageBoxResult.OK)
                {
                    editPost();
                    listBoxCustomPosts.ClearSelected();
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    this.tabControlThemeMain.SelectedTab = tabPageThemeProfile;
                    this.textBoxThemePost.Text = post;
                    listBoxCustomPosts.ClearSelected();
                }
            }
        }

        private void buttonChooseCustomedPost_Click(object sender, EventArgs e)
        {
            tabControlThemeMain.SelectedTab = tabCustomPost;
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            groupBindingSource.DataSource = LoginFacade.LoginUser.Groups;
        }

        private void buttonMakeBirthday_Click(object sender, EventArgs e)
        {
            makeBirthday();
        }

        private void makeBirthday()
        {
            if (listBoxThemeFriends.SelectedItem != null && (radioButtonCloseFriend.Checked || radioButtonFarFriend.Checked))
            {
                try
                {
                    eBuilderType eBuilderType;
                    if (radioButtonCloseFriend.Checked)
                    {
                        eBuilderType = eBuilderType.CloseFriend;
                    }
                    else
                    {
                        eBuilderType = eBuilderType.FarFriend;
                    }

                    BirthdayManager birthdayManager = new BirthdayManager(eBuilderType, LoginFacade.LoginUser, listBoxThemeFriends.SelectedItem);
                    birthdayManager.ConstructHappyBirthdayActivity();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (listBoxThemeFriends.SelectedItem == null)
            {
                MessageBox.Show("please choose friend");
            }
            else
            {
                MessageBox.Show("please choose level of friendly");
            }
        }

        private void radioButtonFarFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFarFriend.Checked)
            {
                radioButtonCloseFriend.Checked = false;
            }
        }

        private void radioButtonCloseFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCloseFriend.Checked)
            {
                radioButtonFarFriend.Checked = false;
            }
        }

        private void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckBoxChange();
        }

        protected virtual void OnCheckBoxChange()
        {
            notifyAllListeners();
        }

        private void notifyAllListeners()
        {
            if (checkBoxThemeDarkMode.Checked)
            {
                ColorSchemeNotifyerDelegate?.Invoke(true);
            }
            else
            {
                ColorSchemeNotifyerDelegate?.Invoke(false);
            }
        }
        public void AddListener(ColorSchemeNotifyerDelegate i_ColorSchemeNotifyerDelegate)
        {
            ColorSchemeNotifyerDelegate += i_ColorSchemeNotifyerDelegate;
        }
        public void RemoveListener(ColorSchemeNotifyerDelegate i_ColorSchemeNotifyerDelegate)
        {
            ColorSchemeNotifyerDelegate -= i_ColorSchemeNotifyerDelegate;
        }
    }
}