using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchEngine.Models
{
    public class FilterViewModel
    {
        public FilterViewModel()
        {
            Results = new List<ResultViewModel>();
        }
        public string SearchTerm { get; set; }
        public IEnumerable<ResultViewModel> Results { get; set; }
    }
}