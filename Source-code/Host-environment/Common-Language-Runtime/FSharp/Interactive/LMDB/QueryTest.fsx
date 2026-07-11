(*



module adhoc =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "https://eristocrates.dev/ontology/adhoc/" }

    let _prefix (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.Replace(" ","_"))

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let knows = _prefix "knows"
    let name = _prefix "name"
    let age = _prefix "age"
    let lang = _prefix "lang"
    let created = _prefix "created"
    let weight = _prefix "weight"

    let Marko = _prefix "Marko"
    let Lop = _prefix "Lop"
    let Java = _prefix "Java"
    let Josh = _prefix "Josh"
    let Vadas = _prefix "Vadas"
    let Peter = _prefix "Peter"
    let Ripple = _prefix "Ripple"

    let Alice = _prefix "Alice"
    let Bob = _prefix "Bob"
    let Charlie = _prefix "Charlie"
    let Person = _prefix "Person"
    let Cat = _prefix "Cat"

































lmdb_read_write {
    let! current_transaction = lmdb_read_write.Current_Transaction
    let! marko = RDF_Literal.simple "marko"
    let! vadas = RDF_Literal.simple "vadas"
    let! lop = RDF_Literal.simple "lop"
    let! java = RDF_Literal.simple "java"
    let! josh = RDF_Literal.simple "josh"
    let! ripple = RDF_Literal.simple "ripple"
    let! peter = RDF_Literal.simple "peter"


    let! _27 = RDF_Literal.autotyped 27
    let! _29 = RDF_Literal.autotyped 29
    let! _32 = RDF_Literal.autotyped 32
    let! _35 = RDF_Literal.autotyped 35

    do! Assert.spod adhoc.Marko adhoc.name marko
    do! Assert.spod adhoc.Marko adhoc.age _29
    do! Assert.spod adhoc.Marko adhoc.knows adhoc.Vadas
    do! Assert.spod adhoc.Marko adhoc.knows adhoc.Josh

    do! Assert.spod adhoc.Vadas adhoc.name vadas
    do! Assert.spod adhoc.Vadas adhoc.age _27

    do! Assert.spod adhoc.Marko adhoc.created adhoc.Lop
    do! Assert.spod adhoc.Lop adhoc.name lop
    do! Assert.spod adhoc.Lop adhoc.lang adhoc.Java

    do! Assert.spod adhoc.Peter adhoc.name peter
    do! Assert.spod adhoc.Peter adhoc.age _35
    do! Assert.spod adhoc.Peter adhoc.created adhoc.Lop

    do! Assert.spod adhoc.Josh adhoc.name josh
    do! Assert.spod adhoc.Josh adhoc.age _32
    do! Assert.spod adhoc.Josh adhoc.created adhoc.Lop
    do! Assert.spod adhoc.Josh adhoc.created adhoc.Ripple

    do! Assert.spod adhoc.Ripple adhoc.name ripple
    do! Assert.spod adhoc.Ripple adhoc.lang adhoc.Java


}



let bgp = Graph_Pattern._p_g adhoc.name Graph_Name.default_graph_term
let g = Graph_Traversal.traversal_with_graph Graph_Name.default_graph_term

let bgp_results = lmdb_read_only { return! bgp |> Quad_Query.quads_by_pattern }

let traversal_results =
    lmdb_read_only {
        return!
            g
            |> Graph_Traversal.V [| adhoc.Marko |]
            |> Graph_Traversal.outE adhoc.knows
            |> Graph_Traversal.to_quads
    }


*)
