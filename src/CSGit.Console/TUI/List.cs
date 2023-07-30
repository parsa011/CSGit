using System;
using CSGit.Core;
using CSGit.Core.Helpers;

/*
 * |Parsa------------|
 * |Nima             |
 * |Ali              |
 */
namespace CSGit.App.TUI
{
    public class ListView
    {
        private List<string> _list;
        private int _index;
        private readonly int _max_width;
        private readonly string _ellipsis;

        public ListView(List<string> list, int index, int max_width)
        {
            _list = list;
            _index = index;
            _max_width = max_width;
            _ellipsis = "..";
        }

        public void Render()
        {
            int i = 1;
            foreach (var item in _list)
            {
                if (i++ == _index)
				{
                    Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Black;
				}
                string buf = "";
                if (item.Length > _max_width)
                    buf = string.Concat(item[..(item.Length - _ellipsis.Length - 2)], _ellipsis);
                else
                    buf = item;
                Console.Write(buf.PadRight(_max_width));
                Console.ResetColor();
                Console.Write("\n");
            }
        }

		public void Next()
		{
			if (_index <= _list.Count)
				_index++;
			Render();
		}

		public void Prev()
		{
			if (_index > 1)
				_index--;
			Render();
		}

		public string Current()
		{
			return _list[_index - 1];
		}
    }
}
