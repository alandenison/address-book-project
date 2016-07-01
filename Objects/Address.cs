using System.Collections.Generic;

namespace AddressBook
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phone;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
      _instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
    _name = newName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
