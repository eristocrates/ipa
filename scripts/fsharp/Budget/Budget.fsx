open System
open System.Globalization


module Iso =
    module Week =
        type Type = { year: int; ordinal: int }

        let from (date: DateTime) : Type =
            { year = ISOWeek.GetYear(date)
              ordinal = ISOWeek.GetWeekOfYear(date) }

        let after (date: DateTime) : Type =
            let week = from date
            let last = ISOWeek.GetWeeksInYear(week.year)

            if week.ordinal < last then
                { week with ordinal = week.ordinal + 1 }
            else
                { year = week.year + 1; ordinal = 1 }

module iCalendar =


    module Property =
        type RRULE =
            { FREQ: freq
              UNTIL: enddate
              COUNT: int
              INTERVAL: int
              BYSECOND: byseclist
              BYMINUTE: byminlist
              BYHOUR: byhrlist
              BYDAY: bywdaylist
              BYMONTHDAY: bymodaylist
              BYYEARDAY: byyrdaylist
              BYWEEKNO: bywknolist
              BYMONTH: bymolist
              BYSETPOS: bysplist
              WKST: weekday }

        and freq =
            | SECONDLY
            | MINUTELY
            | HOURLY
            | DAILY
            | WEEKLY
            | MONTHLY
            | YEARLY

        and enddate =
            | EndDateOnly of DateOnly
            | EndDateTime of DateTime

        and byseclist = int list
        and byminlist = int list
        and byhrlist = int list
        and bywdaylist = weekdaynum list
        and weekday = DayOfWeek
        and weekdaynum = (int option) * weekday
        and bymodaylist = int list
        and byyrdaylist = int list
        and bywknolist = int list
        and bymolist = int list
        and bysplist = int list


module Stipipendarium =

    let paypoch = DateTime(2024, 12, 18)
    let yearcast = DateTime.Now.AddYears(2).Year

    let stipendayGenerator: DateTime seq =
        Seq.unfold
            (fun (current: DateTime) ->
                let next = current.AddDays(14.0)

                if next.Year < yearcast then Some(next, next) else None)
            paypoch

    let stipendays = stipendayGenerator |> Seq.toList

    type Stipendium =
        { startInclusive: DateTime
          endExclusive: DateTime
          inTide: Iso.Week.Type
          outTide: Iso.Week.Type }

        member this.contains(date: DateTime) : bool =
            this.startInclusive <= date && date < this.endExclusive

    module Distipendus =
        type Type =
            { name: Name
              ordinal: int
              year: int
              firstPairPart: Stipendium
              secondPairPart: Stipendium }

        and Name =
            | Primalloc
            | Vectigal
            | Nisabthaoth
            | Meteshat
            | Kuberilchus
            | Tieruslove
            | Epignosynkri
            | Plushencaitus
            | Wauerkmees
            | Maabatar
            | Praesidium
            | Fundominus
            | Premalloc

        let names: Name list =
            [ Primalloc
              Vectigal
              Nisabthaoth
              Meteshat
              Kuberilchus
              Tieruslove
              Epignosynkri
              Plushencaitus
              Wauerkmees
              Maabatar
              Praesidium
              Fundominus
              Premalloc ]




    let stipendi =
        stipendayGenerator
        |> Seq.pairwise
        |> Seq.map (fun (currentStipendium, nextStipendium) ->
            { startInclusive = currentStipendium
              endExclusive = nextStipendium
              inTide = Iso.Week.from currentStipendium
              outTide = Iso.Week.after currentStipendium })
        |> Seq.toList

    let distipendi: Distipendus.Type list =
        stipendi
        |> List.chunkBySize 2
        |> List.mapi (fun i chunk ->
            match chunk with
            | [ first; second ] ->
                { name = Distipendus.names[i % Distipendus.names.Length]
                  ordinal = (i % Distipendus.names.Length) + 1
                  year = first.outTide.year
                  firstPairPart = first
                  secondPairPart = second }
            | _ -> failwith "Incomplete final distipendus: expected exactly 2 stipendi")

// 1. Primalloc
// 2. Vectigal
// 3. Nisabthaoth
// 4. Meteshat
// 5. Kuberilchus
// 6. Tieruslove
// 7. Epignosynkri
// 8. Plushencaitus
// 9. Wauerkmees
// 10. Maabatar
// 11. Praesidium
// 12. Fundominus
// 13. Premalloc

// stipendium: the 14-day atomic unit (Gregorian fortnight), pay-salient.
// paytide: a 7-day week interpreted as in-tide/out-tide.
// distipendus: month-analogue budgeting unit (≈ two stipendiums).
// distipendti: plural of distipendus.
// stipipendarium: the named system/calendar schema containing the 13 distipendti and associated semantics.
// Primalloc / Epignosynkri / Premalloc: functional-phase anchors (non-ordinal “ordinals”).
// Vectigal / Praesidium / Fundominus: observance anchors.
// Tieruslove: honorific anchor.

module Crew =
    module Account =
        let checking = 4959.36

    module Expense =
        let mechanic: float = -5648
        let rental = -832.36
        let total = mechanic - rental

    let balance = Account.checking + Expense.total


module Usaa =
    module Account =
        let checking = 1960.45
        let credit: float = 733

    module Expense =
        let temp: float = 0
        let total = temp

    let balance = Account.checking + Expense.total


module WellsFargo =
    module Account =
        let checking: float = 708.53
        let credit: float = 4720

    module Expense =
        let propertyTax = -3731.26
        let total = propertyTax

    let balance = Account.checking + Expense.total

let totalChecking =
    Crew.Account.checking + WellsFargo.Account.checking + Usaa.Account.checking
