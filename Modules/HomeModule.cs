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
        Contact newContact = new Contact(Request.Form["new-name"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["Contact_Created.cshtml", newContact];
      };

    }
  }
}
