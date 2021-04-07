﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitRevision
{
    public class MovieCollection
    {
        private int inventory;

        public MovieCollection()
        {

        }
        public MovieCollection(int inventory)
        {
            this.inventory = inventory;
        }

        public int Inventory
        {
            get { return inventory; }
        }
        public void Add(int collection)
        {
            if (collection < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(collection));
            }
            inventory += collection;
        }
    }
}
