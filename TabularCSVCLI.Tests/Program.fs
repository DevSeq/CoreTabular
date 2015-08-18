﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open NUnit.Framework
open MicrosoftResearch.Infer.Tabular.CLI

let runTest modelFileName =
        let modelFileName = System.IO.Path.GetFullPath(modelFileName)
        let exeDir = System.IO.Path.GetDirectoryName(modelFileName)
        System.Environment.CurrentDirectory <- exeDir
        runCLI "." None modelFileName "." false None None (Reuse "verified") true true true true

[<Test>]
let TrueSkill() =    
    runTest "..\..\..\Samples\TrueSkill\TrueSkill.csv"
    Assert.True(true)


[<Test>]
let FaithfulCsv() =    
    runTest "..\..\..\Samples\Faithful\Model.csv"
    Assert.True(true)

[<Test>]
let FaithfulTxt() =    
    runTest "..\..\..\Samples\Faithful\Model.txt"
    Assert.True(true)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
