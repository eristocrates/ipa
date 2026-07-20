namespace http.biohackathon.org.resource.faldo.hash

open DoxAletheia

module faldo =
    let _namespace_name = "http://biohackathon.org/resource/faldo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Used to describe a location that consists of a number of Regions but where the order is not known. e.g. the oddly named order() keyword in a INSDC file.
    /// <see href="http://biohackathon.org/resource/faldo#BagOfRegions"></see></summary>
    let BagOfRegions = _prefix "BagOfRegions"
    /// <summary>
    /// Sometimes a location of a feature is defined by a collection of regions e.g. join() and order() in INSDC records. One should always try to model the semantics more accurately than this, these are fallback options to encode legacy data.
    /// <see href="http://biohackathon.org/resource/faldo#CollectionOfRegions"></see></summary>
    let CollectionOfRegions = _prefix "CollectionOfRegions"
    /// <summary>
    /// The 'both strands position' indicates a region that is best described as being on 'both' strands of a double-stranded sequence, rather than one or the other.
    /// <see href="http://biohackathon.org/resource/faldo#BothStrandsPosition"></see></summary>
    let BothStrandsPosition = _prefix "BothStrandsPosition"
    /// <summary>
    /// Part of the coordinate system denoting on which strand the feature can be found. If you do not yet know which stand the feature is on, you should tag the position with just this class. If you know more you should use one of the subclasses. This means a region described with a '.' in GFF3. A GFF3 unstranded position does not have this type in FALDO -- those are just a 'position'.
    /// <see href="http://biohackathon.org/resource/faldo#StrandedPosition"></see></summary>
    let StrandedPosition = _prefix "StrandedPosition"
    /// <summary>
    /// The position is on the forward (positive, 5' to 3') strand. Shown as a '+' in GFF3 and GTF.
    /// <see href="http://biohackathon.org/resource/faldo#ForwardStrandPosition"></see></summary>
    let ForwardStrandPosition = _prefix "ForwardStrandPosition"
    /// <summary>
    /// The position is on the reverse (complement, 3' to 5') strand of the sequence. Shown as '-' in GTF and GFF3.
    /// <see href="http://biohackathon.org/resource/faldo#ReverseStrandPosition"></see></summary>
    let ReverseStrandPosition = _prefix "ReverseStrandPosition"
    /// <summary>
    /// The C-terminus is the end of an amino acid chain (protein or polypeptide), terminated by a free carboxyl group (-COOH).
    /// <see href="http://biohackathon.org/resource/faldo#C-TerminalPosition"></see></summary>
    let ``C-TerminalPosition`` = _prefix "C-TerminalPosition"
    /// <summary>
    /// A position that is exactly known.
    /// <see href="http://biohackathon.org/resource/faldo#ExactPosition"></see></summary>
    let ExactPosition = _prefix "ExactPosition"
    /// <summary>
    /// The position of the starting amino-acid a protein or polypeptide terminated by an amino acid with a free amine group (-NH2). The convention for writing peptide sequences is to put the N-terminus on the left and write the sequence from N- to C-terminus. Instances of this class are often used when the reference sequence is not complete
    /// <see href="http://biohackathon.org/resource/faldo#N-TerminalPosition"></see></summary>
    let ``N-TerminalPosition`` = _prefix "N-TerminalPosition"
    /// <summary>
    /// A region describes a length of sequence with a start position and end position that represents a feature on a sequence, e.g. a gene.
    /// <see href="http://biohackathon.org/resource/faldo#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// Denoted in 1-based closed coordinates, i.e. the position on the first amino acid or nucleotide of a sequence has the value 1. For nucleotide sequences we count from the 5'end of the sequence, while for Aminoacid sequences we start counting from the N-Terminus.
    /// The position value is the offset along the reference where this position is found. Thus the only the position value in combination with the reference determines where a position is.
    /// <see href="http://biohackathon.org/resource/faldo#position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// Superclass for the general concept of a position on a sequence. The sequence is designated with the reference predicate.
    /// <see href="http://biohackathon.org/resource/faldo#Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// This indicates that a feature is between two other positions that are both known exactly and that are next to each other. An example is a restriction enzyme cutting site. The cut is after one position and before the other position (hence, in between).
    /// <see href="http://biohackathon.org/resource/faldo#InBetweenPosition"></see></summary>
    let InBetweenPosition = _prefix "InBetweenPosition"
    /// <summary>
    /// Use when you have an idea of the range in which you can find the position, but you cannot be sure about the exact position.
    /// <see href="http://biohackathon.org/resource/faldo#InRangePosition"></see></summary>
    let InRangePosition = _prefix "InRangePosition"
    /// <summary>
    /// The position is known to be one of the more detailed positions listed by the location predicate.
    /// <see href="http://biohackathon.org/resource/faldo#OneOfPosition"></see></summary>
    let OneOfPosition = _prefix "OneOfPosition"
    /// <summary>
    /// The reference is the resource that the position value is anchored to.  For example, a contig or chromosome in a genome assembly.
    /// <see href="http://biohackathon.org/resource/faldo#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// A position that lacks exact data.
    /// <see href="http://biohackathon.org/resource/faldo#FuzzyPosition"></see></summary>
    let FuzzyPosition = _prefix "FuzzyPosition"
    /// <summary>
    /// This predicate is used to indicate that the feature is found before the exact position. Use to indicate, for example, a cleavage site. The cleavage happens between two amino acids before one and after the other.
    /// <see href="http://biohackathon.org/resource/faldo#before"></see></summary>
    let before = _prefix "before"
    /// <summary>
    /// This predicate is used when you want to describe a non-inclusive range. Only used in the InBetweenPosition to say it is after a nucleotide, but before the next one.
    /// <see href="http://biohackathon.org/resource/faldo#after"></see></summary>
    let after = _prefix "after"
    /// <summary>
    /// The inclusive beginning of a position. Also known as start.
    /// <see href="http://biohackathon.org/resource/faldo#begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    /// The inclusive end of the position.
    /// <see href="http://biohackathon.org/resource/faldo#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// As an ordered list of regions (but the list might not be complete).
    /// Should be used when the location of a region is defined by an ordered list of Regions. However, try to avoid using these types in favor of using more explicit semantics about why the order is important.
    /// <see href="http://biohackathon.org/resource/faldo#ListOfRegions"></see></summary>
    let ListOfRegions = _prefix "ListOfRegions"
    /// <summary>
    /// This is the inverse of the begin:property. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data.
    /// <see href="http://biohackathon.org/resource/faldo#beginOf"></see></summary>
    let beginOf = _prefix "beginOf"
    /// <summary>
    /// This is the inverse of the begin:end. It is included to make it easier to write a number of OWL axioms. You should rarely use this in your raw data.
    /// <see href="http://biohackathon.org/resource/faldo#endOf"></see></summary>
    let endOf = _prefix "endOf"
    /// <summary>
    /// This is the link between the concept whose location you are annotating and its range or position. For example, when annotating the region that describes an exon, the exon would be the subject and the region would be the object of the triple or: 'active site' 'location' [is] 'position 3'.
    /// <see href="http://biohackathon.org/resource/faldo#location"></see></summary>
    let location = _prefix "location"
