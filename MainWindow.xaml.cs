using IntGyako_StreamingSzolgaltato;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace InterfaceGyakorlo
{
    public partial class MainWindow : Window
    {
        private StreamingPlatform platform = new StreamingPlatform();

        public MainWindow()
        {
            InitializeComponent();

            AddContent(new Movie(new Video("Inception", 148)));
            AddContent(new Movie(new Video("Interstellar", 169)));

            AddContent(new Series("Breaking Bad", new List<Video>
            {
                new Video("1. évad 1. rész", 58),
                new Video("1. évad 2. rész", 48),
                new Video("1. évad 3. rész", 46)
            }));

            AddContent(new Series("Planet Earth", new List<Video>
            {
                new Video("1. rész", 50),
                new Video("2. rész", 52),
                new Video("3. rész", 55),
                new Video("4. rész", 53)
            }));
        }

        private void AddContent(IContent content)
        {
            platform.addContent(content);

            ContentList.Items.Add(
                $"{content.getTitle()} - {content.getLength()} perc");
        }

        private void FindLongest_Click(object sender, RoutedEventArgs e)
        {
            IContent longest = platform.getLongestContent();

            if (longest == null)
            {
                LongestText.Text = "A katalógus üres.";
                return;
            }

            LongestText.Text =
                $"A leghosszabb tartalom: {longest.getTitle()} " +
                $"({longest.getLength()} perc)";
        }
    }
}