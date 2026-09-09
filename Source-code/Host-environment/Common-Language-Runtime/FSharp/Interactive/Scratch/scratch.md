Yes. After looking through the current vocabularies, I would not attempt to find a single ontology and make personal finance conform to it. There is a much cleaner decomposition available.

The strongest combination I found is:

**ValueFlows for the prospective/operational layer** — what we intend to spend, what we have committed to, what actually occurred.

**A very small subset of FIBO for specifically financial semantics** — money, accounts, balances, payments, formal payment obligations, and loans.

**SKOS for our own budget/category taxonomy** — because “groceries”, “household”, “discretionary”, “recurring essential”, etc. are classifications, not financial instrument classes.

That gets surprisingly close to the ontology I would actually want for personal financial management, without swallowing FIBO.

### The namespaces worth starting with

| Vocabulary / module                 | What I would use it for                                                                            | Assessment                                             |
| ----------------------------------- | -------------------------------------------------------------------------------------------------- | ------------------------------------------------------ |
| **ValueFlows (`vf`)**               | planned expenditures, expected income, commitments, actual economic events, fulfillment, due dates | **Core**                                               |
| **FIBO CurrencyAmount**             | money amounts and currencies                                                                       | **Core**                                               |
| **FIBO ClientsAndAccounts**         | bank/card/loan accounts, balances, statements, account transactions                                | **Core**                                               |
| **FIBO Agreements**                 | commitments, obligors/obligees, agreements                                                         | **Core when obligations matter**                       |
| **FIBO PaymentsAndSchedules**       | payments, payer/payee, payment schedules, fulfillment of formal payment obligations                | **Core for bills/debt**                                |
| **SKOS**                            | personal expense/income/budget categories                                                          | **Core**                                               |
| **FIBO Loans**                      | principal, loan balance, loan payment schedules, payment histories                                 | Add when needed                                        |
| **Schema.org financial vocabulary** | lightweight interchange for accounts, loans, invoices, monetary amounts                            | Peripheral                                             |
| **Payments Ontology**               | simple payment/expenditure records                                                                 | Interesting, but dated                                 |
| **FIBO CashFlows**                  | cash-flow semantics                                                                                | Potentially useful, but currently only **Provisional** |

FIBO itself is explicitly modular. Its current ontology tree separates `ClientsAndAccounts`, `CurrencyAmount`, `Agreements`, `PaymentsAndSchedules`, `Loans`, etc.; there is no reason to treat FIBO as one indivisible vocabulary. ([Spec.org][1])

So I would start with **individual ontology namespaces**, not `LoadFIBO`, `AllFND`, `AllFBC`, etc.

---

## 1. ValueFlows may actually be the most important discovery here

