# SPA Conference 2016 #

[http://www.spaconference.org/spa2016/](http://www.spaconference.org/spa2016/)

----------

## An Actor's Life for Me - An introduction to the TPL Dataflow Library and asynchronous programming blocks ##

This repository provides the presentation, and source code for the samples and tutorial for the presentation given in London on 28th June at the BCS SPA Conference 2016.

----------

This code was created with .NET Core 1.0.0 RC2.  If you compile with the RTM version you may need to edit the project.json file to use the correct values for the RTM version (use **dotnet new** in a folder to get a sample project.json file).

When compiling the project, if there are library errors use **dotnet restore** at the command line.

----------

## Abstract ##

By using the Dataflow Library you can concentrate on the messages and actions being performed, while the blocks marshal the messages, provide concurrent message processing and buffering as well as supporting cancellation and exception handling.

Every version of the .NET Framework has brought improvements to asynchronous and concurrent programming. While .NET 4.0 brought the async/await model which is useful for improving UI responses and server applications, it can sometimes still be tricky to marshal multiple threads within longer processing pipelines.

The Dataflow Library consists of a Nuget package built on top of the Task Parallel Library (TPL). It harnesses the actor-based programming model to provide a set of dataflow blocks data structures that buffer and process data, which you can connect together to form custom pipelines with messages passed between the blocks.

By using the Dataflow Library you can concentrate on the messages and actions being performed, while the blocks marshal the messages, provide concurrent message processing and buffering as well as supporting cancellation and exception handling.