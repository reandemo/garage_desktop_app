using Store_Online.Core.Localization;
using Store_Online.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Store_Online.Core.Controls
{
    public partial class GarageHeader : UserControl
    {
        private readonly LanguageRepository _languageRepository;
        private readonly Dictionary<string, BitmapImage> _flagCache = new();

        private List<LanguageModel> _languages = new();
        private bool _isLoaded;

        public event EventHandler? LogoutRequested;

        #region Dependency Properties

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageHeader),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register(
                nameof(Subtitle),
                typeof(string),
                typeof(GarageHeader),
                new PropertyMetadata(string.Empty));

        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }

        #endregion

        public GarageHeader()
        {
            InitializeComponent();

            _languageRepository = App.GetService<LanguageRepository>();

            Loaded += GarageHeader_Loaded;

            UserProfile.LogoutRequested += UserProfile_LogoutRequested;
        }

        private void GarageHeader_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isLoaded)
                return;

            _isLoaded = true;

            LoadLanguages();
            LoadCurrentLanguage();
        }

        private void UserProfile_LogoutRequested(object? sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void LoadLanguages()
        {
            try
            {
                _languages = _languageRepository.GetLanguages();

                mnuLanguage.Items.Clear();

                foreach (LanguageModel language in _languages)
                {
                    MenuItem item = new()
                    {
                        Header = language.NativeName,
                        Tag = language,
                        Icon = new Image
                        {
                            Width = 20,
                            Height = 14,
                            Source = GetFlagImage(language.FlagIcon)
                        }
                    };

                    item.Click += Language_Click;

                    mnuLanguage.Items.Add(item);
                }
            }
            catch
            {
                _languages.Clear();
                mnuLanguage.Items.Clear();

                txtCurrentLanguage.Text = string.Empty;
                imgCurrentLanguage.Source = null;
            }
        }

        private void LoadCurrentLanguage()
        {
            try
            {
                if (_languages.Count == 0)
                {
                    txtCurrentLanguage.Text = string.Empty;
                    imgCurrentLanguage.Source = null;
                    return;
                }

                LanguageModel? language =
                    _languages.FirstOrDefault(x =>
                        string.Equals(
                            x.CultureCode,
                            LanguageManager.CurrentCulture.Name,
                            StringComparison.OrdinalIgnoreCase))
                    ?? _languages.FirstOrDefault(x => x.IsDefault)
                    ?? _languages.First();

                txtCurrentLanguage.Text = language.NativeName;
                imgCurrentLanguage.Source = GetFlagImage(language.FlagIcon);
            }
            catch
            {
                txtCurrentLanguage.Text = string.Empty;
                imgCurrentLanguage.Source = null;
            }
        }

        private void ChangeLanguage(LanguageModel language)
        {
            if (language == null)
                return;

            LanguageManager.ChangeCulture(language.CultureCode);

            LoadCurrentLanguage();
        }

        private void Language_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not MenuItem item)
                return;

            if (item.Tag is not LanguageModel language)
                return;

            ChangeLanguage(language);
        }

        private BitmapImage? GetFlagImage(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            if (_flagCache.TryGetValue(fileName, out BitmapImage? image))
                return image;

            try
            {
                image = new BitmapImage(
                    new Uri(
                        $"/Shared/Assets/Flags/{fileName}",
                        UriKind.Relative));

                _flagCache[fileName] = image;

                return image;
            }
            catch
            {
                return null;
            }
        }
    }
}