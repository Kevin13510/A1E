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
   kylg1.IsEnabled = false;
   kylg2.IsEnabled = false;
   kylg3.IsEnabled = false;
   kõrgus.IsEnabled = false;
   raadius.IsEnabled = false;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
  }

  private void kolmnurk_Click(object sender, RoutedEventArgs e)
  {
   kylg1.Text = "";
   kylg2.Text = "";
   kylg3.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   kylg1.IsEnabled = true;
   kylg2.IsEnabled = true;
   kylg3.IsEnabled = true;
   raadius.IsEnabled = false;
   kõrgus.IsEnabled = true;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
  }

  private void ring_Click(object sender, RoutedEventArgs e)
  {
   kylg1.Text = "";
   kylg2.Text = "";
   kylg3.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   kylg1.IsEnabled = false;
   kylg2.IsEnabled = false;
   kylg3.IsEnabled = false;
   kõrgus.IsEnabled = false;
   raadius.IsEnabled = true;
   pikkus.IsEnabled = false;
   laius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
  }

  private void ristkylik_Click(object sender, RoutedEventArgs e)
  {
   kylg1.Text = "";
   kylg2.Text = "";
   kylg3.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   laius.IsEnabled = true;
   pikkus.IsEnabled = true;
   kylg1.IsEnabled = false;
   kylg2.IsEnabled = false;
   kylg3.IsEnabled = false;
   kõrgus.IsEnabled = false;
   raadius.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
  }

  private void ruut_Click(object sender, RoutedEventArgs e)
  {
   kylg1.Text = "";
   kylg2.Text = "";
   kylg3.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   laius.IsEnabled = false;
   pikkus.IsEnabled = false;
   raadius.IsEnabled = false;
   kylg1.IsEnabled = true;
   kylg2.IsEnabled = false;
   kylg3.IsEnabled = false;
   kõrgus.IsEnabled = false;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
  }

  private void arvuta_Click(object sender, RoutedEventArgs e)
  {
   double k1 = 0;
   double k2 = 0;
   double k3 = 0;
   double h = 0;
   double r = 0;
   double a = 0;
   double b = 0;

   


   
   if (kylg1.IsEnabled == true && kõrgus.IsEnabled == true && kylg2.IsEnabled == true && kylg3.IsEnabled == true)
   {
    try
   {
    k1 = double.Parse(kylg1.Text);
    k2 = double.Parse(kylg2.Text);
    k3 = double.Parse(kylg3.Text);
    h = double.Parse(kõrgus.Text);
    //r = int.Parse(raadius.Text);
    //a = int.Parse(pikkus.Text);
    //b = int.Parse(laius.Text);
   }
   catch (FormatException)
   {
    MessageBox.Show("Palun sisesta arvud");
   }
    double kolmnurgaYmbermoot = (k1 * h) / 2;
    double kolmnurgaPindala = k1 + k2 + k3;
    Ymbermoot.Content = kolmnurgaYmbermoot.ToString();
    Pindala.Content = kolmnurgaPindala.ToString();
   }

   
   if (raadius.IsEnabled == true)
   {
    try
    {
     //k1 = int.Parse(kylg1.Text);
     //k2 = int.Parse(kylg2.Text);
     //k3 = int.Parse(kylg3.Text);
     //h = int.Parse(kõrgus.Text);
     r = double.Parse(raadius.Text);
     //a = int.Parse(pikkus.Text);
     //b = int.Parse(laius.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    double ringiYmbermoot = Math.Round(Math.PI * r * r, 2);
    double ringiPindala = Math.Round(2 * Math.PI * r, 2);
    Ymbermoot.Content = ringiYmbermoot.ToString();
    Pindala.Content = ringiPindala.ToString();
   }


   if (laius.IsEnabled == true && pikkus.IsEnabled == true)
   {
    try
    {
     //k1 = int.Parse(kylg1.Text);
     //k2 = int.Parse(kylg2.Text);
     //k3 = int.Parse(kylg3.Text);
     //h = int.Parse(kõrgus.Text);
     //r = int.Parse(raadius.Text);
     a = double.Parse(pikkus.Text);
     b = double.Parse(laius.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    double ristkylikuYmbermoot = Math.Round(2 * (a + b), 2);
    double ristkylikuPindala = Math.Round(a * b / 2, 2);
    Ymbermoot.Content = ristkylikuYmbermoot.ToString();
    Pindala.Content = ristkylikuPindala.ToString();
   }


   if (kylg1.IsEnabled == true)
   {
    try
    {
     k1 = double.Parse(kylg1.Text);
     //k2 = int.Parse(kylg2.Text);
     //k3 = int.Parse(kylg3.Text);
     //h = int.Parse(kõrgus.Text);
     //r = int.Parse(raadius.Text);
     //a = int.Parse(pikkus.Text);
     //b = int.Parse(laius.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    double ristkylikuYmbermoot = Math.Round(4 * k1, 2);
    double ristkylikuPindala = Math.Round(Math.Pow(k1, 2));
    Ymbermoot.Content = ristkylikuYmbermoot.ToString();
    Pindala.Content = ristkylikuPindala.ToString();
   }
   label8.Visibility = Visibility.Visible;
   label9.Visibility = Visibility.Visible;
  }
 }
}