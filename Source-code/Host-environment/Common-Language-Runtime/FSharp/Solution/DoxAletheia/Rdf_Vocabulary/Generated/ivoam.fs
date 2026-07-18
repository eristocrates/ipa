namespace http.www.ivoa.net.rdf.messenger.hash

open DoxAletheia.Rdf_Vocabulary

module ivoam =
    let _namespace_name = "http://www.ivoa.net/rdf/messenger#"
    /// <summary>
    ///       Photon with an energy between 12 eV and 120 eV
    /// <see href="http://www.ivoa.net/rdf/messenger#EUV"></see></summary>
    let EUV = Namespaced_IRI.parse _namespace_name "EUV" |> NamespacedName
    /// <summary>
    ///      Photon with a wavelength between 100 nm and 300 nm
    /// <see href="http://www.ivoa.net/rdf/messenger#UV"></see></summary>
    let UV = Namespaced_IRI.parse _namespace_name "UV" |> NamespacedName

    /// <summary>
    ///        Photon with an energy above 120 keV
    /// <see href="http://www.ivoa.net/rdf/messenger#Gamma-ray"></see></summary>
    let ``Gamma-ray`` =
        Namespaced_IRI.parse _namespace_name "Gamma-ray" |> NamespacedName

    /// <summary>
    ///           Carrier particles of the electromagnetic interaction
    /// <see href="http://www.ivoa.net/rdf/messenger#Photon"></see></summary>
    let Photon = Namespaced_IRI.parse _namespace_name "Photon" |> NamespacedName
    /// <summary>
    ///         Photon with a wavelength between 1 µm and 100 µm
    /// <see href="http://www.ivoa.net/rdf/messenger#Infrared"></see></summary>
    let Infrared = Namespaced_IRI.parse _namespace_name "Infrared" |> NamespacedName
    /// <summary>
    ///       Photon with a wavelength between 0.1 mm and 10 mm (or 30 GHz&lt;=ν&lt;300 GHz)
    /// <see href="http://www.ivoa.net/rdf/messenger#Millimeter"></see></summary>
    let Millimeter = Namespaced_IRI.parse _namespace_name "Millimeter" |> NamespacedName
    /// <summary>
    ///         This term comprises all generations of neutrinos (electron, µ, τ), and particles as well as antiparticles.
    /// <see href="http://www.ivoa.net/rdf/messenger#Neutrino"></see></summary>
    let Neutrino = Namespaced_IRI.parse _namespace_name "Neutrino" |> NamespacedName
    /// <summary>
    ///          Photon with a wavelength between 300 nm and 1000 nm
    /// <see href="http://www.ivoa.net/rdf/messenger#Optical"></see></summary>
    let Optical = Namespaced_IRI.parse _namespace_name "Optical" |> NamespacedName
    /// <summary>
    ///            Photon with a wavelength longer than 10 mm (or ν&lt;30 GHz)
    /// <see href="http://www.ivoa.net/rdf/messenger#Radio"></see></summary>
    let Radio = Namespaced_IRI.parse _namespace_name "Radio" |> NamespacedName
    /// <summary>
    ///            Photon with an energy between 120 eV and 120 keV
    /// <see href="http://www.ivoa.net/rdf/messenger#X-ray"></see></summary>
    let ``X-ray`` = Namespaced_IRI.parse _namespace_name "X-ray" |> NamespacedName
