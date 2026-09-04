#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ivoam =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ivoa.net/rdf/messenger#" "ivoam"

    /// <summary>
    ///   <para>rdfs:label : Extreme UV^^xsd:string</para>
    ///   <para>rdfs:comment :       Photon with an energy between 12 eV and 120 eV^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#EUV">ivoam:EUV</a>
    /// </summary>
    let EUV = _prefixId.prefix "EUV"
    /// <summary>
    ///   <para>rdfs:label : Gamma Ray^^xsd:string</para>
    ///   <para>rdfs:comment :        Photon with an energy above 120 keV^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Gamma-ray">ivoam:Gamma-ray</a>
    /// </summary>
    let Gamma_ray = _prefixId.prefix "Gamma-ray"
    /// <summary>
    ///   <para>rdfs:label : Infrared^^xsd:string</para>
    ///   <para>rdfs:comment :         Photon with a wavelength between 1 µm and 100 µm^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Infrared">ivoam:Infrared</a>
    /// </summary>
    let Infrared = _prefixId.prefix "Infrared"
    /// <summary>
    ///   <para>rdfs:label : Millimeter^^xsd:string</para>
    ///   <para>rdfs:comment :       Photon with a wavelength between 0.1 mm and 10 mm (or 30 GHz&lt;=ν&lt;300 GHz)^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Millimeter">ivoam:Millimeter</a>
    /// </summary>
    let Millimeter = _prefixId.prefix "Millimeter"
    /// <summary>
    ///   <para>rdfs:label : Neutrino^^xsd:string</para>
    ///   <para>rdfs:comment :         This term comprises all generations of neutrinos (electron, µ, τ), and particles as well as antiparticles.^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Neutrino">ivoam:Neutrino</a>
    /// </summary>
    let Neutrino = _prefixId.prefix "Neutrino"
    /// <summary>
    ///   <para>rdfs:label : Optical^^xsd:string</para>
    ///   <para>rdfs:comment :          Photon with a wavelength between 300 nm and 1000 nm^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Optical">ivoam:Optical</a>
    /// </summary>
    let Optical = _prefixId.prefix "Optical"
    /// <summary>
    ///   <para>rdfs:label : Photon^^xsd:string</para>
    ///   <para>rdfs:comment :           Carrier particles of the electromagnetic interaction^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Photon">ivoam:Photon</a>
    /// </summary>
    let Photon = _prefixId.prefix "Photon"
    /// <summary>
    ///   <para>rdfs:label : Radio^^xsd:string</para>
    ///   <para>rdfs:comment :            Photon with a wavelength longer than 10 mm (or ν&lt;30 GHz)^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#Radio">ivoam:Radio</a>
    /// </summary>
    let Radio = _prefixId.prefix "Radio"
    /// <summary>
    ///   <para>rdfs:label : Ultraviolet^^xsd:string</para>
    ///   <para>rdfs:comment :      Photon with a wavelength between 100 nm and 300 nm^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#UV">ivoam:UV</a>
    /// </summary>
    let UV = _prefixId.prefix "UV"
    /// <summary>
    ///   <para>rdfs:label : X-Ray^^xsd:string</para>
    ///   <para>rdfs:comment :            Photon with an energy between 120 eV and 120 keV^^xsd:string</para>
    ///   <a href="http://www.ivoa.net/rdf/messenger#X-ray">ivoam:X-ray</a>
    /// </summary>
    let X_ray = _prefixId.prefix "X-ray"
