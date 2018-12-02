using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class Page
    {
        public int TotalItems { get; set; }
        private List<object> Items;

        public Page()
        {
            this.Items = new List<object>();
        }

        public object GetAt(int index)
        {
            return this.Items[index];
        }

        public void AddItem(object item)
        {
            this.Items.Add(item);
        }
        
        public List<object> GetItems()
        {
            return this.Items;
        }
    }
}
