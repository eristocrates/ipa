namespace http.biohackathon.org.resource.faldo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module faldo =
    let _namespace_iri = Namespace_Iri faldo |> NamespaceIRI
    /// <summary>
    ///   <para>faldo:BagOfRegions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to describe a location that consists of a number of Regions but where the order is not known. e.g. the oddly named order() keyword in a INSDC file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bag of regions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#BagOfRegions">http://biohackathon.org/resource/faldo#BagOfRegions</seealso>
    let BagOfRegions = Prefixed_Name(faldo, "BagOfRegions") |> PrefixedName

    /// <summary>
    ///   <para>faldo:BothStrandsPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The 'both strands position' indicates a region that is best described as being on 'both' strands of a double-stranded sequence, rather than one or the other."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Both strands position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#BothStrandsPosition">http://biohackathon.org/resource/faldo#BothStrandsPosition</seealso>
    let BothStrandsPosition =
        Prefixed_Name(faldo, "BothStrandsPosition") |> PrefixedName

    /// <summary>
    ///   <para>faldo:C-TerminalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The C-terminus is the end of an amino acid chain (protein or polypeptide), terminated by a free carboxyl group (-COOH)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C-Terminal position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#C-TerminalPosition">http://biohackathon.org/resource/faldo#C-TerminalPosition</seealso>
    let C_TerminalPosition = Prefixed_Name(faldo, "C-TerminalPosition") |> PrefixedName

    /// <summary>
    ///   <para>faldo:CollectionOfRegions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sometimes a location of a feature is defined by a collection of regions e.g. join() and order() in INSDC records. One should always try to model the semantics more accurately than this, these are fallback options to encode legacy data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection of regions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#CollectionOfRegions">http://biohackathon.org/resource/faldo#CollectionOfRegions</seealso>
    let CollectionOfRegions =
        Prefixed_Name(faldo, "CollectionOfRegions") |> PrefixedName

    /// <summary>
    ///   <para>faldo:ExactPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A position that is exactly known."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exact position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#ExactPosition">http://biohackathon.org/resource/faldo#ExactPosition</seealso>
    let ExactPosition = Prefixed_Name(faldo, "ExactPosition") |> PrefixedName

    /// <summary>
    ///   <para>faldo:ForwardStrandPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position is on the forward (positive, 5' to 3') strand. Shown as a '+' in GFF3 and GTF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Forward/positive strand position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#ForwardStrandPosition">http://biohackathon.org/resource/faldo#ForwardStrandPosition</seealso>
    let ForwardStrandPosition =
        Prefixed_Name(faldo, "ForwardStrandPosition") |> PrefixedName

    /// <summary>
    ///   <para>faldo:FuzzyPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A position that lacks exact data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fuzzy position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#FuzzyPosition">http://biohackathon.org/resource/faldo#FuzzyPosition</seealso>
    let FuzzyPosition = Prefixed_Name(faldo, "FuzzyPosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:InBetweenPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This indicates that a feature is between two other positions that are both known exactly and that are next to each other. An example is a restriction enzyme cutting site. The cut is after one position and before the other position (hence, in between)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In between positions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#InBetweenPosition">http://biohackathon.org/resource/faldo#InBetweenPosition</seealso>
    let InBetweenPosition = Prefixed_Name(faldo, "InBetweenPosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:InRangePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use when you have an idea of the range in which you can find the position, but you cannot be sure about the exact position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Indeterminate position within a range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#InRangePosition">http://biohackathon.org/resource/faldo#InRangePosition</seealso>
    let InRangePosition = Prefixed_Name(faldo, "InRangePosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:ListOfRegions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Should be used when the location of a region is defined by an ordered list of Regions. However, try to avoid using these types in favor of using more explicit semantics about why the order is important."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"As an ordered list of regions (but the list might not be complete)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"List of regions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#ListOfRegions">http://biohackathon.org/resource/faldo#ListOfRegions</seealso>
    let ListOfRegions = Prefixed_Name(faldo, "ListOfRegions") |> PrefixedName
    /// <summary>
    ///   <para>faldo:N-TerminalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position of the starting amino-acid a protein or polypeptide terminated by an amino acid with a free amine group (-NH2). The convention for writing peptide sequences is to put the N-terminus on the left and write the sequence from N- to C-terminus. Instances of this class are often used when the reference sequence is not complete "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#N-TerminalPosition">http://biohackathon.org/resource/faldo#N-TerminalPosition</seealso>
    let N_TerminalPosition = Prefixed_Name(faldo, "N-TerminalPosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:OneOfPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position is known to be one of the more detailed positions listed by the location predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"One of positions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#OneOfPosition">http://biohackathon.org/resource/faldo#OneOfPosition</seealso>
    let OneOfPosition = Prefixed_Name(faldo, "OneOfPosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Superclass for the general concept of a position on a sequence. The sequence is designated with the reference predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#Position">http://biohackathon.org/resource/faldo#Position</seealso>
    let Position = Prefixed_Name(faldo, "Position") |> PrefixedName
    /// <summary>
    ///   <para>faldo:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region describes a length of sequence with a start position and end position that represents a feature on a sequence, e.g. a gene."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#Region">http://biohackathon.org/resource/faldo#Region</seealso>
    let Region = Prefixed_Name(faldo, "Region") |> PrefixedName

    /// <summary>
    ///   <para>faldo:ReverseStrandPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position is on the reverse (complement, 3' to 5') strand of the sequence. Shown as '-' in GTF and GFF3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Negative/reverse strand position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#ReverseStrandPosition">http://biohackathon.org/resource/faldo#ReverseStrandPosition</seealso>
    let ReverseStrandPosition =
        Prefixed_Name(faldo, "ReverseStrandPosition") |> PrefixedName

    /// <summary>
    ///   <para>faldo:StrandedPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of the coordinate system denoting on which strand the feature can be found. If you do not yet know which stand the feature is on, you should tag the position with just this class. If you know more you should use one of the subclasses. This means a region described with a '.' in GFF3. A GFF3 unstranded position does not have this type in FALDO -- those are just a 'position'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stranded position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#StrandedPosition">http://biohackathon.org/resource/faldo#StrandedPosition</seealso>
    let StrandedPosition = Prefixed_Name(faldo, "StrandedPosition") |> PrefixedName
    /// <summary>
    ///   <para>faldo:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This predicate is used when you want to describe a non-inclusive range. Only used in the InBetweenPosition to say it is after a nucleotide, but before the next one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"after"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#after">http://biohackathon.org/resource/faldo#after</seealso>
    let after = Prefixed_Name(faldo, "after") |> PrefixedName
    /// <summary>
    ///   <para>faldo:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This predicate is used to indicate that the feature is found before the exact position. Use to indicate, for example, a cleavage site. The cleavage happens between two amino acids before one and after the other."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"before"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#before">http://biohackathon.org/resource/faldo#before</seealso>
    let before = Prefixed_Name(faldo, "before") |> PrefixedName
    /// <summary>
    ///   <para>faldo:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The inclusive beginning of a position. Also known as start."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"begin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#begin">http://biohackathon.org/resource/faldo#begin</seealso>
    let begin_ = Prefixed_Name(faldo, "begin") |> PrefixedName
    /// <summary>
    ///   <para>faldo:beginOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse of the begin:property. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"beginOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#beginOf">http://biohackathon.org/resource/faldo#beginOf</seealso>
    let beginOf = Prefixed_Name(faldo, "beginOf") |> PrefixedName
    /// <summary>
    ///   <para>faldo:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inclusive end of the position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#end">http://biohackathon.org/resource/faldo#end</seealso>
    let end_ = Prefixed_Name(faldo, "end") |> PrefixedName
    /// <summary>
    ///   <para>faldo:endOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse of the begin:end. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#endOf">http://biohackathon.org/resource/faldo#endOf</seealso>
    let endOf = Prefixed_Name(faldo, "endOf") |> PrefixedName
    /// <summary>
    ///   <para>faldo:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This is the link between the concept whose location you are annotating and its range or position. For example, when annotating the region that describes an exon, the exon would be the subject and the region would be the object of the triple or: 'active site' 'location' [is] 'position 3'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#location">http://biohackathon.org/resource/faldo#location</seealso>
    let location = Prefixed_Name(faldo, "location") |> PrefixedName
    /// <summary>
    ///   <para>faldo:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Denoted in 1-based closed coordinates, i.e. the position on the first amino acid or nucleotide of a sequence has the value 1. For nucleotide sequences we count from the 5'end of the sequence, while for Aminoacid sequences we start counting from the N-Terminus."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The position value is the offset along the reference where this position is found. Thus the only the position value in combination with the reference determines where a position is."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#position">http://biohackathon.org/resource/faldo#position</seealso>
    let position = Prefixed_Name(faldo, "position") |> PrefixedName
    /// <summary>
    ///   <para>faldo:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference is the resource that the position value is anchored to.  For example, a contig or chromosome in a genome assembly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://biohackathon.org/resource/faldo#reference">http://biohackathon.org/resource/faldo#reference</seealso>
    let reference = Prefixed_Name(faldo, "reference") |> PrefixedName
