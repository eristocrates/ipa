#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module faldo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://biohackathon.org/resource/faldo#" "faldo"

    /// <summary>
    ///   <para>rdfs:label : Bag of regions^^xsd:string</para>
    ///   <para>rdfs:comment : Used to describe a location that consists of a number of Regions but where the order is not known. e.g. the oddly named order() keyword in a INSDC file.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#BagOfRegions">faldo:BagOfRegions</a>
    /// </summary>
    let BagOfRegions = _prefixId.prefix "BagOfRegions"
    /// <summary>
    ///   <para>rdfs:label : Both strands position^^xsd:string</para>
    ///   <para>rdfs:comment : The 'both strands position' indicates a region that is best described as being on 'both' strands of a double-stranded sequence, rather than one or the other.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#BothStrandsPosition">faldo:BothStrandsPosition</a>
    /// </summary>
    let BothStrandsPosition = _prefixId.prefix "BothStrandsPosition"
    /// <summary>
    ///   <para>rdfs:label : C-Terminal position^^xsd:string</para>
    ///   <para>rdfs:comment : The C-terminus is the end of an amino acid chain (protein or polypeptide), terminated by a free carboxyl group (-COOH).^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#C-TerminalPosition">faldo:C-TerminalPosition</a>
    /// </summary>
    let C_TerminalPosition = _prefixId.prefix "C-TerminalPosition"
    /// <summary>
    ///   <para>rdfs:label : Collection of regions^^xsd:string</para>
    ///   <para>rdfs:comment : Sometimes a location of a feature is defined by a collection of regions e.g. join() and order() in INSDC records. One should always try to model the semantics more accurately than this, these are fallback options to encode legacy data.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#CollectionOfRegions">faldo:CollectionOfRegions</a>
    /// </summary>
    let CollectionOfRegions = _prefixId.prefix "CollectionOfRegions"
    /// <summary>
    ///   <para>rdfs:label : Exact position^^xsd:string</para>
    ///   <para>rdfs:comment : A position that is exactly known.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#ExactPosition">faldo:ExactPosition</a>
    /// </summary>
    let ExactPosition = _prefixId.prefix "ExactPosition"
    /// <summary>
    ///   <para>rdfs:label : Forward/positive strand position^^xsd:string</para>
    ///   <para>rdfs:comment : The position is on the forward (positive, 5' to 3') strand. Shown as a '+' in GFF3 and GTF.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#ForwardStrandPosition">faldo:ForwardStrandPosition</a>
    /// </summary>
    let ForwardStrandPosition = _prefixId.prefix "ForwardStrandPosition"
    /// <summary>
    ///   <para>rdfs:label : Fuzzy position^^xsd:string</para>
    ///   <para>rdfs:comment : A position that lacks exact data.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#FuzzyPosition">faldo:FuzzyPosition</a>
    /// </summary>
    let FuzzyPosition = _prefixId.prefix "FuzzyPosition"
    /// <summary>
    ///   <para>rdfs:label : In between positions^^xsd:string</para>
    ///   <para>rdfs:comment : This indicates that a feature is between two other positions that are both known exactly and that are next to each other. An example is a restriction enzyme cutting site. The cut is after one position and before the other position (hence, in between).^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#InBetweenPosition">faldo:InBetweenPosition</a>
    /// </summary>
    let InBetweenPosition = _prefixId.prefix "InBetweenPosition"
    /// <summary>
    ///   <para>rdfs:label : Indeterminate position within a range^^xsd:string</para>
    ///   <para>rdfs:comment : Use when you have an idea of the range in which you can find the position, but you cannot be sure about the exact position.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#InRangePosition">faldo:InRangePosition</a>
    /// </summary>
    let InRangePosition = _prefixId.prefix "InRangePosition"
    /// <summary>
    ///   <para>rdfs:label : List of regions^^xsd:string</para>
    ///   <para>rdfs:comment : As an ordered list of regions (but the list might not be complete).^^xsd:stringrdfs:comment : Should be used when the location of a region is defined by an ordered list of Regions. However, try to avoid using these types in favor of using more explicit semantics about why the order is important.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#ListOfRegions">faldo:ListOfRegions</a>
    /// </summary>
    let ListOfRegions = _prefixId.prefix "ListOfRegions"
    /// <summary>
    ///   <para>rdfs:comment : The position of the starting amino-acid a protein or polypeptide terminated by an amino acid with a free amine group (-NH2). The convention for writing peptide sequences is to put the N-terminus on the left and write the sequence from N- to C-terminus. Instances of this class are often used when the reference sequence is not complete ^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#N-TerminalPosition">faldo:N-TerminalPosition</a>
    /// </summary>
    let N_TerminalPosition = _prefixId.prefix "N-TerminalPosition"
    /// <summary>
    ///   <para>rdfs:label : One of positions^^xsd:string</para>
    ///   <para>rdfs:comment : The position is known to be one of the more detailed positions listed by the location predicate.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#OneOfPosition">faldo:OneOfPosition</a>
    /// </summary>
    let OneOfPosition = _prefixId.prefix "OneOfPosition"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <para>rdfs:comment : Superclass for the general concept of a position on a sequence. The sequence is designated with the reference predicate.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#Position">faldo:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : Region^^xsd:string</para>
    ///   <para>rdfs:comment : A region describes a length of sequence with a start position and end position that represents a feature on a sequence, e.g. a gene.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#Region">faldo:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : Negative/reverse strand position^^xsd:string</para>
    ///   <para>rdfs:comment : The position is on the reverse (complement, 3' to 5') strand of the sequence. Shown as '-' in GTF and GFF3.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#ReverseStrandPosition">faldo:ReverseStrandPosition</a>
    /// </summary>
    let ReverseStrandPosition = _prefixId.prefix "ReverseStrandPosition"
    /// <summary>
    ///   <para>rdfs:label : Stranded position^^xsd:string</para>
    ///   <para>rdfs:comment : Part of the coordinate system denoting on which strand the feature can be found. If you do not yet know which stand the feature is on, you should tag the position with just this class. If you know more you should use one of the subclasses. This means a region described with a '.' in GFF3. A GFF3 unstranded position does not have this type in FALDO -- those are just a 'position'.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#StrandedPosition">faldo:StrandedPosition</a>
    /// </summary>
    let StrandedPosition = _prefixId.prefix "StrandedPosition"
    /// <summary>
    ///   <para>rdfs:label : after^^xsd:string</para>
    ///   <para>rdfs:comment : This predicate is used when you want to describe a non-inclusive range. Only used in the InBetweenPosition to say it is after a nucleotide, but before the next one.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#after">faldo:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>rdfs:label : before^^xsd:string</para>
    ///   <para>rdfs:comment : This predicate is used to indicate that the feature is found before the exact position. Use to indicate, for example, a cleavage site. The cleavage happens between two amino acids before one and after the other.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#before">faldo:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>rdfs:label : begin^^xsd:string</para>
    ///   <para>rdfs:comment : The inclusive beginning of a position. Also known as start.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#begin">faldo:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : beginOf^^xsd:string</para>
    ///   <para>rdfs:comment : This is the inverse of the begin:property. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#beginOf">faldo:beginOf</a>
    /// </summary>
    let beginOf = _prefixId.prefix "beginOf"
    /// <summary>
    ///   <para>rdfs:label : end^^xsd:string</para>
    ///   <para>rdfs:comment : The inclusive end of the position.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#end">faldo:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : endOf^^xsd:string</para>
    ///   <para>rdfs:comment : This is the inverse of the begin:end. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#endOf">faldo:endOf</a>
    /// </summary>
    let endOf = _prefixId.prefix "endOf"
    /// <summary>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>rdfs:comment : This is the link between the concept whose location you are annotating and its range or position. For example, when annotating the region that describes an exon, the exon would be the subject and the region would be the object of the triple or: 'active site' 'location' [is] 'position 3'.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#location">faldo:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <para>rdfs:comment : Denoted in 1-based closed coordinates, i.e. the position on the first amino acid or nucleotide of a sequence has the value 1. For nucleotide sequences we count from the 5'end of the sequence, while for Aminoacid sequences we start counting from the N-Terminus.^^xsd:stringrdfs:comment : The position value is the offset along the reference where this position is found. Thus the only the position value in combination with the reference determines where a position is.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#position">faldo:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>rdfs:label : reference^^xsd:string</para>
    ///   <para>rdfs:comment : The reference is the resource that the position value is anchored to.  For example, a contig or chromosome in a genome assembly.^^xsd:string</para>
    ///   <a href="http://biohackathon.org/resource/faldo#reference">faldo:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
