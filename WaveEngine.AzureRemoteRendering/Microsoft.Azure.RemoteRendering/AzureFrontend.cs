﻿// <auto-generated/>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectId = System.UInt32;

namespace Microsoft.Azure.RemoteRendering
{
    public partial class AzureFrontend
    {
        public ushort InteropId
        {
            get
            {
                UInt64 as64 = (UInt64)handle;
                return (ushort)((as64 & 0xffff000000000000ul) >> 48);
            }
        }

        public static bool operator ==(AzureFrontend a, AzureFrontend b)
        {
            return a?.handle == b?.handle;
        }

        public static bool operator !=(AzureFrontend a, AzureFrontend b)
        {
            return a?.handle != b?.handle;
        }


        public override int GetHashCode()
        {
            return handle.GetHashCode();
        }

        public override bool Equals(Object other)
        {
            if (other == null)
            {
                return handle == default(ulong);
            }

            AzureFrontend oe = other as AzureFrontend;
            if (oe == null)
            {
                return base.Equals(other);
            }

            return handle == oe.handle;
        }
    }

    public partial struct AzureFrontendAccountInfo
    {
        public bool HasRequiredInfo()
        {
            return !string.IsNullOrEmpty(AccountId) && !string.IsNullOrEmpty(AccountDomain) &&
                (!string.IsNullOrEmpty(AccountKey) || !string.IsNullOrEmpty(AccessToken) || !string.IsNullOrEmpty(AuthenticationToken));
        }
    }
}