using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ThrowDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FourDicesGame game = new FourDicesGame();
            bool isTwoSame = false;
            int sameNumber = 0;
            Dice[] dices = game.dices;
            //判別是否有相同數字
            while (!isTwoSame)
            {
                dices = game.Dices();
                (bool, int?) result = game.GetMinPairValue(dices);
                if (result.Item1 == true)
                {
                    sameNumber = (int)result.Item2;
                    isTwoSame = true;
                }
            }
            int totalNumber = game.ComputPoint(sameNumber, dices);
            txtDice1.Text = dices[0].Point.ToString();
            txtDice2.Text = dices[1].Point.ToString();
            txtDice3.Text = dices[2].Point.ToString();
            txtDice4.Text = dices[3].Point.ToString();
            lblsame.Text = sameNumber.ToString();
            lbltotal.Text = totalNumber.ToString();
        }

    }



    public interface IRandomSupplyer
    {
        int Next(int minValue, int maxValue);
    }

    public class Dice : IComparable
    {
        private int randomPoint;

        //每次new後建構函式會讓randomPoint隨機骰一個點數
        public Dice(IRandomSupplyer Supplyer = null)
        {
            //Supplyer = Supplyer==null ? new defaultRandom(): Supplyer;

            //如果沒有給其他物件，則預設介面實作defaultRandom
            Supplyer = Supplyer ?? new defaultRandom();
            randomPoint = Supplyer.Next(1, 7);
        }

        //給Point隨機值?
        public int Point => randomPoint;

        //實作Sort功能
        public int CompareTo(object obj)
        {
            Dice toCompared = (Dice)obj;
            if (this.Point > toCompared.Point)
                return 1;
            else if (this.Point == toCompared.Point)
                return 0;
            else return -1;
        }

    }

    //實作介面 讓介面繼承defaultRandom的值
    public class defaultRandom : IRandomSupplyer
    {
        Random random;
        public defaultRandom()
        {
            random = new Random(Guid.NewGuid().GetHashCode());
        }
        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

    }

    public class FourDicesGame  //四顆骰子遊戲
    {
        public Dice[] dices
        {
            get;set;
        }
        public Dice[] Dices()
        {
            int diceNumber = 4;
            Dice[] dices = new Dice[diceNumber];
            for (int i = 0; i < diceNumber; i++)
            {
                dices[i] = new Dice();
            }
            return dices;
        }

        public int ComputPoint(int sameNumber, Dice[] dices)
        {
            int totalNumber = 0;
            Array.ForEach(dices, i => totalNumber += i.Point);
            return totalNumber - sameNumber * 2;
        }


        public (bool, int?) GetMinPairValue(Dice[] dices)
        {
            Array.Sort(dices);
            int sameNumber;
            if (dices[0].Point == dices[1].Point)
                sameNumber = dices[0].Point;
            else if (dices[1].Point == dices[2].Point)
                sameNumber = dices[1].Point;
            else if (dices[2].Point == dices[3].Point)
                sameNumber = dices[2].Point;
            else
                return (false, null);
            return (true, sameNumber);
        }


    }
}