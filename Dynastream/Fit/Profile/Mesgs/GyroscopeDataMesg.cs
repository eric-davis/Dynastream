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
    /// Implements the GyroscopeData profile message.
    /// </summary>
    public class GyroscopeDataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="GyroscopeDataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte SampleTimeOffset = 1;
            public const byte GyroX = 2;
            public const byte GyroY = 3;
            public const byte GyroZ = 4;
            public const byte CalibratedGyroX = 5;
            public const byte CalibratedGyroY = 6;
            public const byte CalibratedGyroZ = 7;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public GyroscopeDataMesg() : base(Profile.GetMesg(MesgNum.GyroscopeData))
        {
        }

        public GyroscopeDataMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the timestamp.</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the timestamp.</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field SampleTimeOffset</returns>
        public int GetNumSampleTimeOffset()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the gyro sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in gyro_x and gyro_y and gyro_z</summary>
        /// <param name="index">0 based index of SampleTimeOffset element to retrieve</param>
        /// <returns>Returns nullable ushort representing the SampleTimeOffset field</returns>
        public ushort? GetSampleTimeOffset(int index)
        {
            return (ushort?)GetFieldValue(1, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the gyro sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in gyro_x and gyro_y and gyro_z</summary>
        /// <param name="index">0 based index of sample_time_offset</param>
        /// <param name="sampleTimeOffset_">Nullable field value to be set</param>
        public void SetSampleTimeOffset(int index, ushort? sampleTimeOffset_)
        {
            SetFieldValue(1, index, sampleTimeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field GyroX</returns>
        public int GetNumGyroX()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the GyroX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of GyroX element to retrieve</param>
        /// <returns>Returns nullable ushort representing the GyroX field</returns>
        public ushort? GetGyroX(int index)
        {
            return (ushort?)GetFieldValue(2, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set GyroX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of gyro_x</param>
        /// <param name="gyroX_">Nullable field value to be set</param>
        public void SetGyroX(int index, ushort? gyroX_)
        {
            SetFieldValue(2, index, gyroX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field GyroY</returns>
        public int GetNumGyroY()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the GyroY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of GyroY element to retrieve</param>
        /// <returns>Returns nullable ushort representing the GyroY field</returns>
        public ushort? GetGyroY(int index)
        {
            return (ushort?)GetFieldValue(3, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set GyroY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of gyro_y</param>
        /// <param name="gyroY_">Nullable field value to be set</param>
        public void SetGyroY(int index, ushort? gyroY_)
        {
            SetFieldValue(3, index, gyroY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field GyroZ</returns>
        public int GetNumGyroZ()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the GyroZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of GyroZ element to retrieve</param>
        /// <returns>Returns nullable ushort representing the GyroZ field</returns>
        public ushort? GetGyroZ(int index)
        {
            return (ushort?)GetFieldValue(4, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set GyroZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of gyro_z</param>
        /// <param name="gyroZ_">Nullable field value to be set</param>
        public void SetGyroZ(int index, ushort? gyroZ_)
        {
            SetFieldValue(4, index, gyroZ_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedGyroX</returns>
        public int GetNumCalibratedGyroX()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedGyroX field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of CalibratedGyroX element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedGyroX field</returns>
        public float? GetCalibratedGyroX(int index)
        {
            return (float?)GetFieldValue(5, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set CalibratedGyroX field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of calibrated_gyro_x</param>
        /// <param name="calibratedGyroX_">Nullable field value to be set</param>
        public void SetCalibratedGyroX(int index, float? calibratedGyroX_)
        {
            SetFieldValue(5, index, calibratedGyroX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedGyroY</returns>
        public int GetNumCalibratedGyroY()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedGyroY field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of CalibratedGyroY element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedGyroY field</returns>
        public float? GetCalibratedGyroY(int index)
        {
            return (float?)GetFieldValue(6, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set CalibratedGyroY field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of calibrated_gyro_y</param>
        /// <param name="calibratedGyroY_">Nullable field value to be set</param>
        public void SetCalibratedGyroY(int index, float? calibratedGyroY_)
        {
            SetFieldValue(6, index, calibratedGyroY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedGyroZ</returns>
        public int GetNumCalibratedGyroZ()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedGyroZ field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of CalibratedGyroZ element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedGyroZ field</returns>
        public float? GetCalibratedGyroZ(int index)
        {
            return (float?)GetFieldValue(7, index, Fit.SubfieldIndexMainField);
        }

        /// <summary>
        /// Set CalibratedGyroZ field
        /// Units: deg/s
        /// Comment: Calibrated gyro reading</summary>
        /// <param name="index">0 based index of calibrated_gyro_z</param>
        /// <param name="calibratedGyroZ_">Nullable field value to be set</param>
        public void SetCalibratedGyroZ(int index, float? calibratedGyroZ_)
        {
            SetFieldValue(7, index, calibratedGyroZ_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
