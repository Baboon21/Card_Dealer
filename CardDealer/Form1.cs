using System.Windows.Forms;//

namespace CardDealer
{
    public partial class Form1 : Form
    {
        //class atributes
        public List<Card> deckOfCards = new List<Card>();//initialises new List

        public Form1()
        {
            InitializeComponent();
        }

        public void buildDeckofCards()//Method that contains the image files of cards
        {
            deckOfCards.Add(new Card("Black", "Number", "Club", 2, "2_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 3, "2_of_clubs.png"));
            deckOfCards.Add( new Card("Black", "Number", "Club", 4, "4_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 5, "5_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 6, "6_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 7, "7_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 8, "8_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 9, "9_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 10, "10_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Club", 1, "ace_of_clubs.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 2, "2_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 3, "3_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 4, "4_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 5, "5_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 6, "6_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 7, "7_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 8, "8_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 9, "9_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 10, "10_of_hearts.png"));
            deckOfCards.Add(new Card("Black", "Number", "Heart", 1, "ace_of_hearts.png"));
            deckOfCards.Add( new Card("Black", "Number", "Diamonds", 2, "2_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 3, "3_of_Diamonds.png"));
            deckOfCards.Add( new Card("Black", "Number", "Diamonds", 4, "4_of_Diamonds.png"));
            deckOfCards.Add( new Card("Black", "Number", "Diamonds", 5, "5_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 6, "6_of_Diamonds.png"));
            deckOfCards.Add( new Card("Black", "Number", "Diamonds", 7, "7_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 8, "8_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 9, "9_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 10, "10_of_Diamonds.png"));
            deckOfCards.Add(new Card("Black", "Number", "Diamonds", 1, "ace_of_Diamonds.png"));

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displaySelection(List<int> randomSelection)
        {
            //repeat the selection length time.
            // for each instance.
            // we will pick one element from the deck
            string basePath = "C:\\Users\\asolo\\source\\repos\\CardDealer\\CardDealer\\Resources\\image\\";//where The files will  be accessed(will need to be changed when moves to new device due to being on home computer and will go straight to teacher.

            //Displays card in different instances
            Card crd = deckOfCards[randomSelection[0]];
            pictureBox1.Image = Image.FromFile(basePath + crd.picName);
            Card crd2 = deckOfCards[randomSelection[1]];
            pictureBox2.Image = Image.FromFile(basePath + crd2.picName);
            Card crd3 = deckOfCards[randomSelection[2]];
            pictureBox3.Image = Image.FromFile(basePath + crd3.picName);
            Card crd4 = deckOfCards[randomSelection[3]];
            pictureBox4.Image = Image.FromFile(basePath + crd4.picName);
            Card crd5 = deckOfCards[randomSelection[4]];
            pictureBox5.Image = Image.FromFile(basePath + crd5.picName);
        }


        List<int> getUniqueSelection(int size)
        {
            Random random = new Random();
            //List<int> uniqueNumbers = new List<int>();
            //The List Class is like an array but you dont have to initialise the max size of the array. Also you have more funtionality with lists. But if you need the most performance, Using Array would put less stress on Computer resourses.
            List<int> uniqueSelection = new List<int>();

            while (uniqueSelection.Count < size)
            {
                int randomNumber = random.Next(1, deckOfCards.Count);
                if (uniqueSelection.Contains(randomNumber) == false)
                {
                    uniqueSelection.Add(randomNumber);
                }
                //if random number dosen't exists then add
            }
            return uniqueSelection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buildDeckofCards();//builds deck of cards neededfor use
            List<int> randomSelection = getUniqueSelection(5);//Gets 5 card from 'buildDeckofCards' funtion
            displaySelection(randomSelection);//Displays the 5 cards
        }
    }

    public class Card//new class made
    {
       string color;//Red, Black
       public string cardType; //Special, Number 
       public string cardShape; //Heart, Spade, Club, Diamond
       public int cardNumber; //The Number Value of the card/Null
       public string picName;//the file that willbe accessed when setting the variable in the list

        public Card(string cardColor, string type, string _shape, int _cardNumber, string _picName)
        {
            color = cardColor;
            cardType = type;
            cardShape = _shape;
            cardNumber = _cardNumber;
            picName = _picName;
        }
    }
}
