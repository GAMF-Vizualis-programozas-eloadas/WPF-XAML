using System.Windows;

namespace WPF_XAML
{
	/// <summary>
	/// A felületet XAML-ben készítettük. A C# állomány csak
  /// a mögöttes kódot,
	/// azaz az eseménykezelőket tartalmazza.
	/// </summary>
	public partial class wndAblak : Window
  {
    public wndAblak()
    {
      InitializeComponent();
    }

    private void btKilép_Click(object sender, RoutedEventArgs e)
    {
      // Kilépés az alkalmazásból
      Application.Current.Shutdown();
    }

    private void btÜzenet_Click(object sender, RoutedEventArgs e)
    {
      // Üzenetablak megjelenítése
      MessageBox.Show("Üzenet");
    }
  }

}
