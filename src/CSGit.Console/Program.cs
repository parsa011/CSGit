using CSGit.App.TUI;

var terminal = new Terminal();

terminal.Init();

var persons = new List<Person>(){
    new Person("parsa", 12),
    new Person("Hossein", 12),
    new Person("Ali", 13)
};

var list = new ListView(persons.Select(a => a.name).ToList(), 2, 20);
list.Render();

ConsoleKeyInfo key;
do {
	key = Console.ReadKey(true);
	if (key.Key == ConsoleKey.UpArrow)
		list.Prev();
	else if (key.Key == ConsoleKey.DownArrow)
		list.Next();
	else if (key.Key == ConsoleKey.Enter)
		Console.WriteLine(list.Current());
} while (key.KeyChar != 'q');

terminal.Close();
