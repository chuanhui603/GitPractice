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

            Gesture player = paperScissorRockGame.GetGesture();
            Gesture other = paperScissorRockGame.GetGesture();
            txtPlayer.Text = player.ToString();
            txtOther.Text = other.ToString();
            lbl_result.Text = paperScissorRockGame.GameOutCome(player, other).ToString();

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
            if (player == other)
                result = (GameOutCome)2;
            else if (player + 1 == other || player == (Gesture)2 && other == (Gesture)0)
                result = (GameOutCome)0;
            else if (player - 1 == other || player == (Gesture)0 && other == (Gesture)2)
                result = (GameOutCome)1;
            return result;
        }

        public static Gesture GetGesture()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            var result = random.Next(0, 3);
            return (Gesture)result;
        }
    }
}
