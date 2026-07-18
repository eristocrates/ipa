#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\obj\Release\net8.0"
#r "MyProvider.Runtime.dll"

open DoxAletheia

type rdf =
    Rdf_Vocabulary<"http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdf.ttl">

type xsd =
    Rdf_Vocabulary<"http://www.w3.org/2001/XMLSchema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2001\XMLSchema\hash\xsd.ttl">

type rdfs =
    Rdf_Vocabulary<"http://www.w3.org/2000/01/rdf-schema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2000\01\rdf-schema\hash\rdfs.ttl">

type owl =
    Rdf_Vocabulary<"http://www.w3.org/2002/07/owl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\07\owl\hash\owl.ttl">


type owl_time =
    Rdf_Vocabulary<"http://www.w3.org/2006/time#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\time\hash\time.ttl">


type foaf =
    Rdf_Vocabulary<"http://xmlns.com/foaf/0.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foaf.ttl">

type olo =
    Rdf_Vocabulary<"http://purl.org/ontology/olo/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\ontology\olo\core\hash\olo.ttl">
