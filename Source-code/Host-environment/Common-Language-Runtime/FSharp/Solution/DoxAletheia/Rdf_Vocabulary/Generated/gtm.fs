namespace https.www.goudatijdmachine.nl.def.hash

open DoxAletheia.Rdf_Vocabulary

module gtm =
    let _namespace_name = "https://www.goudatijdmachine.nl/def#"

    /// <summary>
    /// A geo-temporal object is an entity that has both geographical and temporal characteristics, enabling the specification and analysis of the location and time period of events or objects in space.
    /// <see href="https://www.goudatijdmachine.nl/def#GeoTemporeelObject"></see></summary>
    let GeoTemporeelObject =
        Namespaced_IRI.parse _namespace_name "GeoTemporeelObject" |> NamespacedName

    /// <summary>
    /// Addressing is the assignment of an address to a location, object, or entity within a geographic area, enabling it to be uniquely identified for postal and identification purposes.
    /// <see href="https://www.goudatijdmachine.nl/def#Adressering"></see></summary>
    let Adressering =
        Namespaced_IRI.parse _namespace_name "Adressering" |> NamespacedName

    /// <summary>
    /// Part of a municipality that is homogeneously demarcated on the basis of historical or urban development characteristics. Homogeneous means that one function is dominant, for example residential function (residential area), work function (industrial area) or recreational function (nature area). However, functions can also be mixed. The municipalities in the Netherlands are divided into districts and neighborhoods. Neighborhoods are the lowest regional level. Neighborhoods are sums of one or more contiguous neighborhoods. The municipality itself determines the division into districts and neighborhoods.
    /// <see href="https://www.goudatijdmachine.nl/def#Buurt"></see></summary>
    let Buurt = Namespaced_IRI.parse _namespace_name "Buurt" |> NamespacedName
    /// <summary>
    /// A structure is an organized collection of interconnected elements within a geographic area, such as a parcel, district, street, neighborhood, section, or place, that together form the physical and functional composition of a region.
    /// <see href="https://www.goudatijdmachine.nl/def#Structuur"></see></summary>
    let Structuur = Namespaced_IRI.parse _namespace_name "Structuur" |> NamespacedName

    /// <summary>
    /// A construction is a human-made or naturally created object or ensemble, which have a physical form and function within a specific area.
    /// <see href="https://www.goudatijdmachine.nl/def#Constructie"></see></summary>
    let Constructie =
        Namespaced_IRI.parse _namespace_name "Constructie" |> NamespacedName

    /// <summary>
    /// A building is the smallest functionally and architecturally-constructively independent unit that is directly and permanently connected to the earth and can be entered and locked.
    /// <see href="https://www.goudatijdmachine.nl/def#Gebouw"></see></summary>
    let Gebouw = Namespaced_IRI.parse _namespace_name "Gebouw" |> NamespacedName
    /// <summary>
    /// A work of art is a civil engineering work for the infrastructure of roads, water, railways, flood defenses and/or pipes and is not intended for permanent human residence.
    /// <see href="https://www.goudatijdmachine.nl/def#Kunstwerk"></see></summary>
    let Kunstwerk = Namespaced_IRI.parse _namespace_name "Kunstwerk" |> NamespacedName
    /// <summary>
    /// Nature is everything in the physical world that is not made by humans, including plants, trees, landscapes, waterways, and other elements of the Earth.
    /// <see href="https://www.goudatijdmachine.nl/def#Natuur"></see></summary>
    let Natuur = Namespaced_IRI.parse _namespace_name "Natuur" |> NamespacedName
    /// <summary>
    /// A partly private community intended for the needy, usually consisting of a number of houses around a small park.
    /// <see href="https://www.goudatijdmachine.nl/def#Hofje"></see></summary>
    let Hofje = Namespaced_IRI.parse _namespace_name "Hofje" |> NamespacedName
    /// <summary>
    /// A quarter is a part of a city or town that is often characterized by a specific function or population group, such as a residential, commercial, or entertainment area.
    /// <see href="https://www.goudatijdmachine.nl/def#Kwartier"></see></summary>
    let Kwartier = Namespaced_IRI.parse _namespace_name "Kwartier" |> NamespacedName

    /// <summary>
    /// One number issued per district.
    /// <see href="https://www.goudatijdmachine.nl/def#NummerAanduiding"></see></summary>
    let NummerAanduiding =
        Namespaced_IRI.parse _namespace_name "NummerAanduiding" |> NamespacedName

    /// <summary>
    /// Combination of the district letter and a number issued per district.
    /// <see href="https://www.goudatijdmachine.nl/def#PlaatselijkeAanduiding"></see></summary>
    let PlaatselijkeAanduiding =
        Namespaced_IRI.parse _namespace_name "PlaatselijkeAanduiding" |> NamespacedName

    /// <summary>
    /// A number issued per street.
    /// <see href="https://www.goudatijdmachine.nl/def#StraatNummerAanduiding"></see></summary>
    let StraatNummerAanduiding =
        Namespaced_IRI.parse _namespace_name "StraatNummerAanduiding" |> NamespacedName

    /// <summary>
    /// A plot is a limited part of Dutch territory that is cadastrally identified and bounded by cadastral boundaries.
    /// <see href="https://www.goudatijdmachine.nl/def#Perceel"></see></summary>
    let Perceel = Namespaced_IRI.parse _namespace_name "Perceel" |> NamespacedName

    /// <summary>
    /// A place is an inhabited location such as a city, town, or other settlement, where people live and work.
    /// <see href="https://www.goudatijdmachine.nl/def#PlaatsPlaats"></see></summary>
    let PlaatsPlaats =
        Namespaced_IRI.parse _namespace_name "PlaatsPlaats" |> NamespacedName

    /// <summary>
    /// The section that uniquely identifies the section within the cadastral municipality.
    /// <see href="https://www.goudatijdmachine.nl/def#Sectie"></see></summary>
    let Sectie = Namespaced_IRI.parse _namespace_name "Sectie" |> NamespacedName
    /// <summary>
    /// A street is a public road in a village, town, or other inhabited area. Streets are usually used by vehicles and pedestrians and can have houses, businesses, and other buildings on either side.
    /// <see href="https://www.goudatijdmachine.nl/def#Straat"></see></summary>
    let Straat = Namespaced_IRI.parse _namespace_name "Straat" |> NamespacedName
    /// <summary>
    /// Part of a municipality and cluster of one or more neighborhoods, which is homogeneously demarcated on the basis of historical or urban development characteristics. A district consists of one or more neighborhoods.
    /// <see href="https://www.goudatijdmachine.nl/def#Wijk"></see></summary>
    let Wijk = Namespaced_IRI.parse _namespace_name "Wijk" |> NamespacedName
    /// <summary>
    /// The property 'adresseert' (adresses) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.
    /// <see href="https://www.goudatijdmachine.nl/def#adresseert"></see></summary>
    let adresseert = Namespaced_IRI.parse _namespace_name "adresseert" |> NamespacedName
    /// <summary>
    /// The property 'heeft adres' (has address) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.
    /// <see href="https://www.goudatijdmachine.nl/def#heeftAdres"></see></summary>
    let heeftAdres = Namespaced_IRI.parse _namespace_name "heeftAdres" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.goudatijdmachine.nl/def#ligtIn"></see>
    /// </summary>
    let ligtIn = Namespaced_IRI.parse _namespace_name "ligtIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.goudatijdmachine.nl/def#ligtInStraat"></see>
    /// </summary>
    let ligtInStraat =
        Namespaced_IRI.parse _namespace_name "ligtInStraat" |> NamespacedName

    /// <summary>
    /// The property 'located in district' indicates that an neighbourhood is situated within a specific district, where a district is a defined area within a city or town.
    /// <see href="https://www.goudatijdmachine.nl/def#ligtInWijk"></see></summary>
    let ligtInWijk = Namespaced_IRI.parse _namespace_name "ligtInWijk" |> NamespacedName

    /// <summary>
    /// The property 'is located on parcel' indicates that an entity is situated on a specific parcel of land, where a parcel is a piece of land delineated for a specific purpose.
    /// <see href="https://www.goudatijdmachine.nl/def#staatOpPerceel"></see></summary>
    let staatOpPerceel =
        Namespaced_IRI.parse _namespace_name "staatOpPerceel" |> NamespacedName
