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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     public MainWindow()
     {
      InitializeComponent();
      Pikkus.Visible = false;
      Laius.Visible = false;
      Raadius.Visible = false;
      Kulg.Visible = false;
      Tulemus.Visible = false;
     }
     
     private void Kolmnurk_Click(object sender, RoutedEventArgs e)
     {
      Pikkus.Visible = true;
      Laius.Visible = false;
      Raadius.Visible = false;
      Kulg.Visible = true;
      Tulemus.Visible = true;
      int pikkus = KolmnurgaPikkus.Text;
      int laius = KolmnurgaLaius.Text;
     }

     private void Ring_Click(object sender, RoutedEventArgs e)
     {
      Pikkus.Visible = false;
      Laius.Visible = false;
      Raadius.Visible = true;
      Kulg.Visible = false;
      Tulemus.Visible = true;
     }
   

     private void Ristkülik_Click(object sender, RoutedEventArgs e)
     {
      Pikkus.Visible = true;
      Laius.Visible = true;
      Raadius.Visible = false;
      Kulg.Visible = true;
      Tulemus.Visible = true;
     }

     private void Ring_Click(object sender, RoutedEventArgs e)
     {
      Pikkus.Visible = false;
      Laius.Visible = false;
      Raadius.Visible = true;
      Kulg.Visible = false;
      Tulemus.Visible = false;
     }

     private void Tulemus_Click(object sender, RoutedEventArgs e)
     {

     }
    }
}
