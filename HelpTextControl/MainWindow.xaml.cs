using System.Windows;

namespace HelpTextControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HelpTextBoldFont.ToolTipText = "This control will display <b>bold</b> tooltip text";
        }
    }
}
