#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true

open System
open System.Linq
open System.IO
open FSharp.Data
open Humanizer
open System.Globalization

#r "IntervalErgonomics.dll"
open IntervalErgonomics
#r "Metaprogramming.dll"
open Metaprogramming

let gregorianCalendar = new GregorianCalendar()

type GregorianCalendar with 
    member this.FirstWeekOfYear (year:int) = 
        this.GetWeekOfYear(DateTime(year,1,1), CalendarWeekRule.FirstDay,DayOfWeek.Monday)
    member this.CurrentWeekOfYear = 
        gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay,DayOfWeek.Monday)
type ISOWeek with 
    static member FirstWeekOfYear (year:int) = DateTime(year,1,1) |>  ISOWeek.GetWeekOfYear
    static member Now = ISOWeek.GetWeekOfYear DateTime.Now



type Paytide = 
    {
        paytideStartInclusive :DateTime
    }
    static member Zero:Paytide  = { paytideStartInclusive =  DateTime(2024, 4, 25) }

    static member Yearcast = 
        Paytide.Zero.previous
        |> Array.unfold (fun paytide ->  
            match paytide.next with 
            | candidate when candidate.paytideStartInclusive.Year <= DateTime.Now.Year + 1 -> 
                Some(candidate, candidate)
            | _ -> None
            )
    
    static member atDateTime  (dateTime: DateTime) (candidate: Paytide) =
        match candidate.asIntervalRange |> IntervalRange.contains dateTime, dateTime < candidate.paytideStartInclusive with 
        | dateTimeWithinIntervalRange ,_ when dateTimeWithinIntervalRange = true -> candidate
        | _ , true -> Paytide.atDateTime dateTime candidate.previous
        | _ , false -> Paytide.atDateTime dateTime candidate.next

    static member ofDateTime (dateTime: DateTime) =
        Paytide.atDateTime dateTime Paytide.Zero
    static member Now = Paytide.ofDateTime DateTime.Now 



    member this.DayOfPaytide (dateTime: DateTime) = int (dateTime.Date - this.paytideStartInclusive.Date).TotalDays
    member this.TodayOfPaytide  =  this.DayOfPaytide DateTime.Now

    member this.paytideEndInclusive =  this.paytideStartInclusive.AddDays(6)
    member this.paytideEndExclusive =  gregorianCalendar.AddWeeks(this.paytideStartInclusive, 1)  

    member this.asIntervalRange = this.paytideStartInclusive +-* this.paytideEndExclusive


    member this.gregorianOrdinal = $"Starting from {this.paytideStartInclusive.ToOrdinalWords()} ending at {this.paytideEndExclusive.ToOrdinalWords()}"
    member this.next : Paytide = { paytideStartInclusive = this.paytideStartInclusive.AddDays 7 }
        

    member this.previous : Paytide = { paytideStartInclusive = this.paytideStartInclusive.AddDays -7 }
    member this.gregorianWeekNumber = 
        gregorianCalendar.GetWeekOfYear(this.paytideStartInclusive, CalendarWeekRule.FirstDay,DayOfWeek.Monday)

    member this.isoWeekNumber = 
        ISOWeek.GetWeekOfYear this.paytideStartInclusive
            
    member this.gregorianStipendiumNumber = (this.gregorianWeekNumber + 1) / 2
    member this.isoStipendiumNumber = (this.isoWeekNumber + 1) / 2
    member this.stipendium = Stipendium.ofDateTime this.paytideStartInclusive
    member this.distipendus = Distipendus.ofDateTime this.paytideStartInclusive
    member this.stipipendarium = Stipipendarium.ofDateTime this.paytideStartInclusive


