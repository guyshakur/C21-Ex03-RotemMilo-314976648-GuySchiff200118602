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
            ColorSchemeNotifyerDelegate += enableOrDisableColorScheme;
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
            labelCountry.Text = $"Country: {weatherDetails.Location.Country}";
            labelCountry.Visible = true;
            labelLastUpdate.Text = $"Last Update: {weatherDetails.Location.LocalTime}";
            labelLastUpdate.Visible = true;
            labelCity.Text = $"City: {weatherDetails.Location.City}";
            labelCity.Visible = true;
            labelPredictWeather.Text = $"Predict: {weatherDetails.DailyPredict.Condition.PredictText}";
            labelPredictWeather.Visible = true;
            labelTemperatureInCelcius.Text = $"Temperture in Celcius: {weatherDetails.DailyPredict.TempertureInCelsius}";
            labelTemperatureInCelcius.Visible = true;
            labelTemperatureInFahrnheit.Text = $"Temperture in Fahrenheit: {weatherDetails.DailyPredict.TempertureInFahrenheit}";
            labelTemperatureInFahrnheit.Visible = true;
            pictureBoxWeatherPredict.ImageLocation = "Http:" + weatherDetails.DailyPredict.Condition.PredictIcon;
            pictureBoxWeatherPredict.Visible = true;
            buttonFetchWeatherDetails.Visible = true;
            labelWeatherDetails.Visible = true;
        }

        private void fetchSelfDetails()
        {
            labelFirstName.Invoke(new Action(() => labelFirstName.Text += LoginFacade.LoginUser.FirstName));
            labelLastName.Invoke(new Action(() => labelLastName.Text += LoginFacade.LoginUser.LastName));
            labelEmail.Invoke(new Action(() => labelEmail.Text += LoginFacade.LoginUser.Email));
            labelGender.Invoke(new Action(() => labelGender.Text += LoginFacade.LoginUser.Gender.ToString()));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text += LoginFacade.LoginUser.Birthday));
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));

            try
            {
                foreach (Page page in LoginFacade.LoginUser.LikedPages)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page.Name)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add("There are no liked pages for this user")));
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
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Message"));
            try
            {
                foreach (Post post in LoginFacade.LoginUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
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
            searchInPost(listBoxPosts.Text);
        }

        private void searchInPost(string i_StringToSearch)
        {
            if (listBoxPosts.Items.Count != 0)
            {
                int id = listBoxPosts.FindString(i_StringToSearch);

                if (id >= 0)
                {
                    listBoxPosts.SetSelected(id, true);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Please fetch posts before");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = LoginFacade.LoginUser.Posts[listBoxPosts.SelectedIndex];
            listBoxComments.DisplayMember = "Message";
            listBoxComments.DataSource = selected.Comments;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchInPost((sender as TextBox)?.Text);
        }

        private void checkBoxSortPostsByOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.Items.Count != 0 && (sender as CheckBox)?.Checked == true)
            {
                try
                {
                    r_LastPostsCollection.Clear();
                    foreach (Post post in listBoxPosts.Items)
                    {
                        r_LastPostsCollection.Add(post);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                listBoxPosts.Sorted = true;
            }
            else if (listBoxPosts.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("no posts");
            }
            else
            {
                listBoxPosts.Sorted = false;
                listBoxPosts.Items.Clear();
                foreach (object obj in r_LastPostsCollection)
                {
                    listBoxPosts.Items.Add(obj);
                }
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selected = LoginFacade.LoginUser.LikedPages[listBoxLikedPages.SelectedIndex];
            new Thread(() => webBrowserPages.Navigate(selected.URL)).Start();
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(listBoxPhotosSelectedPhoto).Start();
        }

        private void listBoxPhotosSelectedPhoto()
        {
            if (listBoxPhotos.SelectedItem != null)
            {
                Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
                if (selectedPhoto != null)
                {
                    pictureBoxPhoto.ImageLocation = selectedPhoto.PictureNormalURL;
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    listBoxPhotosComments.Invoke(new Action(() => listBoxPhotosComments.DataSource = selectedPhoto.Comments));
                }
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));

            try
            {
                foreach (Album album in LoginFacade.LoginUser.Albums)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPhotos.Items.Clear();
            listBoxPhotos.DisplayMember = "CreatedTime.ToString()";
            Album albumSelected = listBoxAlbums.SelectedItem as Album;

            try
            {
                foreach (Photo photo in albumSelected.Photos)
                {
                    listBoxPhotos.Items.Add(photo);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (listBoxPhotos.Items.Count == 0)
            {
                MessageBox.Show("No photos to fetch");
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPhotos.SelectedItem != null)
                {
                    Photo photo = listBoxPhotos.SelectedItem as Photo;
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
                LoginFacade.LoginUser.PostStatus(textBoxPost.Text);
                System.Windows.MessageBox.Show("Your post shared sucessfully");
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Your post can't be shared. Please contact facebook administrator ");
            }
            finally
            {
                textBoxPost.Text = string.Empty;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;
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
                labelStockPrice.Text = $"Price: {searchStock.Price.ToString()}";
                labelStockIpo.Text = $"Stock Ipo: {searchStock.IpoDate}";
                labelStockChanges.Text = $"Changes: {searchStock.Changes.ToString()}";
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

                if (listBoxFriends.Items.Count == 0)
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
                    this.tabControlMain.SelectedTab = tabProfile;
                    this.textBoxPost.Text = post;
                    listBoxCustomPosts.ClearSelected();
                }
            }
        }

        private void buttonChooseCustomedPost_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabCustomPost;
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
            if (listBoxFriends.SelectedItem != null && (radioButtonCloseFriend.Checked || radioButtonFarFriend.Checked))
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

                    BirthdayManager birthdayManager = new BirthdayManager(eBuilderType, LoginFacade.LoginUser, listBoxFriends.SelectedItem);
                    birthdayManager.ConstructHappyBirthdayActivity();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (listBoxFriends.SelectedItem == null)
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
            if (checkBoxDarkMode.Checked)
            {
                ColorSchemeNotifyerDelegate?.Invoke(true);
            }
            else
            {
                ColorSchemeNotifyerDelegate?.Invoke(false);
            }
        }
        public void AddListeners(ColorSchemeNotifyerDelegate i_ColorSchemeNotifyerDelegate)
        {
            ColorSchemeNotifyerDelegate += i_ColorSchemeNotifyerDelegate;
        }
        public void RemoveListeners(ColorSchemeNotifyerDelegate i_ColorSchemeNotifyerDelegate)
        {
            ColorSchemeNotifyerDelegate -= i_ColorSchemeNotifyerDelegate;
        }
    }
}