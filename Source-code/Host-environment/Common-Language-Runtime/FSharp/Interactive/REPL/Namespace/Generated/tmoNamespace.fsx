#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tmo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2001/sw/hcls/ns/transmed/" "tmo"

    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : HL7V3.0:ACTI^^xsd:string</para>
    ///   <para>dce:description : An active ingredient is a pharmaceutical ingredient that has the disposition to treat a certain disease.</para>
    ///   <para>rdfs:label : active ingredient</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0000">tmo:TMO_0000</a>
    /// </summary>
    let TMO_0000 = _prefixId.prefix "TMO_0000"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : medicare:drugs^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1705957^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : sider:drugs^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Pharmaceutical_Formulation^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : pharmgkb:Drug^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : drugbank:drugs^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : dailymed:drugs^^xsd:string</para>
    ///   <para>dce:description : A formulated pharmaceutical is a chemical substance whose granular parts include an active ingredient, an excipient, and possibly a stability regulator for the active ingredient.</para>
    ///   <para>rdfs:label : formulated pharmaceutical</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0001">tmo:TMO_0001</a>
    /// </summary>
    let TMO_0001 = _prefixId.prefix "TMO_0001"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1708062^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Finished_Pharmaceutical_Product^^xsd:string</para>
    ///   <para>dce:description : A pharmaceutical product is a formulated pharmaceutical that has been approved to treat patients.</para>
    ///   <para>rdfs:label : pharmaceutical product</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0002">tmo:TMO_0002</a>
    /// </summary>
    let TMO_0002 = _prefixId.prefix "TMO_0002"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : HL7V3.0:IACT^^xsd:string</para>
    ///   <para>dce:description : An inactive ingredient is a pharmaceutical ingredient that is part of a pharmaceutical formulation but does not have the disposition to treat a certain disease.</para>
    ///   <para>rdfs:label : inactive ingredient</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0003">tmo:TMO_0003</a>
    /// </summary>
    let TMO_0003 = _prefixId.prefix "TMO_0003"
    /// <summary>
    ///   <para>dce:description : An absent phenotype is a phenotype that represents the notable absence of a characteristic.</para>
    ///   <para>rdfs:label : absent phenotype</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0004">tmo:TMO_0004</a>
    /// </summary>
    let TMO_0004 = _prefixId.prefix "TMO_0004"
    /// <summary>
    ///   <para>dce:description : A genetic description is a description of the genetic composition of some entity.</para>
    ///   <para>rdfs:label : genetic description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0005">tmo:TMO_0005</a>
    /// </summary>
    let TMO_0005 = _prefixId.prefix "TMO_0005"
    /// <summary>
    ///   <para>dce:description : A role played by a material entity it being the subject of a study.</para>
    ///   <para>rdfs:label : subject role</para>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Target^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1521840^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0006">tmo:TMO_0006</a>
    /// </summary>
    let TMO_0006 = _prefixId.prefix "TMO_0006"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0033325^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Prognosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D011379^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Prognosis^^xsd:string</para>
    ///   <para>dce:description : A prognosis is a hypothesis about the likely course of a disease, the chance of recovery or recurrence.</para>
    ///   <para>obo:IAO_0000119 : NCI Thesaurus^^xsd:string</para>
    ///   <para>rdfs:label : prognosis</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0007">tmo:TMO_0007</a>
    /// </summary>
    let TMO_0007 = _prefixId.prefix "TMO_0007"
    /// <summary>
    ///   <para>dce:description : A patient role is a role played a human subject that receives medical attention, care or treatment or who is registered with a medical institution with the purpose of receiving medical care when necessary.</para>
    ///   <para>rdfs:label : patient role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0008">tmo:TMO_0008</a>
    /// </summary>
    let TMO_0008 = _prefixId.prefix "TMO_0008"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_clinical:Clinician^^xsd:string</para>
    ///   <para>dce:description : An medical expert role is a role played by a human in a clinical context who is involved in the assessment or administration of treatment or its results.</para>
    ///   <para>rdfs:label : medical expert role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0009">tmo:TMO_0009</a>
    /// </summary>
    let TMO_0009 = _prefixId.prefix "TMO_0009"
    /// <summary>
    ///   <para>dce:description : A biomedical measure is an information content entity that describes or is a measure of biomedically relevant entities.</para>
    ///   <para>rdfs:label : biomedical measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0010">tmo:TMO_0010</a>
    /// </summary>
    let TMO_0010 = _prefixId.prefix "TMO_0010"
    /// <summary>
    ///   <para>dce:description : A molecular structure description is a description of a molecule in terms of its composition and connectivity.</para>
    ///   <para>rdfs:label : molecular structure description</para>
    ///   <para>rdfs:comment : Examples: connection table, fragment, pharmacophore.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0011">tmo:TMO_0011</a>
    /// </summary>
    let TMO_0011 = _prefixId.prefix "TMO_0011"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:2364^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:patent^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D020490^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000313^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BRO:Patent^^xsd:string</para>
    ///   <para>rdfs:label : patent</para>
    ///   <para>dce:description : A patent is an information entity granted by a patent office which confers upon the patenter the sole right to make, use and sell an invention for a set period of time.</para>
    ///   <para>obo:IAO_0000119 : American Heritage(R) Stedman's Medical Dictionary^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0012">tmo:TMO_0012</a>
    /// </summary>
    let TMO_0012 = _prefixId.prefix "TMO_0012"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : An exclusion criterion for clinical trial is a clinical trial criterion which, if satisfied, supports the exclusion of candidate patients.</para>
    ///   <para>rdfs:label : exclusion criterion for clinical trial</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0013">tmo:TMO_0013</a>
    /// </summary>
    let TMO_0013 = _prefixId.prefix "TMO_0013"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A inclusion criterion for clinical trial is a clinical trial criterion which, if satisfied, supports the inclusion of candidate patients.</para>
    ///   <para>rdfs:label : inclusion criterion for clinical trial</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0014">tmo:TMO_0014</a>
    /// </summary>
    let TMO_0014 = _prefixId.prefix "TMO_0014"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A diagnostic result is a medical measure of determining the nature of a  problem or illness through medical procedure.</para>
    ///   <para>rdfs:label : diagnostic result</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0015">tmo:TMO_0015</a>
    /// </summary>
    let TMO_0015 = _prefixId.prefix "TMO_0015"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A clinical protocol is a directive information entity about the objective(s), design, methodology, statistical considerations, and organization of a clinical procedure.</para>
    ///   <para>rdfs:label : clinical protocol</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0016">tmo:TMO_0016</a>
    /// </summary>
    let TMO_0016 = _prefixId.prefix "TMO_0016"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000123^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0332120^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Evidence^^xsd:string</para>
    ///   <para>dce:description : Evidence is a group of indicators that are relevant in some decision-making process.</para>
    ///   <para>rdfs:label : evidence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0017">tmo:TMO_0017</a>
    /// </summary>
    let TMO_0017 = _prefixId.prefix "TMO_0017"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000123^^xsd:string</para>
    ///   <para>dce:description : An environmental description is a description concerning some aspect of a physical environment.</para>
    ///   <para>rdfs:label : environmental description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0018">tmo:TMO_0018</a>
    /// </summary>
    let TMO_0018 = _prefixId.prefix "TMO_0018"
    /// <summary>
    ///   <para>dce:description : A phenotype is an observable characteristic of an organism.</para>
    ///   <para>rdfs:label : phenotype</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0019">tmo:TMO_0019</a>
    /// </summary>
    let TMO_0019 = _prefixId.prefix "TMO_0019"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : pchr:Encounter^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0262926^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Personal_Medical_History^^xsd:string</para>
    ///   <para>dce:description : A personal medical history is a medical record consisting of a collection of information obtained from the patient and from other sources concerning the patient's health.</para>
    ///   <para>rdfs:label : personal medical history</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0020">tmo:TMO_0020</a>
    /// </summary>
    let TMO_0020 = _prefixId.prefix "TMO_0020"
    /// <summary>
    ///   <para>dce:description : A clinical trial protocol is a clinical protocol about the objective(s), design, methodology, statistical considerations, and organization of a clinical trial.</para>
    ///   <para>rdfs:label : clinical trial protocol</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0021">tmo:TMO_0021</a>
    /// </summary>
    let TMO_0021 = _prefixId.prefix "TMO_0021"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0311392^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:72670004^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Sign^^xsd:string</para>
    ///   <para>dce:description : A quality of a patient, a material entity that is part of a patient, or a processual entity that a patient participates in, any one of which is observed in a physical examination and is deemed by the clinician to be of clinical significance.</para>
    ///   <para>obo:IAO_0000119 : Richard Scheuermann, Werner Ceusters, Barry Smith in "Toward an Ontological Treatment of Disease and Diagnosis"^^xsd:string</para>
    ///   <para>rdfs:label : sign</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0022">tmo:TMO_0022</a>
    /// </summary>
    let TMO_0022 = _prefixId.prefix "TMO_0022"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1457887^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Symptom^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : CPR:symptom^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Symptom^^xsd:string</para>
    ///   <para>dce:description : A quality of a patient that is observed by the patient or a processual entity experienced by the patient, either of which is hypothesized by the patient to be a realization of a disease.</para>
    ///   <para>obo:IAO_0000119 : Richard Scheuermann, Werner Ceusters, Barry Smith in "Toward an Ontological Treatment of Disease and Diagnosis"^^xsd:string</para>
    ///   <para>rdfs:label : symptom</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0023">tmo:TMO_0023</a>
    /// </summary>
    let TMO_0023 = _prefixId.prefix "TMO_0023"
    /// <summary>
    ///   <para>dce:description : A medical measure is a measure that describes or is a measure of medically relevant entities.</para>
    ///   <para>rdfs:label : medical measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0024">tmo:TMO_0024</a>
    /// </summary>
    let TMO_0024 = _prefixId.prefix "TMO_0024"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:agency^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Institution^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:385437003^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:2085^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP76237-4^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Institution^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1272753^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : dailymed:organization^^xsd:string</para>
    ///   <para>dce:description : An institution is an entity created by legislation or by practice which acts legally in the same way as a person.</para>
    ///   <para>rdfs:label : institution</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0025">tmo:TMO_0025</a>
    /// </summary>
    let TMO_0025 = _prefixId.prefix "TMO_0025"
    /// <summary>
    ///   <para>dce:description : A regulatory authority is an institution created by legislation which acts to control what treatments can be prescribed.</para>
    ///   <para>rdfs:label : regulatory authority</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0026">tmo:TMO_0026</a>
    /// </summary>
    let TMO_0026 = _prefixId.prefix "TMO_0026"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C2348942^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Healthcare_Payer^^xsd:string</para>
    ///   <para>rdfs:label : institutional payer</para>
    ///   <para>rdfs:comment : This is, at the moment, a kind of institution because
    /// the payers are typically insurance companies or government bodies.
    /// But it is possible in some jurisdictions to pay for treatment oneself.
    /// Treat by renaming to "institutional payer". --CRB^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0027">tmo:TMO_0027</a>
    /// </summary>
    let TMO_0027 = _prefixId.prefix "TMO_0027"
    /// <summary>
    ///   <para>rdfs:label : market</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0028">tmo:TMO_0028</a>
    /// </summary>
    let TMO_0028 = _prefixId.prefix "TMO_0028"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP74341-6^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Study^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0947630^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_research:Study^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000471^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:224699009^^xsd:string</para>
    ///   <para>dce:description : A study is a planned process that consists of planning, study execution, documentation and the production of conclusion(s).</para>
    ///   <para>rdfs:label : study</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0029">tmo:TMO_0029</a>
    /// </summary>
    let TMO_0029 = _prefixId.prefix "TMO_0029"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:intervention^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_research:Intervention^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Intervention^^xsd:string</para>
    ///   <para>dce:description : An intervention is a study in which a substance is administered to a subject or group of subjects.</para>
    ///   <para>rdfs:label : intervention</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0030">tmo:TMO_0030</a>
    /// </summary>
    let TMO_0030 = _prefixId.prefix "TMO_0030"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Diagnosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Diagnosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000075^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_clinical:Diagnosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D003933^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0011900^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : FHHO:Diagnosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Diagnosis^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:439401001^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP72437-4^^xsd:string</para>
    ///   <para>obo:IAO_0000119 : NCI thesaurus^^xsd:string</para>
    ///   <para>dce:description : A diagnosis is a study composed of investigation, analysis and recognition of the presence and nature of disease, condition, or injury from expressed signs and symptoms; also, the scientific determination of any kind; the concise results of such an investigation.</para>
    ///   <para>rdfs:label : diagnosis</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0031">tmo:TMO_0031</a>
    /// </summary>
    let TMO_0031 = _prefixId.prefix "TMO_0031"
    /// <summary>
    ///   <para>rdfs:label : clinical trial</para>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : HL7V3.0:CLNTRL^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:110465008^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D016430^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Clinical_Trial^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:trials^^xsd:string</para>
    ///   <para>dce:description : A clinical trial is a study to assess the efficacy of a substance for the treatment of a condition.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0032">tmo:TMO_0032</a>
    /// </summary>
    let TMO_0032 = _prefixId.prefix "TMO_0032"
    /// <summary>
    ///   <para>dce:description : A drug measure is a biomedical measure that describes or is a measure of drugs or their activies.</para>
    ///   <para>rdfs:label : drug measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0033">tmo:TMO_0033</a>
    /// </summary>
    let TMO_0033 = _prefixId.prefix "TMO_0033"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : GRO:MolecularEntity^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : CHEBI:23367^^xsd:string</para>
    ///   <para>dce:description : Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.</para>
    ///   <para>rdfs:label : molecular entity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0034">tmo:TMO_0034</a>
    /// </summary>
    let TMO_0034 = _prefixId.prefix "TMO_0034"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : GRO:Protein^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ODGI:Protein^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:88878007^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Protein^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : CHEBI:36080^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:23^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : GO:0003675^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SO:0000358^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0033684^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Protein^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Protein^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : PRO:000000001^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : FMA:Protein^^xsd:string</para>
    ///   <para>dce:description : A biological macromolecule that is composed of amino acids linked in a linear sequence (a polypeptide chain).</para>
    ///   <para>rdfs:label : protein</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0035">tmo:TMO_0035</a>
    /// </summary>
    let TMO_0035 = _prefixId.prefix "TMO_0035"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : EFO:0000322^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0007600^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D002460^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Cell_Line^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:11036^^xsd:string</para>
    ///   <para>rdfs:label : cell line</para>
    ///   <para>dce:description : A cell line is a material entity that consists of a population of cells cultured in vitro that are descended through one or more generations (and possible sub-cultures) from a single primary culture which was originally derived from part of an organism.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0036">tmo:TMO_0036</a>
    /// </summary>
    let TMO_0036 = _prefixId.prefix "TMO_0036"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : diseasome:genes^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0017337^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:67271001^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : pharmgkb:Gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D005796^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SO:0000704^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : FMA:Structural_gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Gene_Object^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : GRO:Gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP32747-5^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : PRO:Gene^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NDFRT:C242394^^xsd:string</para>
    ///   <para>rdfs:label : gene</para>
    ///   <para>dce:description : A gene is a part of DNA that encodes information about other molecular entities.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0037">tmo:TMO_0037</a>
    /// </summary>
    let TMO_0037 = _prefixId.prefix "TMO_0037"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0752046^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SO:0000694^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Single_Nucleotide_Polymorphism^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D020641^^xsd:string</para>
    ///   <para>dce:description : A genotype with a single-nucleotide polymorphism (SNP). A SNP is a variation at a single nucleotide locus in the genomes of members of a species. For a variation to be considered a SNP, it must occur in at least 1% of the population.</para>
    ///   <para>rdfs:label : genotype with SNP</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0038">tmo:TMO_0038</a>
    /// </summary>
    let TMO_0038 = _prefixId.prefix "TMO_0038"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : SO:0001019^^xsd:string</para>
    ///   <para>dce:description : A genotype of which variants with a different number of copies of a sequence identifical region exist.</para>
    ///   <para>rdfs:label : genotype with copy number variation</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0039">tmo:TMO_0039</a>
    /// </summary>
    let TMO_0039 = _prefixId.prefix "TMO_0039"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:404204005^^xsd:string</para>
    ///   <para>dce:description : A drug-drug interaction is a drug interaction in which two drugs interact in such a way to produce an abnormal phenotypic event.</para>
    ///   <para>rdfs:label : drug-drug interaction</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0040">tmo:TMO_0040</a>
    /// </summary>
    let TMO_0040 = _prefixId.prefix "TMO_0040"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : NDFRT:C7812^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0242656^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D018450^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Disease_Progression^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000354^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>rdfs:label : disease progression</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0041">tmo:TMO_0041</a>
    /// </summary>
    let TMO_0041 = _prefixId.prefix "TMO_0041"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Mechanism_of_Action^^xsd:string</para>
    ///   <para>dce:description : The mechanism of action is a description of processes and behaviour of a biologically active molecule in its administration into a living system.</para>
    ///   <para>rdfs:label : mechanism of action</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0042">tmo:TMO_0042</a>
    /// </summary>
    let TMO_0042 = _prefixId.prefix "TMO_0042"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : sider:side_effects^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:406644009^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D004362^^xsd:string</para>
    ///   <para>dce:description : An adverse drug event is a any untoward medical occurrence in a patient or clinical investigation subject administered a pharmaceutical product and which does not necessarily have a causal relationship with this treatment. An adverse event (AE) can therefore be any unintended sign (including an abnormal laboratory finding), symptom,or disease temporally associated with the use of a medicinal (investigational) product, whether or not related to the medicinal (investigational) product.</para>
    ///   <para>obo:IAO_0000119 : CDISC glossary^^xsd:string</para>
    ///   <para>rdfs:label : adverse drug event</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0043">tmo:TMO_0043</a>
    /// </summary>
    let TMO_0043 = _prefixId.prefix "TMO_0043"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IEV:0000001^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Pathway^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : GRO:Pathway^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Pathway^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MI:0619^^xsd:string</para>
    ///   <para>obo:IAO_0000119 : NCI Thesaurus^^xsd:string</para>
    ///   <para>dce:description : A pathway is a representation of a set or series of interactions, often forming a network, which biologists have found useful to group together for organizational, historic, biophysical, or other reasons.</para>
    ///   <para>rdfs:label : pathway</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0044">tmo:TMO_0044</a>
    /// </summary>
    let TMO_0044 = _prefixId.prefix "TMO_0044"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000120^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : dcterms:AgentClass^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_research:Population^^xsd:string</para>
    ///   <para>dce:description : A population is a collection of organisms.</para>
    ///   <para>rdfs:label : population</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0045">tmo:TMO_0045</a>
    /// </summary>
    let TMO_0045 = _prefixId.prefix "TMO_0045"
    /// <summary>
    ///   <para>rdfs:label : arm of clinical study</para>
    ///   <para>dce:description : An arm of clinical study is a population that participates in a clinical trial and is subject to some intervention.</para>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:trial_arm_group^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000120^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0046">tmo:TMO_0046</a>
    /// </summary>
    let TMO_0046 = _prefixId.prefix "TMO_0046"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Disease^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP21006-9^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : DOID:4^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NDFRT:C2140^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : GRO:Disease^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : pharmgkb:Disease^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : diseasome:diseases^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0012634^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000155^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:11013^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:condition^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D004194^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Disease_or_Disorder^^xsd:string</para>
    ///   <para>dce:description : A quality of an organism which predisposes it to undergo pathological processes because of one or more disorders in that organism.</para>
    ///   <para>obo:IAO_0000119 : Richard Scheuermann, Werner Ceusters, Barry Smith in "Toward an Ontological Treatment of Disease and Diagnosis"^^xsd:string</para>
    ///   <para>rdfs:label : disease</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0047">tmo:TMO_0047</a>
    /// </summary>
    let TMO_0047 = _prefixId.prefix "TMO_0047"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : SO:0001023^^xsd:string</para>
    ///   <para>dce:description : An allele is a specific variant of a gene.</para>
    ///   <para>rdfs:label : allele</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0048">tmo:TMO_0048</a>
    /// </summary>
    let TMO_0048 = _prefixId.prefix "TMO_0048"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Metabolite^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : CHEBI:25212^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Metabolite^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP20702-4^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0870883^^xsd:string</para>
    ///   <para>dce:description : A metabolite role is the role played by a material entity that is a metabolic substrate, intermediate or product.</para>
    ///   <para>rdfs:label : metabolite role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0049">tmo:TMO_0049</a>
    /// </summary>
    let TMO_0049 = _prefixId.prefix "TMO_0049"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : Drug efficacy is a measure of the capabilty of a drug to produce an intended effect as a function of its concentration.</para>
    ///   <para>rdfs:label : drug efficacy</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0050">tmo:TMO_0050</a>
    /// </summary>
    let TMO_0050 = _prefixId.prefix "TMO_0050"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : Treatment safety is a condition that refers to an absence of harmful side effects resulting from use of the product and may be assessed by laboratory testing of biological samples, special tests and procedures, psychiatric evaluation, and/or physical examination of subjects.</para>
    ///   <para>obo:IAO_0000119 : NCI Thesaurus^^xsd:string</para>
    ///   <para>rdfs:label : treatment safety value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0051">tmo:TMO_0051</a>
    /// </summary>
    let TMO_0051 = _prefixId.prefix "TMO_0051"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1955886^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Biomarker^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D054316^^xsd:string</para>
    ///   <para>dce:description : A biomarker is a characteristic of a material entity that is objectively measured and evaluated as an indicator of normal biological processes, pathogenic processes, or pharmacologic responses to a therapeutic intervention.</para>
    ///   <para>rdfs:label : biomarker</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0052">tmo:TMO_0052</a>
    /// </summary>
    let TMO_0052 = _prefixId.prefix "TMO_0052"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:string</para>
    ///   <para>dce:description : Comparative effectiveness is a drug measure that provides information about which treatment works best, for whom, and under what circumstances.</para>
    ///   <para>rdfs:label : comparative effectiveness</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0053">tmo:TMO_0053</a>
    /// </summary>
    let TMO_0053 = _prefixId.prefix "TMO_0053"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:366925008^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Lifestyle^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:134436002^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D008019^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:367150003^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0023676^^xsd:string</para>
    ///   <para>dce:description : Lifestyle is a description about an individual`s manner of living.</para>
    ///   <para>rdfs:label : lifestyle</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0054">tmo:TMO_0054</a>
    /// </summary>
    let TMO_0054 = _prefixId.prefix "TMO_0054"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:primary_outcomes^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000121^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : linkedct:secondary_outcomes^^xsd:string</para>
    ///   <para>dce:description : A health outcome is a medical measure of health or loss of health.</para>
    ///   <para>rdfs:label : health outcome</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0055">tmo:TMO_0055</a>
    /// </summary>
    let TMO_0055 = _prefixId.prefix "TMO_0055"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0600688^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Toxicity^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:Q000633^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Toxicity^^xsd:string</para>
    ///   <para>dce:description : Toxicity is a quality of a chemical substance which indicates the capacity to cause injury to an organism in a dose dependent manner.</para>
    ///   <para>rdfs:label : toxicity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0056">tmo:TMO_0056</a>
    /// </summary>
    let TMO_0056 = _prefixId.prefix "TMO_0056"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Dose^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : EFO:0000428^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:260911001^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : LNC:LP6801-7^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0178602^^xsd:string</para>
    ///   <para>dce:description : Dosage is the amount of a chemical administered to, or taken by, an organism and expressed as some function of the organism and of time (mg/kg body weight/day).</para>
    ///   <para>rdfs:label : dosage</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0057">tmo:TMO_0057</a>
    /// </summary>
    let TMO_0057 = _prefixId.prefix "TMO_0057"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : ACGT:Syndrome^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : EFO:0000428^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:D013577^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C0039082^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : EFO:0000716^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Syndrome^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : DOID:225^^xsd:string</para>
    ///   <para>rdfs:label : syndrome</para>
    ///   <para>dce:description : A syndrome is a group of signs and symptoms that characterize a particular abnormality.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0058">tmo:TMO_0058</a>
    /// </summary>
    let TMO_0058 = _prefixId.prefix "TMO_0058"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1512571^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000074^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Hypothesis^^xsd:string</para>
    ///   <para>dce:description : A hypothesis is an information content entity that describes a possible correlation between two or more variables.</para>
    ///   <para>rdfs:label : hypothesis</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0059">tmo:TMO_0059</a>
    /// </summary>
    let TMO_0059 = _prefixId.prefix "TMO_0059"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : OCRe_clinical:Subject^^xsd:string</para>
    ///   <para>dce:description : A clinical subject role is the role played by an organism who is the subject of a clinical procedure or assessment.</para>
    ///   <para>rdfs:label : clinical subject role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0060">tmo:TMO_0060</a>
    /// </summary>
    let TMO_0060 = _prefixId.prefix "TMO_0060"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Side_Effect^^xsd:string</para>
    ///   <para>dce:description : A side effect is an effect of an intervention, whether therapeutic or adverse, that is secondary to the intended effect of the intervention.</para>
    ///   <para>rdfs:label : side effect</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0061">tmo:TMO_0061</a>
    /// </summary>
    let TMO_0061 = _prefixId.prefix "TMO_0061"
    /// <summary>
    ///   <para>dce:description : A pharmaceutical ingredient role is a role played by a chemical substance that is part of a pharmaceutical formulation.</para>
    ///   <para>rdfs:label : pharmaceutical ingredient role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0062">tmo:TMO_0062</a>
    /// </summary>
    let TMO_0062 = _prefixId.prefix "TMO_0062"
    /// <summary>
    ///   <para>dce:description : A chemical substance is a material entity consisting of many chemical entities and typically has connected boundaries.</para>
    ///   <para>rdfs:label : chemical substance</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0063">tmo:TMO_0063</a>
    /// </summary>
    let TMO_0063 = _prefixId.prefix "TMO_0063"
    /// <summary>
    ///   <para>dce:description : An active ingredient role is a role played by a chemical substance which has the disposition to treat a certain disease and is part of a pharmaceutical formulation.</para>
    ///   <para>rdfs:label : active ingredient role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0064">tmo:TMO_0064</a>
    /// </summary>
    let TMO_0064 = _prefixId.prefix "TMO_0064"
    /// <summary>
    ///   <para>dce:description : An inactive ingredient role is a role played by a chemical substance which is part of a pharmaceutical formulation but does not have the disposition to treat a certain disease.</para>
    ///   <para>rdfs:label : inactive ingredient role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0065">tmo:TMO_0065</a>
    /// </summary>
    let TMO_0065 = _prefixId.prefix "TMO_0065"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : drugbank:targets^^xsd:string</para>
    ///   <para>dce:description : A molecular target is a molecular entity that is the target of a transformation process.</para>
    ///   <para>rdfs:label : molecular target</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0066">tmo:TMO_0066</a>
    /// </summary>
    let TMO_0066 = _prefixId.prefix "TMO_0066"
    /// <summary>
    ///   <para>rdfs:label : protein target</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0067">tmo:TMO_0067</a>
    /// </summary>
    let TMO_0067 = _prefixId.prefix "TMO_0067"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A diagnostic criterion is a directive information entity for consideration during a diagnosis which, if satisfied, contributes to a diagnostic result</para>
    ///   <para>rdfs:label : diagnostic criterion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0068">tmo:TMO_0068</a>
    /// </summary>
    let TMO_0068 = _prefixId.prefix "TMO_0068"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A diagnostic inclusion criterion is a diagnostic criterion for consideration during a diagnosis which, if satisfied, supports a diagnostic result.</para>
    ///   <para>rdfs:label : diagnostic inclusion criterion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0069">tmo:TMO_0069</a>
    /// </summary>
    let TMO_0069 = _prefixId.prefix "TMO_0069"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : IAO:0000124^^xsd:string</para>
    ///   <para>dce:description : A diagnostic exclusion criterion is a diagnostic criterion for consideration during a diagnosis which, if satisfied, excludes a diagnostic result.</para>
    ///   <para>rdfs:label : diagnostic exclusion criterion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0070">tmo:TMO_0070</a>
    /// </summary>
    let TMO_0070 = _prefixId.prefix "TMO_0070"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : dailymed:ingredients^^xsd:string</para>
    ///   <para>dce:description : A pharmaceutical ingredient is a chemical substance that is part of a formulated pharmaceutical that bears a pharmaceutical ingredient role.</para>
    ///   <para>rdfs:label : pharmaceutical ingredient</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0071">tmo:TMO_0071</a>
    /// </summary>
    let TMO_0071 = _prefixId.prefix "TMO_0071"
    /// <summary>
    ///   <para>dce:description : A molecular target role is a role played by a chemical entity in which it is a specific target of an intervention that aims to change it behavior.</para>
    ///   <para>rdfs:label : molecular target role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0072">tmo:TMO_0072</a>
    /// </summary>
    let TMO_0072 = _prefixId.prefix "TMO_0072"
    /// <summary>
    ///   <para>dce:description : A chemical entity role is a role played by a chemical entity.</para>
    ///   <para>rdfs:label : chemical entity role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0073">tmo:TMO_0073</a>
    /// </summary>
    let TMO_0073 = _prefixId.prefix "TMO_0073"
    /// <summary>
    ///   <para>dce:description : An expert role is a role played by a knowledgeable person.</para>
    ///   <para>rdfs:label : expert role</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0074">tmo:TMO_0074</a>
    /// </summary>
    let TMO_0074 = _prefixId.prefix "TMO_0074"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000011^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:11021^^xsd:string</para>
    ///   <para>dce:description : A planned process is a process in which specific objectives are realized in a plan designed by some agent.</para>
    ///   <para>rdfs:label : planned process</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0075">tmo:TMO_0075</a>
    /// </summary>
    let TMO_0075 = _prefixId.prefix "TMO_0075"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : OBI:0000070^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : MSH:Q000032^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : Galen:Assay^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : cto_asyont:Assay^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : PATO:0000003^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : SNOMEDCT:272392009^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : EFO:0001455^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : NCIt:Assay^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : UMLS:C1510438^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : BIRNLex:11025^^xsd:string</para>
    ///   <para>rdfs:label : assay</para>
    ///   <para>dce:description : An assay is a planned process with the objective to obtain information about a material entity.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0076">tmo:TMO_0076</a>
    /// </summary>
    let TMO_0076 = _prefixId.prefix "TMO_0076"
    /// <summary>
    ///   <para>dce:description : A clinical trial criterion is a directive information entity which, if satisfied, contributes to the inclusion or exclusion of candidate patients.</para>
    ///   <para>rdfs:label : clinical trial criterion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0077">tmo:TMO_0077</a>
    /// </summary>
    let TMO_0077 = _prefixId.prefix "TMO_0077"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : drugbank:enzymes^^xsd:string</para>
    ///   <para>dce:description : An enzyme is a protein that catalyzes (increases the rate of) a chemical reaction.</para>
    ///   <para>rdfs:label : enzyme</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0078">tmo:TMO_0078</a>
    /// </summary>
    let TMO_0078 = _prefixId.prefix "TMO_0078"
    /// <summary>
    ///   <para>rdfs:label : in relation to</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0079">tmo:TMO_0079</a>
    /// </summary>
    let TMO_0079 = _prefixId.prefix "TMO_0079"
    /// <summary>
    ///   <para>dce:description : In this context, a genotype is a material entity made up of two DNA regions on two homologous chromosomes in a diploid cell. One chromosome is derived from the father and one is derived from the mother. The two DNA regions are located at the same genetic locus on each of the two chromosomes.</para>
    ///   <para>rdfs:label : genotype</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0080">tmo:TMO_0080</a>
    /// </summary>
    let TMO_0080 = _prefixId.prefix "TMO_0080"
    /// <summary>
    ///   <para>dce:description : A haplotype a variant DNA region which contains several smaller variant DNA regions which tend to be inherited together.</para>
    ///   <para>rdfs:label : haplotype</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0081">tmo:TMO_0081</a>
    /// </summary>
    let TMO_0081 = _prefixId.prefix "TMO_0081"
    /// <summary>
    ///   <para>dce:description : A gene variant is a variant of another gene based on some difference in sequence (composition and connectivity)</para>
    ///   <para>rdfs:label : gene variant</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0082">tmo:TMO_0082</a>
    /// </summary>
    let TMO_0082 = _prefixId.prefix "TMO_0082"
    /// <summary>
    ///   <para>dce:description : Ethinicity is the quality of an organism that describes membership in a social group based on a common heritage.</para>
    ///   <para>rdfs:label : ethnicity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0083">tmo:TMO_0083</a>
    /// </summary>
    let TMO_0083 = _prefixId.prefix "TMO_0083"
    /// <summary>
    ///   <para>rdfs:label : organismal quality</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0084">tmo:TMO_0084</a>
    /// </summary>
    let TMO_0084 = _prefixId.prefix "TMO_0084"
    /// <summary>
    ///   <para>dce:description : Age is the temporal quality of an organism that refers to the length of time elapsed since it came into existence. For most animals and humans, age refers to the length of time elapsed since birth.</para>
    ///   <para>rdfs:label : age</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0085">tmo:TMO_0085</a>
    /// </summary>
    let TMO_0085 = _prefixId.prefix "TMO_0085"
    /// <summary>
    ///   <para>dce:description : Sex is an quality that inheres in an organism for which sexual differentiation is required for sexual reproduction.</para>
    ///   <para>rdfs:label : sex</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0086">tmo:TMO_0086</a>
    /// </summary>
    let TMO_0086 = _prefixId.prefix "TMO_0086"
    /// <summary>
    ///   <para>dce:description : Male is a sex quality for which sex organs contain only male gametes</para>
    ///   <para>rdfs:label : male</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0087">tmo:TMO_0087</a>
    /// </summary>
    let TMO_0087 = _prefixId.prefix "TMO_0087"
    /// <summary>
    ///   <para>dce:description : Female is a sex quality for which sex organs contain only female gametes</para>
    ///   <para>rdfs:label : female</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0088">tmo:TMO_0088</a>
    /// </summary>
    let TMO_0088 = _prefixId.prefix "TMO_0088"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0089">tmo:TMO_0089</a>
    /// </summary>
    let TMO_0089 = _prefixId.prefix "TMO_0089"
    /// <summary>
    ///   <para>rdfs:label : process description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0090">tmo:TMO_0090</a>
    /// </summary>
    let TMO_0090 = _prefixId.prefix "TMO_0090"
    /// <summary>
    ///   <para>rdfs:label : temporal quality</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0091">tmo:TMO_0091</a>
    /// </summary>
    let TMO_0091 = _prefixId.prefix "TMO_0091"
    /// <summary>
    ///   <para>rdfs:label : comparative description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0092">tmo:TMO_0092</a>
    /// </summary>
    let TMO_0092 = _prefixId.prefix "TMO_0092"
    /// <summary>
    ///   <para>dce:description : A measure is an information content entity that describes or quantifies some thing.</para>
    ///   <para>rdfs:label : measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0093">tmo:TMO_0093</a>
    /// </summary>
    let TMO_0093 = _prefixId.prefix "TMO_0093"
    /// <summary>
    ///   <para>dce:description : A quantity is a quantitative measure of some feature.</para>
    ///   <para>rdfs:label : quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0094">tmo:TMO_0094</a>
    /// </summary>
    let TMO_0094 = _prefixId.prefix "TMO_0094"
    /// <summary>
    ///   <para>rdfs:label : toxic</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0095">tmo:TMO_0095</a>
    /// </summary>
    let TMO_0095 = _prefixId.prefix "TMO_0095"
    /// <summary>
    ///   <para>rdfs:label : non toxic</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0096">tmo:TMO_0096</a>
    /// </summary>
    let TMO_0096 = _prefixId.prefix "TMO_0096"
    /// <summary>
    ///   <para>rdfs:label : historical description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0097">tmo:TMO_0097</a>
    /// </summary>
    let TMO_0097 = _prefixId.prefix "TMO_0097"
    /// <summary>
    ///   <para>rdfs:label : medical history</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0098">tmo:TMO_0098</a>
    /// </summary>
    let TMO_0098 = _prefixId.prefix "TMO_0098"
    /// <summary>
    ///   <para>rdfs:label : numerical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0099">tmo:TMO_0099</a>
    /// </summary>
    let TMO_0099 = _prefixId.prefix "TMO_0099"
    /// <summary>
    ///   <para>dce:description : A functional quantity is a quantity obtained as a result of a function involving one or more parameters.</para>
    ///   <para>rdfs:label : functional quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0100">tmo:TMO_0100</a>
    /// </summary>
    let TMO_0100 = _prefixId.prefix "TMO_0100"
    /// <summary>
    ///   <para>rdfs:label : ranged numerical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0101">tmo:TMO_0101</a>
    /// </summary>
    let TMO_0101 = _prefixId.prefix "TMO_0101"
    /// <summary>
    ///   <para>rdfs:label : scale numerical value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0102">tmo:TMO_0102</a>
    /// </summary>
    let TMO_0102 = _prefixId.prefix "TMO_0102"
    /// <summary>
    ///   <para>dce:description : An enumerated numerical quantity is a numerical quantity selected from a discrete set of quantities.</para>
    ///   <para>rdfs:label : enumerated numerical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0103">tmo:TMO_0103</a>
    /// </summary>
    let TMO_0103 = _prefixId.prefix "TMO_0103"
    /// <summary>
    ///   <para>rdfs:label : unit of measurement</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0104">tmo:TMO_0104</a>
    /// </summary>
    let TMO_0104 = _prefixId.prefix "TMO_0104"
    /// <summary>
    ///   <para>dce:description : A multitude numerical quantity is a numerical quantity that indicates the number of individuals.</para>
    ///   <para>rdfs:label : multitude numerical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0105">tmo:TMO_0105</a>
    /// </summary>
    let TMO_0105 = _prefixId.prefix "TMO_0105"
    /// <summary>
    ///   <para>rdfs:label : physical description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0106">tmo:TMO_0106</a>
    /// </summary>
    let TMO_0106 = _prefixId.prefix "TMO_0106"
    /// <summary>
    ///   <para>rdfs:label : 3D molecular structure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0107">tmo:TMO_0107</a>
    /// </summary>
    let TMO_0107 = _prefixId.prefix "TMO_0107"
    /// <summary>
    ///   <para>rdfs:label : genetic variant</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0108">tmo:TMO_0108</a>
    /// </summary>
    let TMO_0108 = _prefixId.prefix "TMO_0108"
    /// <summary>
    ///   <para>rdfs:label : obsolete</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0109">tmo:TMO_0109</a>
    /// </summary>
    let TMO_0109 = _prefixId.prefix "TMO_0109"
    /// <summary>
    ///   <para>rdfs:label : statistical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0110">tmo:TMO_0110</a>
    /// </summary>
    let TMO_0110 = _prefixId.prefix "TMO_0110"
    /// <summary>
    ///   <para>rdfs:label : p-value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0111">tmo:TMO_0111</a>
    /// </summary>
    let TMO_0111 = _prefixId.prefix "TMO_0111"
    /// <summary>
    ///   <para>rdfs:label : e-value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0112">tmo:TMO_0112</a>
    /// </summary>
    let TMO_0112 = _prefixId.prefix "TMO_0112"
    /// <summary>
    ///   <para>rdfs:label : temporal functional quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0113">tmo:TMO_0113</a>
    /// </summary>
    let TMO_0113 = _prefixId.prefix "TMO_0113"
    /// <summary>
    ///   <para>rdfs:label : pharmacokinetic measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0114">tmo:TMO_0114</a>
    /// </summary>
    let TMO_0114 = _prefixId.prefix "TMO_0114"
    /// <summary>
    ///   <para>rdfs:label : pharmacodynamic measure</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0115">tmo:TMO_0115</a>
    /// </summary>
    let TMO_0115 = _prefixId.prefix "TMO_0115"
    /// <summary>
    ///   <para>rdfs:label : spatial positional datum</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0116">tmo:TMO_0116</a>
    /// </summary>
    let TMO_0116 = _prefixId.prefix "TMO_0116"
    /// <summary>
    ///   <para>dce:description : A magnitude of a genetic marker refers to the the significance of some genetic marker</para>
    ///   <para>rdfs:label : magnitude of a genetic marker</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0117">tmo:TMO_0117</a>
    /// </summary>
    let TMO_0117 = _prefixId.prefix "TMO_0117"
    /// <summary>
    ///   <para>dce:description : An indicator is an entity for which its observation/detection is used in some objective.</para>
    ///   <para>rdfs:label : indicator</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0118">tmo:TMO_0118</a>
    /// </summary>
    let TMO_0118 = _prefixId.prefix "TMO_0118"
    /// <summary>
    ///   <para>dce:description : A sequence position is a identifier for an item in a sequence of items and whose numeric value relates to the position of the item from the start of the sequence.</para>
    ///   <para>rdfs:label : sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0119">tmo:TMO_0119</a>
    /// </summary>
    let TMO_0119 = _prefixId.prefix "TMO_0119"
    /// <summary>
    ///   <para>rdfs:label : numerical quantity selected from a continuous variable</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0120">tmo:TMO_0120</a>
    /// </summary>
    let TMO_0120 = _prefixId.prefix "TMO_0120"
    /// <summary>
    ///   <para>rdfs:label : numerical quantity selected from a discrete variable</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0121">tmo:TMO_0121</a>
    /// </summary>
    let TMO_0121 = _prefixId.prefix "TMO_0121"
    /// <summary>
    ///   <para>dce:description : A chromosomal nucleotide sequence position is an ordinal number which reflects the position of a nucleotide in relation to the first nucleotide of the same chromosome.</para>
    ///   <para>rdfs:label : chromosomal sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0122">tmo:TMO_0122</a>
    /// </summary>
    let TMO_0122 = _prefixId.prefix "TMO_0122"
    /// <summary>
    ///   <para>dce:description : An amino acid sequence position indicates the position of an amino acid residue in relation to the start of the peptide chain.</para>
    ///   <para>rdfs:label : amino acid sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0123">tmo:TMO_0123</a>
    /// </summary>
    let TMO_0123 = _prefixId.prefix "TMO_0123"
    /// <summary>
    ///   <para>rdfs:label : human</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0124">tmo:TMO_0124</a>
    /// </summary>
    let TMO_0124 = _prefixId.prefix "TMO_0124"
    /// <summary>
    ///   <para>dce:description : A nucleotide sequence position indicates the position of a nucleotide residue in relation to the start of the nucleic acid.</para>
    ///   <para>rdfs:label : nucleotide sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0125">tmo:TMO_0125</a>
    /// </summary>
    let TMO_0125 = _prefixId.prefix "TMO_0125"
    /// <summary>
    ///   <para>dce:description : A dexoyribonucleotide sequence position is an ordinal number which reflects the position of a deoxyribonucleotide in relation to the first deoxyribonucleotide of the same deoxyribonucleic acid (DNA).</para>
    ///   <para>rdfs:label : deoxyribonucleotide sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0126">tmo:TMO_0126</a>
    /// </summary>
    let TMO_0126 = _prefixId.prefix "TMO_0126"
    /// <summary>
    ///   <para>dce:description : A ribonucleotide sequence position is an ordinal number which reflects the position of a ribonucleotide in relation to the first ribonucleotide of the same ribonucleic acid (RNA).</para>
    ///   <para>rdfs:label : ribonucleotide sequence position</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0127">tmo:TMO_0127</a>
    /// </summary>
    let TMO_0127 = _prefixId.prefix "TMO_0127"
    /// <summary>
    ///   <para>dce:description : A sequence is an ordered list of objects of a specified type.</para>
    ///   <para>rdfs:label : sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0128">tmo:TMO_0128</a>
    /// </summary>
    let TMO_0128 = _prefixId.prefix "TMO_0128"
    /// <summary>
    ///   <para>dce:description : An amino acid sequence is a sequence of amino acids in which a word (1 more more sequence of characters) represents an amino acid and their adjacency indicates their connectivity.</para>
    ///   <para>rdfs:label : protein sequencerdfs:label : amino acid sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0129">tmo:TMO_0129</a>
    /// </summary>
    let TMO_0129 = _prefixId.prefix "TMO_0129"
    /// <summary>
    ///   <para>dce:description : A nucleotide sequence is a sequence of nucleotides in which a word (1 more more sequence of characters) represents a nucleotide and their adjacency indicates their connectivity.</para>
    ///   <para>rdfs:label : nucleotide sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0130">tmo:TMO_0130</a>
    /// </summary>
    let TMO_0130 = _prefixId.prefix "TMO_0130"
    /// <summary>
    ///   <para>dce:description : a DNA sequence is a sequence of characters that represents the composition and connectivity of a a DNA molecule.</para>
    ///   <para>rdfs:label : DNA sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0131">tmo:TMO_0131</a>
    /// </summary>
    let TMO_0131 = _prefixId.prefix "TMO_0131"
    /// <summary>
    ///   <para>rdfs:label : RNA sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0132">tmo:TMO_0132</a>
    /// </summary>
    let TMO_0132 = _prefixId.prefix "TMO_0132"
    /// <summary>
    ///   <para>rdfs:label : single letter amino acid sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0133">tmo:TMO_0133</a>
    /// </summary>
    let TMO_0133 = _prefixId.prefix "TMO_0133"
    /// <summary>
    ///   <para>rdfs:label : three letter amino acid sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0134">tmo:TMO_0134</a>
    /// </summary>
    let TMO_0134 = _prefixId.prefix "TMO_0134"
    /// <summary>
    ///   <para>rdfs:label : medical description</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0135">tmo:TMO_0135</a>
    /// </summary>
    let TMO_0135 = _prefixId.prefix "TMO_0135"
    /// <summary>
    ///   <para>rdfs:label : medical finding</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0136">tmo:TMO_0136</a>
    /// </summary>
    let TMO_0136 = _prefixId.prefix "TMO_0136"
    /// <summary>
    ///   <para>dce:description : An identifier is an information content entity which consists of one or more symbols in order to identify some entity.</para>
    ///   <para>rdfs:label : identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0137">tmo:TMO_0137</a>
    /// </summary>
    let TMO_0137 = _prefixId.prefix "TMO_0137"
    /// <summary>
    ///   <para>dce:description : A genomic sequence is the collection of sequences that make up an individual's genetic matter.</para>
    ///   <para>rdfs:label : genomic sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0138">tmo:TMO_0138</a>
    /// </summary>
    let TMO_0138 = _prefixId.prefix "TMO_0138"
    /// <summary>
    ///   <para>dce:description : A collection of humans</para>
    ///   <para>rdfs:label : human population</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0139">tmo:TMO_0139</a>
    /// </summary>
    let TMO_0139 = _prefixId.prefix "TMO_0139"
    /// <summary>
    ///   <para>dce:description : A collection of humans from a particular region.</para>
    ///   <para>rdfs:label : regionally-defined human population</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0140">tmo:TMO_0140</a>
    /// </summary>
    let TMO_0140 = _prefixId.prefix "TMO_0140"
    /// <summary>
    ///   <para>dce:description : A reference genomic sequence is a genomic sequence that serves as a standard or reference, and may be composed by the consensus of the genomes of a number of individuals or parts thereof.</para>
    ///   <para>rdfs:label : reference genomic sequence</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0141">tmo:TMO_0141</a>
    /// </summary>
    let TMO_0141 = _prefixId.prefix "TMO_0141"
    /// <summary>
    ///   <para>rdfs:label : medical report</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0142">tmo:TMO_0142</a>
    /// </summary>
    let TMO_0142 = _prefixId.prefix "TMO_0142"
    /// <summary>
    ///   <para>rdfs:label : patient record</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0143">tmo:TMO_0143</a>
    /// </summary>
    let TMO_0143 = _prefixId.prefix "TMO_0143"
    /// <summary>
    ///   <para>rdfs:label : organism</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0144">tmo:TMO_0144</a>
    /// </summary>
    let TMO_0144 = _prefixId.prefix "TMO_0144"
    /// <summary>
    ///   <para>rdfs:label : mouse</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0145">tmo:TMO_0145</a>
    /// </summary>
    let TMO_0145 = _prefixId.prefix "TMO_0145"
    /// <summary>
    ///   <para>rdfs:label : physical quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0146">tmo:TMO_0146</a>
    /// </summary>
    let TMO_0146 = _prefixId.prefix "TMO_0146"
    /// <summary>
    ///   <para>rdfs:label : temporal quantity</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0147">tmo:TMO_0147</a>
    /// </summary>
    let TMO_0147 = _prefixId.prefix "TMO_0147"
    /// <summary>
    ///   <para>rdfs:label : time elapsed</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0148">tmo:TMO_0148</a>
    /// </summary>
    let TMO_0148 = _prefixId.prefix "TMO_0148"
    /// <summary>
    ///   <para>rdfs:label : mass value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0149">tmo:TMO_0149</a>
    /// </summary>
    let TMO_0149 = _prefixId.prefix "TMO_0149"
    /// <summary>
    ///   <para>rdfs:label : length value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0150">tmo:TMO_0150</a>
    /// </summary>
    let TMO_0150 = _prefixId.prefix "TMO_0150"
    /// <summary>
    ///   <para>rdfs:label : criterion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0151">tmo:TMO_0151</a>
    /// </summary>
    let TMO_0151 = _prefixId.prefix "TMO_0151"
    /// <summary>
    ///   <para>rdfs:label : chromosome</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0152">tmo:TMO_0152</a>
    /// </summary>
    let TMO_0152 = _prefixId.prefix "TMO_0152"
    /// <summary>
    ///   <para>rdfs:label : nucleotide residue</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0153">tmo:TMO_0153</a>
    /// </summary>
    let TMO_0153 = _prefixId.prefix "TMO_0153"
    /// <summary>
    ///   <para>rdfs:label : amino acid residue</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0154">tmo:TMO_0154</a>
    /// </summary>
    let TMO_0154 = _prefixId.prefix "TMO_0154"
    /// <summary>
    ///   <para>rdfs:label : nucleic acid region</para>
    ///   <para>rdfs:comment : A nucleic acid region is a part of a nucleic acid that is made up of a continous chain of nucleotide residues.</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0155">tmo:TMO_0155</a>
    /// </summary>
    let TMO_0155 = _prefixId.prefix "TMO_0155"
    /// <summary>
    ///   <para>rdfs:label : dsDNA</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0156">tmo:TMO_0156</a>
    /// </summary>
    let TMO_0156 = _prefixId.prefix "TMO_0156"
    /// <summary>
    ///   <para>dce:description : A chromosome number is an identifier for a chromosome that identifies it from a collection of chromosomes for a given organism.</para>
    ///   <para>rdfs:label : chromosome number</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0157">tmo:TMO_0157</a>
    /// </summary>
    let TMO_0157 = _prefixId.prefix "TMO_0157"
    /// <summary>
    ///   <para>dce:description : An item in a collection identifier is an identifier for an entity that is a member of a collection.</para>
    ///   <para>rdfs:label : item in collection identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0158">tmo:TMO_0158</a>
    /// </summary>
    let TMO_0158 = _prefixId.prefix "TMO_0158"
    /// <summary>
    ///   <para>dce:description : An item in a collection identifier is an identifier for an entity that is a member of an ordered sequence of items (based on some attribute).</para>
    ///   <para>rdfs:label : item in sequence identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0159">tmo:TMO_0159</a>
    /// </summary>
    let TMO_0159 = _prefixId.prefix "TMO_0159"
    /// <summary>
    ///   <para>rdfs:label : snp identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0161">tmo:TMO_0161</a>
    /// </summary>
    let TMO_0161 = _prefixId.prefix "TMO_0161"
    /// <summary>
    ///   <para>rdfs:label : ncbi reference snp identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0162">tmo:TMO_0162</a>
    /// </summary>
    let TMO_0162 = _prefixId.prefix "TMO_0162"
    /// <summary>
    ///   <para>rdfs:label : ncbi submitter snp identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0163">tmo:TMO_0163</a>
    /// </summary>
    let TMO_0163 = _prefixId.prefix "TMO_0163"
    /// <summary>
    ///   <para>rdfs:label : organization</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0164">tmo:TMO_0164</a>
    /// </summary>
    let TMO_0164 = _prefixId.prefix "TMO_0164"
    /// <summary>
    ///   <para>rdfs:label : gene symbol</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0165">tmo:TMO_0165</a>
    /// </summary>
    let TMO_0165 = _prefixId.prefix "TMO_0165"
    /// <summary>
    ///   <para>dce:description : In a group of allelic variants in a population, the ancestral allele is the allele from which all other allelic variants are believed to have descended from during phylogeny.</para>
    ///   <para>rdfs:label : ancestral allele</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0166">tmo:TMO_0166</a>
    /// </summary>
    let TMO_0166 = _prefixId.prefix "TMO_0166"
    /// <summary>
    ///   <para>rdfs:label : nucleic acid</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0167">tmo:TMO_0167</a>
    /// </summary>
    let TMO_0167 = _prefixId.prefix "TMO_0167"
    /// <summary>
    ///   <para>rdfs:label : molecular complex</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0168">tmo:TMO_0168</a>
    /// </summary>
    let TMO_0168 = _prefixId.prefix "TMO_0168"
    /// <summary>
    ///   <para>rdfs:label : date</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0169">tmo:TMO_0169</a>
    /// </summary>
    let TMO_0169 = _prefixId.prefix "TMO_0169"
    /// <summary>
    ///   <para>rdfs:label : publication date</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0170">tmo:TMO_0170</a>
    /// </summary>
    let TMO_0170 = _prefixId.prefix "TMO_0170"
    /// <summary>
    ///   <para>rdfs:label : gene name</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0171">tmo:TMO_0171</a>
    /// </summary>
    let TMO_0171 = _prefixId.prefix "TMO_0171"
    /// <summary>
    ///   <para>rdfs:label : variant DNA region</para>
    ///   <para>rdfs:comment : A variant DNA region is a DNA region of which variants with altered sequence exist in different individuals of the same species or in different samples of the same individual (e.g., genetic variation within an individual, such as mutations in a cancerous tumor). The number of nucleotide residues in different variants can differ (e.g., because of insertions and deletions).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0172">tmo:TMO_0172</a>
    /// </summary>
    let TMO_0172 = _prefixId.prefix "TMO_0172"
    /// <summary>
    ///   <para>rdfs:label : insertion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0173">tmo:TMO_0173</a>
    /// </summary>
    let TMO_0173 = _prefixId.prefix "TMO_0173"
    /// <summary>
    ///   <para>rdfs:label : deletion</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0174">tmo:TMO_0174</a>
    /// </summary>
    let TMO_0174 = _prefixId.prefix "TMO_0174"
    /// <summary>
    ///   <para>rdfs:label : invariant nucleic acid region</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0175">tmo:TMO_0175</a>
    /// </summary>
    let TMO_0175 = _prefixId.prefix "TMO_0175"
    /// <summary>
    ///   <para>rdfs:label : pharmgkb sample identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0176">tmo:TMO_0176</a>
    /// </summary>
    let TMO_0176 = _prefixId.prefix "TMO_0176"
    /// <summary>
    ///   <para>rdfs:label : age</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0178">tmo:TMO_0178</a>
    /// </summary>
    let TMO_0178 = _prefixId.prefix "TMO_0178"
    /// <summary>
    ///   <para>rdfs:label : age in years</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0179">tmo:TMO_0179</a>
    /// </summary>
    let TMO_0179 = _prefixId.prefix "TMO_0179"
    /// <summary>
    ///   <para>rdfs:label : weight in kilograms</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0180">tmo:TMO_0180</a>
    /// </summary>
    let TMO_0180 = _prefixId.prefix "TMO_0180"
    /// <summary>
    ///   <para>rdfs:label : height in centimeters</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0181">tmo:TMO_0181</a>
    /// </summary>
    let TMO_0181 = _prefixId.prefix "TMO_0181"
    /// <summary>
    ///   <para>rdfs:label : centimeter</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0182">tmo:TMO_0182</a>
    /// </summary>
    let TMO_0182 = _prefixId.prefix "TMO_0182"
    /// <summary>
    ///   <para>rdfs:label : kilogram</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0183">tmo:TMO_0183</a>
    /// </summary>
    let TMO_0183 = _prefixId.prefix "TMO_0183"
    /// <summary>
    ///   <para>rdfs:label : year</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0184">tmo:TMO_0184</a>
    /// </summary>
    let TMO_0184 = _prefixId.prefix "TMO_0184"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0185">tmo:TMO_0185</a>
    /// </summary>
    let TMO_0185 = _prefixId.prefix "TMO_0185"
    /// <summary>
    ///   <para>rdfs:label : has unit</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0186">tmo:TMO_0186</a>
    /// </summary>
    let TMO_0186 = _prefixId.prefix "TMO_0186"
    /// <summary>
    ///   <para>rdfs:label : mass per unit time</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0188">tmo:TMO_0188</a>
    /// </summary>
    let TMO_0188 = _prefixId.prefix "TMO_0188"
    /// <summary>
    ///   <para>rdfs:label : milligram per week</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0189">tmo:TMO_0189</a>
    /// </summary>
    let TMO_0189 = _prefixId.prefix "TMO_0189"
    /// <summary>
    ///   <para>rdfs:label : dose</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0190">tmo:TMO_0190</a>
    /// </summary>
    let TMO_0190 = _prefixId.prefix "TMO_0190"
    /// <summary>
    ///   <para>rdfs:label : dose in milligram per week</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0191">tmo:TMO_0191</a>
    /// </summary>
    let TMO_0191 = _prefixId.prefix "TMO_0191"
    /// <summary>
    ///   <para>rdfs:label : ratio</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0192">tmo:TMO_0192</a>
    /// </summary>
    let TMO_0192 = _prefixId.prefix "TMO_0192"
    /// <summary>
    ///   <para>rdfs:label : International Normalized Ratio on the Therapeutic Dose of Warfarin</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0193">tmo:TMO_0193</a>
    /// </summary>
    let TMO_0193 = _prefixId.prefix "TMO_0193"
    /// <summary>
    ///   <para>rdfs:label : medical descriptor</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0194">tmo:TMO_0194</a>
    /// </summary>
    let TMO_0194 = _prefixId.prefix "TMO_0194"
    /// <summary>
    ///   <para>dce:description : Smoker status is a medical descriptor of the tobacco smoking behaviour of a person.</para>
    ///   <para>rdfs:label : smoker status</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0195">tmo:TMO_0195</a>
    /// </summary>
    let TMO_0195 = _prefixId.prefix "TMO_0195"
    /// <summary>
    ///   <para>rdfs:label : has attribute</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0196">tmo:TMO_0196</a>
    /// </summary>
    let TMO_0196 = _prefixId.prefix "TMO_0196"
    /// <summary>
    ///   <para>rdfs:label : pharmgkb subject identifier</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0197">tmo:TMO_0197</a>
    /// </summary>
    let TMO_0197 = _prefixId.prefix "TMO_0197"
    /// <summary>
    ///   <para>rdfs:label : race</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0198">tmo:TMO_0198</a>
    /// </summary>
    let TMO_0198 = _prefixId.prefix "TMO_0198"
    /// <summary>
    ///   <para>dce:description : A short acronym identifying a sample population that was examined by the HapMap project.</para>
    ///   <para>rdfs:label : HapMap population name abbreviation </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0199">tmo:TMO_0199</a>
    /// </summary>
    let TMO_0199 = _prefixId.prefix "TMO_0199"
    let TMO_0200 = _prefixId.prefix "TMO_0200"
    let TMO_0201 = _prefixId.prefix "TMO_0201"
    let TMO_0202 = _prefixId.prefix "TMO_0202"
    let TMO_0203 = _prefixId.prefix "TMO_0203"
    let TMO_0204 = _prefixId.prefix "TMO_0204"
    let TMO_0205 = _prefixId.prefix "TMO_0205"
    let TMO_0206 = _prefixId.prefix "TMO_0206"
    let TMO_0207 = _prefixId.prefix "TMO_0207"
    let TMO_0208 = _prefixId.prefix "TMO_0208"
    let TMO_0209 = _prefixId.prefix "TMO_0209"
    let TMO_0210 = _prefixId.prefix "TMO_0210"
    let TMO_0211 = _prefixId.prefix "TMO_0211"
    let TMO_0212 = _prefixId.prefix "TMO_0212"
    let TMO_0213 = _prefixId.prefix "TMO_0213"
    let TMO_0214 = _prefixId.prefix "TMO_0214"
    /// <summary>
    ///   <para>rdfs:label : DNA region</para>
    ///   <para>rdfs:comment : A DNA region is a part of a DNA molecule that is made up of a continous chain of deoxyribonucleotide residues.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0215">tmo:TMO_0215</a>
    /// </summary>
    let TMO_0215 = _prefixId.prefix "TMO_0215"
    let TMO_0216 = _prefixId.prefix "TMO_0216"
    /// <summary>
    ///   <para>rdfs:label : genetic status </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0217">tmo:TMO_0217</a>
    /// </summary>
    let TMO_0217 = _prefixId.prefix "TMO_0217"
    /// <summary>
    ///   <para>rdfs:label : companion diagnostic role </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0218">tmo:TMO_0218</a>
    /// </summary>
    let TMO_0218 = _prefixId.prefix "TMO_0218"
    /// <summary>
    ///   <para>rdfs:label : genetic test</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0219">tmo:TMO_0219</a>
    /// </summary>
    let TMO_0219 = _prefixId.prefix "TMO_0219"
    /// <summary>
    ///   <para>rdfs:label : DNA</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0220">tmo:TMO_0220</a>
    /// </summary>
    let TMO_0220 = _prefixId.prefix "TMO_0220"
    /// <summary>
    ///   <para>rdfs:label : diagnostic role </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0221">tmo:TMO_0221</a>
    /// </summary>
    let TMO_0221 = _prefixId.prefix "TMO_0221"
    /// <summary>
    ///   <para>rdfs:label : provides supporting evidence for </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0222">tmo:TMO_0222</a>
    /// </summary>
    let TMO_0222 = _prefixId.prefix "TMO_0222"
    let TMO_0223 = _prefixId.prefix "TMO_0223"
    /// <summary>
    ///   <para>rdfs:label : is described by </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0224">tmo:TMO_0224</a>
    /// </summary>
    let TMO_0224 = _prefixId.prefix "TMO_0224"
    /// <summary>
    ///   <para>dce:description : A genotype of which variants exist that differ though an insertion, deletion or a combination thereof.</para>
    ///   <para>rdfs:label : genotype with indel variation</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0225">tmo:TMO_0225</a>
    /// </summary>
    let TMO_0225 = _prefixId.prefix "TMO_0225"
    /// <summary>
    ///   <para>rdfs:label : genotype with short tandem repeat variation</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0226">tmo:TMO_0226</a>
    /// </summary>
    let TMO_0226 = _prefixId.prefix "TMO_0226"
    /// <summary>
    ///   <para>dce:description : A genotype with a multiple-nucleotide polymorphism (MNP). An MNP is a variation of several adjacent nucleotides in the genomes of members of a species. For a variation to be considered an MNP, it must occur in at least 1% of the population.</para>
    ///   <para>rdfs:label : genotype with multiple nucleotide polymorphism</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0227">tmo:TMO_0227</a>
    /// </summary>
    let TMO_0227 = _prefixId.prefix "TMO_0227"
    /// <summary>
    ///   <para>rdfs:label : molecular entity part</para>
    ///   <para>rdfs:comment : A part of a molecular entity or a set of molecular entities. It can be made up of several non-connected sub-parts, potentially on separate molecular entities.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0228">tmo:TMO_0228</a>
    /// </summary>
    let TMO_0228 = _prefixId.prefix "TMO_0228"
    /// <summary>
    ///   <para>dce:description : A genotype containing one matching allele on each chromosome (e.g., CYP2C9*1/*3)</para>
    ///   <para>rdfs:label : genotype with allele </para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0229">tmo:TMO_0229</a>
    /// </summary>
    let TMO_0229 = _prefixId.prefix "TMO_0229"
    /// <summary>
    ///   <para>http://www.geneontology.org/formats/oboInOwl#hasDbXref : pharmgkb:Association^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : pharmgkb:DrugGeneVariantInteraction^^xsd:stringhttp://www.geneontology.org/formats/oboInOwl#hasDbXref : drugbank:drug_interactions^^xsd:string</para>
    ///   <para>dce:description : A drug interaction is a process in which a drug interacts with a living system in such a way that it affects its behaviour.</para>
    ///   <para>rdfs:label : drug interaction</para>
    ///   <a href="http://www.w3.org/2001/sw/hcls/ns/transmed/TMO_0304">tmo:TMO_0304</a>
    /// </summary>
    let TMO_0304 = _prefixId.prefix "TMO_0304"
    let tmo = _prefixId.prefix "tmo"
