namespace http.standaarden.overheid.nl.owms.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owms =
    let _namespace_iri = Namespace_Iri owms |> NamespaceIRI

    /// <summary>
    ///   <para>overheid:terms/Centraal_Bureau_voor_de_Statistiek</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://standaarden.overheid.nl/owms/terms/Centraal_Bureau_voor_de_Statistiek">http://standaarden.overheid.nl/owms/terms/Centraal_Bureau_voor_de_Statistiek</seealso>
    let Centraal_Bureau_voor_de_Statistiek =
        Prefixed_Name(owms, "Centraal_Bureau_voor_de_Statistiek") |> PrefixedName
