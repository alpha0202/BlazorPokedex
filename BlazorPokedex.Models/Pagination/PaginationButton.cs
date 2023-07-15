using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models.Pagination
{
    public class PaginationButton
    {

        public string Text { get; set; }

        public int Page { get; set; }

        public bool Enable { get; set; }

        public bool Active { get; set; }


        public PaginationButton(int page, bool enable, string text)
        {
            
            Page = page;
            Enable = enable;
            Active = enable;
        }


    }
}
