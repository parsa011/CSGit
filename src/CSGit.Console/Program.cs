using CSGit.App.TUI;
using CSGit.Commands;

var terminal = new Terminal();

var gitManager = new CSGitManager("C:\\Users\\parsa011\\Desktop\\csgit");

terminal.Init();

var log = gitManager.Branches.GetBranches(null);

var list = new ListView(log, 1, Console.BufferWidth);
list.Render();

ConsoleKeyInfo key;
do
{
    key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.UpArrow)
        list.Prev();
    else if (key.Key == ConsoleKey.DownArrow)
        list.Next();
    else if (key.Key == ConsoleKey.Enter)
        Console.WriteLine(list.Current());
} while (key.KeyChar != 'q');

terminal.Close();
