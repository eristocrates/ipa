namespace http.www.w3.org.ns.person.hash

open DoxAletheia

module person =
    let _namespace_name = "http://www.w3.org/ns/person#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An individual person who may be dead or alive, but not imaginary. It is that restriction that makes person:Person a sub class of both foaf:Person and schema:Person which both cover imaginary characters as well as real people.
    /// <see href="http://www.w3.org/ns/person#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// All data associated with an individual is subject to change. Names can change for a variety of reasons, either formally or informally, and new information may come to light that means that a correction or clarification can be made to an existing record. Birth names tend to be persistent however and for this reason they are recorded by some public sector information systems. There is no granularity for birth name - the full name should be recorded in a single field.
    /// <see href="http://www.w3.org/ns/person#birthName"></see></summary>
    let birthName = _prefix "birthName"
    /// <summary>
    /// The citizenship relationship links a Person to a Jurisdiction that has conferred citizenship rights on the individual such as the right to vote, to receive certain protection from the community or the issuance of a passport. Multiple citizenships are recorded as multiple instances of the citizenship relationship.
    /// <see href="http://www.w3.org/ns/person#citizenship"></see></summary>
    let citizenship = _prefix "citizenship"
    /// <summary>
    /// The country in which a Person was born.
    /// <see href="http://www.w3.org/ns/person#countryOfBirth"></see></summary>
    let countryOfBirth = _prefix "countryOfBirth"
    /// <summary>
    /// The country in which a Person died.
    /// <see href="http://www.w3.org/ns/person#countryOfDeath"></see></summary>
    let countryOfDeath = _prefix "countryOfDeath"
    /// <summary>
    /// Patronymic names are important in some countries. Iceland does not have a concept of family name in the way that many other European countries do, for example. In Bulgaria and Russia, patronymic names are in every day usage, for example, the &amp;quot;Sergeyevich&amp;quot; (Сергеевич) in &amp;quot;Mikhail Sergeyevich Gorbachev&amp;quot; (Михаил Сергеевич Горбачёв).
    /// <see href="http://www.w3.org/ns/person#patronymicName"></see></summary>
    let patronymicName = _prefix "patronymicName"
    /// <summary>
    /// A person's place of birth.
    /// <see href="http://www.w3.org/ns/person#placeOfBirth"></see></summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    /// A person's place of death.
    /// <see href="http://www.w3.org/ns/person#placeOfDeath"></see></summary>
    let placeOfDeath = _prefix "placeOfDeath"
    /// <summary>
    /// Residency typically provides an individual with a subset of the rights of a citizen.
    /// <see href="http://www.w3.org/ns/person#residency"></see></summary>
    let residency = _prefix "residency"
