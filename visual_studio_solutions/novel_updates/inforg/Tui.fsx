#r "nuget: FSharp.Data"
#r "nuget: Spectre.Console, 0.49.1"
#load "Link.fsx"

#r "nuget: Spectre.Console, 0.49.1"

open Spectre.Console
open System

type Choice =
  { label : string
    link : string
    color : string
    drilldown : unit -> unit
    should_display_menu_again : bool }
  with
    member this.markupString =
      AnsiConsole.MarkupLine($"{this.label}: [{this.color}]{this.link}[/]")

let ask_user_for (label: string) : string =
  TextPrompt<string>(label)
    .PromptStyle("pink")
    .Validate(fun raw_input ->
      if String.IsNullOrWhiteSpace(raw_input) then ValidationResult.Error("Value cannot be empty.")
      else ValidationResult.Success())
  |> AnsiConsole.Prompt

let add_release : Choice =
  // capture primitives so the closure doesn't need to reference add_release by name
  let label = "Add Release"
  let link  = Link.novelupdates.form.add.release
  let color = "blue"

  { label = label
    link = link
    color = color
    drilldown =
      (fun () ->
        // “header” for the action
        AnsiConsole.MarkupLine($"{label}: [{color}]{link}[/]")

        // Spectre.Console prompting (no Console.ReadLine)
        let novelName = ask_user_for "Novel name?"
        let groupName = ask_user_for "Group name?"
        let novelLink = ask_user_for "Novel link?"

        AnsiConsole.MarkupLine($"Captured: [bold]{novelName}[/], [bold]{groupName}[/], [underline]{novelLink}[/]")
      )
    should_display_menu_again = true }

let add_series : Choice =
  let label = "Add Series"
  let link  = Link.novelupdates.form.add.series
  let color = "green"

  { label = label
    link = link
    color = color
    drilldown =
      (fun () ->
        AnsiConsole.MarkupLine($"{label}: [{color}]{link}[/]")

        let novelName = ask_user_for "Novel name?"
        let groupName = ask_user_for "Group name?"
        let novelLink = ask_user_for "Novel link?"

        AnsiConsole.MarkupLine($"Captured: [bold]{novelName}[/], [bold]{groupName}[/], [underline]{novelLink}[/]")
      )
    should_display_menu_again = true }

let exit : Choice =
  { label = "Exit"
    link = ""
    color = "red"
    drilldown =
      (fun () ->
        AnsiConsole.MarkupLine("[red]Exiting...[/]")
      )
    should_display_menu_again = false }

let menu_choices : Choice list =
  [ add_release
    add_series
    exit ]

let user_selection_from (choices: Choice list) : Choice =
  let menu_choices =
    SelectionPrompt<Choice>()
      .Title("[bold]Menu[/]")
      .AddChoices(choices)
      .UseConverter(fun choice -> choice.label)

  AnsiConsole.Prompt(menu_choices)

let rec displayMenu () =
  let selected_menu_choice = user_selection_from menu_choices

  // run the chosen drilldown
  selected_menu_choice.drilldown()

  // decide whether to loop
  if selected_menu_choice.should_display_menu_again then
    displayMenu ()

displayMenu()
