using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Add using statement for data annotations
using System.ComponentModel.DataAnnotations;

namespace PortfolioSite.Models
{
    //Add the metadata type to the contact form
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForm
    {

    }

    public class ContactFormValidation
    {
        //Data annotations hanf the label display of our 
        // fields and set the requirments for valid data. 
        [Required(ErrorMessage="The Daleks will exterminate you if you do not enter a name!"), Display(Name="Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="How can I connect you with other Whovians at your company if I don't know who you work for?")]
        public string CompanyName { get; set; }
        [Required, EmailAddress(ErrorMessage = "All Whovians have valid email messages!"), MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage="I can not connect you with further Whovians if you do not leave a comment!"), DataType(DataType.MultilineText),MaxLength(500)]
        public string Comments { get; set; }
    }

}