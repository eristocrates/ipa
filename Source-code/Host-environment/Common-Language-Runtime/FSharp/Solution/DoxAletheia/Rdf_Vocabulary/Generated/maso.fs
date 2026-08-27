namespace http.securitytoolbox.appspot.com.MASO.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module maso =
    let _namespace_iri = Namespace_Iri maso |> NamespaceIRI
    /// <summary>
    ///   <para>maso:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#">http://securitytoolbox.appspot.com/MASO#</seealso>
    let _prefix_iri = Prefixed_Name(maso, "") |> PrefixedName
    /// <summary>
    ///   <para>maso:AES</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#AES">http://securitytoolbox.appspot.com/MASO#AES</seealso>
    let AES = Prefixed_Name(maso, "AES") |> PrefixedName
    /// <summary>
    ///   <para>maso:AVG</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Antivirus</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#AVG">http://securitytoolbox.appspot.com/MASO#AVG</seealso>
    let AVG = Prefixed_Name(maso, "AVG") |> PrefixedName
    /// <summary>
    ///   <para>maso:Adresse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Adresse">http://securitytoolbox.appspot.com/MASO#Adresse</seealso>
    let Adresse = Prefixed_Name(maso, "Adresse") |> PrefixedName
    /// <summary>
    ///   <para>maso:Adresse-iP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Adresse-iP">http://securitytoolbox.appspot.com/MASO#Adresse-iP</seealso>
    let Adresse_iP = Prefixed_Name(maso, "Adresse-iP") |> PrefixedName
    /// <summary>
    ///   <para>maso:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Agent">http://securitytoolbox.appspot.com/MASO#Agent</seealso>
    let Agent = Prefixed_Name(maso, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>maso:Algorithme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme">http://securitytoolbox.appspot.com/MASO#Algorithme</seealso>
    let Algorithme = Prefixed_Name(maso, "Algorithme") |> PrefixedName
    /// <summary>
    ///   <para>maso:Algorithme-Cryptage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme-Cryptage">http://securitytoolbox.appspot.com/MASO#Algorithme-Cryptage</seealso>
    let Algorithme_Cryptage = Prefixed_Name(maso, "Algorithme-Cryptage") |> PrefixedName
    /// <summary>
    ///   <para>maso:Algorithme-checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme-checksum">http://securitytoolbox.appspot.com/MASO#Algorithme-checksum</seealso>
    let Algorithme_checksum = Prefixed_Name(maso, "Algorithme-checksum") |> PrefixedName
    /// <summary>
    ///   <para>maso:Algorithme-cryptage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme-cryptage">http://securitytoolbox.appspot.com/MASO#Algorithme-cryptage</seealso>
    let Algorithme_cryptage = Prefixed_Name(maso, "Algorithme-cryptage") |> PrefixedName

    /// <summary>
    ///   <para>maso:Algorithme-gestion-cles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme-gestion-cles">http://securitytoolbox.appspot.com/MASO#Algorithme-gestion-cles</seealso>
    let Algorithme_gestion_cles =
        Prefixed_Name(maso, "Algorithme-gestion-cles") |> PrefixedName

    /// <summary>
    ///   <para>maso:Algorithme-signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Algorithme-signature">http://securitytoolbox.appspot.com/MASO#Algorithme-signature</seealso>
    let Algorithme_signature =
        Prefixed_Name(maso, "Algorithme-signature") |> PrefixedName

    /// <summary>
    ///   <para>maso:Antivirus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Antivirus">http://securitytoolbox.appspot.com/MASO#Antivirus</seealso>
    let Antivirus = Prefixed_Name(maso, "Antivirus") |> PrefixedName
    /// <summary>
    ///   <para>maso:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Asset">http://securitytoolbox.appspot.com/MASO#Asset</seealso>
    let Asset = Prefixed_Name(maso, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>maso:Attaque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Attaque">http://securitytoolbox.appspot.com/MASO#Attaque</seealso>
    let Attaque = Prefixed_Name(maso, "Attaque") |> PrefixedName
    /// <summary>
    ///   <para>maso:Authentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Mecanisme</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Authentification">http://securitytoolbox.appspot.com/MASO#Authentification</seealso>
    let Authentification = Prefixed_Name(maso, "Authentification") |> PrefixedName
    /// <summary>
    ///   <para>maso:Autorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Mecanisme</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Autorisation">http://securitytoolbox.appspot.com/MASO#Autorisation</seealso>
    let Autorisation = Prefixed_Name(maso, "Autorisation") |> PrefixedName
    /// <summary>
    ///   <para>maso:BlowFish</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#BlowFish">http://securitytoolbox.appspot.com/MASO#BlowFish</seealso>
    let BlowFish = Prefixed_Name(maso, "BlowFish") |> PrefixedName
    /// <summary>
    ///   <para>maso:CAST</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#CAST">http://securitytoolbox.appspot.com/MASO#CAST</seealso>
    let CAST = Prefixed_Name(maso, "CAST") |> PrefixedName
    /// <summary>
    ///   <para>maso:Carte-credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Carte-credit">http://securitytoolbox.appspot.com/MASO#Carte-credit</seealso>
    let Carte_credit = Prefixed_Name(maso, "Carte-credit") |> PrefixedName
    /// <summary>
    ///   <para>maso:Certificat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Certificat">http://securitytoolbox.appspot.com/MASO#Certificat</seealso>
    let Certificat = Prefixed_Name(maso, "Certificat") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cle-de-Cryptage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cle-de-Cryptage">http://securitytoolbox.appspot.com/MASO#Cle-de-Cryptage</seealso>
    let Cle_de_Cryptage = Prefixed_Name(maso, "Cle-de-Cryptage") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cle-de-cryptage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cle-de-cryptage">http://securitytoolbox.appspot.com/MASO#Cle-de-cryptage</seealso>
    let Cle_de_cryptage = Prefixed_Name(maso, "Cle-de-cryptage") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cle-privee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cle-privee">http://securitytoolbox.appspot.com/MASO#Cle-privee</seealso>
    let Cle_privee = Prefixed_Name(maso, "Cle-privee") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cle-publique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cle-publique">http://securitytoolbox.appspot.com/MASO#Cle-publique</seealso>
    let Cle_publique = Prefixed_Name(maso, "Cle-publique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cle-secrete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cle-secrete">http://securitytoolbox.appspot.com/MASO#Cle-secrete</seealso>
    let Cle_secrete = Prefixed_Name(maso, "Cle-secrete") |> PrefixedName
    /// <summary>
    ///   <para>maso:Composant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Composant">http://securitytoolbox.appspot.com/MASO#Composant</seealso>
    let Composant = Prefixed_Name(maso, "Composant") |> PrefixedName
    /// <summary>
    ///   <para>maso:Confiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Confiance">http://securitytoolbox.appspot.com/MASO#Confiance</seealso>
    let Confiance = Prefixed_Name(maso, "Confiance") |> PrefixedName
    /// <summary>
    ///   <para>maso:Confidentialite</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Confidentialite">http://securitytoolbox.appspot.com/MASO#Confidentialite</seealso>
    let Confidentialite = Prefixed_Name(maso, "Confidentialite") |> PrefixedName
    /// <summary>
    ///   <para>maso:Contremesure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Contremesure">http://securitytoolbox.appspot.com/MASO#Contremesure</seealso>
    let Contremesure = Prefixed_Name(maso, "Contremesure") |> PrefixedName
    /// <summary>
    ///   <para>maso:Contremesure-reseau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Contremesure-reseau">http://securitytoolbox.appspot.com/MASO#Contremesure-reseau</seealso>
    let Contremesure_reseau = Prefixed_Name(maso, "Contremesure-reseau") |> PrefixedName
    /// <summary>
    ///   <para>maso:Controle-dacces</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Mecanisme</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Controle-dacces">http://securitytoolbox.appspot.com/MASO#Controle-dacces</seealso>
    let Controle_dacces = Prefixed_Name(maso, "Controle-dacces") |> PrefixedName
    /// <summary>
    ///   <para>maso:Cookie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cookie">http://securitytoolbox.appspot.com/MASO#Cookie</seealso>
    let Cookie = Prefixed_Name(maso, "Cookie") |> PrefixedName

    /// <summary>
    ///   <para>maso:Cryptage-asymetrique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cryptage-asymetrique">http://securitytoolbox.appspot.com/MASO#Cryptage-asymetrique</seealso>
    let Cryptage_asymetrique =
        Prefixed_Name(maso, "Cryptage-asymetrique") |> PrefixedName

    /// <summary>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Cryptage-symetrique">http://securitytoolbox.appspot.com/MASO#Cryptage-symetrique</seealso>
    let Cryptage_symetrique = Prefixed_Name(maso, "Cryptage-symetrique") |> PrefixedName
    /// <summary>
    ///   <para>maso:DES</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#DES">http://securitytoolbox.appspot.com/MASO#DES</seealso>
    let DES = Prefixed_Name(maso, "DES") |> PrefixedName
    /// <summary>
    ///   <para>maso:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Data">http://securitytoolbox.appspot.com/MASO#Data</seealso>
    let Data = Prefixed_Name(maso, "Data") |> PrefixedName
    /// <summary>
    ///   <para>maso:Defaut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Defaut">http://securitytoolbox.appspot.com/MASO#Defaut</seealso>
    let Defaut = Prefixed_Name(maso, "Defaut") |> PrefixedName
    /// <summary>
    ///   <para>maso:Defaut-interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Defaut-interaction">http://securitytoolbox.appspot.com/MASO#Defaut-interaction</seealso>
    let Defaut_interaction = Prefixed_Name(maso, "Defaut-interaction") |> PrefixedName
    /// <summary>
    ///   <para>maso:Defaut-physique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Defaut-physique">http://securitytoolbox.appspot.com/MASO#Defaut-physique</seealso>
    let Defaut_physique = Prefixed_Name(maso, "Defaut-physique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Deni_de_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Attaque</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Deni_de_service">http://securitytoolbox.appspot.com/MASO#Deni_de_service</seealso>
    let Deni_de_service = Prefixed_Name(maso, "Deni_de_service") |> PrefixedName

    /// <summary>
    ///   <para>maso:Description-logiciel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Description-logiciel">http://securitytoolbox.appspot.com/MASO#Description-logiciel</seealso>
    let Description_logiciel =
        Prefixed_Name(maso, "Description-logiciel") |> PrefixedName

    /// <summary>
    ///   <para>maso:Disponibilite</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Disponibilite">http://securitytoolbox.appspot.com/MASO#Disponibilite</seealso>
    let Disponibilite = Prefixed_Name(maso, "Disponibilite") |> PrefixedName
    /// <summary>
    ///   <para>maso:Domaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Domaine">http://securitytoolbox.appspot.com/MASO#Domaine</seealso>
    let Domaine = Prefixed_Name(maso, "Domaine") |> PrefixedName
    /// <summary>
    ///   <para>maso:Echec-technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Echec-technique">http://securitytoolbox.appspot.com/MASO#Echec-technique</seealso>
    let Echec_technique = Prefixed_Name(maso, "Echec-technique") |> PrefixedName
    /// <summary>
    ///   <para>maso:ElGamal</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-asymetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#ElGamal">http://securitytoolbox.appspot.com/MASO#ElGamal</seealso>
    let ElGamal = Prefixed_Name(maso, "ElGamal") |> PrefixedName
    /// <summary>
    ///   <para>maso:Elliptic_curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-asymetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Elliptic_curve">http://securitytoolbox.appspot.com/MASO#Elliptic_curve</seealso>
    let Elliptic_curve = Prefixed_Name(maso, "Elliptic_curve") |> PrefixedName
    /// <summary>
    ///   <para>maso:Entite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Entite">http://securitytoolbox.appspot.com/MASO#Entite</seealso>
    let Entite = Prefixed_Name(maso, "Entite") |> PrefixedName
    /// <summary>
    ///   <para>maso:Erreur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Erreur">http://securitytoolbox.appspot.com/MASO#Erreur</seealso>
    let Erreur = Prefixed_Name(maso, "Erreur") |> PrefixedName
    /// <summary>
    ///   <para>maso:Firewall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Firewall">http://securitytoolbox.appspot.com/MASO#Firewall</seealso>
    let Firewall = Prefixed_Name(maso, "Firewall") |> PrefixedName
    /// <summary>
    ///   <para>maso:Gestion-cle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Gestion-cle">http://securitytoolbox.appspot.com/MASO#Gestion-cle</seealso>
    let Gestion_cle = Prefixed_Name(maso, "Gestion-cle") |> PrefixedName
    /// <summary>
    ///   <para>maso:Gestion-cles</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Mecanisme</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Gestion-cles">http://securitytoolbox.appspot.com/MASO#Gestion-cles</seealso>
    let Gestion_cles = Prefixed_Name(maso, "Gestion-cles") |> PrefixedName
    /// <summary>
    ///   <para>maso:H%C3%B4te</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#H%C3%B4te">http://securitytoolbox.appspot.com/MASO#H%C3%B4te</seealso>
    let ``H%C3%B4te`` = Prefixed_Name(maso, "H%C3%B4te") |> PrefixedName
    /// <summary>
    ///   <para>maso:HMAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:MAC</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#HMAC">http://securitytoolbox.appspot.com/MASO#HMAC</seealso>
    let HMAC = Prefixed_Name(maso, "HMAC") |> PrefixedName
    /// <summary>
    ///   <para>maso:Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Hardware">http://securitytoolbox.appspot.com/MASO#Hardware</seealso>
    let Hardware = Prefixed_Name(maso, "Hardware") |> PrefixedName
    /// <summary>
    ///   <para>maso:Hash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Hash">http://securitytoolbox.appspot.com/MASO#Hash</seealso>
    let Hash = Prefixed_Name(maso, "Hash") |> PrefixedName
    /// <summary>
    ///   <para>maso:Hote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Hote">http://securitytoolbox.appspot.com/MASO#Hote</seealso>
    let Hote = Prefixed_Name(maso, "Hote") |> PrefixedName
    /// <summary>
    ///   <para>maso:IDEA</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#IDEA">http://securitytoolbox.appspot.com/MASO#IDEA</seealso>
    let IDEA = Prefixed_Name(maso, "IDEA") |> PrefixedName
    /// <summary>
    ///   <para>maso:Identification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Identification">http://securitytoolbox.appspot.com/MASO#Identification</seealso>
    let Identification = Prefixed_Name(maso, "Identification") |> PrefixedName
    /// <summary>
    ///   <para>maso:Imputabilite</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Imputabilite">http://securitytoolbox.appspot.com/MASO#Imputabilite</seealso>
    let Imputabilite = Prefixed_Name(maso, "Imputabilite") |> PrefixedName
    /// <summary>
    ///   <para>maso:Integrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Integrite">http://securitytoolbox.appspot.com/MASO#Integrite</seealso>
    let Integrite = Prefixed_Name(maso, "Integrite") |> PrefixedName
    /// <summary>
    ///   <para>maso:KEA</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Algorithme-gestion-cles</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#KEA">http://securitytoolbox.appspot.com/MASO#KEA</seealso>
    let KEA = Prefixed_Name(maso, "KEA") |> PrefixedName
    /// <summary>
    ///   <para>maso:MAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#MAC">http://securitytoolbox.appspot.com/MASO#MAC</seealso>
    let MAC = Prefixed_Name(maso, "MAC") |> PrefixedName
    /// <summary>
    ///   <para>maso:MD4</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Hash</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#MD4">http://securitytoolbox.appspot.com/MASO#MD4</seealso>
    let MD4 = Prefixed_Name(maso, "MD4") |> PrefixedName
    /// <summary>
    ///   <para>maso:MD5</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Hash</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#MD5">http://securitytoolbox.appspot.com/MASO#MD5</seealso>
    let MD5 = Prefixed_Name(maso, "MD5") |> PrefixedName
    /// <summary>
    ///   <para>maso:Mecanisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Mecanisme">http://securitytoolbox.appspot.com/MASO#Mecanisme</seealso>
    let Mecanisme = Prefixed_Name(maso, "Mecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:Memoire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Memoire">http://securitytoolbox.appspot.com/MASO#Memoire</seealso>
    let Memoire = Prefixed_Name(maso, "Memoire") |> PrefixedName
    /// <summary>
    ///   <para>maso:Menace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Menace">http://securitytoolbox.appspot.com/MASO#Menace</seealso>
    let Menace = Prefixed_Name(maso, "Menace") |> PrefixedName
    /// <summary>
    ///   <para>maso:Microprocesseur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Microprocesseur">http://securitytoolbox.appspot.com/MASO#Microprocesseur</seealso>
    let Microprocesseur = Prefixed_Name(maso, "Microprocesseur") |> PrefixedName
    /// <summary>
    ///   <para>maso:Mot-de-passe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Mot-de-passe">http://securitytoolbox.appspot.com/MASO#Mot-de-passe</seealso>
    let Mot_de_passe = Prefixed_Name(maso, "Mot-de-passe") |> PrefixedName
    /// <summary>
    ///   <para>maso:Non-repudiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Objectif</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Non-repudiation">http://securitytoolbox.appspot.com/MASO#Non-repudiation</seealso>
    let Non_repudiation = Prefixed_Name(maso, "Non-repudiation") |> PrefixedName
    /// <summary>
    ///   <para>maso:Norton</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Antivirus</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Norton">http://securitytoolbox.appspot.com/MASO#Norton</seealso>
    let Norton = Prefixed_Name(maso, "Norton") |> PrefixedName
    /// <summary>
    ///   <para>maso:Objectif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Objectif">http://securitytoolbox.appspot.com/MASO#Objectif</seealso>
    let Objectif = Prefixed_Name(maso, "Objectif") |> PrefixedName
    /// <summary>
    ///   <para>maso:Passeport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Passeport">http://securitytoolbox.appspot.com/MASO#Passeport</seealso>
    let Passeport = Prefixed_Name(maso, "Passeport") |> PrefixedName
    /// <summary>
    ///   <para>maso:Personne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Personne">http://securitytoolbox.appspot.com/MASO#Personne</seealso>
    let Personne = Prefixed_Name(maso, "Personne") |> PrefixedName
    /// <summary>
    ///   <para>maso:Proprietaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Proprietaire">http://securitytoolbox.appspot.com/MASO#Proprietaire</seealso>
    let Proprietaire = Prefixed_Name(maso, "Proprietaire") |> PrefixedName
    /// <summary>
    ///   <para>maso:Protection-physique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protection-physique">http://securitytoolbox.appspot.com/MASO#Protection-physique</seealso>
    let Protection_physique = Prefixed_Name(maso, "Protection-physique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Protocole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole">http://securitytoolbox.appspot.com/MASO#Protocole</seealso>
    let Protocole = Prefixed_Name(maso, "Protocole") |> PrefixedName
    /// <summary>
    ///   <para>maso:Protocole-Cryptage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-Cryptage">http://securitytoolbox.appspot.com/MASO#Protocole-Cryptage</seealso>
    let Protocole_Cryptage = Prefixed_Name(maso, "Protocole-Cryptage") |> PrefixedName

    /// <summary>
    ///   <para>maso:Protocole-authentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-authentification">http://securitytoolbox.appspot.com/MASO#Protocole-authentification</seealso>
    let Protocole_authentification =
        Prefixed_Name(maso, "Protocole-authentification") |> PrefixedName

    /// <summary>
    ///   <para>maso:Protocole-cryptage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-cryptage">http://securitytoolbox.appspot.com/MASO#Protocole-cryptage</seealso>
    let Protocole_cryptage = Prefixed_Name(maso, "Protocole-cryptage") |> PrefixedName

    /// <summary>
    ///   <para>maso:Protocole-gestion-cles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-cles">http://securitytoolbox.appspot.com/MASO#Protocole-gestion-cles</seealso>
    let Protocole_gestion_cles =
        Prefixed_Name(maso, "Protocole-gestion-cles") |> PrefixedName

    /// <summary>
    ///   <para>maso:Protocole-gestion-reseau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-reseau">http://securitytoolbox.appspot.com/MASO#Protocole-gestion-reseau</seealso>
    let Protocole_gestion_reseau =
        Prefixed_Name(maso, "Protocole-gestion-reseau") |> PrefixedName

    /// <summary>
    ///   <para>maso:Protocole-signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Protocole-signature">http://securitytoolbox.appspot.com/MASO#Protocole-signature</seealso>
    let Protocole_signature = Prefixed_Name(maso, "Protocole-signature") |> PrefixedName
    /// <summary>
    ///   <para>maso:RBAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RBAC">http://securitytoolbox.appspot.com/MASO#RBAC</seealso>
    let RBAC = Prefixed_Name(maso, "RBAC") |> PrefixedName
    /// <summary>
    ///   <para>maso:RC2</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Rivest</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RC2">http://securitytoolbox.appspot.com/MASO#RC2</seealso>
    let RC2 = Prefixed_Name(maso, "RC2") |> PrefixedName
    /// <summary>
    ///   <para>maso:RC4</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Rivest</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RC4">http://securitytoolbox.appspot.com/MASO#RC4</seealso>
    let RC4 = Prefixed_Name(maso, "RC4") |> PrefixedName
    /// <summary>
    ///   <para>maso:RC5</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Rivest</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RC5">http://securitytoolbox.appspot.com/MASO#RC5</seealso>
    let RC5 = Prefixed_Name(maso, "RC5") |> PrefixedName
    /// <summary>
    ///   <para>maso:RC6</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Rivest</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RC6">http://securitytoolbox.appspot.com/MASO#RC6</seealso>
    let RC6 = Prefixed_Name(maso, "RC6") |> PrefixedName
    /// <summary>
    ///   <para>maso:RSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-asymetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#RSA">http://securitytoolbox.appspot.com/MASO#RSA</seealso>
    let RSA = Prefixed_Name(maso, "RSA") |> PrefixedName
    /// <summary>
    ///   <para>maso:Rivest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Rivest">http://securitytoolbox.appspot.com/MASO#Rivest</seealso>
    let Rivest = Prefixed_Name(maso, "Rivest") |> PrefixedName
    /// <summary>
    ///   <para>maso:SSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Protocole-gestion-cles</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#SSH">http://securitytoolbox.appspot.com/MASO#SSH</seealso>
    let SSH = Prefixed_Name(maso, "SSH") |> PrefixedName
    /// <summary>
    ///   <para>maso:SSL</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Protocole-gestion-cles</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#SSL">http://securitytoolbox.appspot.com/MASO#SSL</seealso>
    let SSL = Prefixed_Name(maso, "SSL") |> PrefixedName
    /// <summary>
    ///   <para>maso:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Service">http://securitytoolbox.appspot.com/MASO#Service</seealso>
    let Service = Prefixed_Name(maso, "Service") |> PrefixedName
    /// <summary>
    ///   <para>maso:Signature-numerique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Signature-numerique">http://securitytoolbox.appspot.com/MASO#Signature-numerique</seealso>
    let Signature_numerique = Prefixed_Name(maso, "Signature-numerique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Societe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Societe">http://securitytoolbox.appspot.com/MASO#Societe</seealso>
    let Societe = Prefixed_Name(maso, "Societe") |> PrefixedName
    /// <summary>
    ///   <para>maso:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Software">http://securitytoolbox.appspot.com/MASO#Software</seealso>
    let Software = Prefixed_Name(maso, "Software") |> PrefixedName
    /// <summary>
    ///   <para>maso:Storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Storage">http://securitytoolbox.appspot.com/MASO#Storage</seealso>
    let Storage = Prefixed_Name(maso, "Storage") |> PrefixedName
    /// <summary>
    ///   <para>maso:TPE</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Protection-physique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#TPE">http://securitytoolbox.appspot.com/MASO#TPE</seealso>
    let TPE = Prefixed_Name(maso, "TPE") |> PrefixedName
    /// <summary>
    ///   <para>maso:Token-electronique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Token-electronique">http://securitytoolbox.appspot.com/MASO#Token-electronique</seealso>
    let Token_electronique = Prefixed_Name(maso, "Token-electronique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Token-physique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Token-physique">http://securitytoolbox.appspot.com/MASO#Token-physique</seealso>
    let Token_physique = Prefixed_Name(maso, "Token-physique") |> PrefixedName
    /// <summary>
    ///   <para>maso:Trojan-horse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Trojan-horse">http://securitytoolbox.appspot.com/MASO#Trojan-horse</seealso>
    let Trojan_horse = Prefixed_Name(maso, "Trojan-horse") |> PrefixedName
    /// <summary>
    ///   <para>maso:TwoFish</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#TwoFish">http://securitytoolbox.appspot.com/MASO#TwoFish</seealso>
    let TwoFish = Prefixed_Name(maso, "TwoFish") |> PrefixedName
    /// <summary>
    ///   <para>maso:Virus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Virus">http://securitytoolbox.appspot.com/MASO#Virus</seealso>
    let Virus = Prefixed_Name(maso, "Virus") |> PrefixedName
    /// <summary>
    ///   <para>maso:Vulnerabilite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Vulnerabilite">http://securitytoolbox.appspot.com/MASO#Vulnerabilite</seealso>
    let Vulnerabilite = Prefixed_Name(maso, "Vulnerabilite") |> PrefixedName
    /// <summary>
    ///   <para>maso:Worm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#Worm">http://securitytoolbox.appspot.com/MASO#Worm</seealso>
    let Worm = Prefixed_Name(maso, "Worm") |> PrefixedName
    /// <summary>
    ///   <para>maso:X.509</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#X.509">http://securitytoolbox.appspot.com/MASO#X.509</seealso>
    let ``X.509`` = Prefixed_Name(maso, "X.509") |> PrefixedName
    /// <summary>
    ///   <para>maso:_3DES</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Cryptage-symetrique</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#_3DES">http://securitytoolbox.appspot.com/MASO#_3DES</seealso>
    let _3DES = Prefixed_Name(maso, "_3DES") |> PrefixedName

    /// <summary>
    ///   <para>maso:assureAuthentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#assureAuthentification">http://securitytoolbox.appspot.com/MASO#assureAuthentification</seealso>
    let assureAuthentification =
        Prefixed_Name(maso, "assureAuthentification") |> PrefixedName

    /// <summary>
    ///   <para>maso:assureObjectif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#assureObjectif">http://securitytoolbox.appspot.com/MASO#assureObjectif</seealso>
    let assureObjectif = Prefixed_Name(maso, "assureObjectif") |> PrefixedName
    /// <summary>
    ///   <para>maso:capableMecanisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#capableMecanisme">http://securitytoolbox.appspot.com/MASO#capableMecanisme</seealso>
    let capableMecanisme = Prefixed_Name(maso, "capableMecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:capableObjectif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#capableObjectif">http://securitytoolbox.appspot.com/MASO#capableObjectif</seealso>
    let capableObjectif = Prefixed_Name(maso, "capableObjectif") |> PrefixedName
    /// <summary>
    ///   <para>maso:capacite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#capacite">http://securitytoolbox.appspot.com/MASO#capacite</seealso>
    let capacite = Prefixed_Name(maso, "capacite") |> PrefixedName
    /// <summary>
    ///   <para>maso:chemin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#chemin">http://securitytoolbox.appspot.com/MASO#chemin</seealso>
    let chemin = Prefixed_Name(maso, "chemin") |> PrefixedName
    /// <summary>
    ///   <para>maso:cible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#cible">http://securitytoolbox.appspot.com/MASO#cible</seealso>
    let cible = Prefixed_Name(maso, "cible") |> PrefixedName
    /// <summary>
    ///   <para>maso:date-expiration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#date-expiration">http://securitytoolbox.appspot.com/MASO#date-expiration</seealso>
    let date_expiration = Prefixed_Name(maso, "date-expiration") |> PrefixedName
    /// <summary>
    ///   <para>maso:dispose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#dispose">http://securitytoolbox.appspot.com/MASO#dispose</seealso>
    let dispose = Prefixed_Name(maso, "dispose") |> PrefixedName
    /// <summary>
    ///   <para>maso:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#email">http://securitytoolbox.appspot.com/MASO#email</seealso>
    let email = Prefixed_Name(maso, "email") |> PrefixedName
    /// <summary>
    ///   <para>maso:eninteractionAvec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#eninteractionAvec">http://securitytoolbox.appspot.com/MASO#eninteractionAvec</seealso>
    let eninteractionAvec = Prefixed_Name(maso, "eninteractionAvec") |> PrefixedName
    /// <summary>
    ///   <para>maso:estAssureMecanisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estAssureMecanisme">http://securitytoolbox.appspot.com/MASO#estAssureMecanisme</seealso>
    let estAssureMecanisme = Prefixed_Name(maso, "estAssureMecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:estAssureProtocole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estAssureProtocole">http://securitytoolbox.appspot.com/MASO#estAssureProtocole</seealso>
    let estAssureProtocole = Prefixed_Name(maso, "estAssureProtocole") |> PrefixedName
    /// <summary>
    ///   <para>maso:estExigeProtocole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estExigeProtocole">http://securitytoolbox.appspot.com/MASO#estExigeProtocole</seealso>
    let estExigeProtocole = Prefixed_Name(maso, "estExigeProtocole") |> PrefixedName
    /// <summary>
    ///   <para>maso:estExploitePar</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estExploitePar">http://securitytoolbox.appspot.com/MASO#estExploitePar</seealso>
    let estExploitePar = Prefixed_Name(maso, "estExploitePar") |> PrefixedName
    /// <summary>
    ///   <para>maso:estMecanisme</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estMecanisme">http://securitytoolbox.appspot.com/MASO#estMecanisme</seealso>
    let estMecanisme = Prefixed_Name(maso, "estMecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:estPropriete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estPropriete">http://securitytoolbox.appspot.com/MASO#estPropriete</seealso>
    let estPropriete = Prefixed_Name(maso, "estPropriete") |> PrefixedName
    /// <summary>
    ///   <para>maso:estProtegePar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estProtegePar">http://securitytoolbox.appspot.com/MASO#estProtegePar</seealso>
    let estProtegePar = Prefixed_Name(maso, "estProtegePar") |> PrefixedName
    /// <summary>
    ///   <para>maso:estUtiliseProtocole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocole">http://securitytoolbox.appspot.com/MASO#estUtiliseProtocole</seealso>
    let estUtiliseProtocole = Prefixed_Name(maso, "estUtiliseProtocole") |> PrefixedName

    /// <summary>
    ///   <para>maso:estUtiliseProtocoleCryptage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleCryptage">http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleCryptage</seealso>
    let estUtiliseProtocoleCryptage =
        Prefixed_Name(maso, "estUtiliseProtocoleCryptage") |> PrefixedName

    /// <summary>
    ///   <para>maso:estUtiliseProtocoleSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleSignature">http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleSignature</seealso>
    let estUtiliseProtocoleSignature =
        Prefixed_Name(maso, "estUtiliseProtocoleSignature") |> PrefixedName

    /// <summary>
    ///   <para>maso:estexigeProtocole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estexigeProtocole">http://securitytoolbox.appspot.com/MASO#estexigeProtocole</seealso>
    let estexigeProtocole = Prefixed_Name(maso, "estexigeProtocole") |> PrefixedName
    /// <summary>
    ///   <para>maso:estexploitePar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#estexploitePar">http://securitytoolbox.appspot.com/MASO#estexploitePar</seealso>
    let estexploitePar = Prefixed_Name(maso, "estexploitePar") |> PrefixedName
    /// <summary>
    ///   <para>maso:execute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#execute">http://securitytoolbox.appspot.com/MASO#execute</seealso>
    let execute = Prefixed_Name(maso, "execute") |> PrefixedName
    /// <summary>
    ///   <para>maso:exigeMecanisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#exigeMecanisme">http://securitytoolbox.appspot.com/MASO#exigeMecanisme</seealso>
    let exigeMecanisme = Prefixed_Name(maso, "exigeMecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:exigeObjectif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#exigeObjectif">http://securitytoolbox.appspot.com/MASO#exigeObjectif</seealso>
    let exigeObjectif = Prefixed_Name(maso, "exigeObjectif") |> PrefixedName
    /// <summary>
    ///   <para>maso:exigePasseport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#exigePasseport">http://securitytoolbox.appspot.com/MASO#exigePasseport</seealso>
    let exigePasseport = Prefixed_Name(maso, "exigePasseport") |> PrefixedName
    /// <summary>
    ///   <para>maso:exploite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#exploite">http://securitytoolbox.appspot.com/MASO#exploite</seealso>
    let exploite = Prefixed_Name(maso, "exploite") |> PrefixedName
    /// <summary>
    ///   <para>maso:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#fax">http://securitytoolbox.appspot.com/MASO#fax</seealso>
    let fax = Prefixed_Name(maso, "fax") |> PrefixedName
    /// <summary>
    ///   <para>maso:identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Mecanisme</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#identification">http://securitytoolbox.appspot.com/MASO#identification</seealso>
    let identification = Prefixed_Name(maso, "identification") |> PrefixedName
    /// <summary>
    ///   <para>maso:initialise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#initialise">http://securitytoolbox.appspot.com/MASO#initialise</seealso>
    let initialise = Prefixed_Name(maso, "initialise") |> PrefixedName
    /// <summary>
    ///   <para>maso:intrusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>maso:Attaque</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#intrusion">http://securitytoolbox.appspot.com/MASO#intrusion</seealso>
    let intrusion = Prefixed_Name(maso, "intrusion") |> PrefixedName
    /// <summary>
    ///   <para>maso:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#issuer">http://securitytoolbox.appspot.com/MASO#issuer</seealso>
    let issuer = Prefixed_Name(maso, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>maso:longueur-cle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#longueur-cle">http://securitytoolbox.appspot.com/MASO#longueur-cle</seealso>
    let longueur_cle = Prefixed_Name(maso, "longueur-cle") |> PrefixedName
    /// <summary>
    ///   <para>maso:longueur-minimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#longueur-minimum">http://securitytoolbox.appspot.com/MASO#longueur-minimum</seealso>
    let longueur_minimum = Prefixed_Name(maso, "longueur-minimum") |> PrefixedName
    /// <summary>
    ///   <para>maso:marque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#marque">http://securitytoolbox.appspot.com/MASO#marque</seealso>
    let marque = Prefixed_Name(maso, "marque") |> PrefixedName
    /// <summary>
    ///   <para>maso:modele</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#modele">http://securitytoolbox.appspot.com/MASO#modele</seealso>
    let modele = Prefixed_Name(maso, "modele") |> PrefixedName
    /// <summary>
    ///   <para>maso:nom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#nom">http://securitytoolbox.appspot.com/MASO#nom</seealso>
    let nom = Prefixed_Name(maso, "nom") |> PrefixedName
    /// <summary>
    ///   <para>maso:notAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#notAfter">http://securitytoolbox.appspot.com/MASO#notAfter</seealso>
    let notAfter = Prefixed_Name(maso, "notAfter") |> PrefixedName
    /// <summary>
    ///   <para>maso:notBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#notBefore">http://securitytoolbox.appspot.com/MASO#notBefore</seealso>
    let notBefore = Prefixed_Name(maso, "notBefore") |> PrefixedName
    /// <summary>
    ///   <para>maso:numero-de-serie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#numero-de-serie">http://securitytoolbox.appspot.com/MASO#numero-de-serie</seealso>
    let numero_de_serie = Prefixed_Name(maso, "numero-de-serie") |> PrefixedName
    /// <summary>
    ///   <para>maso:prenom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#prenom">http://securitytoolbox.appspot.com/MASO#prenom</seealso>
    let prenom = Prefixed_Name(maso, "prenom") |> PrefixedName
    /// <summary>
    ///   <para>maso:proprietaireDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:inverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#proprietaireDe">http://securitytoolbox.appspot.com/MASO#proprietaireDe</seealso>
    let proprietaireDe = Prefixed_Name(maso, "proprietaireDe") |> PrefixedName
    /// <summary>
    ///   <para>maso:protege</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#protege">http://securitytoolbox.appspot.com/MASO#protege</seealso>
    let protege = Prefixed_Name(maso, "protege") |> PrefixedName
    /// <summary>
    ///   <para>maso:reduit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#reduit">http://securitytoolbox.appspot.com/MASO#reduit</seealso>
    let reduit = Prefixed_Name(maso, "reduit") |> PrefixedName
    /// <summary>
    ///   <para>maso:s_execute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#s_execute">http://securitytoolbox.appspot.com/MASO#s_execute</seealso>
    let s_execute = Prefixed_Name(maso, "s_execute") |> PrefixedName
    /// <summary>
    ///   <para>maso:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#telephone">http://securitytoolbox.appspot.com/MASO#telephone</seealso>
    let telephone = Prefixed_Name(maso, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>maso:utiliseAlgorithme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utiliseAlgorithme">http://securitytoolbox.appspot.com/MASO#utiliseAlgorithme</seealso>
    let utiliseAlgorithme = Prefixed_Name(maso, "utiliseAlgorithme") |> PrefixedName
    /// <summary>
    ///   <para>maso:utiliseMecanisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utiliseMecanisme">http://securitytoolbox.appspot.com/MASO#utiliseMecanisme</seealso>
    let utiliseMecanisme = Prefixed_Name(maso, "utiliseMecanisme") |> PrefixedName
    /// <summary>
    ///   <para>maso:utilisePasseport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utilisePasseport">http://securitytoolbox.appspot.com/MASO#utilisePasseport</seealso>
    let utilisePasseport = Prefixed_Name(maso, "utilisePasseport") |> PrefixedName
    /// <summary>
    ///   <para>maso:utiliseProtocole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utiliseProtocole">http://securitytoolbox.appspot.com/MASO#utiliseProtocole</seealso>
    let utiliseProtocole = Prefixed_Name(maso, "utiliseProtocole") |> PrefixedName
    /// <summary>
    ///   <para>maso:utiliseSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utiliseSignature">http://securitytoolbox.appspot.com/MASO#utiliseSignature</seealso>
    let utiliseSignature = Prefixed_Name(maso, "utiliseSignature") |> PrefixedName
    /// <summary>
    ///   <para>maso:utilisecryptage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#utilisecryptage">http://securitytoolbox.appspot.com/MASO#utilisecryptage</seealso>
    let utilisecryptage = Prefixed_Name(maso, "utilisecryptage") |> PrefixedName
    /// <summary>
    ///   <para>maso:valeur-cookie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#valeur-cookie">http://securitytoolbox.appspot.com/MASO#valeur-cookie</seealso>
    let valeur_cookie = Prefixed_Name(maso, "valeur-cookie") |> PrefixedName
    /// <summary>
    ///   <para>maso:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#version">http://securitytoolbox.appspot.com/MASO#version</seealso>
    let version = Prefixed_Name(maso, "version") |> PrefixedName
    /// <summary>
    ///   <para>maso:vitesse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://securitytoolbox.appspot.com/MASO#vitesse">http://securitytoolbox.appspot.com/MASO#vitesse</seealso>
    let vitesse = Prefixed_Name(maso, "vitesse") |> PrefixedName
