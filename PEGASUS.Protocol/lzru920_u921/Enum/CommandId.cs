using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEGASUS.Protocol.lzru920_u921.Enum
{
    public class CommandId
    {
        public const ushort SETRAWDATAMODE = 50001;//done
        public const ushort SETRAWDATACONFIG = 50003;
        public const ushort GETRAWDATADISTANCEVALUES = 50011;
        public const ushort SETRAWDATAERRORLOGRESET = 50006;//done
        public const ushort SETRAWDATAFRAMECOUNTERRESET = 50014;//done
        public const ushort GETRAWDATAMODE = 50002;//done
        public const ushort GETRAWDATACONFIG = 50004;
    }
}
