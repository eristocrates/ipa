namespace http.www.ivoa.net.rdf.messenger.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ivoam =
    let _namespace_iri = Namespace_Iri ivoam |> NamespaceIRI
    /// <summary>
    ///   <para>ivoam:Neutrino</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>        This term comprises all generations of neutrinos (electron, µ, τ), and particles as well as antiparticles.</para>
    /// labels<para>Neutrino</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Neutrino">http://www.ivoa.net/rdf/messenger#Neutrino</seealso>
    let Neutrino = Prefixed_Name(ivoam, "Neutrino") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Optical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>         Photon with a wavelength between 300 nm and 1000 nm</para>
    /// labels<para>Optical</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Optical">http://www.ivoa.net/rdf/messenger#Optical</seealso>
    let Optical = Prefixed_Name(ivoam, "Optical") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:EUV</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>      Photon with an energy between 12 eV and 120 eV</para>
    /// labels<para>Extreme UV</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#EUV">http://www.ivoa.net/rdf/messenger#EUV</seealso>
    let EUV = Prefixed_Name(ivoam, "EUV") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Photon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>          Carrier particles of the electromagnetic interaction</para>
    /// labels<para>Photon</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Photon">http://www.ivoa.net/rdf/messenger#Photon</seealso>
    let Photon = Prefixed_Name(ivoam, "Photon") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Infrared</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>        Photon with a wavelength between 1 µm and 100 µm</para>
    /// labels<para>Infrared</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Infrared">http://www.ivoa.net/rdf/messenger#Infrared</seealso>
    let Infrared = Prefixed_Name(ivoam, "Infrared") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Gamma-ray</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>       Photon with an energy above 120 keV</para>
    /// labels<para>Gamma Ray</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Gamma-ray">http://www.ivoa.net/rdf/messenger#Gamma-ray</seealso>
    let Gamma_ray = Prefixed_Name(ivoam, "Gamma-ray") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>           Photon with a wavelength longer than 10 mm (or ν&lt;30 GHz)</para>
    /// labels<para>Radio</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Radio">http://www.ivoa.net/rdf/messenger#Radio</seealso>
    let Radio = Prefixed_Name(ivoam, "Radio") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:X-ray</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>           Photon with an energy between 120 eV and 120 keV</para>
    /// labels<para>X-Ray</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#X-ray">http://www.ivoa.net/rdf/messenger#X-ray</seealso>
    let X_ray = Prefixed_Name(ivoam, "X-ray") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:UV</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>     Photon with a wavelength between 100 nm and 300 nm</para>
    /// labels<para>Ultraviolet</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#UV">http://www.ivoa.net/rdf/messenger#UV</seealso>
    let UV = Prefixed_Name(ivoam, "UV") |> PrefixedName
    /// <summary>
    ///   <para>ivoam:Millimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>      Photon with a wavelength between 0.1 mm and 10 mm (or 30 GHz&lt;=ν&lt;300 GHz)</para>
    /// labels<para>Millimeter</para></remarks>
    /// <seealso href="http://www.ivoa.net/rdf/messenger#Millimeter">http://www.ivoa.net/rdf/messenger#Millimeter</seealso>
    let Millimeter = Prefixed_Name(ivoam, "Millimeter") |> PrefixedName
