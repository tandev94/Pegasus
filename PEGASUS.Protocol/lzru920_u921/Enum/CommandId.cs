﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEGASUS.Protocol.lzru920_u921.Enum
{
    public class CommandId
    {
        public const ushort SETRAWDATAMODE = 50001;//done
        public const ushort SETRAWDATACONFIG = 50003;
        public const ushort SETRAWDATACONFIGRESTORE = 50007;
        public const ushort SETRAWDATAREDLASER = 50009;
        public const ushort SETRAWDATAHEARTBEAT = 50012;
        public const ushort GETRAWDATAINFORMATION = 50008;
        public const ushort GETRAWDATAREDLASER = 50010;
        public const ushort GETRAWDATAHEARTBEAT = 50013;
        public const ushort SETRAWDATACONFIGSTORE = 50005;
        public const ushort GETRAWDATADISTANCEVALUES = 50011;
        public const ushort SETRAWDATAERRORLOGRESET = 50006;//done
        public const ushort SETRAWDATAFRAMECOUNTERRESET = 50014;//done
        public const ushort GETRAWDATAMODE = 50002;//done
        public const ushort GETRAWDATACONFIG = 50004;
    }
}
