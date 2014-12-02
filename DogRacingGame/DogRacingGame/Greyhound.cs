using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DogRacingGame
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        public string Name;

        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form
            // Return true if I won the race
           // if (MyPictureBox != null)
           // {
                Location = Randomizer.Next(1, 5);
                MyPictureBox.Left = MyPictureBox.Left + Location;
                //return MyPictureBox.Left == RacetrackLength - MyPictureBox.Width;
                return (MyPictureBox.Right >= RacetrackLength);
           // }
            //return false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
