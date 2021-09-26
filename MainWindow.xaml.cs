using System.Windows;

namespace WPF_Window_Chrome
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void CloseWindow(object sender, RoutedEventArgs e)
		{
			FocusButton.Focus();
			Application.Current.Shutdown();
		}
		private void MaximizeWindow(object sender, RoutedEventArgs e)
		{
			FocusButton.Focus();
			switch (WindowState)
			{
				case WindowState.Maximized: WindowState = WindowState.Normal; break;
				case WindowState.Normal: WindowState = WindowState.Maximized; break;
			}
		}
		private void MinimizeWindow(object sender, RoutedEventArgs e)
		{
			FocusButton.Focus();
			WindowState = WindowState.Minimized;
		}
	}
}
