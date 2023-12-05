using DoiTLean.SFTP.Structures;
using OutSystems.ExternalLibraries.SDK;
using System.Collections.Generic;

namespace DoiTLean.SFTP
{
    /// <summary>
    /// H File Transfer Protocol (SFTP) that you can use in your applications
    /// </summary>
    [OSInterface(Description = "SSH File Transfer Protocol (SFTP) that you can use in your applications",IconResourceName = "DoiTLean.SFTP.resources.odc-sftp.png", Name = "SFTP")]
    public interface ISFTP
    {

        /// <summary>
		/// 
		/// </summary>
		/// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
		/// <param name="Port">default: 22</param>
		/// <param name="Username"></param>
		/// <param name="Paword"></param>
		/// <param name="Path"></param>
		/// <param name="Data"></param>
		[OSAction]
        void Get(string IP, int Port, string Username, string Paword, string Path, out byte[] Data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        /// <param name="Data"></param>
        [OSAction]
        void Put(string IP, int Port, string Username, string Paword, string Path, byte[] Data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword">Plain text paword.</param>
        /// <param name="Path">default: &quot;/&quot;</param>
        /// <param name="NumberOfFiles">Number of files to fetch. Miing or 0 will return all files.
        /// </param>
        /// <param name="List"></param>
        [OSAction]
        void List(string IP, int Port, string Username, string Paword, string Path, int NumberOfFiles, out List<RemoteItem> List);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Source"></param>
        /// <param name="Target"></param>
        [OSAction]
        void Move(string IP, int Port, string Username, string Paword, string Source, string Target);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        [OSAction]
        void Delete(string IP, int Port, string Username, string Paword, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        [OSAction]
        void Mkdir(string IP, int Port, string Username, string Paword, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        [OSAction]
        void Rmdir(string IP, int Port, string Username, string Paword, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        /// <param name="FileName">File name to search</param>
        /// <param name="File"></param>
        [OSAction]
        void Search(string IP, int Port, string Username, string Paword, string Path, string FileName, out RemoteItem File);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="Paword"></param>
        /// <param name="Path"></param>
        /// <param name="Exists"></param>
        [OSAction]
        void Exists(string IP, int Port, string Username, string Paword, string Path, out bool Exists);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        [OSAction]
        void Delete_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        /// <param name="Exists"></param>
        [OSAction]
        void Exists_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path, out bool Exists);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        /// <param name="Data"></param>
        [OSAction]
        void Get_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path, out byte[] Data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        /// <param name="NumberOfFiles">Number of files to fetch. Miing or 0 will return all files.</param>
        /// <param name="List"></param>
        [OSAction]
        void List_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path, int NumberOfFiles, out List<RemoteItem> List);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        [OSAction]
        void Mkdir_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Source"></param>
        /// <param name="Target"></param>
        [OSAction]
        void Move_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Source, string Target);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        /// <param name="Data"></param>
        [OSAction]
        void Put_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path, byte[] Data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        [OSAction]
        void Rmdir_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IP">host (e.g. &quot;127.0.0.1&quot;)</param>
        /// <param name="Port">default: 22</param>
        /// <param name="Username"></param>
        /// <param name="PrivateKey">.pem file content</param>
        /// <param name="Path"></param>
        /// <param name="FileName">File name to search</param>
        /// <param name="File"></param>
        [OSAction]
        void Search_PrivateKey(string IP, int Port, string Username, byte[] PrivateKey, string Path, string FileName, out RemoteItem File);


    }
}