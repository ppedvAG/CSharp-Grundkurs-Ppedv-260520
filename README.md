# CSharp-Grundkurs-Ppedv-260520

# ABLAUF VOM KURS

## M000 | WARMING UP

- [x] Greeter
- [x] VS [homepage](https://visualstudio.microsoft.com/de/)
- [x] [vs-shortcuts](VS-SHORTCUTS.md)
- [x] Git
- [x] [git-commands](GIT-COMMANDS.md)

VS Installer > installierte Version ändern > Sprachpakete

Tools > Options > Text Editor > All Languages > General > Line numbers

commit

## M010 | GETTING STARTED

- [x] Intro [csharp docs](https://docs.microsoft.com/de-de/dotnet/csharp/)
- [x] .NET [dotnet docs](https://docs.microsoft.com/de-de/dotnet/api/?view=netframework-4.8)
- [x] [HelloWorld.cs](M01HelloWorld/HelloWorld.cs)
- [x] [DConsole.cs](M01Demo-Console/DConsole.cs)
- [x] [SPICKER](CSHARP-CHEATSHEET.md)

sln props > startup projects > current

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/a60073d861df577cfc4e030c130a942081a89d49)

## M020 | DATA TYPES, OPERATORS

- [x] Datentypen
- [x] [bool.cs](M02Demo-bool/Dbool.cs)
- [x] [string.cs](M02Demo-string/Dstring.cs)
- [x] [int.cs](M02Demo-int/Dint.cs)
- [x] [double.cs](M02Demo-double/Ddouble.cs)
- [x] Operatoren
- [x] Parsing & Casting
- [x] [enum](M02Demo-enum/Denum.cs)
- [x] [Lab MiniRechner](M02Lab-MiniRechner/MiniRechner.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/957ff3071f8d2127354d4cff845667d22226fad7)

- [x] HasFlag

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/1545bafeba5dd8da277ec5c05babb02be05eb95f)
      
## M030 | ARRAYS & CONTROLS

- [x] [Arrays](M03ArrayNControls/MyArray.cs)
- [x] [if](M03ArrayNControls/MyIf.cs)
- [x] for, siehe Arrays
- [x] while & do while, siehe Zahlenratespiel
- [x] [Klasse Random](M03ArrayNControls/MyRandom.cs)
- [x] [Lab Zahlenratespiel](M03Lab-Zahlenratespiel/Zahlenraten.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/30686a1e3b4f08abda4de9186ddb69e1375655be)

## M040 | METHODS

- [x] arguments
- [x] parameters
- [x] params
- [x] return
- [x] overloads
- [x] out & ref parameters & args
- [x] [Demo Methods](M04Demo-Methods/DMethods.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/66af612a97eee24e38abade38bd136d129d77898)

## M050 | CLASSES & OOP

- [x] constructor
- [x] fields
- [x] props
- [x] class methods
- [x] access modifier
- [x] inctances / objects
- [x] destructor
- [x] [Ü Transport](/M5Fuhrpark/Transport.cs)
- [x] [Ü TransportConsumer](/M5Fuhrpark/FuhrparkApp.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/480aa81214f31240bcd73b1a3b278b16faeadc11)

## M060 | INHERITENCE / VERERBUNG

- [x] base
- [x] virtual & override methods
- [x] abstract methods
- [x] [Ü Flugzeug](M05Lab-Fuhrpark/Flugzeug.cs)
- [x] [Ü PKW](M05Lab-Fuhrpark/PKW.cs)
- [x] [Ü Schiff](M05Lab-Fuhrpark/Schiff.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/46ca5a417197812f05543e96822a9bbace283bb7)

## M070 | INTERFACES & POLYMORPHISM

- [x] interfaces
- [x] override vs overload
- [x] [Ü IKannAndereTransportieren](M05Lab-Fuhrpark/IKannAndereTransportieren.cs)
- [x] [Ü IKannRollen](M05Lab-Fuhrpark/IRollbar.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/74d675b9373ad5ebfec87e9d201015a9cd4a3e9f)

## M080 | GENERIC DATA STRUCTURES

- [x] [List`<T>`](/M8GenericDataStructures/MyList.cs)
- [x] [Stack`<T>`](/M8GenericDataStructures/MyStack.cs)
- [x] [Queue`<T>`](/M8GenericDataStructures/MyQueue.cs)
- [ ] [KeyValuePair`<T1, T2>`](/M8GenericDataStructures/MyKeyValuePair.cs)
- [x] [Dictionary`<T1, T2>`](/M8GenericDataStructures/MyDictionary.cs)
- [ ] Hachtable
- [ ] [Ü Passagierliste](/M5Fuhrpark/FuhrparkApp.cs)
- [x] Warteschlange
- [x] Ü Lab 8 

## M090 | WINDOWS FORMS

- [x] partial classes
- [x] widgets / components
- [x] component props
- [x] [TicTacToe](M09Demo-WinForms/Program.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/d62fb038fec2f717df49f3fbaedd99def6952610)

## M010 | DELEGATES & EVENTS

- [x] custom delegates
- [x] built-in delegates
- [x] anonumous functions
- [x] event handler
- [x] [M10 Delegates](M10Demo-Delegates/Program.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/b724d553f27d191b06a52c6b0d4568d82b5416f9)

Ü Einfacher Taschenrechner?

## M011 | Exception-Handling​

- [x] Exception & throw
- [x] try catch finally
- [x] Exception types
- [x] Custom Exceptions
- [ ] [standard exception](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/using-standard-exception-types)
- [x] [Demo-Exception](M08GenericDataStructures/MyList.cs)
- [x] [customized exception](M08GenericDataStructures/ItemDoesNotExist.cs)

## M012 | File Access Dateizugriff​

- [x] SaveFileDialog & OpenFileDialog
- [x] StreamReader & StreamWriter
- [x] JSON, serialize & deserialize 
- [x] [M12 File Access & JSON](M12Demo-FileAccess/Program.cs)
- [x] [Ü Schreibe & Lese generisch und mit Open/SaveFileDialog]()

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/c99d8985e4caae047dea92fcb479283a2e27db6f)

