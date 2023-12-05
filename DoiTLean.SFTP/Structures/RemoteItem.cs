using OutSystems.ExternalLibraries.SDK;
using System;
using System.Xml.Linq;

namespace DoiTLean.SFTP.Structures
{
    /// <summary>
    /// The JSON Pair struct represents a record of attribute, previous and new value for each attribute compared by the DiffJSON class
    /// </summary>
    [OSStructure(Description = "Remote Item")]
    public struct RemoteItem
    {

        [OSStructureField(DataType = OSDataType.Text)]
        public string ssFilename;

        [OSStructureField(DataType = OSDataType.Integer)]
        public int ssSizeInBytes;

        [OSStructureField(DataType = OSDataType.Boolean)]
        public bool ssIsDir;

        [OSStructureField(DataType = OSDataType.Boolean)]
        public bool ssIsLink;

        [OSStructureField(DataType = OSDataType.DateTime)]
        public DateTime ssCreated;

        [OSStructureField(DataType = OSDataType.DateTime)]
        public DateTime ssModified;


        /// <summary>
        /// Constructs an RemoteItem.
        /// </summary>
        public RemoteItem(string Filename, int SizeInBytes, bool IsDir, bool IsLink, DateTime Created, DateTime Modified) : this()
        {
            ssFilename = Filename ?? string.Empty;
            ssSizeInBytes = SizeInBytes;
            ssIsDir = IsDir;
            ssIsLink = IsLink;
            ssCreated = Created;
            ssModified = Modified;

        }
    }

}


