using EsercizioGit;

Logic logic = new Logic();

logic.AddContact("Giulia");
logic.AddContact("Marta");
logic.AddContact("Mario");

bool isOn = true;

Console.WriteLine("Welcome to your contact app. Here you can add, view, delete and search your contacts");

do
{
    string input = Console.ReadLine();
    string[] words = input.Split(' ');

    switch (words[0])
    {
        case "add":
            logic.AddContact(words[1]);
            Console.WriteLine("added " + words[1]);
            break;

        case "del":
            if (logic.RemoveContact(words[1]))
                Console.WriteLine(words[1] + " Removed");
            else
                Console.WriteLine("User not found");
            break;

        case "view":
            DisplayContacts();
            break;

        default:
            Console.WriteLine("Command not found");
            break;

    }

}
while (isOn);



void DisplayContacts()
{
    foreach (var contact in logic.GetContacts())
    {
        Console.WriteLine(contact.Name);
    }
}
