using System.Runtime.InteropServices;
using OPST.TstSln1;
using OPST.TstSln2;

namespace OPST.TstSln3
{
    public class TstCls3 : TstIfc3
    {
        public TstCls3()
        {
            
        }

        public void Run()
        {
            // OPST.TstSln1
            var tstCls1 = new TstCls1();
            tstCls1.TstFnc1a();

            // OPST.TstSln2
            var tstCls2 = new TstCls2b();
            tstCls2.TstFnc2a();

        }
        
    }
}