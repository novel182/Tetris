using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tetris
{
    class GameController
    {
        TetrisBlock currentBlock;
        double speed;

        private Timer timer1;

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += Update;
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        public GameController()
        {
            speed = 1;
            InitTimer();
            currentBlock = 
        }

        public void HandleDownArrowKey()
        {
            speed = 4;
        }

        public void HandleLeftArrowKey()
        {
            //change currentBlock position by -1
        }

        public void HandleRightArrowKey()
        {
            //change currentBlock position by 1
        }

        public void HandleBlockStopped()
        {
            speed = 1;
        }

        private void Update(object sender, EventArgs e)
        {
            
        }
    }
}
