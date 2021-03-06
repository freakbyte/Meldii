﻿using System.IO;
using System.Runtime.Serialization.Json;

namespace Meldii.DataStructures
{
    public class FirefallPatchData
    {
        public string build;
        public string environment;
        public string region;
        public string patch_level;
        public bool error;

        public static FirefallPatchData Create(Stream data)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(FirefallPatchData));
            return (FirefallPatchData)serializer.ReadObject(data);
        }

        public static FirefallPatchData CreateError()
        {
            FirefallPatchData r = new FirefallPatchData();
            r.error = true;
            return r;
        }
    }
}
