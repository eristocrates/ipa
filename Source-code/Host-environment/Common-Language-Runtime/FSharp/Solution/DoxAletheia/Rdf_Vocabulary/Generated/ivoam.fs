namespace http.www.ivoa.net.rdf.messenger.hash

open DoxAletheia

module ivoam =
    let _namespace_name = "http://www.ivoa.net/rdf/messenger#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///       Photon with an energy between 12 eV and 120 eV
    /// <see href="http://www.ivoa.net/rdf/messenger#EUV"></see></summary>
    let EUV = _prefix "EUV"
    /// <summary>
    ///      Photon with a wavelength between 100 nm and 300 nm
    /// <see href="http://www.ivoa.net/rdf/messenger#UV"></see></summary>
    let UV = _prefix "UV"
    /// <summary>
    ///        Photon with an energy above 120 keV
    /// <see href="http://www.ivoa.net/rdf/messenger#Gamma-ray"></see></summary>
    let ``Gamma-ray`` = _prefix "Gamma-ray"
    /// <summary>
    ///           Carrier particles of the electromagnetic interaction
    /// <see href="http://www.ivoa.net/rdf/messenger#Photon"></see></summary>
    let Photon = _prefix "Photon"
    /// <summary>
    ///         Photon with a wavelength between 1 µm and 100 µm
    /// <see href="http://www.ivoa.net/rdf/messenger#Infrared"></see></summary>
    let Infrared = _prefix "Infrared"
    /// <summary>
    ///       Photon with a wavelength between 0.1 mm and 10 mm (or 30 GHz&lt;=ν&lt;300 GHz)
    /// <see href="http://www.ivoa.net/rdf/messenger#Millimeter"></see></summary>
    let Millimeter = _prefix "Millimeter"
    /// <summary>
    ///         This term comprises all generations of neutrinos (electron, µ, τ), and particles as well as antiparticles.
    /// <see href="http://www.ivoa.net/rdf/messenger#Neutrino"></see></summary>
    let Neutrino = _prefix "Neutrino"
    /// <summary>
    ///          Photon with a wavelength between 300 nm and 1000 nm
    /// <see href="http://www.ivoa.net/rdf/messenger#Optical"></see></summary>
    let Optical = _prefix "Optical"
    /// <summary>
    ///            Photon with a wavelength longer than 10 mm (or ν&lt;30 GHz)
    /// <see href="http://www.ivoa.net/rdf/messenger#Radio"></see></summary>
    let Radio = _prefix "Radio"
    /// <summary>
    ///            Photon with an energy between 120 eV and 120 keV
    /// <see href="http://www.ivoa.net/rdf/messenger#X-ray"></see></summary>
    let ``X-ray`` = _prefix "X-ray"
