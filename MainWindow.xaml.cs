using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_Script_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StoryLinkedList scriptList = new StoryLinkedList();
        private List<string> sortedScript;
        public int currentIndex = 0;


        public MainWindow()
        {
            InitializeComponent();
            LoadScript();
            scriptList.Sort();
            sortedScript = scriptList.ToList();
            DisplayFullScript();
        }

        public void LoadScript()
        {
            scriptList.Add(12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams.");
            scriptList.Add(4, "The Firewall Fortress looms ahead, its defenses formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
            scriptList.Add(2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom.");
            scriptList.Add(1, " In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge.");
            scriptList.Add(7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as \"Syntax Sentinels,\" united by their dedication to digital mastery.");
            scriptList.Add(10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere.");
            scriptList.Add(11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology.");
            scriptList.Add(9, " In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes.");
            scriptList.Add(5, " Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions.");
            scriptList.Add(6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumored to contain the ultimate programming language. 8 The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm.");
        }

        private void DisplayFullScript()
        {
            ScriptBox.Text = string.Join("\n\n", sortedScript);
        }

        private void DisplayCurrentLine()
        {
            if (sortedScript.Count > 0)
                ScriptBox.Text = sortedScript[currentIndex];
        }

        private void FullScript_Click(object sender, RoutedEventArgs e)
        {
            DisplayFullScript();
        }

        private void LineMode_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = 0;
            DisplayCurrentLine();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < sortedScript.Count - 1)
            {
                currentIndex++;
                DisplayCurrentLine();
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentLine();
            }
        }

    }
}