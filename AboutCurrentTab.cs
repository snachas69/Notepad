using System.Data;
namespace Notepad
{
    public partial class AboutCurrentTab : Form
    {
        public AboutCurrentTab() => InitializeComponent();
        public AboutCurrentTab(string language, RichTextBox richTextBox) : this()
        {
            string[] words = richTextBox.Text.Split(" \n\t.,;:/\\?!'\"&%1234567890#@$^*()[]{}`~=+№₴".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            _charactersAmountLabel2.Text = richTextBox.Text.Length.ToString();
            _wordsAmountLabel2.Text = words.Length.ToString();

            Dictionary<string, int> statistics = new Dictionary<string, int>();
            foreach (string word in words)
                if (statistics.ContainsKey(word))
                    statistics[word]++;
                else
                    statistics[word] = 1;

            string times = language switch
            {
                "Deutsch" => " mal\n",
                "Français" => " fois\n",
                "Русский" => " раз\n",
                "Українська" => " разів\n",
                _ => " times\n"
            };
            foreach (var item in statistics.OrderByDescending(i => i.Value))
                _wordRepeatmentStatisticsListBox.Items.Add(item.Key + ": " + item.Value + times);
            
            _currentLanguage = language;
            SetUILocalization();
        }

        private string _currentLanguage;
        private string[] _english = {
            "About Current Tab", 
            "Amount", 
            "Characters:", 
            "Words:", 
            "Words repeatment statistics"
        };
        private string[] _russian = {
            "О выбранной вкладке",
            "Количество",
            "Символов:",
            "Слов:",
            "Статистика повторяющихся слов"
        };
        private string[] _ukrainian = {
            "Про вибрану вкладку",
            "Кількість",
            "Символів:",
            "Слів:",
            "Статистика повторюваних слів"
        };
        private string[] _german = {
            "Über den aktuellen Tab",
            "Menge",
            "Figuren:",
            "Wörter:",
            "Wortwiederholungsstatistik"
        };
        private string[] _french = {
            "À propos de l'onglet actuel",
            "Foule",
            "Personnages:",
            "Mots:",
            "Statistiques de répétition de mots"
        };

        private void SetUILocalization()
        {
            string[] items = _currentLanguage switch
            {
                "Deutsch" => _german,
                "Français" => _french,
                "Русский" => _russian,
                "Українська" => _ukrainian,
                _ => _english
            };

            Text = items[0];
            _amountGroupBox.Text = items[1];
            _charactersAmountLabel1.Text = items[2];
            _wordsAmountLabel1.Text = items[3];
            _wordRepeatmentStatisticsGroupBox.Text = items[4];
        }
    }
}
