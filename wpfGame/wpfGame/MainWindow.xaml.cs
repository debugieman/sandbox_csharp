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
using System.Windows.Threading;


namespace wpfGame
    
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.01);
            timer.Tick += Timer_Tick;
            SetUpGame();


        }

        private void Timer_Tick1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
           //throw new NotImplementedException();




        }

        

        private void SetUpGame()
        {
            List<string>animalEmoji = new List<string>

        {
        "🐻","🐻",
        "🐶","🐶",
        "🐱‍","🐱‍",
        "🦁","🦁",
        "🦊","🦊",
        "🦒","🦒",
        "🦝","🦝",
        "🐼","🐼",





        };
            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid1.Children.OfType<TextBlock>())
            { 
            int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);


            }
        
        
        
        }
        TextBlock lastTextBlockClicked;
        bool findingMatch = false;


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
           
            
            
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;

            }

            else if (textBlock.Text == lastTextBlockClicked.Text)

            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else 
            
            { 
             lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch= false;
            }

          
        }

        private void TimeTextBlock_(object sender, MouseButtonEventArgs e)
        {

        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
