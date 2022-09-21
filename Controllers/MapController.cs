using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_safe_of_the_Pilot_brothers.Controllers
{
    public static class MapController
    {

  
        public const int cellSize = 20;
        public const int indent = 100;
        public static int[,] map;
        public static CheckBox[,] CheckBoxes;

       
        public static void Init(Form current, int mapSize)
        {   
           
            ConfigureMapSize(current, mapSize);
            InitMap(mapSize);
            InitButtons(current, mapSize);
            RandomReversRowColumnInMap(9);
            UpdateMap();
        }
        public static void Refresh(Form current)
        {
            if (CheckBoxes != null)
            {
                for (int i = 0; i < CheckBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < CheckBoxes.GetLength(1); j++)
                    {
                        current.Controls.Remove(CheckBoxes[i, j]);
                    }
                }
            }
        }


        private static void ConfigureMapSize(Form current, int mapSize)
        {
            current.Width = (mapSize + 1) * cellSize + indent;
            current.Height = (mapSize + 2) * cellSize + indent;
        }


        private static void InitMap(int mapSize)

        {
            map = new int[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = 0;
                }
            }
        }
        private static void InitButtons(Form current, int mapSize)
        {
            CheckBoxes = new CheckBox[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(j * cellSize + indent, i * cellSize + indent);
                    checkBox.Size = new Size(cellSize, cellSize);
                    current.Controls.Add(checkBox);
                    checkBox.Click += new EventHandler(OnButtonPressed);
                    CheckBoxes[i, j] = checkBox;

                }
            }
        }

        private static void OnButtonPressed(object sender, EventArgs e)
        {
            CheckBox pressButton = sender as CheckBox;
            int i = FindClickCheckBox(pressButton).I;
            int j = FindClickCheckBox(pressButton).J;
            if (pressButton.Checked == true) map[i,j] = 1;
            else { map[i, j] = 0; }

            ReversRowColumnInMap(i, j);
            UpdateMap();
            CheckWin();


        }
        private static (int I, int J) FindClickCheckBox(CheckBox pressButton) 
        { 
            int I=0, J=0;
            for (int i = 0; i < CheckBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < CheckBoxes.GetLength(0); j++)
                {
                    if (pressButton == CheckBoxes[i, j])
                    {
                        I = i;
                        J = j;
                    }
                }
            }   
            return (I, J);
        }
        private static void ReversRowColumnInMap(int x, int y) 
        {

            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (x != i)
                {
                    if (map[i, y] == 0) { map[i, y] = 1; }
                    else { map[i, y] = 0; }
                }
            }
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (y != j)
                {
                    if (map[x, j] == 0) { map[x, j] = 1; }
                    else { map[x, j] = 0; }
                }
            }

        }
        private static void RandomReversRowColumnInMap(int count)
        {
            int r1,r2;

            for (int i = 0; i < count; i++)
            {
                r1 = new Random().Next(0, map.GetLength(0));
                r2 = new Random().Next(0, map.GetLength(0));
               
                ReversRowColumnInMap(r1, r2);
                if (map[r1, r2] == 0) map[r1,r2] = 1;
                else { map[r1, r2] = 0; }
            }
           
        }
            private static void UpdateMap() 
        {
            for (int i = 0; i < CheckBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < CheckBoxes.GetLength(1); j++)
                {
                        CheckBoxes[i, j].Checked = Convert.ToBoolean(map[i, j]);
                }
            }

        }
        private static void CheckWin()
        {
            bool win = true;
           
               for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] != map[0, 0]) win = false;
                    }
                }

           if(win) MessageBox.Show("Вы выйграли");

        }

    }
}
