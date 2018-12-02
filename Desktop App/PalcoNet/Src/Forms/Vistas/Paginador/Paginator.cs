
using PalcoNet.Src.Modelo.Entidades;
using System;
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

        public Page NextPage()
        {
            Page currentPage = null;
            this.PageNumber += 1;
            if (this.Pages.Count == 0)
            {
                int offset = this.PageNumber * this.ItemsPerPage;
                currentPage = this.SearchPaged(offset, this.ItemsPerPage);
                this.TotalRecords = currentPage.TotalItems;
                this.TotalPages = (int)Math.Ceiling((decimal)this.TotalRecords / (decimal)this.ItemsPerPage);
                this.Pages.Add(currentPage);
            }
            else
            {
                try
                {
                    currentPage = this.Pages[this.PageNumber];
                }
                catch (Exception)
                {
                    int offset = this.PageNumber * this.ItemsPerPage;
                    currentPage = this.SearchPaged(offset, this.ItemsPerPage);
                    this.Pages.Add(currentPage);
                }
            }
            
            return this.Pages[this.PageNumber];
        }

        public Page LastPage()
        {
            Page currentPage = null;
            this.PageNumber = this.TotalPages - 1;
            try
            {
                currentPage = this.Pages[this.PageNumber];
            }
            catch (Exception)
            {
                int offset = (this.PageNumber) * this.ItemsPerPage;
                currentPage = this.SearchPaged(offset, this.ItemsPerPage);
                this.Pages.Insert(this.PageNumber, currentPage);
                currentPage = this.Pages[this.PageNumber];
            }

            return currentPage;
        }

        public Page PreviousPage()
        {
            this.PageNumber -= 1;
            return this.Pages[this.PageNumber];
        }

        public Page FirstPage()
        {
            this.PageNumber = 0;
            return this.Pages[this.PageNumber];
        }

        public abstract Page SearchPaged(int offset, int itemsPerPage);
    }
}
