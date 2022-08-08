namespace BlazingChat.Shared {

    public class Contact {

        public int ContactId {get; set;}
        public string FirstName {get; set;} = default!;
        public string LastName {get; set;} = default!;

        public Contact() {

        }

        public Contact(int contactId, string fistName, string lastName) {
            this.ContactId = contactId;
            this.FirstName = fistName;
            this.LastName = lastName;
        }
    }
}