# Universal.Common
Support utilities and extensions meant to extend the default functionality from the base class library.

## Classes

### BinaryReader
Endianness-aware implementation of System.IO.BinaryReader, allowing to read primitive types from a stream in big-endian or little-endian byte order.
```csharp
using (var stream = new FileStream("file.bin", FileMode.Open, FileAccess.Read))
{
    // Create a BinaryReader with big-endian byte order
    using (var reader = new BinaryReader(stream, Endian.Big))
    {
        // Read an Int32 in big-endian order
        int value = reader.ReadInt32();
    }
}
```

### BinaryWriter
Endianness-aware implementation of System.IO.BinaryWriter, allowing to write primitive types to a stream in big-endian or little-endian byte order.
```csharp
using (var stream = new FileStream("file.bin", FileMode.Create, FileAccess.Write))
{
    // Create a BinaryWriter with big-endian byte order
    using (var writer = new BinaryWriter(stream, Endian.Big))
    {
        // Write an Int32 in big-endian order
        writer.Write(1234567890);
    }
}
```

### BitSequence
Utility for as-is bit manipulations.

```csharp
BitSequence bs1 = new BitSequence("10001010"); // Binary representation in string.
BitSequence bs2 = new BitSequence(new bool[] { true, false, true }); // As booleans.
BitSequence bs3 = bs1 & "11110000"; // Bitwise and, implicit conversion from binary representation string.
```
### BitStream
Utility to perform bit-level operations on System.IO.Stream.
```csharp
using (BitStream bitStream = new BitStream(stream)) 
{
    uint value = bitStream.ReadUInt32(4); // Reads 4 bits from the stream and interprets it as an unsigned integer, padding if necessary.
}
```

### MediaType
Represents MIME types and provides functionality for working with media types in various contexts.

#### Constructor
```csharp
MediaType mediaType = new MediaType("application/json");
```

#### MediaType Detection

The MediaType class provides several static methods to create MediaType instances from different sources:

1. FromExtension
```csharp
MediaType mediaType = MediaType.FromExtension(".json");
// Returns a MediaType instance for "application/json"
```
Creates a MediaType instance based on a file extension (with or without the leading dot).

2. FromByteArray
```csharp
byte[] fileBytes = File.ReadAllBytes("sample.png");
MediaType mediaType = MediaType.FromByteArray(fileBytes);
// Returns a MediaType instance for "image/png"
```
Detects the media type based on the file signature in the byte array.

3. FromStream
```csharp
using (FileStream stream = File.OpenRead("sample.jpg"))
{
    MediaType mediaType = MediaType.FromStream(stream);
    // Returns a MediaType instance for "image/jpeg"
}
```
Detects the media type based on the file signature read from the stream.

These methods allow for flexible media type detection from various sources, making it easier to work with files and data streams in different formats.

### SemanticVersion
Implements version numbers that follow the Semantic Versioning 2.0.0 specification (https://semver.org/). Supports major, minor, and patch version components along with pre-release identifiers and build metadata.

```csharp
// Basic version
var version = new SemanticVersion(1, 2, 3); // 1.2.3

// Version with pre-release and build metadata
var version = new SemanticVersion(1, 2, 3, "alpha.1", "build.123"); // 1.2.3-alpha.1+build.123

// Parse from string
SemanticVersion version = SemanticVersion.Parse("2.0.0-rc.1+build.123");

// Version comparison follows SemVer rules
Assert.IsTrue(SemanticVersion.Parse("1.0.0-alpha") < SemanticVersion.Parse("1.0.0"));
Assert.IsTrue(SemanticVersion.Parse("1.0.0-alpha.1") < SemanticVersion.Parse("1.0.0-alpha.2"));
```

### StreamSegment
Represents a segment of a Stream that is itself a stream. This allows you to work with a specific portion of a stream as if it were a separate stream.
```csharp
using (var stream = new FileStream("file.bin", FileMode.Open, FileAccess.Read))
{
    // Create a StreamSegment that represents the first 1024 bytes of the stream
    using (var segment = new StreamSegment(stream, 0, 1024))
    {
        // Read the first 1024 bytes of the stream
        byte buffer = new byte;
        segment.Read(buffer, 0, 1024);
    }
}
```

### UriBuilder
Derived from System.UriBuilder, this class provides a fluent API to configure segments and queries.
```csharp
UriBuilder uriBuilder = new UriBuilder("http://www.myhost.com");
uriBuilder
    .AddSegments("api", "Product", 1)
    .AddQuery("key", "value");
// "https://www.myhost.com/api/Product/1?key=value"
```

### ZigZag
Static class that encodes arrays to matrices and vice-versa.
```csharp
int[,] matrix = new int[,] { { 0, 1 }, { 2, 3 } };
int[] array = ZigZag.ToArray(matrix); // [0, 1, 2, 3]
```