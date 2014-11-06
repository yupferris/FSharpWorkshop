# Learn F# Workshop

Resources, code snippets, installation instructions and slides from the Learn F# workshop for OsloSFP.

## Goals & Introduction

The goals of this workshop are to more or less simply get a taste of the F# programming language. We'll do this by going over
some history of the language, then we'll have a basic grammar and syntax walkthrough, followed by some basic problem solving
with unit tests and the fsi prompt. Finally, we'll pull in some basic networking and graphing libraries and pump some real data
through a simple system.

## Installation

To get ourselves up and running, we'll need to install:
 - __F#__ - http://fsharp.org/ has fantastic guides on how to prepare the F# compiler (_fsc_) and F# interactive prompt
   (_fsi_) for many different platforms, and even if you don't feel like installing it, you can just use the online console
   provided at http://www.tryfsharp.org/Create . This console will suffice for all of the code provided for the workshop,
   minus some of the later network and charting portions.

 - __NuGet Package Manager__ (_optional_) - This is a simple package manager tool for the .NET platform, and ships with Visual
   Studio. If you don't have it installed or are running mac/linux, you can download and install it from
   [here](https://www.nuget.org/). Also, if you plan on using it from the command line, there's a great guide on how to do
   that [here](http://blog.davidebbo.com/2011/01/installing-nuget-packages-directly-from.html).

 - __F# Data__ - A library for manipulating data in F#, much of which is implemented with Type Providers. We'll use this for
   interpreting JSON in our real-world data example. You can get it [here](http://fsharp.github.io/FSharp.Data/) under the
   _"How to get F# Data"_ section, or follow one of these links directly:
   - [FSharp.Data for Windows, Mac and Linux](https://nuget.org/packages/FSharp.Data) on NuGet
   - [FSharp.Data for Windows, Mac and Linux](https://github.com/fsharp/FSharp.Data/zipball/release) binary release (.zip
     file)
   - [FSharp.Data source](https://github.com/fsharp/FSharp.Data/zipball/master) (.zip file)

 - __F# Charting__ - F# Charting is a lovely little cross-platform charting library. You can get it
   [here](http://fsharp.github.io/FSharp.Charting/) under the section _"How to get F# Charting"_, or follow one of these
   links directly:
   - [FSharp.Charting for Windows](https://nuget.org/packages/FSharp.Charting) on NuGet
   - [FSharp.Charting.Gtk for Mac/Linux](https://nuget.org/packages/FSharp.Charting.Gtk) on NuGet
   - [FSharp.Charting for Windows](https://github.com/fsharp/FSharp.Charting/zipball/release) binary release (.zip file)
   - [FSharp.Charting source](https://github.com/fsharp/FSharp.Charting/zipball/master) (.zip file)

Then, we'll do a quick test to make sure everything's good to go. The simplest ways to do this are as follows:
 - __Windows with Visual Studio:__ Create a new Visual F# Console Application, and using NuGet, install the FSharp.Charting
   package. If you're unfamiliar with how to do this, refer to the official documentation
   [here](http://docs.nuget.org/docs/start-here/managing-nuget-packages-using-the-dialog) for more details. Once that's done,
   add an F# Script File to the project. Open that, and type in the following lines:

    ```
    #r "packages/FSharp.Charting.0.90.7/lib/net40/FSharp.Charting.dll"
    open FSharp.Charting

    Chart.Line([for x in 0 .. 10 -> x, x * x]).ShowChart()
    ```
    
   Select all of the text, and use Alt+Enter to execute the code in the F# Interactive prompt. Note that this key shortcut
   may be taken already if you're using tools like Resharper, but the option should be available in the right-click context
   menu when the text is selected as well.
 
 - __Windows, Mac + Linux from the command prompt:__ Locate the FSharp.Charting[.Gtk].dll file, either in the installed NuGet
   package directory (most likely under the lib/net40 directory), or from the binary or source release build. Fire up __fsi__
   and enter the following lines (_note that all of the "[.Gtk]" text instances are only necessary if you're using
   FSharp.Charting.Gtk.dll_):

    ```
    #r "FSharp.Charting[.Gtk].dll"
    open FSharp.Charting[.Gtk]
    
    Chart.Line([for x in 0 .. 10 -> x, x * x]).ShowChart()
    ```
    
   If you run into any trouble, more information about referencing the library can be found
   [here](http://fsharp.github.io/FSharp.Charting/ReferencingTheLibrary.html).

And that's it :) .

## Workshop code and slides

The problem solving code scripts are available on this repo already. Please wait to try solving them until the presentation
:) . The slides/solutions will be made available after the workshop.
