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
   kylg1.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   raadius.Visibility = Visibility.Hidden;
   pikkus.Visibility = Visibility.Hidden;
   laius.Visibility = Visibility.Hidden;
   SisestaAndmed.Text = "Vali kujund.";
   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   Võrdhaarne.Visibility = Visibility.Hidden;
   Täisnurkne.Visibility = Visibility.Hidden;
   Võrdkülgne.Visibility = Visibility.Hidden;


   kylg1txt.Visibility = Visibility.Hidden;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Hidden;
   raadiustxt.Visibility = Visibility.Hidden;
   pikkustxt.Visibility = Visibility.Hidden;
   laiustxt.Visibility = Visibility.Hidden;
   kast.Visibility = Visibility.Hidden;
  }

  private void kolmnurk_Click(object sender, RoutedEventArgs e)
  {
   arvuta.Visibility = Visibility.Hidden;
   Võrdhaarne.Visibility = Visibility.Visible;
   Täisnurkne.Visibility = Visibility.Visible;
   Võrdkülgne.Visibility = Visibility.Visible;
   SisestaAndmed.Text = "Vali kolmnurga tüüp";
   kylg1.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   kylg1.Visibility = Visibility.Hidden;
   raadius.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   pikkus.Visibility = Visibility.Hidden;
   laius.Visibility = Visibility.Hidden;
   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";

   kylg1txt.Visibility = Visibility.Hidden;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Hidden;
   raadiustxt.Visibility = Visibility.Hidden;
   pikkustxt.Visibility = Visibility.Hidden;
   laiustxt.Visibility = Visibility.Hidden;
   kast.Visibility = Visibility.Hidden;
  }

  private void ring_Click(object sender, RoutedEventArgs e)
  {
   Võrdhaarne.Visibility = Visibility.Hidden;
   Täisnurkne.Visibility = Visibility.Hidden;
   Võrdkülgne.Visibility = Visibility.Hidden;
   SisestaAndmed.Text = "Sisesta kujundi andmed";
   kylg1.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   raadius.Visibility = Visibility.Visible;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";

   kylg1txt.Visibility = Visibility.Hidden;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Hidden;
   raadiustxt.Visibility = Visibility.Visible;
   pikkustxt.Visibility = Visibility.Hidden;
   laiustxt.Visibility = Visibility.Hidden;

   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   kylg1.Visibility = Visibility.Hidden;
   laius.Visibility = Visibility.Hidden;
   pikkus.Visibility = Visibility.Hidden;
   kast.Visibility = Visibility.Hidden;
  }

  private void ristkylik_Click(object sender, RoutedEventArgs e)
  {
   Võrdhaarne.Visibility = Visibility.Hidden;
   Täisnurkne.Visibility = Visibility.Hidden;
   Võrdkülgne.Visibility = Visibility.Hidden;
   SisestaAndmed.Text = "Sisesta kujundi andmed";
   kylg1.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   laius.Visibility = Visibility.Visible;
   pikkus.Visibility = Visibility.Visible;
   kylg1.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   raadius.Visibility = Visibility.Hidden;
   arvuta.Visibility = Visibility.Visible;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";

   kylg1txt.Visibility = Visibility.Hidden;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Hidden;
   raadiustxt.Visibility = Visibility.Hidden;
   pikkustxt.Visibility = Visibility.Visible;
   laiustxt.Visibility = Visibility.Visible;

   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   kylg1.Visibility = Visibility.Hidden;
   kast.Visibility = Visibility.Hidden;
  }

  private void ruut_Click(object sender, RoutedEventArgs e)
  {
   Võrdhaarne.Visibility = Visibility.Hidden;
   Täisnurkne.Visibility = Visibility.Hidden;
   Võrdkülgne.Visibility = Visibility.Hidden;
   SisestaAndmed.Text = "Sisesta kujundi andmed";
   kylg1.Text = "";
   kõrgus.Text = "";
   raadius.Text = "";
   pikkus.Text = "";
   laius.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   laius.Visibility = Visibility.Hidden;
   pikkus.Visibility = Visibility.Hidden;
   raadius.Visibility = Visibility.Hidden;
   kylg1.Visibility = Visibility.Visible;
   kõrgus.Visibility = Visibility.Hidden;
   arvuta.Visibility = Visibility.Visible;
   kylg1txt.Content = "Külg:";
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";

   kylg1txt.Visibility = Visibility.Visible;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Hidden;
   raadiustxt.Visibility = Visibility.Hidden;
   pikkustxt.Visibility = Visibility.Hidden;
   laiustxt.Visibility = Visibility.Hidden;

   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Hidden;
   kast.Visibility = Visibility.Hidden;
  }

  private void arvuta_Click(object sender, RoutedEventArgs e)
  {
   double k1 = 0;
   double h = 0;
   double r = 0;
   double a = 0;
   double b = 0;
   double k2 = 0;
   double k3 = 0;



   if (kylg1txt.Content.ToString() == "Alus:" && kylg2txt.Content.ToString() == "Haar:")
   {
    if (kylg1.Text == "" || kõrgus.Text == "" || Külg2.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
   {
    k1 = double.Parse(kylg1.Text);
    h = double.Parse(kõrgus.Text);
    k2 = double.Parse(Külg2.Text);
   }
   catch (FormatException)
   {
    MessageBox.Show("Palun sisesta arvud");
   }
    kast.Visibility = Visibility.Visible;
     double kolmnurgaPindala = (k1 * h) / 2;
     double kolmnurgaYmbermoot = k1 + k2 + k2;
     label8.Visibility = Visibility.Visible;
     label9.Visibility = Visibility.Visible;
     Ymbermoot.Content = kolmnurgaYmbermoot.ToString();
     Pindala.Content = kolmnurgaPindala.ToString();
     SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
   }


   if (kylg1txt.Content.ToString() == "Hüpotenuus:" && kylg2txt.Content.ToString() == "1. kaatet:" && kylg3txt.Content.ToString() == "2. kaatet:")
   {
    if (kylg1.Text == "" || Külg2.Text == "" || Külg3.Text == "" || kõrgus.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
    {
     k1 = double.Parse(kylg1.Text);
     k2 = double.Parse(Külg2.Text);
     k3 = double.Parse(Külg3.Text);
     h = double.Parse(kõrgus.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    
    if (Math.Round(Math.Pow(k1, 2)) == Math.Pow(k2, 2) + Math.Pow(k3, 2))
    {
     kast.Visibility = Visibility.Visible;
     double kolmnurgaPindala = (k1 * h) / 2;
     double kolmnurgaYmbermoot = k1 + k2 + k3;
     label8.Visibility = Visibility.Visible;
     label9.Visibility = Visibility.Visible;
     Ymbermoot.Content = kolmnurgaYmbermoot.ToString();
     Pindala.Content = kolmnurgaPindala.ToString();
     SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
    }
    else
    {
     MessageBox.Show("Sisestasid mitte korrektsed andmed!");
     return;
    }
   }

   if (kylg1txt.Content.ToString() == "Külg:" && kõrgus.IsVisible == true && Külg2.IsVisible == false && Külg3.IsVisible == false)
   {
    if (kylg1.Text == "" || kõrgus.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
    {
     k1 = double.Parse(kylg1.Text);
     h = double.Parse(kõrgus.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    kast.Visibility = Visibility.Visible;
    double kolmnurgaPindala = (k1 * h) / 2;
    double kolmnurgaYmbermoot = k1 + k1 + k1;
    label8.Visibility = Visibility.Visible;
    label9.Visibility = Visibility.Visible;
    Ymbermoot.Content = kolmnurgaYmbermoot.ToString();
    Pindala.Content = kolmnurgaPindala.ToString();
    SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
   }


   if (raadius.IsVisible == true)
   {
    if (raadius.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
    {
     r = double.Parse(raadius.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    kast.Visibility = Visibility.Visible;
    double ringiYmbermoot = Math.Round(Math.PI * r * r, 2);
    double ringiPindala = Math.Round(2 * Math.PI * r, 2);
    Ymbermoot.Content = ringiYmbermoot.ToString();
    Pindala.Content = ringiPindala.ToString();
    SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
   }


   if (laius.IsVisible == true && pikkus.IsVisible == true)
   {
    if (laius.Text == "" || pikkus.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
    {
     a = double.Parse(pikkus.Text);
     b = double.Parse(laius.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    kast.Visibility = Visibility.Visible;
    double ristkylikuYmbermoot = Math.Round(2 * (a + b), 2);
    double ristkylikuPindala = Math.Round(a * b, 2);
    Ymbermoot.Content = ristkylikuYmbermoot.ToString();
    Pindala.Content = ristkylikuPindala.ToString();
    SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
   }


   if (kylg1.IsVisible == true && kõrgus.IsVisible == false && Külg2.IsVisible == false)
   {
    if (kylg1.Text == "")
    {
     MessageBox.Show("Sa ei sisestanud kõiki andmeid!");
     return;
    }
    try
    {
     k1 = double.Parse(kylg1.Text);
    }
    catch (FormatException)
    {
     MessageBox.Show("Palun sisesta arvud");
    }
    kast.Visibility = Visibility.Visible;
    double ruuduYmbermoot = Math.Round(4 * k1, 2);
    double ruuduPindala = Math.Round(Math.Pow(k1, 2));
    Ymbermoot.Content = ruuduYmbermoot.ToString();
    Pindala.Content = ruuduPindala.ToString();
    SisestaAndmed.Text = "Uue kujundi arvutamiseks vali uuesti kujund.";
   }
   label8.Visibility = Visibility.Visible;
   label9.Visibility = Visibility.Visible;
  }

  private void Võrdhaarne_Click(object sender, RoutedEventArgs e)
  {
   kast.Visibility = Visibility.Hidden;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
   SisestaAndmed.Text = "Sisesta andmed";
   arvuta.Visibility = Visibility.Visible;
   kylg1.Visibility = Visibility.Visible;
   Külg2.Visibility = Visibility.Visible;
   Külg3.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Visible;

   kylg1txt.Visibility = Visibility.Visible;
   kylg2txt.Visibility = Visibility.Visible;
   kylg3txt.Visibility = Visibility.Hidden;
   kõrgustxt.Visibility = Visibility.Visible;

   kylg1txt.Content = "Alus:";
   kylg2txt.Content = "Haar:";

   kylg1.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   kõrgus.Text = "";
  }

  private void Võrdkülgne_Click(object sender, RoutedEventArgs e)
  {
   kast.Visibility = Visibility.Hidden;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
   SisestaAndmed.Text = "Sisesta andmed";
   arvuta.Visibility = Visibility.Visible;
   kylg1txt.Content = "Külg:";
   kylg1.Visibility = Visibility.Visible;
   Külg2.Visibility = Visibility.Hidden;
   Külg3.Visibility = Visibility.Hidden;
   kõrgus.Visibility = Visibility.Visible;

   kõrgustxt.Visibility = Visibility.Visible;
   kylg1txt.Visibility = Visibility.Visible;
   kylg2txt.Visibility = Visibility.Hidden;
   kylg3txt.Visibility = Visibility.Hidden;
   kylg1.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   kõrgus.Text = "";
  }

  private void Täisnurkne_Click(object sender, RoutedEventArgs e)
  {
   kast.Visibility = Visibility.Hidden;
   label8.Visibility = Visibility.Hidden;
   label9.Visibility = Visibility.Hidden;
   Ymbermoot.Content = "";
   Pindala.Content = "";
   SisestaAndmed.Text = "Sisesta andmed";
   arvuta.Visibility = Visibility.Visible;
   kylg1.Visibility = Visibility.Visible;
   Külg2.Visibility = Visibility.Visible;
   Külg3.Visibility = Visibility.Visible;
   kõrgus.Visibility = Visibility.Visible;

   kylg1txt.Content = "Hüpotenuus:";
   kylg2txt.Content = "1. kaatet:";
   kylg3txt.Content = "2. kaatet:";

   kylg1txt.Visibility = Visibility.Visible;
   kylg2txt.Visibility = Visibility.Visible;
   kylg3txt.Visibility = Visibility.Visible;
   kõrgustxt.Visibility = Visibility.Visible;
   kylg1.Text = "";
   Külg2.Text = "";
   Külg3.Text = "";
   kõrgus.Text = "";
  }
 }
}