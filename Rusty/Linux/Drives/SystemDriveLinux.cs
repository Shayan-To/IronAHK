﻿using System;
using System.Collections.Generic;
using System.Text;
using IronAHK.Rusty.Cores.Common.Drives;
using System.IO;

namespace IronAHK.Rusty.Linux.Drives
{
    class SystemDriveLinux : SystemDrive
    {
        public SystemDriveLinux(DriveInfo drv)
            : base(drv) { }

        public override void Eject() {
            throw new NotImplementedException();
        }

        public override void Retract() {
            throw new NotImplementedException();
        }

        public override StatusCD Status {
            get { throw new NotImplementedException(); }
        }

        public override long Serial {
            get { throw new NotImplementedException(); }
        }
    }
}
