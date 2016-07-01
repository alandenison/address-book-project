using Nancy;
using AddressBook;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/new"] = _ => {
        return View["/Contact_Form.cshtml"];
      };
      Post["/new-contact"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-address"], Request.Form["new-phone"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["Contact_Created.cshtml", newContact];
      };
      Get["/list"] = _ =>{
        List<Contact> allContacts = Contact.GetAll();
        return View["Contact_List.cshtml", allContacts];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["Contacts_Cleared.cshtml"];
      };
    }
  }
}
