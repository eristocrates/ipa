namespace http.topbraid.org.swa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swa =
    let _namespace_iri = Namespace_Iri swa |> NamespaceIRI

    /// <summary>
    ///   <para>swa:PlainTextFieldEditor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/swa#PlainTextFieldEditor">http://topbraid.org/swa#PlainTextFieldEditor</seealso>
    let PlainTextFieldEditor =
        Prefixed_Name(swa, "PlainTextFieldEditor") |> PrefixedName
