
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
        public Pageable form { get; set; }
        public PaginatorControls controls { get; set; }
        public DatabaseEntity Entity { get; set; }
        public Dictionary<int, Page> Pages { get; set; }

        protected void initialize(Pageable form)
        {
            this.PageNumber = -1;
            this.ItemsPerPage = 0;
            this.TotalPages = 0;
            this.TotalRecords = 0;
            this.Pages = new Dictionary<int, Page>();
            this.form = form;
            this.controls = new PaginatorControls(this.form);
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
                this.Pages.Add(this.PageNumber, currentPage);
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
                    this.Pages.Add(this.PageNumber, currentPage);
                }
            }
            this.updateControls();
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
                this.Pages.Add(this.PageNumber, currentPage);
            }

            this.updateControls();
            return currentPage;
        }

        public Page PreviousPage()
        {
            this.PageNumber -= 1;
            Page currentPage = null;
            try
            {
                currentPage = this.Pages[this.PageNumber];
            }
            catch (Exception)
            {
                int offset = (this.PageNumber) * this.ItemsPerPage;
                currentPage = this.SearchPaged(offset, this.ItemsPerPage);
                this.Pages.Add(this.PageNumber, currentPage);
            }
            this.updateControls();
            return currentPage;
        }

        public Page FirstPage()
        {
            this.PageNumber = 0;
            this.updateControls();
            return this.Pages[this.PageNumber];
        }

        public void updateControls()
        {
            if(this.PageNumber <= 0)
            {
                this.controls.Controls["totalPaginas"].Text = this.TotalPages.ToString();
                if(this.TotalRecords == 0)
                    this.controls.Controls["paginaActual"].Text = "0";
                else
                    this.controls.Controls["paginaActual"].Text = "1";

                this.controls.Controls["btn_previousPage"].Enabled = false;
                this.controls.Controls["btn_firstPage"].Enabled = false;
                this.controls.Controls["btn_nextPage"].Enabled = true;
                this.controls.Controls["btn_lastPage"].Enabled = true;
            }
            else
            {
                if(this.PageNumber == (this.TotalPages - 1))
                {
                    this.controls.Controls["paginaActual"].Text = this.TotalPages.ToString();
                    this.controls.Controls["btn_previousPage"].Enabled = true;
                    this.controls.Controls["btn_firstPage"].Enabled = true;
                    this.controls.Controls["btn_nextPage"].Enabled = false;
                    this.controls.Controls["btn_lastPage"].Enabled = false;
                }
                else
                {
                    this.controls.Controls["paginaActual"].Text = (this.PageNumber+1).ToString();
                    this.controls.Controls["btn_previousPage"].Enabled = true;
                    this.controls.Controls["btn_firstPage"].Enabled = true;
                    this.controls.Controls["btn_nextPage"].Enabled = true;
                    this.controls.Controls["btn_lastPage"].Enabled = true;
                }
            }
        }

        public abstract Page SearchPaged(int offset, int itemsPerPage);
    }
}
