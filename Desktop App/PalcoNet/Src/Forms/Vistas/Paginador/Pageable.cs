using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public interface Pageable
    {
        void btn_nextPage_Click(object sender, EventArgs e);

        void btn_firstPage_Click(object sender, EventArgs e);

        void btn_previousPage_Click(object sender, EventArgs e);

        void btn_lastPage_Click(object sender, EventArgs e);
    }
}
