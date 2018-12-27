using Discord;
using Discord.Rest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PurgeMyDiscord
{
    public partial class MainForm : Form
    {
        private const string TokenFilename = "PurgeMyDiscord_token.txt";
        private readonly DiscordRestClient _client = new DiscordRestClient();

        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.PurgeMyDiscord;

            LoginView();
            tokenTbox.Text = LoadToken();
        }

        private string LoadToken()
        {
            return File.Exists(TokenFilename) ? File.ReadAllText(TokenFilename) : "";
        }

        private void SaveToken(string token)
        {
            File.WriteAllText(TokenFilename, token);
        }

        private void LoginView()
        {
            tokenTbox.Enabled = true;
            loginBtn.Enabled = true;

            userCbox.Enabled = false;
            messagesNum.Enabled = false;
            purgeBtn.Enabled = false;
            progressBar.Enabled = false;
        }

        private void PurgeView()
        {
            tokenTbox.Enabled = false;
            loginBtn.Enabled = false;

            userCbox.Enabled = true;
            messagesNum.Enabled = true;
            purgeBtn.Enabled = true;
            progressBar.Enabled = true;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;

            try
            {
                var token = tokenTbox.Text.Trim().Trim('\"', '\'');
                await _client.LoginAsync(TokenType.User, token);
            
                var dmChannels = await _client.GetDMChannelsAsync();
                LoadUsers(dmChannels);

                PurgeView();
                SaveToken(token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginBtn.Enabled = true;
            }
        }

        private void LoadUsers(IReadOnlyCollection<RestDMChannel> channels)
        {
            userCbox.Items.Clear();

            foreach (var channel in channels.OrderBy(c => c.ToString()))
            {
                userCbox.Items.Add(new ComboBoxItem(channel.ToString(), channel));
            }

            userCbox.SelectedIndex = 0;
        }

        private RestDMChannel GetSelectedChannel()
        {
            return (userCbox.SelectedItem as ComboBoxItem).Value;
        }

        private async void purgeBtn_Click(object sender, EventArgs e)
        {
            purgeBtn.Enabled = false;

            var channel = GetSelectedChannel();
            var messagesToPurge = (int) messagesNum.Value;

            if (messagesToPurge == -1)
            {
                progressBar.Maximum = 1001;
                progressBar.Value = 1000;
                progressBar.Style = ProgressBarStyle.Continuous;
            }
            else
            {
                progressBar.Maximum = messagesToPurge;
                progressBar.Value = 0;
                progressBar.Style = ProgressBarStyle.Blocks;
            }

            var messages = channel.GetMessagesAsync(int.MaxValue);
            var messageEnumerator = messages.GetEnumerator();
            
            while (messageEnumerator.MoveNext().Result)
            {
                // foreach message on page (100 per page)
                foreach (var message in messageEnumerator.Current)
                {
                    if (message.Author.Mention == _client.CurrentUser.Mention && message.Source == MessageSource.User)
                    {
                        await message.DeleteAsync();

                        if (progressBar.Style == ProgressBarStyle.Blocks)
                        {
                            progressBar.Value++;
                        }

                        if (--messagesToPurge == 0)
                        {
                            return;
                        }
                    }
                }
            }

            progressBar.Value = progressBar.Maximum;

            SystemSounds.Beep.Play();
            Activate();
            Focus();

            purgeBtn.Enabled = true;
        }
    }
}