and Stipendium = 
    {
        highPaytide:Paytide
        lowPaytide:Paytide
    }
    static member Zero = 
        {
            highPaytide = Paytide.Zero
            lowPaytide = Paytide.Zero.next
        }
    static member Yearcast = 
            Stipendium.Zero.previous
            |> Array.unfold (fun stipendium ->  
                match stipendium.next with 
                | candidate when candidate.highPaytide.paytideStartInclusive.Year <= DateTime.Now.Year + 1 -> 
                    Some(candidate, candidate)
                | _ -> None
                )

    static member atDateTime  (dateTime: DateTime) (candidate: Stipendium) =
        if candidate.asIntervalRange
           |> IntervalRange.contains dateTime then

            candidate

        elif dateTime < candidate.stipendiumStartInclusive then
            Stipendium.atDateTime dateTime candidate.previous

        else
            Stipendium.atDateTime dateTime candidate.next
    static member ofDateTime (dateTime: DateTime) =
        Stipendium.atDateTime dateTime Stipendium.Zero
    static member Now = Stipendium.ofDateTime DateTime.Now 
    member this.stipendiumStartInclusive = this.highPaytide.paytideStartInclusive

    member this.DayOfStipendium (dateTime:DateTime) = int (dateTime.Date - this.stipendiumStartInclusive.Date).TotalDays
    member this.TodayOfStipendium  = this.DayOfStipendium DateTime.Now
    member this.stipendiumEndInclusive =  this.stipendiumStartInclusive.AddDays(13)
    member this.stipendiumEndExclusive =  gregorianCalendar.AddWeeks(this.stipendiumStartInclusive, 2)  
    member this.asIntervalRange = this.stipendiumStartInclusive +-* this.stipendiumEndExclusive
    member this.gregorianOrdinal = $"Starting from {this.stipendiumStartInclusive.ToOrdinalWords()} ending at {this.stipendiumEndExclusive.ToOrdinalWords()}"
    member this.next : Stipendium = { highPaytide = this.highPaytide.next.next ; lowPaytide = this.lowPaytide.next.next}
        

    member this.previous : Stipendium = { highPaytide = this.highPaytide.previous.previous ; lowPaytide = this.lowPaytide.previous.previous}
    member this.payPeriodEndInclusive = this.stipendiumStartInclusive.AddDays(-6)
    member this.BOCCCheckDateTime = this.stipendiumStartInclusive
    member this.SyntechCheckDateTime = this.stipendiumStartInclusive.AddDays(1)
    member this.paytides = [| this.highPaytide ; this.lowPaytide|]
    member this.distipendus = Distipendus.ofDateTime this.stipendiumStartInclusive
    member this.stipipendarium:Stipipendarium = Stipipendarium.ofDateTime this.stipendiumStartInclusive
    member this.index = this.stipipendarium.stipendia |> Array.findIndex (fun stipendium -> stipendium = this)


and Distipendus = 
    {
        antecedentStipendium : Stipendium
        succeedentStipendium : Stipendium
    }
    static member Zero = 
        {
        antecedentStipendium = Stipendium.Zero
        succeedentStipendium  = Stipendium.Zero.next
        }

    static member Yearcast = 
        Distipendus.Zero.previous
        |> Array.unfold (fun (distipendus :Distipendus) ->  
            match distipendus.next with 
            | candidate when  candidate.antecedentStipendium.stipendiumStartInclusive.Year <= DateTime.Now.Year + 1 ->
                Some (candidate, candidate)
            | _ -> None
        
        )
    static member atDateTime  (dateTime: DateTime) (candidate: Distipendus) =
        match candidate.asIntervalRange |> IntervalRange.contains dateTime, dateTime < candidate.antecedentStipendium.stipendiumStartInclusive with 
        | dateTimeWithinIntervalRange ,_ when dateTimeWithinIntervalRange = true -> candidate
        | _ , true -> Distipendus.atDateTime dateTime candidate.previous
        | _ , false -> Distipendus.atDateTime dateTime candidate.next
    static member ofDateTime (dateTime: DateTime) =
        Distipendus.atDateTime dateTime Distipendus.Zero
    static member Now = Distipendus.ofDateTime DateTime.Now 

    member this.asIntervalRange = this.antecedentStipendium.stipendiumStartInclusive +-* this.succeedentStipendium.stipendiumEndExclusive
    
    member this.distipendusStartInclusive = this.antecedentStipendium.stipendiumStartInclusive

    member this.DayOfDistipendus (dateTime:DateTime) = int (dateTime.Date - this.distipendusStartInclusive.Date).TotalDays
    member this.TodayOfStipendium  = this.DayOfDistipendus DateTime.Now
    member this.distipendusEndInclusive =  this.succeedentStipendium.stipendiumEndInclusive
    member this.distipendusEndExclusive =  this.succeedentStipendium.stipendiumEndExclusive
    member this.gregorianOrdinal =  $"Starting from {this.distipendusStartInclusive.ToOrdinalWords()} ending at {this.distipendusEndExclusive.ToOrdinalWords()}"
    member this.next : Distipendus = 

        {
            antecedentStipendium = this.antecedentStipendium.next.next
            succeedentStipendium = this.succeedentStipendium.next.next
        }
    member this.previous : Distipendus = 

        {
            antecedentStipendium = this.antecedentStipendium.previous.previous
            succeedentStipendium = this.succeedentStipendium.previous.previous
        }
    member this.paytides = 
        Array.concat[|
                this.antecedentStipendium.paytides
                this.succeedentStipendium.paytides
        |]
    member this.stipendia = 
        [|
                this.antecedentStipendium
                this.succeedentStipendium
        |]
    member this.stipipendarium : Stipipendarium = Stipipendarium.ofDateTime this.distipendusStartInclusive

      member this.index = this.stipipendarium.distipendi |> Array.findIndex ((=) this)
      member this.name = 
        match this.index with 
        | 0 -> "Primalloc"
        | 1 -> "Vectigal"
        | 2 -> "Nisabthaoth"
        | 3 -> "Meteshat"
        | 4 -> "Kuberilchus"
        | 5 -> "Erisyris"
        | 6 -> "Epignosynkri"
        | 7 -> "Plushencaitus"
        | 8 -> "Wauerkmees"
        | 9 -> "Maabatar"
        | 10 -> "Praesidium"
        | 11 -> "Fundominus"
        | 12 -> "Premalloc"
        | index ->
            failwithf "Unexpected Distipendus index %d" index