Ü Anmeldeformular? / Gästeliste?

## M013 | Entity Framework Core

- [x] ORM
- [x] DBContext
- [x] DBSet & Entities
- [x] [Demo ](M13Demo-EntityFramework/EFDbContext.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/d01b26e388b9bc2ef2ae52537923ab750057a306)

## M014 | TAP (async/await)

- [x] Task
- [x] async/await
- [x] Threads
- [x] [Demo Task](M14Demo-AsyncAwait/MyTask.cs)
- [x] [Demo async await](M14Demo-AsyncAwait/Program.cs)
- [ ] siehe Fuhrpark, zufälliges Erzeugen

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/a7159fca6ad2103356eac70f2f5f94803611e808)

## M015 | Timing Klassen

- [x] [Klasse Timing](M15Demo-Timing/Form1.cs#Timer)
- [x] [Klasse Stopwatch](M15Demo-Timing/Form1.cs#Stopwatch)
- [x] [Ü kollidierende Buttons mit Timing]

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/122a89a4fdf05232ae218d5529094314dd911b4a)
 
## M016 | Unit-Tests

- [x] TestPackages & TestProject
- [x] TestClasses, TestMethods, TestAnnotations
- [x] Assert-Klasse
- [x] [Demo-UnitTest](M16Demo-UnitTests/UnitTest1.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/bf72bd74bf492f27b87324158d914f254372b57b)

## M017 | HttpClient & Linq

- [ ] [HttpClient](M17Demo-HttpClient/Form1.cs)
- [ ] [LINQ Befehle](M17Demo-HttpClient/Form1.cs)

[commit](https://github.com/ppedvAG/csharp-grundkurs-ppedv-260520/commit/8d761b9dc8b8eb8cd97c0bad580b11f307107d43)

## M018 | Debugging & Publishing

commit


