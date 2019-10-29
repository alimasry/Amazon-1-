using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    class Store
    {
        private ArrayList products = new ArrayList();
        private string name;
        private string id;

        Store(ArrayList products , string name , string id)
        {
            this.products = products;
            this.name = name;
            this.id = id;
        }

        public bool setProducts(ArrayList products)
        {
            this.products = products;
            return true;
        }
        public bool setName(String name)
        {
            this.name = name;
            return true;
        }
        public bool setId(string id)
        {
            this.id = id;
            return true;
        }

        public ArrayList getProducts()
        {
            return this.products;
        }
        public string getName()
        {
            return this.name;
        }
        public string getId()
        {
            return this.id;
        }
    }
}
