#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2017 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 20.24Release
// Tag = production/akw/20.24.01-0-g5fa480b
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the Software profile message.
    /// </summary>
    public class SoftwareMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SoftwareMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Version = 3;
            public const byte PartNumber = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SoftwareMesg() : base(Profile.GetMesg(MesgNum.Software))
        {
        }

        public SoftwareMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Version field</summary>
        /// <returns>Returns nullable float representing the Version field</returns>
        public float? GetVersion()
        {
            return (float?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set Version field</summary>
        /// <param name="version_">Nullable field value to be set</param>
        public void SetVersion(float? version_)
        {
            SetFieldValue(3, 0, version_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PartNumber field</summary>
        /// <returns>Returns byte[] representing the PartNumber field</returns>
        public byte[] GetPartNumber()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the PartNumber field</summary>
        /// <returns>Returns String representing the PartNumber field</returns>
        public String GetPartNumberAsString()
        {
            byte[] data = (byte[])GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set PartNumber field</summary>
        /// <param name="partNumber_"> field value to be set</param>
        public void SetPartNumber(String partNumber_)
        {
            byte[] data = Encoding.UTF8.GetBytes(partNumber_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(5, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set PartNumber field</summary>
        /// <param name="partNumber_">field value to be set</param>
        public void SetPartNumber(byte[] partNumber_)
        {
            SetFieldValue(5, 0, partNumber_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
