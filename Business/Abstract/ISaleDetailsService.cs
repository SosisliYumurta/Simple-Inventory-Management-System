using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaleDetailsService
    {
        void GetAll();
        void Get(int id);
    }
}
