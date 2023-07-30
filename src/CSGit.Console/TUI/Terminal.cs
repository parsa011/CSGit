using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGit.App.TUI
{
    public class Terminal
    {
        private int _height;
        private int _width;
        public Terminal()
        {
            _height = Console.LargestWindowHeight;
            _width = Console.LargestWindowWidth;
            Console.SetWindowSize(_width, _height);
            Console.SetBufferSize(_width, _height);
            Console.SetWindowPosition(0, 0);
        }

		public void Init()
		{
			Console.Clear();
		}

		public void Close()
		{
			Console.Clear();
		}
    }
}
