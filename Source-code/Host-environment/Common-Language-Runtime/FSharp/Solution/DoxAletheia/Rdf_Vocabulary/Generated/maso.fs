namespace http.securitytoolbox.appspot.com.MASO.hash

open DoxAletheia.Rdf_Vocabulary

module maso =
    let _namespace_name = "http://securitytoolbox.appspot.com/MASO#"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#AES"></see>
    /// </summary>
    let AES = Namespaced_IRI.parse _namespace_name "AES" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cryptage-symetrique"></see>
    /// </summary>
    let ``Cryptage-symetrique`` =
        Namespaced_IRI.parse _namespace_name "Cryptage-symetrique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#AVG"></see>
    /// </summary>
    let AVG = Namespaced_IRI.parse _namespace_name "AVG" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Antivirus"></see>
    /// </summary>
    let Antivirus = Namespaced_IRI.parse _namespace_name "Antivirus" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Adresse"></see>
    /// </summary>
    let Adresse = Namespaced_IRI.parse _namespace_name "Adresse" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Token-electronique"></see>
    /// </summary>
    let ``Token-electronique`` =
        Namespaced_IRI.parse _namespace_name "Token-electronique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Adresse-iP"></see>
    /// </summary>
    let ``Adresse-iP`` =
        Namespaced_IRI.parse _namespace_name "Adresse-iP" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hote"></see>
    /// </summary>
    let Hote = Namespaced_IRI.parse _namespace_name "Hote" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estPropriete"></see>
    /// </summary>
    let estPropriete =
        Namespaced_IRI.parse _namespace_name "estPropriete" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#s_execute"></see>
    /// </summary>
    let s_execute = Namespaced_IRI.parse _namespace_name "s_execute" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Entite"></see>
    /// </summary>
    let Entite = Namespaced_IRI.parse _namespace_name "Entite" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#H%C3%B4te"></see>
    /// </summary>
    let ``H%C3%B4te`` =
        Namespaced_IRI.parse _namespace_name "H%C3%B4te" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme"></see>
    /// </summary>
    let Algorithme = Namespaced_IRI.parse _namespace_name "Algorithme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-checksum"></see>
    /// </summary>
    let ``Algorithme-checksum`` =
        Namespaced_IRI.parse _namespace_name "Algorithme-checksum" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-cryptage"></see>
    /// </summary>
    let ``Algorithme-cryptage`` =
        Namespaced_IRI.parse _namespace_name "Algorithme-cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-gestion-cles"></see>
    /// </summary>
    let ``Algorithme-gestion-cles`` =
        Namespaced_IRI.parse _namespace_name "Algorithme-gestion-cles" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-signature"></see>
    /// </summary>
    let ``Algorithme-signature`` =
        Namespaced_IRI.parse _namespace_name "Algorithme-signature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Contremesure"></see>
    /// </summary>
    let Contremesure =
        Namespaced_IRI.parse _namespace_name "Contremesure" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Attaque"></see>
    /// </summary>
    let Attaque = Namespaced_IRI.parse _namespace_name "Attaque" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Menace"></see>
    /// </summary>
    let Menace = Namespaced_IRI.parse _namespace_name "Menace" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Authentification"></see>
    /// </summary>
    let Authentification =
        Namespaced_IRI.parse _namespace_name "Authentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Objectif"></see>
    /// </summary>
    let Objectif = Namespaced_IRI.parse _namespace_name "Objectif" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Confidentialite"></see>
    /// </summary>
    let Confidentialite =
        Namespaced_IRI.parse _namespace_name "Confidentialite" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Mecanisme"></see>
    /// </summary>
    let Mecanisme = Namespaced_IRI.parse _namespace_name "Mecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Autorisation"></see>
    /// </summary>
    let Autorisation =
        Namespaced_IRI.parse _namespace_name "Autorisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#BlowFish"></see>
    /// </summary>
    let BlowFish = Namespaced_IRI.parse _namespace_name "BlowFish" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#CAST"></see>
    /// </summary>
    let CAST = Namespaced_IRI.parse _namespace_name "CAST" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Carte-credit"></see>
    /// </summary>
    let ``Carte-credit`` =
        Namespaced_IRI.parse _namespace_name "Carte-credit" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Token-physique"></see>
    /// </summary>
    let ``Token-physique`` =
        Namespaced_IRI.parse _namespace_name "Token-physique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Certificat"></see>
    /// </summary>
    let Certificat = Namespaced_IRI.parse _namespace_name "Certificat" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-de-Cryptage"></see>
    /// </summary>
    let ``Cle-de-Cryptage`` =
        Namespaced_IRI.parse _namespace_name "Cle-de-Cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-privee"></see>
    /// </summary>
    let ``Cle-privee`` =
        Namespaced_IRI.parse _namespace_name "Cle-privee" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-de-cryptage"></see>
    /// </summary>
    let ``Cle-de-cryptage`` =
        Namespaced_IRI.parse _namespace_name "Cle-de-cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-publique"></see>
    /// </summary>
    let ``Cle-publique`` =
        Namespaced_IRI.parse _namespace_name "Cle-publique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-secrete"></see>
    /// </summary>
    let ``Cle-secrete`` =
        Namespaced_IRI.parse _namespace_name "Cle-secrete" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Composant"></see>
    /// </summary>
    let Composant = Namespaced_IRI.parse _namespace_name "Composant" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Software"></see>
    /// </summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Confiance"></see>
    /// </summary>
    let Confiance = Namespaced_IRI.parse _namespace_name "Confiance" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estMecanisme"></see>
    /// </summary>
    let estMecanisme =
        Namespaced_IRI.parse _namespace_name "estMecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Identification"></see>
    /// </summary>
    let Identification =
        Namespaced_IRI.parse _namespace_name "Identification" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Contremesure-reseau"></see>
    /// </summary>
    let ``Contremesure-reseau`` =
        Namespaced_IRI.parse _namespace_name "Contremesure-reseau" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Controle-dacces"></see>
    /// </summary>
    let ``Controle-dacces`` =
        Namespaced_IRI.parse _namespace_name "Controle-dacces" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Disponibilite"></see>
    /// </summary>
    let Disponibilite =
        Namespaced_IRI.parse _namespace_name "Disponibilite" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cookie"></see>
    /// </summary>
    let Cookie = Namespaced_IRI.parse _namespace_name "Cookie" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cryptage-asymetrique"></see>
    /// </summary>
    let ``Cryptage-asymetrique`` =
        Namespaced_IRI.parse _namespace_name "Cryptage-asymetrique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-Cryptage"></see>
    /// </summary>
    let ``Algorithme-Cryptage`` =
        Namespaced_IRI.parse _namespace_name "Algorithme-Cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#DES"></see>
    /// </summary>
    let DES = Namespaced_IRI.parse _namespace_name "DES" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut"></see>
    /// </summary>
    let Defaut = Namespaced_IRI.parse _namespace_name "Defaut" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut-interaction"></see>
    /// </summary>
    let ``Defaut-interaction`` =
        Namespaced_IRI.parse _namespace_name "Defaut-interaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut-physique"></see>
    /// </summary>
    let ``Defaut-physique`` =
        Namespaced_IRI.parse _namespace_name "Defaut-physique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Deni_de_service"></see>
    /// </summary>
    let Deni_de_service =
        Namespaced_IRI.parse _namespace_name "Deni_de_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Description-logiciel"></see>
    /// </summary>
    let ``Description-logiciel`` =
        Namespaced_IRI.parse _namespace_name "Description-logiciel" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Domaine"></see>
    /// </summary>
    let Domaine = Namespaced_IRI.parse _namespace_name "Domaine" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Echec-technique"></see>
    /// </summary>
    let ``Echec-technique`` =
        Namespaced_IRI.parse _namespace_name "Echec-technique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#ElGamal"></see>
    /// </summary>
    let ElGamal = Namespaced_IRI.parse _namespace_name "ElGamal" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Elliptic_curve"></see>
    /// </summary>
    let Elliptic_curve =
        Namespaced_IRI.parse _namespace_name "Elliptic_curve" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Erreur"></see>
    /// </summary>
    let Erreur = Namespaced_IRI.parse _namespace_name "Erreur" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Firewall"></see>
    /// </summary>
    let Firewall = Namespaced_IRI.parse _namespace_name "Firewall" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Gestion-cles"></see>
    /// </summary>
    let ``Gestion-cles`` =
        Namespaced_IRI.parse _namespace_name "Gestion-cles" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#HMAC"></see>
    /// </summary>
    let HMAC = Namespaced_IRI.parse _namespace_name "HMAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MAC"></see>
    /// </summary>
    let MAC = Namespaced_IRI.parse _namespace_name "MAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hardware"></see>
    /// </summary>
    let Hardware = Namespaced_IRI.parse _namespace_name "Hardware" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hash"></see>
    /// </summary>
    let Hash = Namespaced_IRI.parse _namespace_name "Hash" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#IDEA"></see>
    /// </summary>
    let IDEA = Namespaced_IRI.parse _namespace_name "IDEA" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Imputabilite"></see>
    /// </summary>
    let Imputabilite =
        Namespaced_IRI.parse _namespace_name "Imputabilite" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Integrite"></see>
    /// </summary>
    let Integrite = Namespaced_IRI.parse _namespace_name "Integrite" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#KEA"></see>
    /// </summary>
    let KEA = Namespaced_IRI.parse _namespace_name "KEA" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MD4"></see>
    /// </summary>
    let MD4 = Namespaced_IRI.parse _namespace_name "MD4" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MD5"></see>
    /// </summary>
    let MD5 = Namespaced_IRI.parse _namespace_name "MD5" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Gestion-cle"></see>
    /// </summary>
    let ``Gestion-cle`` =
        Namespaced_IRI.parse _namespace_name "Gestion-cle" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Memoire"></see>
    /// </summary>
    let Memoire = Namespaced_IRI.parse _namespace_name "Memoire" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Microprocesseur"></see>
    /// </summary>
    let Microprocesseur =
        Namespaced_IRI.parse _namespace_name "Microprocesseur" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Mot-de-passe"></see>
    /// </summary>
    let ``Mot-de-passe`` =
        Namespaced_IRI.parse _namespace_name "Mot-de-passe" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Non-repudiation"></see>
    /// </summary>
    let ``Non-repudiation`` =
        Namespaced_IRI.parse _namespace_name "Non-repudiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Norton"></see>
    /// </summary>
    let Norton = Namespaced_IRI.parse _namespace_name "Norton" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Passeport"></see>
    /// </summary>
    let Passeport = Namespaced_IRI.parse _namespace_name "Passeport" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Personne"></see>
    /// </summary>
    let Personne = Namespaced_IRI.parse _namespace_name "Personne" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Proprietaire"></see>
    /// </summary>
    let Proprietaire =
        Namespaced_IRI.parse _namespace_name "Proprietaire" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Societe"></see>
    /// </summary>
    let Societe = Namespaced_IRI.parse _namespace_name "Societe" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protection-physique"></see>
    /// </summary>
    let ``Protection-physique`` =
        Namespaced_IRI.parse _namespace_name "Protection-physique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole"></see>
    /// </summary>
    let Protocole = Namespaced_IRI.parse _namespace_name "Protocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-authentification"></see>
    /// </summary>
    let ``Protocole-authentification`` =
        Namespaced_IRI.parse _namespace_name "Protocole-authentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-cryptage"></see>
    /// </summary>
    let ``Protocole-cryptage`` =
        Namespaced_IRI.parse _namespace_name "Protocole-cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-cles"></see>
    /// </summary>
    let ``Protocole-gestion-cles`` =
        Namespaced_IRI.parse _namespace_name "Protocole-gestion-cles" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-reseau"></see>
    /// </summary>
    let ``Protocole-gestion-reseau`` =
        Namespaced_IRI.parse _namespace_name "Protocole-gestion-reseau" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-signature"></see>
    /// </summary>
    let ``Protocole-signature`` =
        Namespaced_IRI.parse _namespace_name "Protocole-signature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RBAC"></see>
    /// </summary>
    let RBAC = Namespaced_IRI.parse _namespace_name "RBAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC2"></see>
    /// </summary>
    let RC2 = Namespaced_IRI.parse _namespace_name "RC2" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Rivest"></see>
    /// </summary>
    let Rivest = Namespaced_IRI.parse _namespace_name "Rivest" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC4"></see>
    /// </summary>
    let RC4 = Namespaced_IRI.parse _namespace_name "RC4" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC5"></see>
    /// </summary>
    let RC5 = Namespaced_IRI.parse _namespace_name "RC5" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC6"></see>
    /// </summary>
    let RC6 = Namespaced_IRI.parse _namespace_name "RC6" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RSA"></see>
    /// </summary>
    let RSA = Namespaced_IRI.parse _namespace_name "RSA" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#SSH"></see>
    /// </summary>
    let SSH = Namespaced_IRI.parse _namespace_name "SSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#SSL"></see>
    /// </summary>
    let SSL = Namespaced_IRI.parse _namespace_name "SSL" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Signature-numerique"></see>
    /// </summary>
    let ``Signature-numerique`` =
        Namespaced_IRI.parse _namespace_name "Signature-numerique" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Storage"></see>
    /// </summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#TPE"></see>
    /// </summary>
    let TPE = Namespaced_IRI.parse _namespace_name "TPE" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Trojan-horse"></see>
    /// </summary>
    let ``Trojan-horse`` =
        Namespaced_IRI.parse _namespace_name "Trojan-horse" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#TwoFish"></see>
    /// </summary>
    let TwoFish = Namespaced_IRI.parse _namespace_name "TwoFish" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Virus"></see>
    /// </summary>
    let Virus = Namespaced_IRI.parse _namespace_name "Virus" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Vulnerabilite"></see>
    /// </summary>
    let Vulnerabilite =
        Namespaced_IRI.parse _namespace_name "Vulnerabilite" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Worm"></see>
    /// </summary>
    let Worm = Namespaced_IRI.parse _namespace_name "Worm" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#X.509"></see>
    /// </summary>
    let ``X.509`` = Namespaced_IRI.parse _namespace_name "X.509" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#_3DES"></see>
    /// </summary>
    let _3DES = Namespaced_IRI.parse _namespace_name "_3DES" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#assureAuthentification"></see>
    /// </summary>
    let assureAuthentification =
        Namespaced_IRI.parse _namespace_name "assureAuthentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#assureObjectif"></see>
    /// </summary>
    let assureObjectif =
        Namespaced_IRI.parse _namespace_name "assureObjectif" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capableMecanisme"></see>
    /// </summary>
    let capableMecanisme =
        Namespaced_IRI.parse _namespace_name "capableMecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capableObjectif"></see>
    /// </summary>
    let capableObjectif =
        Namespaced_IRI.parse _namespace_name "capableObjectif" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capacite"></see>
    /// </summary>
    let capacite = Namespaced_IRI.parse _namespace_name "capacite" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#chemin"></see>
    /// </summary>
    let chemin = Namespaced_IRI.parse _namespace_name "chemin" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#cible"></see>
    /// </summary>
    let cible = Namespaced_IRI.parse _namespace_name "cible" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#date-expiration"></see>
    /// </summary>
    let ``date-expiration`` =
        Namespaced_IRI.parse _namespace_name "date-expiration" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#dispose"></see>
    /// </summary>
    let dispose = Namespaced_IRI.parse _namespace_name "dispose" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#email"></see>
    /// </summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#eninteractionAvec"></see>
    /// </summary>
    let eninteractionAvec =
        Namespaced_IRI.parse _namespace_name "eninteractionAvec" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estAssureMecanisme"></see>
    /// </summary>
    let estAssureMecanisme =
        Namespaced_IRI.parse _namespace_name "estAssureMecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estAssureProtocole"></see>
    /// </summary>
    let estAssureProtocole =
        Namespaced_IRI.parse _namespace_name "estAssureProtocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#proprietaireDe"></see>
    /// </summary>
    let proprietaireDe =
        Namespaced_IRI.parse _namespace_name "proprietaireDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estProtegePar"></see>
    /// </summary>
    let estProtegePar =
        Namespaced_IRI.parse _namespace_name "estProtegePar" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#protege"></see>
    /// </summary>
    let protege = Namespaced_IRI.parse _namespace_name "protege" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocole"></see>
    /// </summary>
    let estUtiliseProtocole =
        Namespaced_IRI.parse _namespace_name "estUtiliseProtocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleCryptage"></see>
    /// </summary>
    let estUtiliseProtocoleCryptage =
        Namespaced_IRI.parse _namespace_name "estUtiliseProtocoleCryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-Cryptage"></see>
    /// </summary>
    let ``Protocole-Cryptage`` =
        Namespaced_IRI.parse _namespace_name "Protocole-Cryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utilisecryptage"></see>
    /// </summary>
    let utilisecryptage =
        Namespaced_IRI.parse _namespace_name "utilisecryptage" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleSignature"></see>
    /// </summary>
    let estUtiliseProtocoleSignature =
        Namespaced_IRI.parse _namespace_name "estUtiliseProtocoleSignature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseSignature"></see>
    /// </summary>
    let utiliseSignature =
        Namespaced_IRI.parse _namespace_name "utiliseSignature" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estexigeProtocole"></see>
    /// </summary>
    let estexigeProtocole =
        Namespaced_IRI.parse _namespace_name "estexigeProtocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigePasseport"></see>
    /// </summary>
    let exigePasseport =
        Namespaced_IRI.parse _namespace_name "exigePasseport" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estexploitePar"></see>
    /// </summary>
    let estexploitePar =
        Namespaced_IRI.parse _namespace_name "estexploitePar" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exploite"></see>
    /// </summary>
    let exploite = Namespaced_IRI.parse _namespace_name "exploite" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#execute"></see>
    /// </summary>
    let execute = Namespaced_IRI.parse _namespace_name "execute" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigeMecanisme"></see>
    /// </summary>
    let exigeMecanisme =
        Namespaced_IRI.parse _namespace_name "exigeMecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigeObjectif"></see>
    /// </summary>
    let exigeObjectif =
        Namespaced_IRI.parse _namespace_name "exigeObjectif" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estExigeProtocole"></see>
    /// </summary>
    let estExigeProtocole =
        Namespaced_IRI.parse _namespace_name "estExigeProtocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estExploitePar"></see>
    /// </summary>
    let estExploitePar =
        Namespaced_IRI.parse _namespace_name "estExploitePar" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#fax"></see>
    /// </summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#identification"></see>
    /// </summary>
    let identification =
        Namespaced_IRI.parse _namespace_name "identification" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#initialise"></see>
    /// </summary>
    let initialise = Namespaced_IRI.parse _namespace_name "initialise" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#intrusion"></see>
    /// </summary>
    let intrusion = Namespaced_IRI.parse _namespace_name "intrusion" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#issuer"></see>
    /// </summary>
    let issuer = Namespaced_IRI.parse _namespace_name "issuer" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#longueur-cle"></see>
    /// </summary>
    let ``longueur-cle`` =
        Namespaced_IRI.parse _namespace_name "longueur-cle" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#longueur-minimum"></see>
    /// </summary>
    let ``longueur-minimum`` =
        Namespaced_IRI.parse _namespace_name "longueur-minimum" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#marque"></see>
    /// </summary>
    let marque = Namespaced_IRI.parse _namespace_name "marque" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#modele"></see>
    /// </summary>
    let modele = Namespaced_IRI.parse _namespace_name "modele" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#nom"></see>
    /// </summary>
    let nom = Namespaced_IRI.parse _namespace_name "nom" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#notAfter"></see>
    /// </summary>
    let notAfter = Namespaced_IRI.parse _namespace_name "notAfter" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#notBefore"></see>
    /// </summary>
    let notBefore = Namespaced_IRI.parse _namespace_name "notBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#numero-de-serie"></see>
    /// </summary>
    let ``numero-de-serie`` =
        Namespaced_IRI.parse _namespace_name "numero-de-serie" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#prenom"></see>
    /// </summary>
    let prenom = Namespaced_IRI.parse _namespace_name "prenom" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#reduit"></see>
    /// </summary>
    let reduit = Namespaced_IRI.parse _namespace_name "reduit" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#telephone"></see>
    /// </summary>
    let telephone = Namespaced_IRI.parse _namespace_name "telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseAlgorithme"></see>
    /// </summary>
    let utiliseAlgorithme =
        Namespaced_IRI.parse _namespace_name "utiliseAlgorithme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseMecanisme"></see>
    /// </summary>
    let utiliseMecanisme =
        Namespaced_IRI.parse _namespace_name "utiliseMecanisme" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseProtocole"></see>
    /// </summary>
    let utiliseProtocole =
        Namespaced_IRI.parse _namespace_name "utiliseProtocole" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utilisePasseport"></see>
    /// </summary>
    let utilisePasseport =
        Namespaced_IRI.parse _namespace_name "utilisePasseport" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#valeur-cookie"></see>
    /// </summary>
    let ``valeur-cookie`` =
        Namespaced_IRI.parse _namespace_name "valeur-cookie" |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#vitesse"></see>
    /// </summary>
    let vitesse = Namespaced_IRI.parse _namespace_name "vitesse" |> NamespacedName
