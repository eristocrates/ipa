# SafeName

Cross-platform filename and path validation and sanitization for .NET. Turn any user-supplied name into a safe filename that will not break, overwrite, or open a path-traversal hole. Zero external dependencies.

```csharp
using SafeName;

FileName.Sanitize("My:Report*.pdf"); // "My_Report_.pdf"
FileName.Sanitize("CON.txt");        // "CON_.txt"   (CON is a Windows device name)
FileName.Sanitize("report.   ");     // "report"     (Windows silently strips the trailing dot and spaces)
```

Your upload handler is one `CON.txt` away from a bug. A user uploads a file named `CON`, or `report.`, or a name with 300 emoji in it, and the hand-rolled `Path.GetInvalidFileNameChars()` loop that every team writes lets it straight through. Then Windows silently renames it, or the write fails, or a name of `../../etc/passwd` lands somewhere it should not. Sanitizing a filename correctly is a real correctness and security problem, and it is easy to get wrong.

## The gap

Every other ecosystem has a battle-tested library for this. Python has [pathvalidate](https://github.com/thombashi/pathvalidate) and Node has [sanitize-filename](https://github.com/parshap/node-sanitize-filename), both among the most-installed packages in their ecosystems (tens of millions of downloads a month; check the current figures on PyPI and npm). Go and Rust have equivalents. On NuGet there was nothing, so .NET developers hand-roll a character loop that misses the parts that actually bite. SafeName is that library for .NET, with its behavior checked for rule parity against both pathvalidate and sanitize-filename (see [Correctness](#correctness)).

## The traps hand-rolled code misses

A loop over `Path.GetInvalidFileNameChars()` handles the easy 10 percent. These are the traps it misses:

- **Windows reserved device names.** `CON`, `PRN`, `AUX`, `NUL`, `COM1` through `COM9`, `LPT1` through `LPT9`, and the console-handle names `CONIN$` and `CONOUT$` are reserved. They are reserved even with an extension, so `CON.txt` and `CON.tar.gz` are also reserved, and the check is case-insensitive. A file named `CON` cannot be created on Windows at all. The classic bug is checking only the bare name, or forgetting the extension case.
- **Trailing dots and spaces.** Windows silently strips them. A file you save as `report.` is read back as `report`, so your database row points at a file that does not exist. SafeName removes them up front so what you store is what is on disk.
- **Byte length, not character length.** Most Unix filesystems (ext4, APFS, XFS) limit a filename component to 255 *bytes* and store names as UTF-8, so 100 emoji is 400 bytes and is rejected, even though it is only 100 characters. SafeName measures in UTF-8 bytes by default, which is the correct and commonly-missed choice.
- **Control characters and DEL.** Bytes 0 through 31 and 127 are invalid on Windows and dangerous everywhere. NUL is invalid even on POSIX.
- **Reserved characters that differ per platform.** Windows forbids `< > : " / \ | ? *`; POSIX forbids only `/` and NUL. A name that is fine on Linux can be illegal on Windows.
- **Path separators hiding in a filename.** A single component that contains `/` or `\` is not one file, it is a directory traversal waiting to happen.

## Install

```
dotnet add package SafeName
```

## Quickstart

```csharp
using SafeName;

// Sanitize: never throws on the input, always returns a usable name.
FileName.Sanitize("My:Report*.pdf");   // "My_Report_.pdf"
FileName.Sanitize("CON");              // "CON_"
FileName.Sanitize("résumé.pdf");       // "résumé.pdf"  (Unicode is kept by default)
FileName.Sanitize("");                 // "untitled"    (empty input uses the fallback)

// Validate: detailed, never throws.
FileName.IsValid("COM1");                               // false (reserved on Windows and Universal)
FileName.IsValid("COM1", PlatformProfile.Posix);        // true  (POSIX has no reserved device names)

ValidationResult result = FileName.Validate("a<b.");
// result.IsValid == false
// result.Errors has a ReservedCharacter at position 1 and a TrailingDotOrSpace
```

## Platform profiles

The rules a name must satisfy differ per operating system, so you pick a profile.

| Profile | Rules |
|---|---|
| `Universal` (default) | The intersection of Windows and POSIX: valid only if valid on both. Use this when you do not control the target filesystem. |
| `Windows` | Reserved characters `< > : " / \ | ? *`, control characters, reserved device names, and no trailing dots or spaces. |
| `Posix` | Only `/` and NUL are forbidden. Trailing dots and spaces, backslashes, and names like `CON` are all allowed. |
| `Auto` | Detects the current OS and applies `Windows` or `Posix`. |

```csharp
var windows = new SanitizeOptions { Profile = PlatformProfile.Windows };
var posix   = new SanitizeOptions { Profile = PlatformProfile.Posix };

FileName.Sanitize("data:v2", windows); // "data_v2"  (colon is reserved on Windows)
FileName.Sanitize("data:v2", posix);   // "data:v2"  (colon is fine on POSIX)
```

## Options

```csharp
var options = new SanitizeOptions
{
    Replacement = "-",                          // what to substitute for each unsafe character (default "_")
    Profile = PlatformProfile.Universal,        // default
    MaxLength = 255,                            // default
    MaxLengthUnit = MaxLengthUnit.Utf8Bytes,    // default; the correct choice for most filesystems
    PreserveExtension = true,                   // keep ".pdf" when truncating for length (default)
    CollapseConsecutiveReplacements = true,     // "a<>b" becomes "a-b", not "a--b" (default)
    NullOrEmptyFallback = "untitled",           // used when the input cleans down to nothing (default)
    AllowUnicode = true,                        // false strips every non-ASCII character (default true)
    ReservedNamePolicy = ReservedNamePolicy.Suffix, // "CON" becomes "CON_"; Reject uses the fallback instead
};

FileName.Sanitize("a|b|c", options); // "a-b-c"
```

Bad options fail loudly: an empty `Replacement`, a `MaxLength` of zero or less, a `Replacement` that is itself unsafe (a reserved character, a separator, or nothing but dots and spaces), or a non-ASCII `Replacement` combined with `AllowUnicode = false` (which would contradict the ASCII-only guarantee) throws `ArgumentException`. Sanitizing the input name never throws, which is the whole point: garbage in, safe name out.

`MaxLengthUnit` is worth a deliberate choice. Filesystems limit bytes, not characters. `Utf8Bytes` (the default) matches ext4, APFS, and XFS, which cap a component at 255 bytes; `Chars` matches NTFS, which caps at 255 UTF-16 code units. When SafeName truncates for length it keeps the extension by default, so a very long `.pdf` stays a `.pdf`.

## ASP.NET Core file upload

This is the integration most teams want. Take `IFormFile.FileName`, which is attacker-controlled, and turn it into a safe storage name.

```csharp
using SafeName;

app.MapPost("/upload", async (IFormFile file, IWebHostEnvironment env) =>
{
    // Never trust file.FileName. Sanitize it to a single safe component.
    string safeName = FileName.Sanitize(file.FileName);

    string uploadsRoot = Path.Combine(env.ContentRootPath, "uploads");
    Directory.CreateDirectory(uploadsRoot);

    // Combine, then resolve and confirm the result stays inside the uploads folder.
    string fullPath = Path.GetFullPath(Path.Combine(uploadsRoot, safeName));
    string root = Path.GetFullPath(uploadsRoot);
    if (!fullPath.StartsWith(root + Path.DirectorySeparatorChar, StringComparison.Ordinal))
    {
        return Results.BadRequest("Invalid file name.");
    }

    await using var stream = File.Create(fullPath);
    await file.CopyToAsync(stream);
    return Results.Ok(new { storedAs = safeName });
});
```

## Security: this makes names safe, it does not sandbox paths

Read this part. SafeName makes a *name* safe. It does not confine filesystem *access* to a directory, and it is not a substitute for doing so.

`FilePath.Sanitize` strips `..` and `.` segments and cleans each component, which removes the obvious traversal:

```csharp
FilePath.Sanitize("../../etc/passwd");            // "etc/passwd"
FilePath.Sanitize("uploads/../../../etc/passwd"); // "uploads/etc/passwd"
```

There is a sharp edge here that is easy to skim past: `FilePath.Sanitize` preserves an *absolute* root when the input has one, because rewriting an absolute path to a relative one would be surprising.

```csharp
FilePath.Sanitize("/etc/passwd"); // "/etc/passwd"  (still absolute)
FilePath.Sanitize("C:\\Windows");  // "C:/Windows"   (still rooted on a drive)
```

That is correct behavior, but it means `Path.Combine(baseDir, absoluteResult)` **discards** `baseDir` and returns the absolute path, escaping your directory entirely. This is a documented .NET behavior of `Path.Combine`, not a SafeName quirk. It is exactly why the containment check below is mandatory: never trust the joined path, always resolve it with `Path.GetFullPath` and confirm it starts with your base directory.

If you take any user input and join it to a base directory, you must resolve the final path and check that it stays inside the base. That check is the actual security boundary:

```csharp
static string SafeCombine(string baseDirectory, string userSuppliedName)
{
    string safeName = FileName.Sanitize(userSuppliedName);
    string root = Path.GetFullPath(baseDirectory);
    string full = Path.GetFullPath(Path.Combine(root, safeName));

    if (full != root && !full.StartsWith(root + Path.DirectorySeparatorChar, StringComparison.Ordinal))
    {
        throw new InvalidOperationException("Resolved path escapes the base directory.");
    }

    return full;
}
```

Use `FileName.Sanitize` for the name and `Path.GetFullPath` plus a base-directory containment check for the access. They are complementary, and you need both.

## Validate

`Validate` returns every reason a name is not safe, each with a reason code and, where it applies, the position of the offending character. It never throws.

```csharp
ValidationResult result = FileName.Validate("a<b:c*d.", PlatformProfile.Windows);

foreach (ValidationError error in result.Errors)
{
    Console.WriteLine($"{error.Reason} at {error.Position}: {error.Message}");
}

// result.Sanitized carries a safe repair as a convenience.
```

The reason codes are `Empty`, `ReservedCharacter`, `ControlCharacter`, `ReservedDeviceName`, `TrailingDotOrSpace`, `TooLong`, `PathSeparatorPresent`, `PathTraversal`, and `UnpairedSurrogate`.

`Validate` and `IsValid` default to the Universal profile and a limit of 255 UTF-8 bytes. To check a name against the exact profile, maximum length, and length unit you sanitized with, pass the same `SanitizeOptions`:

```csharp
var options = new SanitizeOptions { MaxLengthUnit = MaxLengthUnit.Chars, MaxLength = 120 };
string safe = FileName.Sanitize(userName, options);
bool ok = FileName.IsValid(safe, options); // validates for the same profile + unit + length; always true
```

## Correctness

Getting the rules right is the entire value of the library, so its behavior is checked for rule parity against the two most-used references in other ecosystems:

- **Python pathvalidate** (the reference for which names are valid on which platform). SafeName's `IsValid` is compared against pathvalidate's verdicts over a corpus covering reserved names, reserved characters, control characters, trailing dots and spaces, and separators, on the Windows, POSIX, and Universal profiles.
- **npm sanitize-filename** (a widely-used sanitizer). SafeName's output is checked to remove the same forbidden characters and to always be a valid, non-empty filename.

The claim is *rule* parity, not byte-for-byte output parity: the libraries use different replacement strategies (sanitize-filename deletes unsafe characters and blanks reserved names entirely, SafeName replaces and suffixes), so the same flagged characters and the same reserved names are what parity means here. Where the references genuinely disagree with each other or with the documented filesystem rules, SafeName picks the rule and pins the choice with a test:

- **`COM0` and `LPT0`** are treated as valid. SafeName follows Microsoft's documented reserved list, which is `COM1` through `COM9` and `LPT1` through `LPT9`. pathvalidate additionally reserves the zero forms; SafeName does not.
- **`.` and `..`** are treated as unusable filenames and replaced with the fallback, because they are directory references, not names. pathvalidate accepts them as filename strings.
- **On the POSIX profile**, only `/` and NUL are forbidden, so backslashes and control characters other than NUL are allowed, faithful to POSIX. pathvalidate is stricter there.
- **Space-padded reserved names** such as `" CON"` and `"abc CON"` are treated as valid. Only the exact stem (`CON`, with a trailing-space and extension allowance) is a device name; a leading space or extra text makes it an ordinary filename. Verified on Windows 11, these create real files rather than opening the device. pathvalidate is over-strict on some of these forms.

Beyond the oracles, the suite pins the reserved-name matrix (`CON`, `con`, `CON.txt`, `CON.tar.gz`, `COM1` through `COM9`, `LPT1` through `LPT9`, `CONIN$`, `CONOUT$`, and the near-misses `CONtext`, `COM0`, `COM10`, `CONIN`, `CONINX`), the per-platform character and control-character matrices, byte-length truncation including a 100-emoji case, extension preservation, and the full path and traversal handling.

The core invariant is checked as a property over thousands of hostile fuzz inputs (Unicode, emoji, control characters, lone surrogates, traversal, reserved names, and 10,000-character strings), and not just with the defaults: it is proven across the full documented option space, varying the replacement (single- and multi-character, including dot- and space-terminated and non-ASCII replacements), the length unit (`Utf8Bytes` and `Chars`), the maximum length (including the pathological tiny values 3, 4, and 5), `PreserveExtension`, `AllowUnicode`, and consecutive-replacement collapsing, for every profile, over more than 100,000 sanitized outputs. For each, the output of `Sanitize` passes the options-aware `Validate` for the exact same options, never contains a path separator, is never a reserved name, is valid UTF-16 (every unpaired surrogate is repaired), stays ASCII-only when `AllowUnicode` is false, and never exceeds the length limit, with zero exceptions. Sanitizing is idempotent (`Sanitize(Sanitize(x))` equals `Sanitize(x)`) and stateless, so it is safe to call from any thread.

## Performance

Sanitizing is a linear scan of a short string, so it is fast. The claim, enforced as CI floors that must hold on slow shared runners, is:

- `FileName.Sanitize`: more than 100,000 names per second.
- `FileName.IsValid`: more than 200,000 names per second.

On a modern desktop the measured numbers are much higher (best case, a single short valid string, `IsValid` exceeds two million per second; on a mixed workload that includes a 300-character input, `Sanitize` runs a few hundred thousand per second). Treat the floors as the promise and the high numbers as best-case. You sanitize a filename once per upload, so this is never the bottleneck.

## Limitations

- This is not a path-confinement tool. See the [security section](#security-this-makes-names-safe-it-does-not-sandbox-paths).
- Filesystem byte limits are approximated to safe defaults (255 per component, 260 for a Windows path, 4096 for a POSIX path). Exotic filesystems with different limits are not modeled individually.
- There are no cloud-storage key rules in this release (S3, Azure Blob, and GCS have their own naming constraints).
- `AllowUnicode = false` strips non-ASCII characters; it does not transliterate them.

## Roadmap

- Cloud-storage key rules (S3, Azure Blob, GCS).
- A slugify mode (lowercase, hyphenate, transliterate) for URL-friendly names.
- More filesystem profiles (case-insensitivity awareness, long-path Windows).

## License

MIT
