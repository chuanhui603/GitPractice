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



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    public enum Gesture
    {
        Sciccors,Paper,Rock
    }

    public enum GameOutCome
    {
        Win,Lose,Draw
    }

    public class paperScissorRockGame
    {
        public static GameOutCome GameOutCome(Gesture player, Gesture other)
        {

        }

        public static Gesture GetGesture()
        {

        }
    }
}
