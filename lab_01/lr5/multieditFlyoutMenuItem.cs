using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class multieditFlyoutMenuItem
    {
        public multieditFlyoutMenuItem()
        {
            TargetType = typeof(multieditFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}