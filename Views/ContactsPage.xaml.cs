namespace Contacts.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
        List<Contact> contacts = new List<Contact>()
        {
            new Contact() {Name="Ruwan Weerasena",Email="RuwanWeerasena@email.com"},
            new Contact() {Name="Kusal Mendis",Email="KusalMendis@email.com"},
            new Contact() {Name="Sadeera Samarawikrama",Email="SadeeraSamarawikrama@email.com"},
            new Contact() {Name="Pathum Nissanka",Email="PathumNissanka@email.com"},
            new Contact() {Name= "DDe Silva",Email="DDeSilva@email.com"}

           
        };
        listContacts.ItemsSource = contacts;

    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(listContacts.SelectedItem != null)
        {
            await Shell.Current.GoToAsync(nameof(EditContactPage));
        
        }
        
        
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}