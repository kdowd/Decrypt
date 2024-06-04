using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Decrypt
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

        private void TheBtn_Click(object sender, RoutedEventArgs e)
        {
          


            Dictionary<char, char> lettersDict= new Dictionary<char, char>();
            //keyValuePairs.Add(ÇüéâäåçàêëïèÄÉæÆöûùÿÖÜìÅôò);
            string? AllSecretChars = "ÇüéâäåçàêëïèÄÉæÆöûùÿÖÜìÅôò╟╚╔╩╦¢£¥₧ƒáíóúñÑªº¿⌐¬½¼¡«»";
            string? LowerAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

           
            var counter = AllSecretChars?.Length ;
            //MessageBox.Show(counter.ToString());

            for (int i = 0; i < counter; i++)
            {
              
                lettersDict.Add(AllSecretChars[i], LowerAlphabet[i] );
            }



            string special = "êΘÉääâΘÿàêùΘâäéûôÆÿäâΘÆèäÇùä";
            foreach (var i in special)
            {
              
               

                if (lettersDict.ContainsKey(i))
                {
                    var val = lettersDict[i];
                    Debug.Write(val);
                }
                
            }



        }
    }
}
