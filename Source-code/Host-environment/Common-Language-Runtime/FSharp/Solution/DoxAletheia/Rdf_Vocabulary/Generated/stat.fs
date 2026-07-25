namespace https.www.w3.org.ns.posix.stat.rdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module stat =
    let _namespace_iri = Namespace_Iri stat |> NamespaceIRI
    /// <summary>
    ///   <para>stat:blksize</para>
    /// </summary>
    /// <remarks>
    ///   <para>blocksize for file system I/O</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#blksize">https://www.w3.org/ns/posix/stat.rdf#blksize</seealso>
    let blksize = Prefixed_Name(stat, "blksize") |> PrefixedName
    /// <summary>
    ///   <para>stat:ctime</para>
    /// </summary>
    /// <remarks>
    ///   <para>time of last status change</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#ctime">https://www.w3.org/ns/posix/stat.rdf#ctime</seealso>
    let ctime = Prefixed_Name(stat, "ctime") |> PrefixedName
    /// <summary>
    ///   <para>stat:ino</para>
    /// </summary>
    /// <remarks>
    ///   <para>inode number</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#ino">https://www.w3.org/ns/posix/stat.rdf#ino</seealso>
    let ino = Prefixed_Name(stat, "ino") |> PrefixedName
    /// <summary>
    ///   <para>stat:mtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>time of last modification</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#mtime">https://www.w3.org/ns/posix/stat.rdf#mtime</seealso>
    let mtime = Prefixed_Name(stat, "mtime") |> PrefixedName
    /// <summary>
    ///   <para>stat:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>total size, in bytes</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#size">https://www.w3.org/ns/posix/stat.rdf#size</seealso>
    let size = Prefixed_Name(stat, "size") |> PrefixedName
    /// <summary>
    ///   <para>stat:dev</para>
    /// </summary>
    /// <remarks>
    ///   <para>ID of device containing file</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#dev">https://www.w3.org/ns/posix/stat.rdf#dev</seealso>
    let dev = Prefixed_Name(stat, "dev") |> PrefixedName
    /// <summary>
    ///   <para>stat:rdev</para>
    /// </summary>
    /// <remarks>
    ///   <para>device ID (if special file)</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#rdev">https://www.w3.org/ns/posix/stat.rdf#rdev</seealso>
    let rdev = Prefixed_Name(stat, "rdev") |> PrefixedName
    /// <summary>
    ///   <para>stat:atime</para>
    /// </summary>
    /// <remarks>
    ///   <para>time of last access</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#atime">https://www.w3.org/ns/posix/stat.rdf#atime</seealso>
    let atime = Prefixed_Name(stat, "atime") |> PrefixedName
    /// <summary>
    ///   <para>stat:blocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>number of 512B blocks allocated</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#blocks">https://www.w3.org/ns/posix/stat.rdf#blocks</seealso>
    let blocks = Prefixed_Name(stat, "blocks") |> PrefixedName
    /// <summary>
    ///   <para>stat:gid</para>
    /// </summary>
    /// <remarks>
    ///   <para>group ID of owner</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#gid">https://www.w3.org/ns/posix/stat.rdf#gid</seealso>
    let gid = Prefixed_Name(stat, "gid") |> PrefixedName
    /// <summary>
    ///   <para>stat:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>protection</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#mode">https://www.w3.org/ns/posix/stat.rdf#mode</seealso>
    let mode = Prefixed_Name(stat, "mode") |> PrefixedName
    /// <summary>
    ///   <para>stat:nlink</para>
    /// </summary>
    /// <remarks>
    ///   <para>number of hard links</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#nlink">https://www.w3.org/ns/posix/stat.rdf#nlink</seealso>
    let nlink = Prefixed_Name(stat, "nlink") |> PrefixedName
    /// <summary>
    ///   <para>stat:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>user ID of owner</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/posix/stat.rdf#uid">https://www.w3.org/ns/posix/stat.rdf#uid</seealso>
    let uid = Prefixed_Name(stat, "uid") |> PrefixedName
