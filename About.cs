using System.Media;

namespace Notepad
{
    public partial class About : Form
    {
        private SoundPlayer _soundPlayer = new(Directory.GetCurrentDirectory() + "\\Not a rickroll, promise.wav");
        public About()
        {
            InitializeComponent();
            _soundPlayer.Play();
        }

        private void WhenFormClosed(object sender, FormClosedEventArgs e) => _soundPlayer.Stop();
        
    }
}
