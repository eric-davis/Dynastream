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
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    internal class DeveloperDataLookup
    {
        private readonly Dictionary<DeveloperDataKey, FieldDescriptionMesg> m_fieldDescriptionMesgs;
        private readonly Dictionary<byte, DeveloperDataIdMesg> m_developerDataIdMesgs;

        public DeveloperDataLookup()
        {
            m_fieldDescriptionMesgs = new Dictionary<DeveloperDataKey, FieldDescriptionMesg>();
            m_developerDataIdMesgs = new Dictionary<byte, DeveloperDataIdMesg>();
        }

        public Tuple<DeveloperDataIdMesg, FieldDescriptionMesg> GetMesgs(DeveloperDataKey key)
        {
            DeveloperDataIdMesg devIdMesg;
            FieldDescriptionMesg descriptionMesg;

            m_developerDataIdMesgs.TryGetValue(key.DeveloperDataIndex, out devIdMesg);
            m_fieldDescriptionMesgs.TryGetValue(key, out descriptionMesg);

            if (devIdMesg != null && descriptionMesg != null)
            {
                return new Tuple<DeveloperDataIdMesg, FieldDescriptionMesg>(
                    devIdMesg,
                    descriptionMesg);
            }

            return null;
        }

        public void Add(DeveloperDataIdMesg mesg)
        {
            byte? index = mesg.GetDeveloperDataIndex();
            if (index == null)
                return;
            
            /***********************************************************************************************
            * The following, commented out line appears to be the cause of the "An item with the same key 
            * has already been added" exception. The key already exists in the dictionary. Updating the 
            * value instead of performing a .Add() seems to avoid the error? Not sure if there are any 
            * other negative repercussions...
            *   - Eric.Davis_2017.03.08
            ***********************************************************************************************/
            //m_developerDataIdMesgs.Add(index.Value, mesg);
            m_developerDataIdMesgs[index.Value] = mesg;

            // Remove all fields currently associated with this developer
            var keysToRemove = m_fieldDescriptionMesgs.Keys.Where(x => x.DeveloperDataIndex == index).ToList();
            
            foreach (var key in keysToRemove)
            {
                m_fieldDescriptionMesgs.Remove(key);
            }
        }

        public DeveloperFieldDescription Add(FieldDescriptionMesg mesg)
        {
            DeveloperFieldDescription desc = null;

            byte? developerDataIndex = mesg.GetDeveloperDataIndex();
            byte? fieldDefinitionNumber = mesg.GetFieldDefinitionNumber();
            if ((developerDataIndex != null) &&
                (fieldDefinitionNumber != null))
            {
                var key = new DeveloperDataKey(
                    (byte)developerDataIndex,
                    (byte)fieldDefinitionNumber);

                m_fieldDescriptionMesgs[key] = mesg;

                // Build a Description of the pairing we just created
                var pair = GetMesgs(key);
                if (pair != null)
                {
                    desc = new DeveloperFieldDescription(pair.Item1, pair.Item2);
                }
            }

            return desc;
        }
    }
} // namespace
