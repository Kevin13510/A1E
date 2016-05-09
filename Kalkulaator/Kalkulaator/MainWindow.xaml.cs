using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulaator
{
 public partial class MainWindow : Window
 {
  public MainWindow()
  {
   InitializeComponent();
   arvuta.Visibility = Visibility.Hidden;
   külg.isEnabled = false;
   kõrgus.isEnabled = false;
   raadius.IsEnabled = false;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
  }

  private void kolmnurk_Click(object sender, RoutedEventArgs e)
  {
   külg.isEnabled = true;
   raadius.IsEnabled = false;
   kõrgus.isEnabled = true;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
  }

  private void ring_Click(object sender, RoutedEventArgs e)
  {
   külg.isEnabled = false;
   kõrgus.isEnabled = false;
   raadius.IsEnabled = false;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
  }

  private void ristkylik_Click(object sender, RoutedEventArgs e)
  {
   laius.IsEnabled = true;
   pikkus.IsEnabled = true;
   külg.isEnabled = false;
   kõrgus.isEnabled = false;
   raadius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
  }

  private void ruut_Click(object sender, RoutedEventArgs e)
  {
   laius.IsEnabled = false;
   pikkus.IsEnabled = false;
   raadius.isEnabled = false;
   külg.isEnabled = true;
   kõrgus.isEnabled = false;
   arvuta.Visibility = Visibility.Visible;
  }

  private void arvuta_Click(object sender, RoutedEventArgs e)
  {
   int kolmnurgaYmbermõõt = (int.Parse(külg.Text) * int.Parse(kõrgus.Text)) / 2;
   int kolmnurgaPindala = külg + külg + külg;
   if (külg.isEnabled == true && kõrgus.isEnabled == true)
   {
    
   }
  }
 }
}
