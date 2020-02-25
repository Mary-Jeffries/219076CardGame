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

namespace _219076CardGame
{
    public enum Suit {Clubs, Diamonds, Hearts, Spades}
    public enum FaceValue {Ace, Two, Three, Four, Five, Six, Seven, Eight,
    Nine, Ten, Jack, Queen, King} 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //gloabl variable
        Random random; 
        
        public MainWindow()
        {
            InitializeComponent(); 
            random = new Random(1);

        }

        private void btnPickCard_Click(object sender, RoutedEventArgs e)
        {
            int cardValue = random.Next(52); 
            Suit suit = (Suit)(cardValue / 13);
            FaceValue facevalue = (FaceValue)(cardValue / 13);    
            lblOutput.Content = cardValue + Environment.NewLine + 
                facevalue.ToString() + " of " + suit.ToString();  
            
        }
    }
}
