
using PalcoNet.Src.Modelo.Entidades;
using System.Collections.Generic;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public abstract class Paginator
    {
        public int PageNumber { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }

        public DatabaseEntity Entity { get; set; }

        private List<Page> Pages;
        
        public Paginator()
        {
            this.PageNumber = -1;
            this.ItemsPerPage = 0;
            this.TotalPages = 0;
            this.TotalRecords = 0;
            this.Pages = new List<Page>();
        }
        

        public Page nextPage()
        {
            if(this.Pages.Count == 0)
            {
                int offset = this.PageNumber * this.ItemsPerPage;
                this.Pages.Add(this.SearchPaged(offset, this.ItemsPerPage));
            }

            Page currentPage = this.Pages[this.PageNumber];
            
            this.PageNumber += 1;
            return currentPage;
        }

        public Page previousPage()
        {
            this.PageNumber -= 1;
            return null;
        }

        public abstract Page SearchPaged(int offset, int itemsPerPage);
    }
}
