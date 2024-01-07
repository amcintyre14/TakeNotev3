using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNotev3
{
    public class FileGroup
    {
        public string Name { get; set; }
        public List<string> Files { get; set; }
        public ListViewGroup ListViewGroup { get; set; }

        public FileGroup(string name)
        {
            Name = name;
            Files = new List<string>();
            ListViewGroup = new ListViewGroup(Name);
        }

    }
}
