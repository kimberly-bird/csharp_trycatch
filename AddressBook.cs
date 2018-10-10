using System;
using System.Collections.Generic;

namespace trycatch {
    internal class AddressBook {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact> ();

        public void AddContact (string email, Contact contact) {
            try {
                Contacts.Add (email, contact);
            } catch (ArgumentException ex) {
                Console.WriteLine ($"Sorry, something went wrong when adding the contact: {ex.Message}");
            }
        }

        public Contact GetByEmail (string email) {
            return Contacts[email];
        }
    }
}