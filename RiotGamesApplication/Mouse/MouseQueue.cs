using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RiotGamesApplication.Mouse
{
    class MouseQueue
    {
        private List<MouseMove> MouseMoves = new List<MouseMove>();

        public MouseQueue(params MouseMove[] mousemovements)
        {
            foreach(MouseMove m in mousemovements)
            {
                MouseMoves.Add(m);
            }

            Thread thread = new Thread(run);
            thread.Start();
        }

        public void run()
        {
            foreach(MouseMove mm in MouseMoves)
            {
                while (mm.running())
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
