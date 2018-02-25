using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.DNA.Console
{
    
}

namespace NCA
{
    using NCL;
    using NCE;

    public interface IDNA
    {
        int DNA();
    }

    class Program
    {
        static void Main(string[] args)
        {
            CL _cl = new CL();
            int j = ((NCL.IDNA)_cl).DNA();      //  

            NCE.Program _pr = new NCE.Program();
            int k = ((NCE.IDNA)_pr).DNA();
        }
    }
}
