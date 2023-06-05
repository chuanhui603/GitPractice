using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapperScissorRock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            paperScissorRockGame game = new paperScissorRockGame();
            var player = game.GetGesture();
            txtPlayer.Text = 
        }
    }


    public enum Gesture
    {
        Sciccors, Paper, Rock

    }

    public enum GameOutCome
    {
        Win, Lose, Draw
    }

    public class paperScissorRockGame
    {
        public static GameOutCome GameOutCome(Gesture player, Gesture other)
        {
            var result = new GameOutCome();
            //Draw
            if (player == Gesture.Paper && other == Gesture.Paper)
            {
                result = (GameOutCome)2;
            }
            else if (player == Gesture.Rock && other == Gesture.Rock)
            {
                result = (GameOutCome)2;
            }
            else if (player == Gesture.Sciccors && other == Gesture.Sciccors)
            {
                result = (GameOutCome)2;
            }

            //Win
            else if (player == Gesture.Paper && other == Gesture.Rock)
            {
                result = (GameOutCome)0;
            }
            else if (player == Gesture.Rock && other == Gesture.Sciccors)
            {
                result = (GameOutCome)0;
            }
            else if (player == Gesture.Sciccors && other == Gesture.Paper)
            {
                result = (GameOutCome)0;
            }

            //Lose

            else if (player == Gesture.Paper && other == Gesture.Sciccors)
            {
                result = (GameOutCome)1;
            }
            else if (player == Gesture.Rock && other == Gesture.Paper)
            {
                result = (GameOutCome)1;
            }
            else if (player == Gesture.Sciccors && other == Gesture.Rock)
            {
                result = (GameOutCome)1;
            }
            return result;


        }

        public static Gesture GetGesture()
        {
            Random random = new Random();
            var result = random.Next(0, 4);
            return (Gesture)result;
        }
    }
}
