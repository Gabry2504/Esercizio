namespace EsercizioGit
{
    internal class Logic
    {
        List<Contact> contacts = new List<Contact>();


        public void AddContact(string name)
        {
            Contact contact = new Contact(name);
            contacts.Add(contact);
        }

        public bool RemoveContact(string name)
        {
            bool isFound = false
                ;
            foreach (Contact contact in contacts)
            {
                if (contact.Name == name)
                {
                    contacts.Remove(contact);
                    isFound = true;
                }
            }

            return isFound;
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}