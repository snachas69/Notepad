namespace Notepad
{
    public class MyTabPage : TabPage
    {
        public MyTabPage(string text) : base(text)
        {
        }
        public string? Path { get; set; }
    }
}
