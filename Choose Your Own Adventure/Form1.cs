using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
//Valentina Montoya
//ICS3U
//Monday, March 27, 2023
// Choose your own adventure game about a sort of farming/town simulator



namespace Choose_Your_Own_Adventure
{
    public partial class Form1 : Form
    {

        //track which page the user is at
        int page = 1;

        //initialize random number for later actions
        Random randGen = new Random();
        int randomValue;

        //check amount of money
        int money = 0;

        //check inventory
        int bracelet = 0;
        int diamond = 0;
        int srawberry = 0;
        int flowers = 0;


        public Form1()
        {
            InitializeComponent();

            //initialize starting screen
            background.Image = Properties.Resources.farm;
            outputLabel.Text = "You wake up at your lovely farm!";
            Thread.Sleep(1000);
            outputLabel.Text += "\n Where would you like to go?";

            optionLabel1.Text = "Down to town?";

            optionLabel2.Text = "Down to the beach?";

        }

        private void option1Button_Click(object sender, EventArgs e)
        {



            //town
            //all left options

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            //pub or shop
            else if (page == 4)
            {
                 
                page = 5;
            }
            //pub
            else if (page == 5)
            {

                page = 6;
            }
            else if (page == 6)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue < 50)
                {
                    page = 7;
                }
                else
                {
                    page = 60;
                }
            }
            else if (page == 60)
            {
                page = 99;
            }
            else if (page ==8)
            {
                page = 99;
            }
            //Pierre's shop
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            //shane convo.
            else if (page == 10)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue < 50)
                {
                    page = 11;
                }
                else
                {
                    page = 61;
                }
            }
            else if (page == 11)
            {
                if (bracelet == 1)
                {
                    page = 12;
                }
                else
                {
                    page = 66;
                }
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 16;
            }
            //shopping
            else if (page == 16)
            {
                if (money > 15)
                {
                    page = 18;
                }
                else
                {
                    page = 70;
                }
            }
            else if (page == 70)
            {
                page = 17;
            }
            //convince pierre
            else if (page == 18)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue > 50)
                {
                    page = 19;
                }
                else
                {
                    page = 67;
                }
            }
            else if (page == 21)
                if (money < 10)
                {
                    page = 71;
                }
                else
                {
                    page = 23;
                }
            else if (page == 23)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue > 50)
                {
                    page = 24;
                }
                else
                {
                    page = 90;
                }
            }
            else if (page == 71)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 26;
            }


            //Beach
            else if (page == 17)
            {
                page = 26;
            }
            else if (page == 26)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue < 50)
                {
                    //death
                    page = 27;
                }
                else
                {
                    page = 28;
                }
            }
            //fishing
            else if (page == 28)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 30;
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 31)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue > 70)
                {
                    //get fish
                    page = 32;
                }
                else
                {
                    page = 33;
                }
            }
            //talk to Haley
            else if (page == 32)
            {
                page = 36;
            }
            else if (page == 36)
            {
                page = 37;
            }
            else if (page == 37)
            {
                page = 38;
            }
            //go to fish
            else if (page == 38)
            {
                page = 29;
            }
            else if (page == 39)
            {
                page = 29;
            }
            else if (page == 33)
            {
                page = 30;
            }
            else if (page == 34)
            {
                page = 36;
            }
            else if (page == 40)
            {
                page = 41;
            }
            else if (page == 41)
            {
                page = 99;
            }
            else if (page == 42)
            {
                page = 36;
            }

            else if (page == 67)
            {
                page = 99;
            }
            else if (page == 60)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page == 41)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }



            switch (page)
            {

                case 2:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;

                    outputLabel.Text = "While walking to town, you see something in the dirt";

                    outputLabel.Text += "\n Do you want to pick it up?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 3:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You found a bracelet!";
                    //sound

                    bracelet = 1;

                    Thread.Sleep(800);

                    outputLabel.Text += "\n Continue?";

                    optionLabel1.Text = "Yes";
                    break;
                   


                case 4:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You continue your walk to town";
                    outputLabel.Text += "\n Where do you want to go?";

                    optionLabel1.Text = "Pub";
                    optionLabel2.Text = "Shop";
                    break;

                case 5:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to enter the pub";
                    outputLabel.Text += "\n You are greeted by loud music and the smell of grease";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Yuck";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.Emilynormal;
                    outputLabel.Text = "Emily greets you and tries to start a conversation with you!";
                    outputLabel.Text += "\n How do you respond?";

                    optionLabel1.Text = "Positively";
                    optionLabel2.Text = "Negatively";
                    break;

                case 6:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyhappy;
                    outputLabel.Text = "Emily gives a drink she made herself for free!";
                    outputLabel.Text += "\n She says she could use your opinion on it";

                    outputLabel.Text += "\n Do you try it?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 60:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "The drink tastes horrible!";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "\n You faint due to the awfulness";

                    outputLabel.Text += "\n Do you want to retry";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 7:
                    background.Image = Properties.Resources.Pub;
                    outputLabel.Text = "The drink tastes amazing!";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "\n You down the entire thing in less than 5 seconds";
                    outputLabel.Text += "\n You thank Emily profously and tell her that it was great";
                    portraitBox.Image = Properties.Resources.emilyhappy;

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Emily gives you 10 dollars for trying the drink";
                    money = 15;
                    //sound

                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "You leave the pub";
                    outputLabel.Text = "\n Where do you want to go now?";

                    optionLabel1.Text = "Shop";
                    optionLabel2.Text = "Home";
                    break;

                case 8:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "Emily is shocked by your rudeness";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n That shockness quickly turns to anger";
                    portraitBox.Image = Properties.Resources.emilyanger;
                    outputLabel.Text += "\n Emily then kicks you out of the pub";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Would you like to retry?";

                    optionLabel1.Text = "Retry?";
                    optionLabel2.Text = "No";
                    break;
                    
                //Enter the shop
                case 9:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You enter Pierre's shop";
                    outputLabel.Text += "\nYou see Pierre manning the cashier and Shane shopping in an aisle";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Who do you want to talk to first?";

                    optionLabel1.Text = "Shane";
                    optionLabel2.Text = "Pierre";
                    break;

                //Talk to Shane
                case 10:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane greets you lacklusterdly";
                    outputLabel.Text += "\n Shane seems to be distracted";

                    outputLabel.Text = "Do you want to pursue a conversation with him?";

                    optionLabel1.Text = "Pursue conversation";
                    optionLabel2.Text = "Leave him be";
                    break;

                case 61:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shaneannoyed;
                    outputLabel.Text = "Shane is clearly annoyed with your attemps to talk to him";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n He tells you to leave him alone";
                    outputLabel.Text += "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 11:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane tells you that he recently lost a bracelet that his niece,Jasmine, gave him";
                    outputLabel.Text += "\n He asks you whether you've seen it on the ground or not?";
                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel1.Text = "Continue?";
                    break;

                case 66:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Give bracelet?";

                    optionLabel1.Text = "Give Shane the bracelet";
                    optionLabel2.Text = "Don't give him the bracelet";
                    break;

                case 12:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanehappy;
                    outputLabel.Text = "Shane thanks you profously";
                    outputLabel.Text += "\n While thanking you he gives you 5 bucks";

                    money += 5;
                    break;

                case 14:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "You tell Shane that you don't have the bracelet";
                    outputLabel.Text += "\n He asks you to keep an eye out for it.";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 13:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide that you'd rather keep your life then attempt to poke the beast";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n Coninue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                //Talk to Pierre
                case 15:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to talk to Pierre and see what's on sale";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Pierre greets you enthusiastically!";
                    outputLabel.Text += "\nHe asks you what you would like to get";

                    optionLabel1.Text = "Flowers";
                    optionLabel2.Text = "Strawberry seeds";
                    break;

                //Buy flowers
                case 16:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "You would like some flowers";
                    outputLabel.Text += "\nPierre tells you that they cost 15 dollars";

                    optionLabel1.Text = "Give money";
                    optionLabel2.Text = "Don't give money";
                    break;

                case 17:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got flowers !!";
                    //add text in middle of screen
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel2.Text = "Home";
                    break;

                case 18:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 19:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap and gave you the flowers for free!";
                    Refresh();
                    Thread.Sleep(3000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";
                    //image appears
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 90:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 20:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Buy Strawberry seeds
                case 21:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You tell Pierre that you would like some Strawberry seeds";
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text += "\nPierre says that the Strawberry seeds cost 10 dollars";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you have enough?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 71:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Do you want to give the money to Pierre?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 22:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got strawberry seeds!";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel1.Text = "Home";
                    break;

                case 23:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 24:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap!";
                    Refresh();
                    Thread.Sleep(2000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";
                    
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 67:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 25:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Ocean
                case 26:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "While heading South you think you see something in the river!";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "Do you want to try to pick it up?";

                    optionLabel1.Text = "Try to get it";
                    optionLabel2.Text = "Don't risk it";
                    break;

                case 27:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You fall into the river and drown";
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 80:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You carefull reach into the river and grab the object you saw";
                    outputLabel.Text += "\n You find a diamond!";
                    diamond = 1;
                    portraitBox.Image = Properties.Resources.Diamond;

                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "You continue your walk down to the beach";
                    Refresh();
                    Thread.Sleep(800);

                    optionLabel1.Text = "Continue";
                    break;

                case 28:
                    
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "After a few more minutes, you finally make it to the beach!";
                    outputLabel.Text += "\n What do you want to do now?";

                    optionLabel1.Text = "Fish";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Talk to Haley";
                    break;

                case 29:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You walk down to the boardwalk to do some fishing!";
                    outputLabel.Text += "\n You sit down on a bench and throw your fishing rod in the water";

                    Refresh();
                    Thread.Sleep(3500);

                    outputLabel.Text = "You continue to wait for a fish to appear.";

                    optionLabel1.Text = "Continue";
                    break;

                case 30:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);

                    outputLabel.Text = "You wait for 5 minutes before starting to get bored";
                    outputLabel.Text += "\n Do you decide to wait more or leave?";

                    optionLabel1.Text = "Wait a bit longer";
                    optionLabel2.Text = "Leave the bored walk";
                    break;

                case 31:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to wait longer";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "You feel a tug on your fishing rod!";

                    outputLabel.Text = "\nDo you want to pull?";

                    optionLabel1.Text = "Pull";
                    optionLabel2.Text = "Don't pull";
                    break;

                case 32:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.Crimsonfish;
                    outputLabel.Text = "You find the Legendary Crimson!!";
                    Refresh();
                    Thread.Sleep(800);

                    outputLabel.Text = "Feeling satisfied with your catch, you decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 33:
                    background.Image = Properties.Resources.fishing;
                    outputLabel.Text = "You find seaweed";
                    portraitBox.Image = Properties.Resources.Seaweed;
                    Refresh();
                    Thread.Sleep(850);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "Yay . . .";

                    outputLabel.Text += "\nWould you like to try to catch something else?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "Stop fishing";
                    break;

                case 34:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decided to stop fishing";
                    outputLabel.Text += "\nWhat do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 35:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You get impatient and decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Haley
                case 36:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleynormal;
                    outputLabel.Text = "You greet Haley enthusiastically and ask her what she's doing";
                    Refresh();
                    Thread.Sleep(800);
                    outputLabel.Text += "\n She says that she's looking for a gem to take a photo of for the museum";

                    outputLabel.Text += "Do you give her the diamond?";

                    optionLabel1.Text = "Give her the diamond";
                    optionLabel2.Text = "Don't give her the diamond";
                    break;

                case 37:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyhappy;
                    outputLabel.Text = "Haley gasps, excitedly she asks if she can take a picture of the diamond";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\nDo you let her take a photo of the diamond?";

                    optionLabel1.Text = "Let her take a photo";
                    optionLabel2.Text = "Don't let her take a photo";
                    break;

                case 38:
                    background.Image = Properties.Resources.ocean;
                    outputLabel.Text = "Haley thanks you before taking multiple photos of the diamond";

                    Refresh();
                    Thread.Sleep(5000);

                    portraitBox.Image = Properties.Resources.haleyeyesclosed;
                    outputLabel.Text = "Haley gives you the diamond back before heading out, thanking you once again";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n What do you decide to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 39:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyangry;
                    outputLabel.Text = "Haley huffs, obviously annoyed that you're taking up her time";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text += "\n She tells you that she needs to continue finding a gem and asks you to leave her alone";

                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "What do you want to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Seagulls
                case 40:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to feed the seagulls!";
                    outputLabel.Text += "\n You rip small pieces of bread that you magically had in your pocket and throw them at the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "You continue to feed the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "Do you want to chase the seagulls?";

                    optionLabel1.Text = "Chase the seagulls >:]";
                    optionLabel2.Text = "Leave the seagulls be";
                    break;

                case 41:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to chase the seagulls";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "You are having the time of your life when suddenly the seagulls all turn towards you";
                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "All the seagulls all start chasing you now";
                    outputLabel.Text += "You fall into a fetal position as they all continue their revenge";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Do you want to try again?";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 42:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Good choice!";
                    outputLabel.Text += "You decide that you value your life and would rather not anger seagulls";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You decide to leave the seagulls in peace";
                    outputLabel.Text += "What do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Go fishing";
                    optionLabel3.Text = "Go home";
                    break;

                case 99:
                    background.Image = Properties.Resources.farm;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Thank you for playing!";

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();

                    break;
                default:
                    break;


            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //all right options
            //town
            if (page == 2)
            {
                page = 4;
            }

            //shop
            else if (page == 4)
            {
                page = 9;
            }

            //Pierre
            else if (page == 9)
            {
                page = 15;
            }
            else if (page == 8)
            {
                page = 99;
            }
            //choose flowers
            else if (page == 15)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            //strawberry seeds
            else if (page == 16)
            {
                if (money > 15)
                {
                    page = 70;
                }
                else
                {
                    page = 18;
                }
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                randomValue = randGen.Next(1, 101);
                if (randomValue < 50)
                {
                    page = 99;
                }
                else
                {
                    page = 20;
                }
            }
            //shane
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 66)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 15;
            }
            //pub
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 67;
            }
            else if (page == 67)
            {
                page = 99;
            }
            //beach
            else if (page == 1)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 28;
            }
            //feed seagulls
            else if (page == 28)
            {
                page = 40;
            }
            else if (page == 40)
            {
                page = 42;
            }
            //fish
            else if (page == 42)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 35;
            }
            else if (page == 35)
            {
                page = 40;
            }
            else if (page == 31)
            {
                page = 30;
            }
            else if (page == 33)
            {
                page = 34;
            }
            else if (page == 34)
            {
                page = 40;
            }
            else if (page == 32)
            {
                page = 40;
            }
            //Haley
            else if (page == 36)
            {
                page = 39;
            }
            else if (page == 37)
            {
                page = 39;
            }
            else if (page == 39)
            {
                page = 40;
            }
            else if (page == 38)
            {
                page = 40;
            }
            else if (page == 41)
            {
                page = 99;
            }
            else if (page == 60)
            {
                page = 99;
            }
            else if (page == 67)
            {
                page = 99;
            }
            else if (page == 90)
            {
                page = 99;
            }
            else if (page ==99)
            {
                page = 1;
            }


            switch (page)
            {

                case 2:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;

                    outputLabel.Text = "While walking to town, you see something in the dirt";

                    outputLabel.Text += "\n Do you want to pick it up?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 3:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You found a bracelet!";
                    //sound

                    bracelet = 1;

                    Thread.Sleep(800);

                    outputLabel.Text += "\n Continue?";

                    optionLabel1.Text = "Yes";
                    break;



                case 4:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You continue your walk to town";
                    outputLabel.Text += "\n Where do you want to go?";

                    optionLabel1.Text = "Pub";
                    optionLabel2.Text = "Shop";
                    break;

                case 5:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to enter the pub";
                    outputLabel.Text += "\n You are greeted by loud music and the smell of grease";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Yuck";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.Emilynormal;
                    outputLabel.Text = "Emily greets you and tries to start a conversation with you!";
                    outputLabel.Text += "\n How do you respond?";

                    optionLabel1.Text = "Positively";
                    optionLabel2.Text = "Negatively";
                    break;

                case 6:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyhappy;
                    outputLabel.Text = "Emily gives a drink she made herself for free!";
                    outputLabel.Text += "\n She says she could use your opinion on it";

                    outputLabel.Text += "\n Do you try it?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 60:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "The drink tastes horrible!";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "\n You faint due to the awfulness";

                    outputLabel.Text += "\n Do you want to retry";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 7:
                    background.Image = Properties.Resources.Pub;
                    outputLabel.Text = "The drink tastes amazing!";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "\n You down the entire thing in less than 5 seconds";
                    outputLabel.Text += "\n You thank Emily profously and tell her that it was great";
                    portraitBox.Image = Properties.Resources.emilyhappy;

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Emily gives you 10 dollars for trying the drink";
                    money = 15;
                    //sound

                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "You leave the pub";
                    outputLabel.Text = "\n Where do you want to go now?";

                    optionLabel1.Text = "Shop";
                    optionLabel2.Text = "Home";
                    break;

                case 8:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "Emily is shocked by your rudeness";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n That shockness quickly turns to anger";
                    portraitBox.Image = Properties.Resources.emilyanger;
                    outputLabel.Text += "\n Emily then kicks you out of the pub";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Would you like to retry?";

                    optionLabel1.Text = "Retry?";
                    optionLabel2.Text = "No";
                    break;

                //Enter the shop
                case 9:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You enter Pierre's shop";
                    outputLabel.Text += "\nYou see Pierre manning the cashier and Shane shopping in an aisle";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Who do you want to talk to first?";

                    optionLabel1.Text = "Shane";
                    optionLabel2.Text = "Pierre";
                    break;

                //Talk to Shane
                case 10:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane greets you lacklusterdly";
                    outputLabel.Text += "\n Shane seems to be distracted";

                    outputLabel.Text = "Do you want to pursue a conversation with him?";

                    optionLabel1.Text = "Pursue conversation";
                    optionLabel2.Text = "Leave him be";
                    break;

                case 61:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shaneannoyed;
                    outputLabel.Text = "Shane is clearly annoyed with your attemps to talk to him";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n He tells you to leave him alone";
                    outputLabel.Text += "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 11:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane tells you that he recently lost a bracelet that his niece,Jasmine, gave him";
                    outputLabel.Text += "\n He asks you whether you've seen it on the ground or not?";
                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel1.Text = "Continue?";
                    break;

                case 66:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Give bracelet?";

                    optionLabel1.Text = "Give Shane the bracelet";
                    optionLabel2.Text = "Don't give him the bracelet";
                    break;

                case 12:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanehappy;
                    outputLabel.Text = "Shane thanks you profously";
                    outputLabel.Text += "\n While thanking you he gives you 5 bucks";

                    money += 5;
                    break;

                case 14:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "You tell Shane that you don't have the bracelet";
                    outputLabel.Text += "\n He asks you to keep an eye out for it.";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 13:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide that you'd rather keep your life then attempt to poke the beast";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n Coninue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                //Talk to Pierre
                case 15:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to talk to Pierre and see what's on sale";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Pierre greets you enthusiastically!";
                    outputLabel.Text += "\nHe asks you what you would like to get";

                    optionLabel1.Text = "Flowers";
                    optionLabel2.Text = "Strawberry seeds";
                    break;

                //Buy flowers
                case 16:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "You would like some flowers";
                    outputLabel.Text += "\nPierre tells you that they cost 15 dollars";

                    optionLabel1.Text = "Give money";
                    optionLabel2.Text = "Don't give money";
                    break;

                case 17:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got flowers !!";
                    //add text in middle of screen
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel2.Text = "Home";
                    break;

                case 18:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 19:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap and gave you the flowers for free!";
                    Refresh();
                    Thread.Sleep(3000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";
                    //image appears
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 90:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 20:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Buy Strawberry seeds
                case 21:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You tell Pierre that you would like some Strawberry seeds";
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text += "\nPierre says that the Strawberry seeds cost 10 dollars";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you have enough?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 71:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Do you want to give the money to Pierre?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 22:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got strawberry seeds!";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel1.Text = "Home";
                    break;

                case 23:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 24:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap!";
                    Refresh();
                    Thread.Sleep(2000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";

                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 67:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 25:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Ocean
                case 26:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "While heading South you think you see something in the river!";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "Do you want to try to pick it up?";

                    optionLabel1.Text = "Try to get it";
                    optionLabel2.Text = "Don't risk it";
                    break;

                case 27:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You fall into the river and drown";
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 80:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You carefull reach into the river and grab the object you saw";
                    outputLabel.Text += "\n You find a diamond!";
                    diamond = 1;
                    portraitBox.Image = Properties.Resources.Diamond;

                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "You continue your walk down to the beach";
                    Refresh();
                    Thread.Sleep(800);

                    optionLabel1.Text = "Continue";
                    break;

                case 28:

                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "After a few more minutes, you finally make it to the beach!";
                    outputLabel.Text += "\n What do you want to do now?";

                    optionLabel1.Text = "Fish";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Talk to Haley";
                    break;

                case 29:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You walk down to the boardwalk to do some fishing!";
                    outputLabel.Text += "\n You sit down on a bench and throw your fishing rod in the water";

                    Refresh();
                    Thread.Sleep(3500);

                    outputLabel.Text = "You continue to wait for a fish to appear.";

                    optionLabel1.Text = "Continue";
                    break;

                case 30:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);

                    outputLabel.Text = "You wait for 5 minutes before starting to get bored";
                    outputLabel.Text += "\n Do you decide to wait more or leave?";

                    optionLabel1.Text = "Wait a bit longer";
                    optionLabel2.Text = "Leave the bored walk";
                    break;

                case 31:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to wait longer";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "You feel a tug on your fishing rod!";

                    outputLabel.Text = "\nDo you want to pull?";

                    optionLabel1.Text = "Pull";
                    optionLabel2.Text = "Don't pull";
                    break;

                case 32:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.Crimsonfish;
                    outputLabel.Text = "You find the Legendary Crimson!!";
                    Refresh();
                    Thread.Sleep(800);

                    outputLabel.Text = "Feeling satisfied with your catch, you decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 33:
                    background.Image = Properties.Resources.fishing;
                    outputLabel.Text = "You find seaweed";
                    portraitBox.Image = Properties.Resources.Seaweed;
                    Refresh();
                    Thread.Sleep(850);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "Yay . . .";

                    outputLabel.Text += "\nWould you like to try to catch something else?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "Stop fishing";
                    break;

                case 34:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decided to stop fishing";
                    outputLabel.Text += "\nWhat do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 35:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You get impatient and decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Haley
                case 36:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleynormal;
                    outputLabel.Text = "You greet Haley enthusiastically and ask her what she's doing";
                    Refresh();
                    Thread.Sleep(800);
                    outputLabel.Text += "\n She says that she's looking for a gem to take a photo of for the museum";

                    outputLabel.Text += "Do you give her the diamond?";

                    optionLabel1.Text = "Give her the diamond";
                    optionLabel2.Text = "Don't give her the diamond";
                    break;

                case 37:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyhappy;
                    outputLabel.Text = "Haley gasps, excitedly she asks if she can take a picture of the diamond";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\nDo you let her take a photo of the diamond?";

                    optionLabel1.Text = "Let her take a photo";
                    optionLabel2.Text = "Don't let her take a photo";
                    break;

                case 38:
                    background.Image = Properties.Resources.ocean;
                    outputLabel.Text = "Haley thanks you before taking multiple photos of the diamond";

                    Refresh();
                    Thread.Sleep(5000);

                    portraitBox.Image = Properties.Resources.haleyeyesclosed;
                    outputLabel.Text = "Haley gives you the diamond back before heading out, thanking you once again";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n What do you decide to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 39:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyangry;
                    outputLabel.Text = "Haley huffs, obviously annoyed that you're taking up her time";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text += "\n She tells you that she needs to continue finding a gem and asks you to leave her alone";

                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "What do you want to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Seagulls
                case 40:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to feed the seagulls!";
                    outputLabel.Text += "\n You rip small pieces of bread that you magically had in your pocket and throw them at the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "You continue to feed the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "Do you want to chase the seagulls?";

                    optionLabel1.Text = "Chase the seagulls >:]";
                    optionLabel2.Text = "Leave the seagulls be";
                    break;

                case 41:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to chase the seagulls";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "You are having the time of your life when suddenly the seagulls all turn towards you";
                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "All the seagulls all start chasing you now";
                    outputLabel.Text += "You fall into a fetal position as they all continue their revenge";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Do you want to try again?";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 42:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Good choice!";
                    outputLabel.Text += "You decide that you value your life and would rather not anger seagulls";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You decide to leave the seagulls in peace";
                    outputLabel.Text += "What do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Go fishing";
                    optionLabel3.Text = "Go home";
                    break;

                case 99:
                    background.Image = Properties.Resources.farm;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Thank you for playing!";

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();

                    break;
                default:
                    break;


            }
        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            //all middle options
            if (page == 28)
            {
                page = 36;
            }
            else if (page == 39)
            {
                page = 99;
            }
            else if (page == 39)
            {
                page = 99;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 35)
            {
                page = 99;
            }
            else if (page == 38)
            {
                page = 99;
            }
            else if (page == 42)
            {
                page = 99;
            }
            else if (page == 61)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 80)
            {
                page = 99;
            }


            switch (page)
            {

                case 2:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;

                    outputLabel.Text = "While walking to town, you see something in the dirt";

                    outputLabel.Text += "\n Do you want to pick it up?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 3:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You found a bracelet!";
                    //sound

                    bracelet = 1;

                    Thread.Sleep(800);

                    outputLabel.Text += "\n Continue?";

                    optionLabel1.Text = "Yes";
                    break;



                case 4:
                    background.Image = Properties.Resources.Town;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You continue your walk to town";
                    outputLabel.Text += "\n Where do you want to go?";

                    optionLabel1.Text = "Pub";
                    optionLabel2.Text = "Shop";
                    break;

                case 5:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to enter the pub";
                    outputLabel.Text += "\n You are greeted by loud music and the smell of grease";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Yuck";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.Emilynormal;
                    outputLabel.Text = "Emily greets you and tries to start a conversation with you!";
                    outputLabel.Text += "\n How do you respond?";

                    optionLabel1.Text = "Positively";
                    optionLabel2.Text = "Negatively";
                    break;

                case 6:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyhappy;
                    outputLabel.Text = "Emily gives a drink she made herself for free!";
                    outputLabel.Text += "\n She says she could use your opinion on it";

                    outputLabel.Text += "\n Do you try it?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 60:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "The drink tastes horrible!";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "\n You faint due to the awfulness";

                    outputLabel.Text += "\n Do you want to retry";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 7:
                    background.Image = Properties.Resources.Pub;
                    outputLabel.Text = "The drink tastes amazing!";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "\n You down the entire thing in less than 5 seconds";
                    outputLabel.Text += "\n You thank Emily profously and tell her that it was great";
                    portraitBox.Image = Properties.Resources.emilyhappy;

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Emily gives you 10 dollars for trying the drink";
                    money = 15;
                    //sound

                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "You leave the pub";
                    outputLabel.Text = "\n Where do you want to go now?";

                    optionLabel1.Text = "Shop";
                    optionLabel2.Text = "Home";
                    break;

                case 8:
                    background.Image = Properties.Resources.Pub;
                    portraitBox.Image = Properties.Resources.emilyshock;
                    outputLabel.Text = "Emily is shocked by your rudeness";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n That shockness quickly turns to anger";
                    portraitBox.Image = Properties.Resources.emilyanger;
                    outputLabel.Text += "\n Emily then kicks you out of the pub";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Would you like to retry?";

                    optionLabel1.Text = "Retry?";
                    optionLabel2.Text = "No";
                    break;

                //Enter the shop
                case 9:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You enter Pierre's shop";
                    outputLabel.Text += "\nYou see Pierre manning the cashier and Shane shopping in an aisle";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Who do you want to talk to first?";

                    optionLabel1.Text = "Shane";
                    optionLabel2.Text = "Pierre";
                    break;

                //Talk to Shane
                case 10:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane greets you lacklusterdly";
                    outputLabel.Text += "\n Shane seems to be distracted";

                    outputLabel.Text = "Do you want to pursue a conversation with him?";

                    optionLabel1.Text = "Pursue conversation";
                    optionLabel2.Text = "Leave him be";
                    break;

                case 61:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shaneannoyed;
                    outputLabel.Text = "Shane is clearly annoyed with your attemps to talk to him";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n He tells you to leave him alone";
                    outputLabel.Text += "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 11:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Shane tells you that he recently lost a bracelet that his niece,Jasmine, gave him";
                    outputLabel.Text += "\n He asks you whether you've seen it on the ground or not?";
                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel1.Text = "Continue?";
                    break;

                case 66:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "Give bracelet?";

                    optionLabel1.Text = "Give Shane the bracelet";
                    optionLabel2.Text = "Don't give him the bracelet";
                    break;

                case 12:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanehappy;
                    outputLabel.Text = "Shane thanks you profously";
                    outputLabel.Text += "\n While thanking you he gives you 5 bucks";

                    money += 5;
                    break;

                case 14:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.shanenormal;
                    outputLabel.Text = "You tell Shane that you don't have the bracelet";
                    outputLabel.Text += "\n He asks you to keep an eye out for it.";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "Continue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                case 13:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide that you'd rather keep your life then attempt to poke the beast";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text = "\n Coninue shopping?";

                    optionLabel1.Text = "Continue";
                    break;

                //Talk to Pierre
                case 15:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to talk to Pierre and see what's on sale";
                    Refresh();
                    Thread.Sleep(2000);

                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Pierre greets you enthusiastically!";
                    outputLabel.Text += "\nHe asks you what you would like to get";

                    optionLabel1.Text = "Flowers";
                    optionLabel2.Text = "Strawberry seeds";
                    break;

                //Buy flowers
                case 16:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "You would like some flowers";
                    outputLabel.Text += "\nPierre tells you that they cost 15 dollars";

                    optionLabel1.Text = "Give money";
                    optionLabel2.Text = "Don't give money";
                    break;

                case 17:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got flowers !!";
                    //add text in middle of screen
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel2.Text = "Home";
                    break;

                case 18:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 19:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap and gave you the flowers for free!";
                    Refresh();
                    Thread.Sleep(3000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";
                    //image appears
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 90:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 20:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Buy Strawberry seeds
                case 21:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You tell Pierre that you would like some Strawberry seeds";
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text += "\nPierre says that the Strawberry seeds cost 10 dollars";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Do you have enough?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 71:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrehappy;
                    outputLabel.Text = "Do you want to give the money to Pierre?";

                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;

                case 22:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "You got strawberry seeds!";
                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where would you like to go now?";

                    optionLabel1.Text = "Beach";
                    optionLabel1.Text = "Home";
                    break;

                case 23:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierrenormal;
                    outputLabel.Text = "Do you try to use your amazing persuation skills to try to convice Pierre to give you the flowers for free? ";

                    optionLabel1.Text = "Use professional convicing skills";
                    optionLabel2.Text = "Don't use professional convincing skills";
                    break;

                case 24:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Persuasion was highly effective!";
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "\n Pierre fell under your trap!";
                    Refresh();
                    Thread.Sleep(2000);
                    portraitBox.Image = Properties.Resources.pierrehappy;

                    outputLabel.Text = "You got flowers for free!";

                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "Where do want to go now?";

                    optionLabel1.Text = "Town";
                    optionLabel2.Text = "Beach";
                    break;

                case 67:
                    background.Image = Properties.Resources.shop;
                    portraitBox.Image = Properties.Resources.pierreshock;
                    outputLabel.Text = "Pierre was not effected by your top notch skills!";
                    outputLabel.Text += "\n Pierre became increasingly offended by the fact you would try that on him.";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Pierre kicks you out of his shop";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 25:
                    background.Image = Properties.Resources.shop;
                    outputLabel.Text = "Pierre tells you to leave as his shop is closing";
                    portraitBox.Image = Properties.Resources.pierreannoyed;
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Do you want to retry?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                //Ocean
                case 26:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "While heading South you think you see something in the river!";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "Do you want to try to pick it up?";

                    optionLabel1.Text = "Try to get it";
                    optionLabel2.Text = "Don't risk it";
                    break;

                case 27:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You fall into the river and drown";
                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "Would you like to try again?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "No";
                    break;

                case 80:
                    background.Image = Properties.Resources.bridge;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You carefull reach into the river and grab the object you saw";
                    outputLabel.Text += "\n You find a diamond!";
                    diamond = 1;
                    portraitBox.Image = Properties.Resources.Diamond;

                    Refresh();
                    Thread.Sleep(1500);

                    outputLabel.Text = "You continue your walk down to the beach";
                    Refresh();
                    Thread.Sleep(800);

                    optionLabel1.Text = "Continue";
                    break;

                case 28:

                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "After a few more minutes, you finally make it to the beach!";
                    outputLabel.Text += "\n What do you want to do now?";

                    optionLabel1.Text = "Fish";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Talk to Haley";
                    break;

                case 29:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You walk down to the boardwalk to do some fishing!";
                    outputLabel.Text += "\n You sit down on a bench and throw your fishing rod in the water";

                    Refresh();
                    Thread.Sleep(3500);

                    outputLabel.Text = "You continue to wait for a fish to appear.";

                    optionLabel1.Text = "Continue";
                    break;

                case 30:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);

                    outputLabel.Text = "You wait for 5 minutes before starting to get bored";
                    outputLabel.Text += "\n Do you decide to wait more or leave?";

                    optionLabel1.Text = "Wait a bit longer";
                    optionLabel2.Text = "Leave the bored walk";
                    break;

                case 31:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to wait longer";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "You feel a tug on your fishing rod!";

                    outputLabel.Text = "\nDo you want to pull?";

                    optionLabel1.Text = "Pull";
                    optionLabel2.Text = "Don't pull";
                    break;

                case 32:
                    background.Image = Properties.Resources.fishing;
                    portraitBox.Image = Properties.Resources.Crimsonfish;
                    outputLabel.Text = "You find the Legendary Crimson!!";
                    Refresh();
                    Thread.Sleep(800);

                    outputLabel.Text = "Feeling satisfied with your catch, you decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 33:
                    background.Image = Properties.Resources.fishing;
                    outputLabel.Text = "You find seaweed";
                    portraitBox.Image = Properties.Resources.Seaweed;
                    Refresh();
                    Thread.Sleep(850);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ".";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = ". . .";
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "Yay . . .";

                    outputLabel.Text += "\nWould you like to try to catch something else?";

                    optionLabel1.Text = "Retry";
                    optionLabel2.Text = "Stop fishing";
                    break;

                case 34:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decided to stop fishing";
                    outputLabel.Text += "\nWhat do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 35:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You get impatient and decide to leave the board walk";
                    outputLabel.Text += "\nWhere do you want to go now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Haley
                case 36:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleynormal;
                    outputLabel.Text = "You greet Haley enthusiastically and ask her what she's doing";
                    Refresh();
                    Thread.Sleep(800);
                    outputLabel.Text += "\n She says that she's looking for a gem to take a photo of for the museum";

                    outputLabel.Text += "Do you give her the diamond?";

                    optionLabel1.Text = "Give her the diamond";
                    optionLabel2.Text = "Don't give her the diamond";
                    break;

                case 37:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyhappy;
                    outputLabel.Text = "Haley gasps, excitedly she asks if she can take a picture of the diamond";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\nDo you let her take a photo of the diamond?";

                    optionLabel1.Text = "Let her take a photo";
                    optionLabel2.Text = "Don't let her take a photo";
                    break;

                case 38:
                    background.Image = Properties.Resources.ocean;
                    outputLabel.Text = "Haley thanks you before taking multiple photos of the diamond";

                    Refresh();
                    Thread.Sleep(5000);

                    portraitBox.Image = Properties.Resources.haleyeyesclosed;
                    outputLabel.Text = "Haley gives you the diamond back before heading out, thanking you once again";
                    Refresh();
                    Thread.Sleep(4000);

                    outputLabel.Text += "\n What do you decide to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                case 39:
                    background.Image = Properties.Resources.ocean;
                    portraitBox.Image = Properties.Resources.haleyangry;
                    outputLabel.Text = "Haley huffs, obviously annoyed that you're taking up her time";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text += "\n She tells you that she needs to continue finding a gem and asks you to leave her alone";

                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "What do you want to do now?";

                    optionLabel1.Text = "Go fishing";
                    optionLabel2.Text = "Feed the seagulls";
                    optionLabel3.Text = "Go home";
                    break;

                //Seagulls
                case 40:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to feed the seagulls!";
                    outputLabel.Text += "\n You rip small pieces of bread that you magically had in your pocket and throw them at the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "You continue to feed the seagulls";
                    Refresh();
                    Thread.Sleep(5000);

                    outputLabel.Text = "Do you want to chase the seagulls?";

                    optionLabel1.Text = "Chase the seagulls >:]";
                    optionLabel2.Text = "Leave the seagulls be";
                    break;

                case 41:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "You decide to chase the seagulls";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += "You are having the time of your life when suddenly the seagulls all turn towards you";
                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "All the seagulls all start chasing you now";
                    outputLabel.Text += "You fall into a fetal position as they all continue their revenge";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "Do you want to try again?";

                    optionLabel1.Text = "Try again";
                    optionLabel2.Text = "No";
                    break;

                case 42:
                    background.Image = Properties.Resources.seagulls;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Good choice!";
                    outputLabel.Text += "You decide that you value your life and would rather not anger seagulls";

                    Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You decide to leave the seagulls in peace";
                    outputLabel.Text += "What do you want to do now?";

                    optionLabel1.Text = "Talk to Haley";
                    optionLabel2.Text = "Go fishing";
                    optionLabel3.Text = "Go home";
                    break;

                case 99:
                    background.Image = Properties.Resources.farm;
                    portraitBox.Image = Properties.Resources.brown;
                    outputLabel.Text = "Thank you for playing!";

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();

                    break;
                default:
                    break;

            }
        }
    }
}


