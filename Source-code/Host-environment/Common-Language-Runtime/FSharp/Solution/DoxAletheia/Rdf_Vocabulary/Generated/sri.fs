namespace https.w3id.org.sri.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sri =
    let _namespace_iri = Namespace_Iri sri |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:sri#Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This represents a building which is assessed."</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="https://w3id.org/sri#Building">https://w3id.org/sri#Building</seealso>
    let Building = Prefixed_Name(sri, "Building") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of technical domains."</para>
    /// labels<para>"Domain"</para></remarks>
    /// <seealso href="https://w3id.org/sri#Domain">https://w3id.org/sri#Domain</seealso>
    let Domain = Prefixed_Name(sri, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#FunctionalThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of instances in the functional hierarchy, this includes Domains and Services."</para>
    /// labels<para>"FunctionalThing"</para></remarks>
    /// <seealso href="https://w3id.org/sri#FunctionalThing">https://w3id.org/sri#FunctionalThing</seealso>
    let FunctionalThing = Prefixed_Name(sri, "FunctionalThing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of Impacts."</para>
    /// labels<para>"Impact"</para></remarks>
    /// <seealso href="https://w3id.org/sri#Impact">https://w3id.org/sri#Impact</seealso>
    let Impact = Prefixed_Name(sri, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#ImpactThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of all instances in the impact hierarchy, this includes Impacts and Key Capabilities."</para>
    /// labels<para>"ImpactThing"</para></remarks>
    /// <seealso href="https://w3id.org/sri#ImpactThing">https://w3id.org/sri#ImpactThing</seealso>
    let ImpactThing = Prefixed_Name(sri, "ImpactThing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#KeyCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of all Key Capabilities, aggregation of Impacts."</para>
    /// labels<para>"KeyCapability"</para></remarks>
    /// <seealso href="https://w3id.org/sri#KeyCapability">https://w3id.org/sri#KeyCapability</seealso>
    let KeyCapability = Prefixed_Name(sri, "KeyCapability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of service levels."</para>
    /// labels<para>"Level"</para></remarks>
    /// <seealso href="https://w3id.org/sri#Level">https://w3id.org/sri#Level</seealso>
    let Level = Prefixed_Name(sri, "Level") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for Services."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="https://w3id.org/sri#Service">https://w3id.org/sri#Service</seealso>
    let Service = Prefixed_Name(sri, "Service") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#ServiceCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Service Catalogue is a collection of services used in an assessment."</para>
    /// labels<para>"Service catalogue"</para></remarks>
    /// <seealso href="https://w3id.org/sri#ServiceCatalogue">https://w3id.org/sri#ServiceCatalogue</seealso>
    let ServiceCatalogue = Prefixed_Name(sri, "ServiceCatalogue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#ServiceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for all ServiceLevel instances, which are all allowed/defined combinations of Services and Levels."</para>
    /// labels<para>"Service level"</para></remarks>
    /// <seealso href="https://w3id.org/sri#ServiceLevel">https://w3id.org/sri#ServiceLevel</seealso>
    let ServiceLevel = Prefixed_Name(sri, "ServiceLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#adaptTheirOperationToTheNeedsOfTheOccupant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#KeyCapability</para>
    ///
    /// labels<para>"Adapt their operation to the needs of the occupant"</para></remarks>
    /// <seealso href="https://w3id.org/sri#adaptTheirOperationToTheNeedsOfTheOccupant">https://w3id.org/sri#adaptTheirOperationToTheNeedsOfTheOccupant</seealso>
    let adaptTheirOperationToTheNeedsOfTheOccupant =
        Prefixed_Name(sri, "adaptTheirOperationToTheNeedsOfTheOccupant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#adaptToSignalsFromTheGrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#KeyCapability</para>
    ///
    /// labels<para>"Adapt to signals from the grid"</para></remarks>
    /// <seealso href="https://w3id.org/sri#adaptToSignalsFromTheGrid">https://w3id.org/sri#adaptToSignalsFromTheGrid</seealso>
    let adaptToSignalsFromTheGrid =
        Prefixed_Name(sri, "adaptToSignalsFromTheGrid") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#additionalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Additional Level if share is &lt; 100%."</para>
    /// labels<para>"additional level"</para></remarks>
    /// <seealso href="https://w3id.org/sri#additionalLevel">https://w3id.org/sri#additionalLevel</seealso>
    let additionalLevel = Prefixed_Name(sri, "additionalLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates something to an assessment dataset."</para>
    /// labels<para>"assessment"</para></remarks>
    /// <seealso href="https://w3id.org/sri#assessment">https://w3id.org/sri#assessment</seealso>
    let assessment = Prefixed_Name(sri, "assessment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates something to a Building."</para>
    /// labels<para>"building"</para></remarks>
    /// <seealso href="https://w3id.org/sri#building">https://w3id.org/sri#building</seealso>
    let building = Prefixed_Name(sri, "building") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#comfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Impact</para>
    ///
    /// labels<para>"Comfort"</para></remarks>
    /// <seealso href="https://w3id.org/sri#comfort">https://w3id.org/sri#comfort</seealso>
    let comfort = Prefixed_Name(sri, "comfort") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#convenience</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Impact</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Convenience"</para></remarks>
    /// <seealso href="https://w3id.org/sri#convenience">https://w3id.org/sri#convenience</seealso>
    let convenience = Prefixed_Name(sri, "convenience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#cooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cooling"</para></remarks>
    /// <seealso href="https://w3id.org/sri#cooling">https://w3id.org/sri#cooling</seealso>
    let cooling = Prefixed_Name(sri, "cooling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Domain</para>
    ///
    /// labels<para>"Dynamic building envelope"</para></remarks>
    /// <seealso href="https://w3id.org/sri#dE">https://w3id.org/sri#dE</seealso>
    let dE = Prefixed_Name(sri, "dE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dHW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Domain</para>
    ///
    /// labels<para>"Domestic hot water"</para></remarks>
    /// <seealso href="https://w3id.org/sri#dHW">https://w3id.org/sri#dHW</seealso>
    let dHW = Prefixed_Name(sri, "dHW") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dsd-assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/sri#dsd-assessment">https://w3id.org/sri#dsd-assessment</seealso>
    let dsd_assessment = Prefixed_Name(sri, "dsd-assessment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dsd-scores</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/sri#dsd-scores">https://w3id.org/sri#dsd-scores</seealso>
    let dsd_scores = Prefixed_Name(sri, "dsd-scores") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dsd-sriscores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///
    /// labels<para>"SRI scores DSD"</para></remarks>
    /// <seealso href="https://w3id.org/sri#dsd-sriscores">https://w3id.org/sri#dsd-sriscores</seealso>
    let dsd_sriscores = Prefixed_Name(sri, "dsd-sriscores") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#dsd-weights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/sri#dsd-weights">https://w3id.org/sri#dsd-weights</seealso>
    let dsd_weights = Prefixed_Name(sri, "dsd-weights") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#eV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Domain</para>
    ///
    /// labels<para>"Electric vehicle charging"</para></remarks>
    /// <seealso href="https://w3id.org/sri#eV">https://w3id.org/sri#eV</seealso>
    let eV = Prefixed_Name(sri, "eV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Electricity"</para></remarks>
    /// <seealso href="https://w3id.org/sri#electricity">https://w3id.org/sri#electricity</seealso>
    let electricity = Prefixed_Name(sri, "electricity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#energy_efficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Impact</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Energy efficiency"</para></remarks>
    /// <seealso href="https://w3id.org/sri#energy_efficiency">https://w3id.org/sri#energy_efficiency</seealso>
    let energy_efficiency = Prefixed_Name(sri, "energy_efficiency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#energy_flexibility_and_storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Impact</para>
    ///
    /// labels<para>"Energy flexibility and storage"</para></remarks>
    /// <seealso href="https://w3id.org/sri#energy_flexibility_and_storage">https://w3id.org/sri#energy_flexibility_and_storage</seealso>
    let energy_flexibility_and_storage =
        Prefixed_Name(sri, "energy_flexibility_and_storage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relates something to a FunctionalThing."</para>
    /// labels<para>"function"</para></remarks>
    /// <seealso href="https://w3id.org/sri#function">https://w3id.org/sri#function</seealso>
    let function_ = Prefixed_Name(sri, "function") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#health_well_being_and_accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Impact</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Health well being and accessibility"</para></remarks>
    /// <seealso href="https://w3id.org/sri#health_well_being_and_accessibility">https://w3id.org/sri#health_well_being_and_accessibility</seealso>
    let health_well_being_and_accessibility =
        Prefixed_Name(sri, "health_well_being_and_accessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Heating"</para></remarks>
    /// <seealso href="https://w3id.org/sri#heating">https://w3id.org/sri#heating</seealso>
    let heating = Prefixed_Name(sri, "heating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#icscore</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The impact criterion score is defined for Services and calculated for Domains in Step 3."</para>
    /// labels<para>"impact criterion score"</para></remarks>
    /// <seealso href="https://w3id.org/sri#icscore">https://w3id.org/sri#icscore</seealso>
    let icscore = Prefixed_Name(sri, "icscore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relates something to an ImpactThing."</para>
    /// labels<para>"impact"</para></remarks>
    /// <seealso href="https://w3id.org/sri#impact">https://w3id.org/sri#impact</seealso>
    let impact = Prefixed_Name(sri, "impact") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#information_to_occupants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Impact</para>
    ///
    /// labels<para>"Information to occupants"</para></remarks>
    /// <seealso href="https://w3id.org/sri#information_to_occupants">https://w3id.org/sri#information_to_occupants</seealso>
    let information_to_occupants =
        Prefixed_Name(sri, "information_to_occupants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relates something to a Level."</para>
    /// labels<para>"level"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level">https://w3id.org/sri#level</seealso>
    let level = Prefixed_Name(sri, "level") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#level0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Level</para>
    ///
    /// labels<para>"Level 0"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level0">https://w3id.org/sri#level0</seealso>
    let level0 = Prefixed_Name(sri, "level0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#level1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Level</para>
    ///
    /// labels<para>"Level 1"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level1">https://w3id.org/sri#level1</seealso>
    let level1 = Prefixed_Name(sri, "level1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#level2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Level 2"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level2">https://w3id.org/sri#level2</seealso>
    let level2 = Prefixed_Name(sri, "level2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#level3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Level 3"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level3">https://w3id.org/sri#level3</seealso>
    let level3 = Prefixed_Name(sri, "level3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#level4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Level</para>
    ///
    /// labels<para>"Level 4"</para></remarks>
    /// <seealso href="https://w3id.org/sri#level4">https://w3id.org/sri#level4</seealso>
    let level4 = Prefixed_Name(sri, "level4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#lighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Domain</para>
    ///
    /// labels<para>"Lighting"</para></remarks>
    /// <seealso href="https://w3id.org/sri#lighting">https://w3id.org/sri#lighting</seealso>
    let lighting = Prefixed_Name(sri, "lighting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#mC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#Domain</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Monitoring and control"</para></remarks>
    /// <seealso href="https://w3id.org/sri#mC">https://w3id.org/sri#mC</seealso>
    let mC = Prefixed_Name(sri, "mC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#maintenance_and_fault_prediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Impact</para>
    ///
    /// labels<para>"Maintenance and fault prediction"</para></remarks>
    /// <seealso href="https://w3id.org/sri#maintenance_and_fault_prediction">https://w3id.org/sri#maintenance_and_fault_prediction</seealso>
    let maintenance_and_fault_prediction =
        Prefixed_Name(sri, "maintenance_and_fault_prediction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#max</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Maximum impact criterion score. This is defined for Domains and calculated in Step 4."</para>
    /// labels<para>"maximum impact criterion score"</para></remarks>
    /// <seealso href="https://w3id.org/sri#max">https://w3id.org/sri#max</seealso>
    let max = Prefixed_Name(sri, "max") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#optimiseEnergyEfficiencyAndOverallIn-UsePerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#KeyCapability</para>
    ///
    /// labels<para>"Optimise energy efficiency and overall in-use performance"</para></remarks>
    /// <seealso href="https://w3id.org/sri#optimiseEnergyEfficiencyAndOverallIn-UsePerformance">https://w3id.org/sri#optimiseEnergyEfficiencyAndOverallIn-UsePerformance</seealso>
    let optimiseEnergyEfficiencyAndOverallIn_UsePerformance =
        Prefixed_Name(sri, "optimiseEnergyEfficiencyAndOverallIn-UsePerformance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sri#score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The smart-readiness score is defined for ImpactThings on all levels from Impacts to the complete Building (Steps 5, 6, and 7) and optionally for Domains (Step 8)"</para>
    /// labels<para>"smart-readiness score"</para></remarks>
    /// <seealso href="https://w3id.org/sri#score">https://w3id.org/sri#score</seealso>
    let score = Prefixed_Name(sri, "score") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#serviceCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates something to a ServiceCatalogue."</para>
    /// labels<para>"service catalogue"</para></remarks>
    /// <seealso href="https://w3id.org/sri#serviceCatalogue">https://w3id.org/sri#serviceCatalogue</seealso>
    let serviceCatalogue = Prefixed_Name(sri, "serviceCatalogue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#share</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A percentage (value between 0.0 and 1.0) which expresses that parts of a building are assessed with different levels wrt. a Service. If share is &lt; 100% then additionalLevel has to be defined."</para>
    /// labels<para>"share"</para></remarks>
    /// <seealso href="https://w3id.org/sri#share">https://w3id.org/sri#share</seealso>
    let share = Prefixed_Name(sri, "share") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#topDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#FunctionalThing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"All domains"</para></remarks>
    /// <seealso href="https://w3id.org/sri#topDomain">https://w3id.org/sri#topDomain</seealso>
    let topDomain = Prefixed_Name(sri, "topDomain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#topImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:sri#ImpactThing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"All impacts"</para></remarks>
    /// <seealso href="https://w3id.org/sri#topImpact">https://w3id.org/sri#topImpact</seealso>
    let topImpact = Prefixed_Name(sri, "topImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#ventilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:sri#Domain</para>
    ///
    /// labels<para>"Ventilation"</para></remarks>
    /// <seealso href="https://w3id.org/sri#ventilation">https://w3id.org/sri#ventilation</seealso>
    let ventilation = Prefixed_Name(sri, "ventilation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sri#weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A weight of the weight matrix used for weighing the smart-readiness scores before aggregation."</para>
    /// labels<para>"weight"</para></remarks>
    /// <seealso href="https://w3id.org/sri#weight">https://w3id.org/sri#weight</seealso>
    let weight = Prefixed_Name(sri, "weight") |> PrefixedName
