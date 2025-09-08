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
using System.Windows.Shapes;

namespace Sommatif2Interface.View
{
    /// <summary>
    /// Logique d'interaction pour CalculateurIMC.xaml
    /// </summary>
    public partial class CalculateurIMC : Window
    {
        public CalculateurIMC()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Comportements.TextBox_SelectionContenu(sender, e);
        }
        
        private string CalculerIMC(string poids,string taille)
        {
            double poidsConverti;
            double tailleConverti;

            double.TryParse(poids, out poidsConverti);
            double.TryParse(taille, out tailleConverti);

         

            return $"{poidsConverti/(tailleConverti*tailleConverti)}";
        }

        private void btnCalculerIMC_Click(object sender, RoutedEventArgs e)
        {
            resultasIMC.Text =CalculerIMC(valeurPoids.Text,valeurTaille.Text);

            double IMC;
            double.TryParse(resultasIMC.Text, out IMC);

            //if(IMC> 18.5 && IMC<24.9)
            //{
            //    categorie.Text = "Poids normal";
            //}
            //else if(IMC > 24.9 && IMC < 29.9)
            //{
            //    categorie.Text = "Surpoids";
            //}
            //else if(IMC > 29.9 && IMC < 40)
            //{
            //    categorie.Text = "Obésité";
            //}
            //else if(IMC<18.5)
            //{
            //    categorie.Text = "Insuffisance pondérale";
            //}



            if (IMC < 18.5)
            {
                categorie.Text = "Insuffisance pondérale";
            }
            else if (IMC >= 18.5 && IMC < 24.9)
            {
                categorie.Text = "Poids normal";
            }
            else if (IMC >= 24.9 && IMC < 29.9)
            {
                categorie.Text = "Surpoids";
            }
            else // IMC >= 29.9
            {
                categorie.Text = "Obésité";
            }

        }
    }
}
