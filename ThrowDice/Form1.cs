using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace ThrowDice
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

        private void btn_Start_Click(object sender, EventArgs e)
        {
            CreatDice Creat = new CreatDice();
            ThrowDice Throw = new ThrowDice();
            Panel palDice = pal_Dice;                                                                     //骰子文字方塊出現區域(或者可以做成UserControl?)
            List<int> DiceNum = new List<int>();                                           //骰子的點數
            List<int> Sum = new List<int>();                                                    //骰子判斷會給出相同數字跟總數兩種結果
            Throw.LeastTwoSameDice(4, DiceNum, Sum);                         //骰子數量跟回傳結果
            Creat.CreateDicePanel(4, DiceNum, Sum, palDice);                //在panel創造骰子結果

        }
    }


    public class CreatDice   //設計骰子樣式跟排版
    {
        public void Clear(Panel palDice)  //清空Dicepanel
        {
            palDice.Controls.Clear();
        }

        public void CreateDicePanel(int DiceNum, List<int> DicePointer, List<int> SumResult, Panel palDice)
        {
            if (DicePointer.Count == DiceNum)
            {
                Clear(palDice);                                             //每次扔骰清空畫面

                //產生骰子
                int DiceLocalColumn = 100;                //初始X軸出現位置
                int DiceLocalRow = 50;                       //初始Y軸出現位置
                int DiceColumnLength = 120;         //骰子間距
                int DiceSizeWidth = 30;                   //骰子寬度
                int DiceSizeHeigth = 30;                //骰子高度
                int DiceFontSize = 16;                   //字體大小
                for (int i = 0; i < DiceNum; i++)
                {
                    string Dicenumber = DicePointer[i].ToString();
                    TextBox DiceBox = new TextBox();
                    DiceBox.Font = new Font("Calibri", DiceFontSize);
                    DiceBox.Location = new Point(DiceLocalColumn + DiceColumnLength * i, DiceLocalRow);
                    DiceBox.Size = new Size(DiceSizeWidth, DiceSizeHeigth);
                    DiceBox.Text = Dicenumber;
                    DiceBox.TextAlign = HorizontalAlignment.Center;
                    palDice.Controls.Add(DiceBox);
                }


                //產生結果
                int SumLocalColumn = 170;                //初始X軸出現位置
                int SumLocalRow = 120;                    //初始Y軸出現位置
                int SumColumnLength = 150;        //結果間距
                int SumSizeWidth = 150;                  //結果寬度
                int SumFontSize = 16;                    //字體大小
                for (int i = 0; i < SumResult.Count; i++)      //創造總和跟相同數字的label
                {
                    Label Sumlabel = new Label();
                    Sumlabel.Font = new Font("Calibri", SumFontSize);
                    Sumlabel.Location = new Point(SumLocalColumn + SumColumnLength * i, SumLocalRow);
                    Sumlabel.Width = SumSizeWidth;
                    Sumlabel.Text = i == 0 ? $"相同數字:{SumResult[i]}" : $"總和:{SumResult[i]}";
                    palDice.Controls.Add(Sumlabel);
                }
            }
            else
            {
                MessageBox.Show("骰子數量與號碼有誤");
            }

        }
    
    }
    public class ThrowDice  //判斷骰子規則
    {
        public void LeastTwoSameDice(int Dice, List<int> Dicenum, List<int> Sum)    //添加亂數號碼
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());  //Guid.NewGuid().GetHashCode()能短時間產生更亂的亂數
            int MaxDiceNumber = 6;                                                                                   //設定最大數字為6      //傳值給判斷函數判斷骰子是否有重複
            while (Sum.Count == 0)
            {
                for (int i = 0; i < Dice; i++)                                                                           //依輸入骰子數量添加List數字
                {
                    int RandomNum = random.Next(1, MaxDiceNumber + 1);         //亂數範圍在1~6之間            
                    Dicenum.Add(RandomNum);
                }
                Dicenum.Sort();
                FourDiceThrow(Dicenum, Sum);                                                                 //判斷骰子數量是否重複
                if(Sum.Count == 0)                                                                                          //沒有結果則清空骰子直到跳出迴圈
                {
                    Dicenum.Clear();
                }
            }
        }

        public void FourDiceThrow(List<int> Dicenum, List<int> Sum)               //4枚骰子的判斷方法
        {
            int SameNum = 0;             //相同的骰子號碼
            int totalNum = 0;
            try
            {     
                /*  4枚骰子的判斷方式  若有兩組相同數字則以最小的為主 沒有相同數字則直接丟catch*/
                if (Dicenum[0] == Dicenum[1])
                {
                    SameNum = Dicenum[0];
                    totalNum = Dicenum[2] + Dicenum[3];
                    Sum.Add(SameNum);
                    Sum.Add(totalNum);
                }
                else if (Dicenum[1] == Dicenum[2])
                {
                    SameNum = Dicenum[1];
                    totalNum = Dicenum[0] + Dicenum[3];
                    Sum.Add(SameNum);
                    Sum.Add(totalNum);
                }
                else if (Dicenum[2] == Dicenum[3])
                {
                    SameNum = Dicenum[2];
                    totalNum = Dicenum[1] + Dicenum[0];
                    Sum.Add(SameNum);
                    Sum.Add(totalNum);
                }
            }
            catch
            {
                
            }
        }
    }
}




