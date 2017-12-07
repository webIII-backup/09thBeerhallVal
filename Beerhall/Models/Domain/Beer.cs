﻿using System;

namespace Beerhall.Models.Domain
{
    public class Beer
    {
        #region Fields
        private string _name;
        #endregion

        #region Properties
        public int BeerId { get; set; }
        public string Name {
            get {
                return _name;
            }
            private set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A beer must have a name");
                _name = value;
            }
        }

        public string Description { get; set; }
        public double? AlcoholByVolume { get; set; }
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        protected Beer()
        {

        }

        public Beer(string name) : this()
        {
            Name = name;
        }
        #endregion
    }
}
