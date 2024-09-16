using Avalonia.Controls;
using Avalonia.Input;

namespace LoginUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            this.BeginMoveDrag(e);  
        }
    }
}