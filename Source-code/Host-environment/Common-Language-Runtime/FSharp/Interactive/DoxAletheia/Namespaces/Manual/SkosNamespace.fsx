#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics


module skos =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://www.w3.org/2004/02/skos/core#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name = Lexical_Form.from_string local_name_string.low_lined transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ", "_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }
              
    let Collection = _prefix "Collection"
          

    
    let Concept = _prefix "Concept"
          

    
    let ConceptScheme = _prefix "ConceptScheme"
          

    
    let OrderedCollection = _prefix "OrderedCollection"
          

    
    let broadMatch = _prefix "broadMatch"
          

    
    let broaderTransitive = _prefix "broaderTransitive"
          

    
    let changeNote = _prefix "changeNote"
          

    
    let closeMatch = _prefix "closeMatch"
          

    
    let definition = _prefix "definition"
          

    
    let editorialNote = _prefix "editorialNote"
          

    
    let example = _prefix "example"
          

    
    let hasTopConcept = _prefix "hasTopConcept"
          

    
    let historyNote = _prefix "historyNote"
          

    
    let inScheme = _prefix "inScheme"
          

    
    let member = _prefix "member"
          

    
    let narrowMatch = _prefix "narrowMatch"
          

    
    let narrowerTransitive = _prefix "narrowerTransitive"
          

    
    let notation = _prefix "notation"
          

    
    let note = _prefix "note"
          

    
    let relatedMatch = _prefix "relatedMatch"
          

    
    let scopeNote = _prefix "scopeNote"
          

    
    let semanticRelation = _prefix "semanticRelation"
          

    
    let topConceptOf = _prefix "topConceptOf"
          

    /// A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.
    let prefLabel = _prefix "prefLabel"
          

    /// Broader concepts are typically rendered as parents in a concept hierarchy (tree).
    let broader = _prefix "broader"
          

    /// For any resource, every item in the list given as the value of the
///       skos:memberList property is also a value of the skos:member property.
    let memberList = _prefix "memberList"
          

    /// Narrower concepts are typically rendered as children in a concept hierarchy (tree).
    let narrower = _prefix "narrower"
          

    /// The range of skos:altLabel is the class of RDF plain literals.
    let altLabel = _prefix "altLabel"
          

    /// The range of skos:hiddenLabel is the class of RDF plain literals.
    let hiddenLabel = _prefix "hiddenLabel"
          

    /// The range of skos:prefLabel is the class of RDF plain literals.
    let prefLabel = _prefix "prefLabel"
          

    /// These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.
    let mappingRelation = _prefix "mappingRelation"
          

    /// skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.
    let exactMatch = _prefix "exactMatch"
          

    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
///       disjoint properties.
    let prefLabel = _prefix "prefLabel"
          

    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    let altLabel = _prefix "altLabel"
          

    /// skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.
    let hiddenLabel = _prefix "hiddenLabel"
          

    /// skos:related is disjoint with skos:broaderTransitive
    let related = _prefix "related"
          