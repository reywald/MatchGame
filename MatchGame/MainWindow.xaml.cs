using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐘", "🐘",
                "🐳", "🐳", 
                "🦘","🦘",
                "🐙","🐙",
                "🐫","🐫",
                "🦕","🦕",
                "🦔","🦔",
                "🐡","🐡"
            };
            
            Random random = new Random();

            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}