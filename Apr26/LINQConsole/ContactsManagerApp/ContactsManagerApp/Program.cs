
class Program
{
    static void Main()
    {
        ContactManager contactManager = new ContactManager();
        bool option = true;
        while (option)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Remove Contact");
            Console.WriteLine("Enter an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a name to add:");
                    string nameToAdd = Console.ReadLine();
                    contactManager.Add(nameToAdd);
                    Console.WriteLine($"{nameToAdd} added to list");
                    break;
                case "2":
                    Console.WriteLine("Contacts in the list are:");
                    var contact = contactManager.GetContacts();
                    if (contact.Any())
                    {
                        contact.ForEach(c => Console.WriteLine(c.Name));
                    }
                    else
                    {
                        Console.WriteLine("List is empty");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter a name to edit:");
                    string oldName = Console.ReadLine();

                    if (contactManager.ListItemExists(oldName))
                    {
                        Console.WriteLine("Enter the new name name to edit:");
                        string newName = Console.ReadLine();
                        contactManager.EditContact(oldName, newName);
                        Console.WriteLine($"{oldName} edited in the list");
                    }
                    else
                    {
                        Console.WriteLine($"{oldName} does not exist in the list");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter the name to remove from the list:");
                    string nameToRemove = Console.ReadLine();
                    if (contactManager.ListItemExists(nameToRemove))
                    {
                        contactManager.RemoveContact(nameToRemove);
                        Console.WriteLine($"{nameToRemove} removed from the list");
                    }
                    else
                    {
                        Console.WriteLine($"{nameToRemove} does not exist in the list");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}