and Stipipendarium = 
    {
        stipipendariumStartInclusive :DateTime
    }
    static member Zero = { stipipendariumStartInclusive = Paytide.Zero.paytideStartInclusive }
    static member Yearcast = 
        Stipipendarium.Zero.previous
        |> Array.unfold (fun (stipipendarium :Stipipendarium) ->  
            match stipipendarium.next with 
            | candidate when  candidate.stipipendariumStartInclusive.Year <= DateTime.Now.Year + 1 ->
                Some (candidate, candidate)
            | _ -> None
        
        )
    
    static member atDateTime  (dateTime: DateTime) (candidate: Stipipendarium) =
        match candidate.asIntervalRange |> IntervalRange.contains dateTime, dateTime < candidate.stipipendariumStartInclusive with 
        | dateTimeWithinIntervalRange ,_ when dateTimeWithinIntervalRange = true -> candidate
        | _ , true -> Stipipendarium.atDateTime dateTime candidate.previous
        | _ , false -> Stipipendarium.atDateTime dateTime candidate.next

    static member ofDateTime (dateTime: DateTime) =
        Stipipendarium.atDateTime dateTime Stipipendarium.Zero
    static member Now = Stipipendarium.ofDateTime DateTime.Now 


    member this.Primalloc = Distipendus.ofDateTime this.stipipendariumStartInclusive
    member this.Vectigal = this.Primalloc.next
    member this.Nisabthaoth = this.Vectigal.next
    member this.Meteshat = this.Nisabthaoth.next
    member this.Kuberilchus = this.Meteshat.next
    member this.Erisyris = this.Kuberilchus.next
    member this.Epignosynkri = this.Erisyris.next
    member this.Plushencaitus = this.Epignosynkri.next
    member this.Wauerkmees = this.Plushencaitus.next
    member this.Maabatar = this.Wauerkmees.next
    member this.Praesidium = this.Maabatar.next
    member this.Fundominus = this.Praesidium.next
    member this.Premalloc = this.Fundominus.next

    member this.stipipendariumEndInclusive = this.Premalloc.distipendusEndInclusive
    member this.stipipendariumEndExclusive = this.Premalloc.distipendusEndExclusive
    member this.DayOfStipipendarium (dateTime:DateTime) = int (dateTime.Date - this.stipipendariumStartInclusive.Date).TotalDays
    member this.TodayOfStipipendarium  = this.DayOfStipipendarium DateTime.Now
    member this.asIntervalRange = this.stipipendariumStartInclusive +-* this.stipipendariumEndExclusive


    member this.distipendi = 

        [|
            this.Primalloc
            this.Vectigal
            this.Nisabthaoth
            this.Meteshat
            this.Kuberilchus
            this.Erisyris
            this.Epignosynkri
            this.Plushencaitus
            this.Wauerkmees
            this.Maabatar
            this.Praesidium
            this.Fundominus
            this.Premalloc

        |]
    member this.stipendia = 
        this.distipendi
        |> Array.collect (fun distipendium -> distipendium.stipendia)
        
    member this.paytides =
        this.stipendia
        |> Array.collect (fun stipendium -> stipendium.paytides)
    member this.next =  { stipipendariumStartInclusive =  this.stipipendariumEndExclusive }

    member this.previous =
        let previousPremalloc =
            this.Primalloc.previous

        Stipipendarium.ofDateTime
            previousPremalloc.distipendusStartInclusive

    member this.gregorianOrdinal =  $"Starting from {this.stipipendariumStartInclusive.ToOrdinalWords()} ending at {this.stipipendariumEndExclusive.ToOrdinalWords()}"