[ValueFlows specification](https://www.valueflo.ws/specification/spec-overview/?utm_source=chatgpt.com)
Exact namespace: [ValueFlows `vf:` namespace](https://w3id.org/valueflows/ont/vf?utm_source=chatgpt.com)

Its authoritative specification uses the `vf` prefix and that namespace. ([Valueflows][2])

ValueFlows is based on the REA family of economic models, and its distinction between these three concepts maps exceptionally well onto personal budgeting:

* `vf:Intent` — a desired, proposed, planned, or **estimated** economic flow, potentially involving only one agent.
* `vf:Commitment` — a planned economic flow that has actually been scheduled or promised from one agent to another.
* `vf:EconomicEvent` — an economic flow that has actually occurred. ([Valueflows][3])

That gives us a distinction that a budgeting system badly needs:

> **anticipated → committed → actual**

For example:

```turtle
:SeptemberGroceries
    a vf:Intent .

:SeptemberRent
    a vf:Commitment .

:SeptemberRentPayment
    a vf:EconomicEvent ;
    vf:fulfills :SeptemberRent .
```

The last relation is actually defined by ValueFlows: `vf:fulfills` relates an economic event to the commitment that it completely or partially fulfills. ([Valueflows][3])

This immediately avoids one of the conceptual traps I would expect from using FIBO alone. A budgeted `$400 for groceries` is **not an obligation** and probably not even a commitment. It is an estimate/intention. ValueFlows has an extant class expressly capable of saying that.

It also has `vf:due`, whose domain includes `Intent`, `Commitment`, `Claim`, and `Plan`, so anticipated and committed expenditures can carry due dates without pretending that all of them are legal debts. ([Valueflows][3])

That is unusually well aligned with the problem.

---

## 2. FIBO `CurrencyAmount`

Prefix I would use: `fibo-cur`.

Exact namespace: [FIBO FND Accounting — CurrencyAmount](https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/?utm_source=chatgpt.com)

This is the obvious foundation whenever the object really is money. FIBO defines `MonetaryAmount`, currencies, and monetary-amount relationships; the current ontology explicitly identifies this namespace. 

The important distinction FIBO makes is that a monetary amount isn't just an arbitrary decimal. `fibo-cur:MonetaryAmount` combines a value with a currency.

I would use that rather than inventing things such as:

```turtle
:thing :amount 123.45 .
```

There is one qualification: FIBO has increasingly migrated generic quantity semantics into **OMG Commons**, so following the complete OWL structure of `MonetaryAmount` will pull us into Commons concepts as well. That does not mean we need the entire FIBO import closure in the operational graph.

In an RDF store, we can quite legitimately **use the IRIs as vocabulary terms without loading every imported ontology into every data graph**. The ontology/import closure can be maintained separately for reasoning, documentation, validation, or code generation.

---

## 3. FIBO `ClientsAndAccounts` is far more relevant than its name initially suggests

Prefix: `fibo-acct`.

Exact namespace: [FIBO FBC — ClientsAndAccounts](https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/?utm_source=chatgpt.com)

The current source declares precisely that namespace. 

This ontology contains a surprising amount of the mundane personal-finance machinery we actually need:

`Account`, `CustomerAccount`, `DemandDepositAccount`, `LoanOrCreditAccount`, `AccountStatement`, `Balance`, `AccountingTransaction`, `IndividualTransaction`, account holders, transaction dates, posting dates, payment due dates, starting/ending balances, and transaction descriptions.

For example, FIBO defines `Balance` as a subclass of `MonetaryAmount`, specifically an amount of money **available or owed**. It also defines an `AccountingTransaction` as an event recognized by an entry in an account's records. 

It also explicitly treats monthly credit-card bills as account statements, and lets an `AccountStatement` record individual transactions. 

That means this one ontology gets us quite a long way toward representing imported bank data.

Conceptually:

```turtle
:Checking
    a fibo-acct:DemandDepositAccount .

:CheckingBalance
    a fibo-acct:Balance .

:Transaction_20260904_001
    a fibo-acct:IndividualTransaction .
```

I would distinguish this **account-record view** from ValueFlows' **economic-event view**. They are related but aren't necessarily identical concepts.

A card transaction, for example, may simultaneously warrant an economic event representation and a particular account's transaction record. We should not collapse those layers prematurely.

---

## 4. FIBO `Agreements`

Prefix: `fibo-agr`.

Exact namespace: [FIBO FND — Agreements](https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/?utm_source=chatgpt.com)

The namespace is current FIBO. 

The useful classes here include:

`Agreement`
`BilateralAgreement`
`Commitment`
`Obligor`
`Obligee`

FIBO defines `Commitment` as a promise by a party to act or refrain from acting, and explicitly notes the associated relationship between commitments, rights and obligations. 

This is useful for things such as:

* rental agreements
* subscription agreements
* repayment agreements
* service contracts
* installment arrangements
* perhaps promises made between family members, depending upon how formal we want our model

But I would **not** call every budget line a FIBO `Commitment`. Its semantics are stronger than “we expect this expenditure.”

That is another reason ValueFlows' `Intent` is useful alongside it.

---

## 5. FIBO `PaymentsAndSchedules`

Prefix: `fibo-pay`.

Exact namespace: [FIBO FND — PaymentsAndSchedules](https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/?utm_source=chatgpt.com)

This ontology sits directly on top of `CurrencyAmount`, `Agreements`, contracts and FIBO's date/scheduling modules. 

Its particularly useful concepts are:

`Payment`
`PaymentEvent`
`PaymentObligation`
`PaymentSchedule`
`Payer`
`Payee`
`hasPaymentAmount`
`hasPaymentSchedule`
`fulfillsObligation`

`Payment` is explicitly a delivery of money in fulfillment of an obligation. `fulfillsObligation` relates that payment to the payment obligation it satisfies. 

For an actual contractual obligation, we can therefore say something structurally like:

```turtle
:SeptemberRentObligation
    a fibo-pay:PaymentObligation .

:SeptemberRentPayment
    a fibo-pay:Payment ;
    fibo-pay:fulfillsObligation :SeptemberRentObligation .
```

There is, however, an **important boundary condition** here.

FIBO currently defines `PaymentObligation` as a **legally enforceable duty** to pay money under a contract. 

So:

* rent under a lease → very plausible `PaymentObligation`
* credit-card minimum payment → plausible
* loan installment → plausible
* utility bill → likely, depending on contractual relationship
* “we should set aside $200 for car repairs” → **absolutely not**
* desired grocery allocation → **not**
* anticipated discretionary purchase → **not**

That distinction is exactly why I would not make `PaymentObligation` the root of the budgeting model.

---

## 6. SKOS is probably the right answer for budget categories

Exact namespace: `skos:` is already imported by FIBO itself as the W3C SKOS vocabulary; the current FIBO source uses it directly. 

Our categories such as:

```text
Expense
    Housing
        Rent
        Maintenance
    Utilities
        Electricity
        Internet
    Food
        Groceries
        Dining
    Transportation
    Medical
    Debt Service
    Discretionary
```

are much more naturally a `skos:ConceptScheme` than an OWL class hierarchy.

That distinction matters. A grocery transaction isn't ontologically *an instance of Groceries* in the same sense that a checking account is an instance of `DemandDepositAccount`. “Groceries” is a **classification imposed for financial analysis**.

So I would be quite comfortable defining our own scheme:

```turtle
:BudgetCategories
    a skos:ConceptScheme .

:Groceries
    a skos:Concept ;
    skos:inScheme :BudgetCategories ;
    skos:broader :Food .
```

Then a tiny local predicate can associate an intent, commitment, transaction, etc. with its budget category.

This is not ontology failure. It is exactly what a local application vocabulary is for.

Interesting corroboration: the older Linked Data **Payments Ontology** explicitly recommends representing expenditure categorization schemes as SKOS Concept Schemes rather than hard-coding categories into its ontology. ([Epimorphics][4])

---

## 7. FIBO Loans, only when the debt model requires it

Prefix: `fibo-loan`.

Exact namespace: [FIBO LOAN — Loans](https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/?utm_source=chatgpt.com)

The current source declares this namespace directly. 

This is worth adding if personal finances include loans whose internal structure we actually want to analyze. It defines, among other things:

* `Loan`
* `LoanSpecificCustomerAccount`
* `LoanPaymentSchedule`
* loan balance
* payment history
* principal amount

`LoanPaymentSchedule` specializes FIBO's general `PaymentSchedule`, while `LoanSpecificCustomerAccount` specializes both customer and loan/credit accounts. 

That is a good example of how the FIBO modules can be added progressively rather than beginning with the entire ontology.

---

## What I would *not* make foundational

**FIBO CashFlows** sounds obvious from the name, but the current ontology is still marked **Provisional**, rather than Release. I would examine it for terms, but would not make our personal ontology structurally dependent upon it yet.

**Schema.org** has useful `MonetaryAmount`, `BankAccount`, `LoanOrCredit`, `PaymentCard`, `Invoice`, `RepaymentSpecification`, etc. It is useful as an interoperability/publishing surface, but its model is much less expressive for “planned vs committed vs incurred vs paid”.

**The Payments Ontology** uses the namespace [Payments Ontology namespace](https://reference.data.gov.uk/def/payment?utm_source=chatgpt.com). It has straightforward payment/payee/payer/expenditure concepts and explicitly supports SKOS expenditure categories. ([Epimorphics][4]) I like its simplicity, but it dates from the UK Linked Data/public-spending effort and I wouldn't choose it over the currently maintained ValueFlows + FIBO combination for a new system.

I also found public-sector “budget” ontologies, but I would **not reuse them simply because they contain a class named `Budget`**. Their concepts are generally tied to public-sector accounting, revenue accounts, statistical reporting, appropriations, organizational services, etc. That is the wrong intensional meaning for a household budget.

---

## The ontology boundary I think is most productive

I would therefore make the first semantic partition something like:

```text
vf:Intent
    prospective / estimated
    "we expect or desire this flow"

vf:Commitment
    promised / scheduled
    "this flow is actually committed"

fibo-pay:PaymentObligation
    legally enforceable monetary duty
    "we owe this"

vf:EconomicEvent
    observed actual economic flow
    "this happened"

fibo-pay:Payment
    actual transfer of money satisfying an obligation
    "this was paid"

fibo-acct:IndividualTransaction
    transaction as represented in an account's records
    "the bank/card/account recorded this"
```

Those are **not six names for the same thing**. They are six useful states/perspectives on financial reality.

For personal finance, that is extremely valuable. It lets us represent the difference between:

```text
$600 planned for groceries
$150 expected electric bill
$1,400 rent contractually due
$73.21 actually spent at a supermarket
$1,400 transfer actually made
$1,400 debit appearing on checking account
```

without forcing all six into an undifferentiated `Transaction`.

And importantly, we do **not** need to invent most of those semantics.

If I were choosing the actual starting namespace set today, it would be **ValueFlows + FIBO CurrencyAmount + FIBO ClientsAndAccounts + SKOS**, then **Agreements/PaymentsAndSchedules** as soon as we model obligations. Everything else can be acquired incrementally. That is small enough to inspect term-by-term while still giving us a serious semantic substrate. ([Valueflows][3])

[1]: https://spec.edmcouncil.org/fibo/ontology/master/latest/tree.html "Ontology file directory ."
[2]: https://www.valueflo.ws/specification/spec-overview/ "Specification Overview - Valueflows"
[3]: https://www.valueflo.ws/specification/all_vf.html "Valueflows Ontology"
[4]: https://www.epimorphics.com/guide-to-the-payments-ontology/ "Guide to the Payments Ontology - Epimorphics"

-------------------------------------------------------------------------------------
Correct on both points.

The phrase “our categories” was erroneous: I introduced illustrative categories and then referred to them as though they were already part of the model. They were not.

More importantly, there are extant classifications that can supply actual category individuals rather than merely giving us `skos:Concept` with nothing to instantiate. The strongest one I found is substantially better than what I gave before.

### COICOP / ECOICOP 2 is probably the primary expenditure taxonomy

The UN's **Classification of Individual Consumption According to Purpose (COICOP)** is explicitly the international reference classification of **household expenditure**, including use in household budget surveys and living-standards analysis. ([UNSD][1])

Even better for RDF purposes, Eurostat publishes the European form as Linked Open Data. Eurostat states that its classifications are represented using **SKOS + XKOS**, with the classification entries themselves being `skos:Concept`s and their hierarchy represented through SKOS relations. ([CROS][2])

The current version is **ECOICOP version 2**, which Eurostat states is identical to **UN COICOP 2018 down to the five-digit level**. It became the operative HICP classification in January 2026. ([European Commission][3])

Most usefully, I was able to pin down the actual current concept-scheme URI:

```text
http://data.europa.eu/ed1/ecoicop2/ecoicop2
```

and the Publications Office dataset identifier is:

```text
http://publications.europa.eu/resource/dataset/ecoicop2
```

The former is cited directly by Statistics Sweden in its 2026 regulations as the official EU classification resource. ([Statistikmyndigheten SCB][4])

So this is not a taxonomy we would need to reconstruct ourselves.

Its top-level categories are already highly recognizable as personal expenditure categories:

```text
01  Food and non-alcoholic beverages
02  Alcoholic beverages, tobacco and narcotics
03  Clothing and footwear
04  Housing, water, electricity, gas and other fuels
05  Furnishings, household equipment and routine household maintenance
06  Health
07  Transport
08  Information and communication
09  Recreation, sport and culture
10  Education services
11  Restaurants and accommodation services
12  Insurance and financial services
13  Personal care, social protection and miscellaneous goods and services
```

Those are not merely headings. ECOICOP 2 continues hierarchically through **groups → classes → subclasses**, down to five digits. ([European Commission][3])

For example, division 04 decomposes through things such as rental payments, dwelling maintenance/repair, water-related services, electricity, gas, and other fuels. ([UNSD][5])

This means an expenditure need not merely be tagged:

```turtle
:expense :category :Housing .
```

It can refer to an **external classification concept with an internationally defined intensional meaning**.

That is much closer to what we actually need.

There is also an older, extremely convenient RDF publication of Eurostat COICOP in Eionet:

```text
http://dd.eionet.europa.eu/vocabulary/eurostat/coicop/
```

It is explicitly a released RDF vocabulary and currently exposes **804 concepts**, with RDF and JSON-LD downloads. For example:

```text
http://dd.eionet.europa.eu/vocabulary/eurostat/coicop/CP01
```

is the concept *Food and non-alcoholic beverages*. ([Eionet][6])

That instance is based on the older classification rather than ECOICOP 2, so for new modelling I would favor ECOICOP 2. But the Eionet publication is useful evidence of exactly the semantic architecture we're after.

### COICOP is not sufficient for *all* personal-finance outflows

There is an important boundary here.

COICOP classifies **individual consumption by purpose**. It therefore gives us a superb answer to:

> What kind of consumption expenditure was this?

It does not necessarily answer:

> What kind of movement of money was this?

Those are different classifications.

For example:

```text
$80 grocery purchase
```

is naturally COICOP.

But:

```text
$500 transferred into savings
$300 credit-card principal repayment
$2,000 income-tax payment
$100 brokerage contribution
$500 received as wages
```

should not be forcibly squeezed into consumption classes.

This is where the other vocabularies become complementary rather than competitive.

### FIBO `CashFlows` is useful, provisional or not

I understated this previously because I treated its maturity status as more consequential than it is for this use.

Namespace:

```text
https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/
```

The ontology is actually quite small and focused. It defines:

```text
CashFlow
CashFlowStructure
TriggeringEvent

hasSourceOfMoney
hasTargetOfMoney
```

A `CashFlow` is defined as the movement of money from a source to a sink, and its OWL restrictions require exactly one source, exactly one target, and exactly one `MonetaryAmount`. 

That is immediately useful for personal finance.

Conceptually:

```text
checking account
      │
      │ $67.43
      ▼
electric utility
```

can be represented independently of whether that movement is:

* a payment,
* a fulfillment of an obligation,
* an account transaction,
* an economic event,
* or classified under an expenditure-purpose taxonomy.

That separation is desirable.

`CashFlowStructure` is potentially even more interesting. FIBO describes it as a structure containing one or more cash flows, and explicitly says such a structure may include a **schedule, historic payments, projected payments, relevant contracts/accounts, and triggering events**. 

That sounds directly applicable to something like:

```text
Electricity account
    expected monthly cash flows
    actual historic cash flows
    relevant account
    recurring schedule
```

or:

```text
Loan
    scheduled principal/interest cash flows
    actual payments
    source account
    loan account
```

One caution: I would probably avoid FIBO's `TriggeringEvent` here despite the generic-looking name. Its current definition is specifically phrased around events triggering aspects of a **credit default swap**, so it carries narrower semantics than its name suggests. 

### Another extant classification worth retaining: BLS Consumer Expenditure

For a US personal-finance model, I would also retain the **Bureau of Labor Statistics Consumer Expenditure Survey classification** as a reference taxonomy even though I have not found a first-class RDF/SKOS namespace for it.

It is actually broader in some practical household-budget respects than COICOP. BLS' published major expenditure components include things such as:

```text
Food
Housing
Transportation
Healthcare
Entertainment
Apparel and services
Cash contributions
Personal insurance and pensions
Education
Personal care
...
```

and the underlying CE program collects not only expenditure but **income, changes in assets, and changes in liabilities**. ([Bureau of Labor Statistics][7])

So there is a useful distinction:

| Classification                | Semantic strength                                    | RDF status                                                                  |
| ----------------------------- | ---------------------------------------------------- | --------------------------------------------------------------------------- |
| **ECOICOP 2 / COICOP 2018**   | International household consumption-purpose taxonomy | **Native SKOS/XKOS LOD**                                                    |
| **BLS Consumer Expenditure**  | Very practical US household-budget classification    | Extant taxonomy, but not apparently published as a canonical RDF vocabulary |
| **FIBO CashFlows**            | Movement/source/target/amount semantics              | **OWL ontology**                                                            |
| **FIBO PaymentsAndSchedules** | actual payments and payment obligations              | **OWL ontology**                                                            |
| **FIBO ClientsAndAccounts**   | account/transaction/balance semantics                | **OWL ontology**                                                            |
| **ValueFlows**                | intent/commitment/event planning semantics           | **RDF/OWL vocabulary**                                                      |

There is no reason we have to select exactly one classification axis.

An actual supermarket debit could legitimately participate in several independent descriptions:

```text
account record       → FIBO IndividualTransaction
money movement       → FIBO CashFlow
economic occurrence  → ValueFlows EconomicEvent
purpose              → ECOICOP concept
amount/currency       → FIBO MonetaryAmount
```

That is not redundant modelling. Each answers a different question.

### There is another promising classification family for non-consumption money

I would also keep **ESA 2010 transaction classifications** in consideration—not because we should model ourselves as a national economy, but because it provides an extant classification for categories that COICOP intentionally does not cover.

ESA separates:

```text
P.*  transactions in products
D.*  distributive transactions
F.*  transactions in financial assets and liabilities
B.*  balancing items
```

and therefore has established categories such as:

```text
D.1    Compensation of employees
D.41   Interest
F.2    Currency and deposits
F.4    Loans
```

as well as taxes, transfers, social benefits, dividends, etc. ([European Commission][8])

I would **not yet promote that to the same status as ECOICOP**, because I have not yet located an equivalently clean canonical RDF publication of the transaction code system. But semantically it may be the missing complement for things like income, taxes, transfers, savings, and changes in liabilities.

So the emerging architecture is more precise than my previous answer:

```text
                    PERSONAL FINANCIAL PHENOMENON
                               │
          ┌────────────────────┼────────────────────┐
          │                    │                    │
       purpose              mechanism             status
          │                    │                    │
   ECOICOP / COICOP       FIBO CashFlow       ValueFlows
   "what was it for?"     "where did money    intent /
                           move from/to?"       commitment /
                                               event

          │
          ├── account representation → FIBO ClientsAndAccounts
          ├── payment semantics      → FIBO PaymentsAndSchedules
          ├── debt semantics         → FIBO Loans
          └── amount/currency        → FIBO CurrencyAmount
```

And critically, **ECOICOP 2 gives us extant category resources rather than requiring us to invent “Groceries”, “Housing”, etc. ourselves**. That is the correction I would make to the prior recommendation. ([Publications Office of the EU][9])

I think the next useful investigation is specifically the other side of that gap: extant RDF classifications for **income, taxes, transfers, savings/investment, and debt repayment**, so that COICOP is not forced to do work it was never designed to do.

[1]: https://unstats.un.org/unsd/classifications/coicop?utm_source=chatgpt.com "UNSD — COICOP"
[2]: https://cros.ec.europa.eu/book-page/modeling-eurostats-statistical-classifications-showvoc "Modeling of Eurostat's statistical classifications in ShowVoc | Eurostat CROS"
[3]: https://ec.europa.eu/eurostat/web/hicp/information-data?utm_source=chatgpt.com "Information on data - Harmonised Indices of Consumer Prices (HICP) - Eurostat"
[4]: https://www.scb.se/om-scb/scbs-verksamhet/regelverk-och-policyer/foreskrifter/uppgiftslamnande/scb-fs-202609/?utm_source=chatgpt.com "Statistiska centralbyråns föreskrifter och allmänna råd om uppgifter till statistik avseende Konsumentprisindex"
[5]: https://unstats.un.org/unsd/classifications/Econ/Structure/Detail/EN/2094/04?utm_source=chatgpt.com "UNSD — Classification Detail"
[6]: https://dd.eionet.europa.eu/vocabulary/eurostat/coicop/view "Data Dictionary - Vocabulary"
[7]: https://www.bls.gov/opub/reports/consumer-expenditures/2024/home.htm?utm_source=chatgpt.com "Consumer expenditures in 2024 : BLS Reports : U.S. Bureau of Labor Statistics"
[8]: https://webgate.acceptance.ec.europa.eu/eurostat/esa2010/chapter/view/1?utm_source=chatgpt.com "Chapter 1 - General features and basic principles*"
[9]: https://op.europa.eu/ro/web/eu-vocabularies/eurostat "Eurostat - EU Vocabularies - Publications Office of the EU"
