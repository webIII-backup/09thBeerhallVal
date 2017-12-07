using Beerhall.Models.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace Beerhall.Models.ViewModels
{
    public class BrewerEditViewModel
    {
        public string Name { get; set; }
        [Display(Prompt = "Street and house number")]
        public string Street { get; set; }
        [Display(Name = "Location")]
        public string PostalCode { get; set; }
        [DataType(DataType.Currency)]
        public int? Turnover { get; set; }
        public string Description { get; set; }
        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }
        [Display(Name = "Date established")]
        [DataType(DataType.Date)]
        public DateTime? DateEstablished { get; set; }
        public BrewerEditViewModel()
        {
        }

        public BrewerEditViewModel(Brewer brewer)
        {
            Name = brewer.Name;
            Street = brewer.Street;
            PostalCode = brewer.Location?.PostalCode;
            Turnover = brewer.Turnover;
            ContactEmail = brewer.ContactEmail;
            Description = brewer.Description;
            DateEstablished = brewer.DateEstablished;
        }
    }
}
