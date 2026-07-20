namespace http.securitytoolbox.appspot.com.MASO.hash

open DoxAletheia

module maso =
    let _namespace_name = "http://securitytoolbox.appspot.com/MASO#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#AES"></see>
    /// </summary>
    let AES = _prefix "AES"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cryptage-symetrique"></see>
    /// </summary>
    let ``Cryptage-symetrique`` = _prefix "Cryptage-symetrique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#AVG"></see>
    /// </summary>
    let AVG = _prefix "AVG"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Antivirus"></see>
    /// </summary>
    let Antivirus = _prefix "Antivirus"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Adresse"></see>
    /// </summary>
    let Adresse = _prefix "Adresse"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Token-electronique"></see>
    /// </summary>
    let ``Token-electronique`` = _prefix "Token-electronique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Adresse-iP"></see>
    /// </summary>
    let ``Adresse-iP`` = _prefix "Adresse-iP"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hote"></see>
    /// </summary>
    let Hote = _prefix "Hote"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estPropriete"></see>
    /// </summary>
    let estPropriete = _prefix "estPropriete"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#s_execute"></see>
    /// </summary>
    let s_execute = _prefix "s_execute"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Entite"></see>
    /// </summary>
    let Entite = _prefix "Entite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#H%C3%B4te"></see>
    /// </summary>
    let ``H%C3%B4te`` = _prefix "H%C3%B4te"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme"></see>
    /// </summary>
    let Algorithme = _prefix "Algorithme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-checksum"></see>
    /// </summary>
    let ``Algorithme-checksum`` = _prefix "Algorithme-checksum"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-cryptage"></see>
    /// </summary>
    let ``Algorithme-cryptage`` = _prefix "Algorithme-cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-gestion-cles"></see>
    /// </summary>
    let ``Algorithme-gestion-cles`` = _prefix "Algorithme-gestion-cles"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-signature"></see>
    /// </summary>
    let ``Algorithme-signature`` = _prefix "Algorithme-signature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Contremesure"></see>
    /// </summary>
    let Contremesure = _prefix "Contremesure"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Attaque"></see>
    /// </summary>
    let Attaque = _prefix "Attaque"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Menace"></see>
    /// </summary>
    let Menace = _prefix "Menace"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Authentification"></see>
    /// </summary>
    let Authentification = _prefix "Authentification"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Objectif"></see>
    /// </summary>
    let Objectif = _prefix "Objectif"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Confidentialite"></see>
    /// </summary>
    let Confidentialite = _prefix "Confidentialite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Mecanisme"></see>
    /// </summary>
    let Mecanisme = _prefix "Mecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Autorisation"></see>
    /// </summary>
    let Autorisation = _prefix "Autorisation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#BlowFish"></see>
    /// </summary>
    let BlowFish = _prefix "BlowFish"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#CAST"></see>
    /// </summary>
    let CAST = _prefix "CAST"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Carte-credit"></see>
    /// </summary>
    let ``Carte-credit`` = _prefix "Carte-credit"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Token-physique"></see>
    /// </summary>
    let ``Token-physique`` = _prefix "Token-physique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Certificat"></see>
    /// </summary>
    let Certificat = _prefix "Certificat"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-de-Cryptage"></see>
    /// </summary>
    let ``Cle-de-Cryptage`` = _prefix "Cle-de-Cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-privee"></see>
    /// </summary>
    let ``Cle-privee`` = _prefix "Cle-privee"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-de-cryptage"></see>
    /// </summary>
    let ``Cle-de-cryptage`` = _prefix "Cle-de-cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-publique"></see>
    /// </summary>
    let ``Cle-publique`` = _prefix "Cle-publique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cle-secrete"></see>
    /// </summary>
    let ``Cle-secrete`` = _prefix "Cle-secrete"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Composant"></see>
    /// </summary>
    let Composant = _prefix "Composant"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Software"></see>
    /// </summary>
    let Software = _prefix "Software"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Confiance"></see>
    /// </summary>
    let Confiance = _prefix "Confiance"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estMecanisme"></see>
    /// </summary>
    let estMecanisme = _prefix "estMecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Identification"></see>
    /// </summary>
    let Identification = _prefix "Identification"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Contremesure-reseau"></see>
    /// </summary>
    let ``Contremesure-reseau`` = _prefix "Contremesure-reseau"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Controle-dacces"></see>
    /// </summary>
    let ``Controle-dacces`` = _prefix "Controle-dacces"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Disponibilite"></see>
    /// </summary>
    let Disponibilite = _prefix "Disponibilite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cookie"></see>
    /// </summary>
    let Cookie = _prefix "Cookie"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Cryptage-asymetrique"></see>
    /// </summary>
    let ``Cryptage-asymetrique`` = _prefix "Cryptage-asymetrique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Algorithme-Cryptage"></see>
    /// </summary>
    let ``Algorithme-Cryptage`` = _prefix "Algorithme-Cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#DES"></see>
    /// </summary>
    let DES = _prefix "DES"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut"></see>
    /// </summary>
    let Defaut = _prefix "Defaut"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut-interaction"></see>
    /// </summary>
    let ``Defaut-interaction`` = _prefix "Defaut-interaction"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Defaut-physique"></see>
    /// </summary>
    let ``Defaut-physique`` = _prefix "Defaut-physique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Deni_de_service"></see>
    /// </summary>
    let Deni_de_service = _prefix "Deni_de_service"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Description-logiciel"></see>
    /// </summary>
    let ``Description-logiciel`` = _prefix "Description-logiciel"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Domaine"></see>
    /// </summary>
    let Domaine = _prefix "Domaine"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Echec-technique"></see>
    /// </summary>
    let ``Echec-technique`` = _prefix "Echec-technique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#ElGamal"></see>
    /// </summary>
    let ElGamal = _prefix "ElGamal"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Elliptic_curve"></see>
    /// </summary>
    let Elliptic_curve = _prefix "Elliptic_curve"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Erreur"></see>
    /// </summary>
    let Erreur = _prefix "Erreur"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Firewall"></see>
    /// </summary>
    let Firewall = _prefix "Firewall"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Gestion-cles"></see>
    /// </summary>
    let ``Gestion-cles`` = _prefix "Gestion-cles"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#HMAC"></see>
    /// </summary>
    let HMAC = _prefix "HMAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MAC"></see>
    /// </summary>
    let MAC = _prefix "MAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hardware"></see>
    /// </summary>
    let Hardware = _prefix "Hardware"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Hash"></see>
    /// </summary>
    let Hash = _prefix "Hash"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#IDEA"></see>
    /// </summary>
    let IDEA = _prefix "IDEA"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Imputabilite"></see>
    /// </summary>
    let Imputabilite = _prefix "Imputabilite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Integrite"></see>
    /// </summary>
    let Integrite = _prefix "Integrite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#KEA"></see>
    /// </summary>
    let KEA = _prefix "KEA"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MD4"></see>
    /// </summary>
    let MD4 = _prefix "MD4"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#MD5"></see>
    /// </summary>
    let MD5 = _prefix "MD5"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Gestion-cle"></see>
    /// </summary>
    let ``Gestion-cle`` = _prefix "Gestion-cle"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Memoire"></see>
    /// </summary>
    let Memoire = _prefix "Memoire"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Microprocesseur"></see>
    /// </summary>
    let Microprocesseur = _prefix "Microprocesseur"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Mot-de-passe"></see>
    /// </summary>
    let ``Mot-de-passe`` = _prefix "Mot-de-passe"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Non-repudiation"></see>
    /// </summary>
    let ``Non-repudiation`` = _prefix "Non-repudiation"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Norton"></see>
    /// </summary>
    let Norton = _prefix "Norton"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Passeport"></see>
    /// </summary>
    let Passeport = _prefix "Passeport"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Personne"></see>
    /// </summary>
    let Personne = _prefix "Personne"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Proprietaire"></see>
    /// </summary>
    let Proprietaire = _prefix "Proprietaire"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Societe"></see>
    /// </summary>
    let Societe = _prefix "Societe"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protection-physique"></see>
    /// </summary>
    let ``Protection-physique`` = _prefix "Protection-physique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole"></see>
    /// </summary>
    let Protocole = _prefix "Protocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-authentification"></see>
    /// </summary>
    let ``Protocole-authentification`` = _prefix "Protocole-authentification"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-cryptage"></see>
    /// </summary>
    let ``Protocole-cryptage`` = _prefix "Protocole-cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-cles"></see>
    /// </summary>
    let ``Protocole-gestion-cles`` = _prefix "Protocole-gestion-cles"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-gestion-reseau"></see>
    /// </summary>
    let ``Protocole-gestion-reseau`` = _prefix "Protocole-gestion-reseau"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-signature"></see>
    /// </summary>
    let ``Protocole-signature`` = _prefix "Protocole-signature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RBAC"></see>
    /// </summary>
    let RBAC = _prefix "RBAC"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC2"></see>
    /// </summary>
    let RC2 = _prefix "RC2"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Rivest"></see>
    /// </summary>
    let Rivest = _prefix "Rivest"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC4"></see>
    /// </summary>
    let RC4 = _prefix "RC4"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC5"></see>
    /// </summary>
    let RC5 = _prefix "RC5"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RC6"></see>
    /// </summary>
    let RC6 = _prefix "RC6"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#RSA"></see>
    /// </summary>
    let RSA = _prefix "RSA"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#SSH"></see>
    /// </summary>
    let SSH = _prefix "SSH"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#SSL"></see>
    /// </summary>
    let SSL = _prefix "SSL"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Signature-numerique"></see>
    /// </summary>
    let ``Signature-numerique`` = _prefix "Signature-numerique"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Storage"></see>
    /// </summary>
    let Storage = _prefix "Storage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#TPE"></see>
    /// </summary>
    let TPE = _prefix "TPE"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Trojan-horse"></see>
    /// </summary>
    let ``Trojan-horse`` = _prefix "Trojan-horse"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#TwoFish"></see>
    /// </summary>
    let TwoFish = _prefix "TwoFish"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Virus"></see>
    /// </summary>
    let Virus = _prefix "Virus"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Vulnerabilite"></see>
    /// </summary>
    let Vulnerabilite = _prefix "Vulnerabilite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Worm"></see>
    /// </summary>
    let Worm = _prefix "Worm"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#X.509"></see>
    /// </summary>
    let ``X.509`` = _prefix "X.509"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#_3DES"></see>
    /// </summary>
    let _3DES = _prefix "_3DES"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#assureAuthentification"></see>
    /// </summary>
    let assureAuthentification = _prefix "assureAuthentification"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#assureObjectif"></see>
    /// </summary>
    let assureObjectif = _prefix "assureObjectif"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capableMecanisme"></see>
    /// </summary>
    let capableMecanisme = _prefix "capableMecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capableObjectif"></see>
    /// </summary>
    let capableObjectif = _prefix "capableObjectif"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#capacite"></see>
    /// </summary>
    let capacite = _prefix "capacite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#chemin"></see>
    /// </summary>
    let chemin = _prefix "chemin"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#cible"></see>
    /// </summary>
    let cible = _prefix "cible"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#date-expiration"></see>
    /// </summary>
    let ``date-expiration`` = _prefix "date-expiration"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#dispose"></see>
    /// </summary>
    let dispose = _prefix "dispose"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#email"></see>
    /// </summary>
    let email = _prefix "email"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#eninteractionAvec"></see>
    /// </summary>
    let eninteractionAvec = _prefix "eninteractionAvec"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estAssureMecanisme"></see>
    /// </summary>
    let estAssureMecanisme = _prefix "estAssureMecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estAssureProtocole"></see>
    /// </summary>
    let estAssureProtocole = _prefix "estAssureProtocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#proprietaireDe"></see>
    /// </summary>
    let proprietaireDe = _prefix "proprietaireDe"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estProtegePar"></see>
    /// </summary>
    let estProtegePar = _prefix "estProtegePar"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#protege"></see>
    /// </summary>
    let protege = _prefix "protege"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocole"></see>
    /// </summary>
    let estUtiliseProtocole = _prefix "estUtiliseProtocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleCryptage"></see>
    /// </summary>
    let estUtiliseProtocoleCryptage = _prefix "estUtiliseProtocoleCryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#Protocole-Cryptage"></see>
    /// </summary>
    let ``Protocole-Cryptage`` = _prefix "Protocole-Cryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utilisecryptage"></see>
    /// </summary>
    let utilisecryptage = _prefix "utilisecryptage"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estUtiliseProtocoleSignature"></see>
    /// </summary>
    let estUtiliseProtocoleSignature = _prefix "estUtiliseProtocoleSignature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseSignature"></see>
    /// </summary>
    let utiliseSignature = _prefix "utiliseSignature"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estexigeProtocole"></see>
    /// </summary>
    let estexigeProtocole = _prefix "estexigeProtocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigePasseport"></see>
    /// </summary>
    let exigePasseport = _prefix "exigePasseport"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estexploitePar"></see>
    /// </summary>
    let estexploitePar = _prefix "estexploitePar"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exploite"></see>
    /// </summary>
    let exploite = _prefix "exploite"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#execute"></see>
    /// </summary>
    let execute = _prefix "execute"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigeMecanisme"></see>
    /// </summary>
    let exigeMecanisme = _prefix "exigeMecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#exigeObjectif"></see>
    /// </summary>
    let exigeObjectif = _prefix "exigeObjectif"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estExigeProtocole"></see>
    /// </summary>
    let estExigeProtocole = _prefix "estExigeProtocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#estExploitePar"></see>
    /// </summary>
    let estExploitePar = _prefix "estExploitePar"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#fax"></see>
    /// </summary>
    let fax = _prefix "fax"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#identification"></see>
    /// </summary>
    let identification = _prefix "identification"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#initialise"></see>
    /// </summary>
    let initialise = _prefix "initialise"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#intrusion"></see>
    /// </summary>
    let intrusion = _prefix "intrusion"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#issuer"></see>
    /// </summary>
    let issuer = _prefix "issuer"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#longueur-cle"></see>
    /// </summary>
    let ``longueur-cle`` = _prefix "longueur-cle"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#longueur-minimum"></see>
    /// </summary>
    let ``longueur-minimum`` = _prefix "longueur-minimum"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#marque"></see>
    /// </summary>
    let marque = _prefix "marque"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#modele"></see>
    /// </summary>
    let modele = _prefix "modele"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#nom"></see>
    /// </summary>
    let nom = _prefix "nom"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#notAfter"></see>
    /// </summary>
    let notAfter = _prefix "notAfter"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#notBefore"></see>
    /// </summary>
    let notBefore = _prefix "notBefore"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#numero-de-serie"></see>
    /// </summary>
    let ``numero-de-serie`` = _prefix "numero-de-serie"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#prenom"></see>
    /// </summary>
    let prenom = _prefix "prenom"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#reduit"></see>
    /// </summary>
    let reduit = _prefix "reduit"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#telephone"></see>
    /// </summary>
    let telephone = _prefix "telephone"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseAlgorithme"></see>
    /// </summary>
    let utiliseAlgorithme = _prefix "utiliseAlgorithme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseMecanisme"></see>
    /// </summary>
    let utiliseMecanisme = _prefix "utiliseMecanisme"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utiliseProtocole"></see>
    /// </summary>
    let utiliseProtocole = _prefix "utiliseProtocole"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#utilisePasseport"></see>
    /// </summary>
    let utilisePasseport = _prefix "utilisePasseport"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#valeur-cookie"></see>
    /// </summary>
    let ``valeur-cookie`` = _prefix "valeur-cookie"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://securitytoolbox.appspot.com/MASO#vitesse"></see>
    /// </summary>
    let vitesse = _prefix "vitesse"
