using System.Globalization;
using System.Text;
using Xceed.Words.NET;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            NotePadSizeChanged(null, null);
            switch (CultureInfo.InstalledUICulture.Name)
            {
                case "de-DE":
                    _checked = _menuItemGerman;
                    _menuItemGerman.Checked = true;
                    _currentLanguage = "Deutsch";
                    break;
                case "fr-FR":
                    _checked = _menuItemFrench;
                    _menuItemFrench.Checked = true;
                    _currentLanguage = "Français";
                    break;
                case "uk-UA":
                    _checked = _menuItemUkrainian;
                    _menuItemUkrainian.Checked = true;
                    _currentLanguage = "Українська";
                    break;
                case "ru-RU":
                    _checked = _menuItemRussian;
                    _menuItemRussian.Checked = true;
                    _currentLanguage = "Русский";
                    break;
                default:
                    _checked = _menuItemEnglish;
                    _menuItemEnglish.Checked = true;
                    _currentLanguage = "English";
                    break;
            };
            
            SetUILocalization();
        }

        private ToolStripMenuItem _checked;
        private string _currentLanguage;

        private string[] _english = {
            "Line:", "Column:", "Lines amount:",
            "File", "New", "Open", "Save", "Save as", "Remove", "Exit",
            "Edit", "Copy", "Paste", "Cut", "Select All", "Replace Current Tab",
            "Help","View Help", "Send Help", "About Notepad", "About Current Tab",
            "Language", "English", "Русский", "Українська", "Deutsch", "Français",
        };

        private string[] _russian = {
            "Строка","Столбец", "Количество строк:",
            "Файл", "Новый", "Открыть", "Сохранить", "Сохранить как", "Удалить", "Выход",
            "Изменить", "Копировать", "Вставить", "Вырезать", "Выделить всё", "Заменить выбранную вкладку",
            "Помощь", "Посмотреть помощь", "Попросить помощи", "О Notepad", "О выбранной вкладке",
            "Язык", "English", "Русский", "Українська", "Deutsch", "Français",
        };

        private string[] _ukrainian = {
            "Рядок", "Стовбець", "Кількість рядків:",
            "Файл", "Новий", "Відкрити", "Зберегти", "Зберегти як", "Видалити", "Вихід",
            "Редагувати", "Копіювати", "Вставити", "Вирізати", "Виділити все", "Замінити виділену вкладку",
            "Поміч", "Подивитися поміч", "Попросити допомоги", "Про Notepad", "Про вибрану вкладку",
            "Мова", "English", "Русский", "Українська", "Deutsch", "Français",
        };

        private string[] _german = {
            "Linie","Säule", "Zeilenanzahl:",
            "Datei", "Neu", "Öffnen", "Speichern", "Speichern unter", "Entfernen", "Beenden",
            "Bearbeiten", "Kopieren", "Einfügen", "Ausschneiden", "Alles auswählen", "Aktuelle Registerkarte ersetzen",
            "Hilfe", "Hilfe anzeigen", "Hilfe senden", "Über Notepad", "Über den aktuellen Tab",
            "Sprache", "English", "Русский", "Українська", "Deutsch", "Français",
        };

        private string[] _french = {
            "Line", "Clonne", "Nombre de lignes:",
            "Fichier", "Nouveau", "Ouvrir", "Enregistrer", "Enregistrer sous", "Supprimer", "Quitter",
            "Modifier", "Copier", "Coller", "Couper", "Sélectionner tout", "Remplacer l'onglet actuel",
            "Aide", "Afficher l'aide", "Envoyer l'aide", "À propos du Notepad", "À propos de l'onglet actuel",
            "Langue", "English", "Русский", "Українська", "Deutsch", "Français",
        };

        private void SetUILocalization()
        {
            string[] items = _currentLanguage switch
            {
                "Deutsch" => _german,
                "Français" => _french,
                "Українська" => _ukrainian,
                "Русский" => _russian,
                _ => _english
            };

            _cursorPositionLnStatusLabel1.Text = items[0];
            _cursorPositionColStatusLabel1.Text = items[1];
            _linesAmountStatusLabel1.Text = items[2];
            _menuItemFile.Text = items[3];
            _menuItemNew.Text = items[4];
            _menuItemOpen.Text = items[5];
            _menuItemSave.Text = items[6];
            _menuItemSaveAs.Text = items[7];
            _menuItemRemove.Text = items[8];
            _menuItemExit.Text = items[9];
            _menuItemEdit.Text = items[10];
            _menuItemCopy.Text = items[11];
            _menuItemPaste.Text = items[12];
            _menuItemCut.Text = items[13];
            _menuItemSelectAll.Text = items[14];
            _menuItemReplace.Text = items[15];
            _menuItemHelp.Text = items[16];
            _menuItemViewHelp.Text = items[17];
            _menuItemSendHelp.Text = items[18];
            _menuItemAboutNotepad.Text = items[19];
            _menuItemAboutCurrentTab.Text = items[20];
            _menuItemLanguage.Text = items[21];
            _menuItemEnglish.Text = items[22];
            _menuItemRussian.Text = items[23];
            _menuItemUkrainian.Text = items[24];
            _menuItemGerman.Text = items[25];
            _menuItemFrench.Text = items[26];
        }

        private void UILanguageChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                _checked.Checked = false;
                item.Checked = true;
                _checked = item;
                _currentLanguage = item.Text;
            }
            SetUILocalization();
        }

        private void NewClick(object sender, EventArgs e)
        {
            Prompt prompt = new(_currentLanguage);
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                _tabControl.TabPages.Add(prompt.TabPage);
                _tabControl.SelectedTab = prompt.TabPage;
                TabPageChanged(sender, e);
                RichTextBoxTextChanged(sender, e);
            }
        }

        private void TabPageChanged(object sender, EventArgs e)
        {
            if (_tabControl.SelectedTab is not null)
            {
                try
                {
                    string path = (_tabControl.TabPages[_tabControl.SelectedIndex] as MyTabPage).Path;
                    if (path.Substring(path.Length - 5, 5) == ".docx")
                        _richTextBox.Text = DocX.Load(path).Text;
                    else
                        _richTextBox.Text = File.ReadAllText(path, Encoding.Unicode);
                    RichTextBoxTextChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OpenClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Select File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MyTabPage tabPage = new(openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\') + 1));
                tabPage.Path = openFileDialog.FileName;
                _tabControl.TabPages.Add(tabPage);
                _tabControl.SelectedTab = tabPage;
                TabPageChanged(sender, e);
                RichTextBoxTextChanged(sender, e);
            }
        }

        private void ExitClick(object sender, EventArgs e) => Close();

        private void RemoveClick(object sender, EventArgs e)
        {
            if (_tabControl.SelectedTab is not null)
            {
                _richTextBox.Text = string.Empty;
                _tabControl.TabPages.Remove(_tabControl.SelectedTab);
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (_tabControl.TabPages.Count > 0)
            {
                File.WriteAllText((_tabControl.SelectedTab as MyTabPage).Path, _richTextBox.Text, Encoding.Unicode);
                Text = "Saved";
                Thread.Sleep(500);
                Text = "Notepad";
            }
        }

        private void SaveAsTxtClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath + '\\' + _tabControl.SelectedTab.Text + "\\.txt";
                if (!File.Exists(path))
                    File.Create(path).Close();
                File.WriteAllText(path, _richTextBox.Text, Encoding.Unicode);
            }
        }

        private void SaveAsDocxClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath + '\\' + _tabControl.SelectedTab.Text + ".docx";
                DocX docx = DocX.Create(path);
                docx.InsertParagraph(_richTextBox.Text);
                docx.Save();
            }
        }

        private void RichTextBoxTextChanged(object sender, EventArgs e)
        {
            _linesAmountStatusLabel2.Text = _richTextBox.Text.Count(i => i == '\n').ToString();
            DisplayCursorPosition();
        }

        private void RichTextBoxTextChanged(object sender, KeyPressEventArgs e) => RichTextBoxTextChanged(sender, e as EventArgs);

        private void NotePadSizeChanged(object sender, EventArgs e)
        {
            if (_richTextBox.Width != Width)
                _richTextBox.Width = Width;
            if (_richTextBox.Height != Height - _statusStrip.Height - _tabControl.Height - _menuStrip.Height - panel1.Height - 52)
                _richTextBox.Height = Height - _statusStrip.Height - _tabControl.Height - _menuStrip.Height - panel1.Height - 52;
        }

        private void DisplayCursorPosition()
        {
            _cursorPositionLnStatusLabel2.Text = (_richTextBox.GetLineFromCharIndex(_richTextBox.SelectionStart) + 1).ToString();
            _cursorPositionColStatusLabel2.Text = (_richTextBox.SelectionStart - _richTextBox.GetFirstCharIndexOfCurrentLine() + 1).ToString();
        }

        private void RichTextBoxMouseClick(object sender, MouseEventArgs e) => DisplayCursorPosition();

        private void RichTextBoxKeyUp(object sender, KeyEventArgs e) => DisplayCursorPosition();

        private void RichTextBoxKeyDown(object sender, KeyEventArgs e) => DisplayCursorPosition();

        private void AboutCurrentTabClick(object sender, EventArgs e) => new AboutCurrentTab(_currentLanguage, _richTextBox).ShowDialog();

        private void AboutNotepadMenuItemClick(object sender, EventArgs e) => new About().ShowDialog();

        private void ViewHelppMenuItemClick(object sender, EventArgs e) => MessageBox.Show("¯\\_(ツ)_/¯");

        private void SendHelpMenuItemClick(object sender, EventArgs e)
        {
            string message = _currentLanguage switch
            {
                "Deutsch" => "Entschuldigung, wir können nicht antworten:(",
                "Русский" => "Приносим свои извинения, мы не можем вам ответить:(",
                "Українська" => "Вибачаємося, ми не вспромозі вам вам відповсіти:(",
                "Français" => "Désolé, nous ne pouvons pas répondre:(",
                _ => "Sorry, we can't respond:(",
            };
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SelectAllMenuItemClick(object sender, EventArgs e) => _richTextBox.SelectAll();

        private void ReplaceClick(object sender, EventArgs e)
        {
            OpenClick(sender, e);
            RemoveClick(sender, e);
        }

        private void MenuItemPasteClick(object sender, EventArgs e) => _richTextBox.Paste();

        private void CopyMenuItemClick(object sender, EventArgs e) => Clipboard.SetText(_richTextBox.SelectedText);

        private void CutMenuItemClick(object sender, EventArgs e) => _richTextBox.Cut();
    }
}