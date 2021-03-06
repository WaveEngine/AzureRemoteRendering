﻿// <auto-generated/>
#pragma warning disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectId = System.UInt32;

namespace Microsoft.Azure.RemoteRendering
{
    public partial class AzureSession
    {
        private RemoteManager _actions = null;
        private GraphicsBinding _binding = null;

        public ushort InteropId
        {
            get
            {
                UInt64 as64 = (UInt64)handle;
                return (ushort)((as64 & 0xffff000000000000ul) >> 48);
            }
        }


        public static bool operator ==(AzureSession a, AzureSession b)
        {
            return a?.handle == b?.handle;
        }

        public static bool operator !=(AzureSession a, AzureSession b)
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

            AzureSession oe = other as AzureSession;
            if (oe == null)
            {
                return base.Equals(other);
            }

            return handle == oe.handle;
        }

        /// <summary>
        /// Get the runtime API if connected to this session.
        /// </summary>
        public Microsoft.Azure.RemoteRendering.RemoteManager Actions
        {
            get
            {
                if( _actions == null )
                {
                    ulong result_handle = handle;
                    _actions = (result_handle != default(ulong)) ? new Microsoft.Azure.RemoteRendering.RemoteManager(result_handle, transfer: true) : null;
                }

                return _actions;
            }
        }

        /// <summary>
        /// Get the graphics binding for this session.
        /// </summary>
        public Microsoft.Azure.RemoteRendering.GraphicsBinding GraphicsBinding
        {
            get
            {
                if( _binding == null )
                {
                    ulong result_handle = handle;
                    _binding = (result_handle != default(ulong)) ? Factories.GraphicsBindingFactory(result_handle, transfer: true) : null;
                }

                return _binding;
            }
        }
    }
}
