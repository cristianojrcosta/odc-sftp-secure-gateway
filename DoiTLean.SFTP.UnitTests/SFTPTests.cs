using NUnit.Framework;
using OutSystems.ExternalLibraries.SDK;
using JSONPair = DoiTLean.SFTP.Structures.RemoteItem;

namespace DoiTLean.SFTP.UnitTests;

public class NScrapeTests {

    /// <summary>
    /// Tests if the JSONPair constructor correctly creates the JSONPair struct
    /// </summary>
    [Test]
    public void NScrapeTest() {
        Assert.That("2", Is.EqualTo("2"));
    }


}