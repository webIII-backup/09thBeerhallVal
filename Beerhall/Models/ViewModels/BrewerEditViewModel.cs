using Beerhall.Models.Domain;
using System;

namespace Beerhall.Models.ViewModels
{
    public class BrewerEditViewModel
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int? Turnover { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
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
