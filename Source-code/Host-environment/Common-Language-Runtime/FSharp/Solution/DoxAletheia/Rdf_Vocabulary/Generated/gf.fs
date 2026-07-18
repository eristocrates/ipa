namespace http.def.seegrid.csiro.au.isotc211.iso19109._2005.feature.hash

open DoxAletheia.Rdf_Vocabulary

module gf =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#"
    /// <summary>
    /// In ISO 19156 the class GFI_Feature is defined as an instance of GF_FeatureType. In this OWL representation we do not have a specific class for GF_FeatureType because this would imply subclassing owl:Class which is inconsistent with OWL-DL restrictions.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#AnyFeature"></see></summary>
    let AnyFeature = Namespaced_IRI.parse _namespace_name "AnyFeature" |> NamespacedName
