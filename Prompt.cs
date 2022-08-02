namespace Notepad
{
    public partial class Prompt : Form
    {
        public Prompt() => InitializeComponent();
        public Prompt(string language) : this()
        {
            string[] items = language switch
            {
                "Deutsch" => _german,
                "Français" => _french,
                "Русский" => _russian,
                "Українська" => _ukrainian,
                _ => _english
            };

            Text = items[0];
            label1.Text = items[1];
            label2.Text = items[2];
            _browsButton.Text = items[3];
            _createButton.Text = items[4];
            _cancelButton.Text = items[5];
        }

        private string[] _english = {
            "Prompt",
            "File Name",
            "File Path",
            "Brows",
            "Create",
            "Cancel"
        };
        private string[] _russian = {
            "Ввод",
            "Имя файла",
            "Путь файла",
            "Исткать",
            "Создать",
            "Закрыть"
        };
        private string[] _ukrainian = {
            "Введення",
            "Ім'я файлу",
            "Шлях файлу",
            "Шукати",
            "Створити",
            "Закрити"
        };
        private string[] _german = {
            "Prompt",
            "Dateiname",
            "Dateipfad",
            "Suchen",
            "Schaffen",
            "Schließen"
        };
        private string[] _french = {
            "Saisir",
            "Nom de fichier",
            "Chemin de fichier",
            "Sourcils",
            "Créer",
            "Annuler"
        };
        public MyTabPage TabPage { get; private set; }

        private void CreateTabClick(object sender, EventArgs e)
        {
            if (_fileName.Text != string.Empty)
            {
                try
                {
                    if (!File.Exists(_filePath.Text))
                    {
                        File.Create(_filePath.Text).Close();
                        TabPage = new MyTabPage(_filePath.Text.Substring(_filePath.Text.LastIndexOf('\\') + 1));
                        TabPage.Path = _filePath.Text;
                        DialogResult = DialogResult.OK;
                        Close();
                        return;
                    }
                    throw new Exception("A file with this name already exists");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("The field must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BrowsClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                _filePath.Text = folderBrowserDialog.SelectedPath + '\\' + _fileName.Text;
            
        }

        private void CloseClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
                _filePath.Text = _filePath.Text.Substring(0, _filePath.Text.Length - 2);
            else if (e.KeyChar > 32 && e.KeyChar < 126)
                _filePath.Text += e.KeyChar;
        }
    }
}
