using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SaveHero.CfgParser;
using SaveHero.Archive;
using SaveHero.Path;
using Button = System.Windows.Controls.Button;
using TextBox = System.Windows.Controls.TextBox;

namespace SaveHero
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StatusBar.MouseLeftButtonDown += (o, e) => DragMove();
            ComboBoxPopulate();
        }

        private void OnClickExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnClickMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ComboBoxPopulate()
        {
            try
            {
                var items = CfgReader.ReadCfg(@"Profiles.ini").OrderBy(x => x.Title).ToList();

                ComboBoxProfile.ItemsSource = items;
                ComboBoxProfile.DisplayMemberPath = "Title";
                ComboBoxProfile.SelectedValuePath = "Data";
                ComboBoxProfile.Text = "Select profile...";
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e);
                ComboBoxProfile.IsEnabled = false;
            }
        }

        private void ComboBoxProfileChanged(object sender, SelectionChangedEventArgs e)
        {
            Profile profile = (Profile)ComboBoxProfile.SelectedItem;
            var profileData = profile.Data;
            TextBoxSource.Text = profileData["SourcePath"];
            TextBoxDestination.Text = profileData["DestinationPath"];
            TextBoxArchiveName.Text = profileData["ArchiveName"];
        }

        private void OnTextBoxChange(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).Background = Brushes.White;
            LabelStatus.Content = "Ready!";
            LabelStatus.Foreground = (Brush) FindResource("SaveheroLightGreenBrush");
        }

        private void OpenConfig(object sender, RoutedEventArgs e)
        {
            Process.Start("Profiles.ini");
        }

        private void OpenDir(object sender, RoutedEventArgs e)
        {
            string btnId = (sender as Button).Name;
            string path;

            if (btnId.Contains("Source")) path = TextBoxSource.Text;
            else if (btnId.Contains("Destination")) path = TextBoxDestination.Text;
            else path = null;

            if (Path.Path.VerifyDir(path, false)) Process.Start(path);
            else
            {
                if (TextBoxSource.Text == path) TextBoxSource.Background = Brushes.LightCoral;
                if (TextBoxDestination.Text == path) TextBoxDestination.Background = Brushes.LightCoral;
            }
        }

        private void BrowseForDir(object sender, RoutedEventArgs e)
        {
            string btnId = (sender as Button).Name;
            string path = "";

            FolderBrowserDialog dirBrowser = new FolderBrowserDialog();
            if (dirBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = dirBrowser.SelectedPath;
            }

            if (Path.Path.VerifyDir(path, false))
            {
                if (btnId.Contains("Source")) TextBoxSource.Text = path;
                if (btnId.Contains("Destination")) TextBoxDestination.Text = path;
            }
        }

        private void PerformBackup(object sender, RoutedEventArgs e)
        {
            string src = TextBoxSource.Text;
            string dst = TextBoxDestination.Text;
            string zip = TextBoxArchiveName.Text.Replace(" ", "");
            string ext = ".zip";

            bool isVerifiedSrc = Path.Path.VerifyDir(src, false);
            bool isVerifiedDst = Path.Path.VerifyDir(dst, true);

            if (!isVerifiedSrc) TextBoxSource.Background = Brushes.LightCoral;
            if (!isVerifiedDst) TextBoxDestination.Background = Brushes.LightCoral;

            if (CheckBoxIncludeDateTime.IsChecked.HasValue && CheckBoxIncludeDateTime.IsChecked.Value)
            {
                zip += string.Format("_{0:yyyy-MM-dd}_{0:HHmmss}", DateTime.Now);
            }

            string filepath = dst + @"\" + zip + ext;

            if (isVerifiedSrc && isVerifiedDst) Archive.Archive.ZipDirectory(src, filepath);

            if (File.Exists(filepath))
            {
                LabelStatus.Foreground = (Brush) FindResource("SaveheroLightGreenBrush");
                LabelStatus.Content = "Archive created successfully!";
            }
            else
            {
                LabelStatus.Foreground = (Brush) FindResource("SaveheroErrorRedBrush");
                LabelStatus.Content = "Archive could not be created.";
            }
        }
    }
}
