using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanProject.Core.Common
{
    public interface ITransient
    {
        bool IsTransient { get; set; }
    }
}
