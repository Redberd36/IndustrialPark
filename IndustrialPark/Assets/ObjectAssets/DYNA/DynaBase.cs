﻿using System.Collections.Generic;
using System.Linq;

namespace IndustrialPark
{
    public class DynaBase
    {
        public virtual string Note { get; }
        public byte[] data { get; set; }

        public DynaBase()
        {
            data = new byte[0];
        }

        public DynaBase(IEnumerable<byte> enumerable)
        {
            data = enumerable.ToArray();
        }

        public virtual byte[] ToByteArray()
        {
            return data;
        }

        public virtual bool HasReference(uint assetID)
        {
            return false;
        }
    }
}