using System.Xml.Linq;

class ContactManager
{
    private List<Contact> contactList;
    public ContactManager()
    {
        contactList = new List<Contact>();
    }
    //method to add names to the list
    public void Add(string name)
    {
        contactList.Add(new Contact{ Name = name });
    }
    //method to display the names from the list
    public List<Contact> GetContacts()
    {
        return contactList.ToList();
    }
    //method to check if the name exists
    public bool ListItemExists(string name)
    {
        return contactList.Any(c=>c.Name.Equals(name));
    }
    //method to edit the name in the list
    public void EditContact(string oldName, string newName)
    {
        var contactToEdit = 
                contactList.FirstOrDefault(c => c.Name.Equals(oldName));
        contactToEdit.Name = newName;
    }
    //method to remove name from the list
    public bool RemoveContact(string name)
    {
        var contactToRemove =
        contactList.FirstOrDefault(c => c.Name.Equals(name));
        contactList.Remove(contactToRemove);
        return true;
    }
}