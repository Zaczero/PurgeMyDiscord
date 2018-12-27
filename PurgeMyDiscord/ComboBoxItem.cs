using Discord.Rest;

namespace PurgeMyDiscord
{
    public class ComboBoxItem
    {
        public string Text;
        public RestDMChannel Value;

        public ComboBoxItem(string text, RestDMChannel value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
