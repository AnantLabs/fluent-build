# What Is FluentBuild #
FluentBuild is a simple fluent interface around common build tasks written for .NET developers. It allows users to write a build file in a .NET language of your choice.

# Where Is The Project At #
Version 1.x had the goal to be able to compile and deploy itself which has been achieved.

The next goal is to expand out the capabilities to include broader support for various scenarios and tools to make it a more comprehensive tool.

# News #
**September 22, 2012**
I have been working with FluentBuild on several projects lately and I feel it has become stable enough to cut the cord and release it under a non-beta status. v1.2.0.0 is released as well as the v1.0.0.0 of the team city plugin.

**September 21, 2012**
The [mailing list](https://groups.google.com/forum/?fromgroups#!forum/fluent-build-discuss) has been launched.

**June 20, 2012**
We have published FluentBuild to nuGet!

**May 19, 2012**
v1.1 Beta has been published. More info can be found on my blog http://www.haveyougotwoods.ca/2012/05/19/fluentbuild-1-1-beta

**April 18, 2012**
I have had some issues with the interface design in a few areas so I am currently reworking that. A bug was also discovered in the way executables handle error codes and continuation. After some review I am going to rework a lot of this area to make things simpler and work more reliably. I have also started blogging about FB and some of the changes I am working on http://www.haveyougotwoods.ca/

**August 17, 2011**
New beta is out! This update has some new features and bug fixes:
-When a task errors it terminates the build (unless OnError is set to Continue)
-TeamCity plugin updated to work with TeamCity 6.5. The plugin is still in Alpha phase and not released yet but it is included in source)
-Added flag that indicated that you do not want the error stream of a process shown as an error if the process exists with code 0
-MSBuild object is extended with a WithArgument function.
-Timeout of 50 seconds is now replaced by a Property Timeout. Default the Timeout property is null and the process will run until finished with no timeout (The default can be set back to 50 seconds, of course but I think a property makes sense here).
-The InvokeNextTask in the BuildFile has now a Try Catch so it doesn't crash FluentBuild if there is a runtime error in a custom implemented Task.
-Adding the ability to get a team city property by using GetProperty()
-Fixed naming inconsistencies in Executable
-Rework of the assembly info building
-Adding in more attributes that can be used for AssemblyInfo.cs
-Added the ability to add your own assembly custom attribute
-[bug #1](https://code.google.com/p/fluent-build/issues/detail?id=1) Fixed. Incorrectly handling .dll files
-Ability to manually run tasks from command line


**June 16, 2011**
I have managed to get some time to address some things that have been identified. A new beta realease should be featured soon.

**December 19, 2010**
I finally got some time and put together a quick video that shows how you can use FluentBuild from start to finish. [Watch it](http://www.haveyougotwoods.com/images/haveyougotwoods_com/FluentBuildDemo1_0_Beta/)

**October 19, 2010**
I am pleased to announce that beta 1.0 has been released. This release finalizes the syntax and feature set for this version of FluentBuild. The only changes that will be made to this version will be bug fixes.

# Benefits/Features #
  * Don't have to learn a new language just to do builds
  * Easy to refactor your builds
  * Easy to spot unused sections
  * Colorized output makes it easy to spot warnings / errors
  * Syntax checking as you edit/compile
  * Easy to navigate in IDE as build language is a .NET language
  * No XML!
  * Intellisense and a fluent interface makes writing a build quick and easy
  * Access to the .NET runtime allows easy extension of builds
  * Can subclass build classes for easy re-use
  * Only dependency is the .NET framework
  * Built-in (MsSql) database creation and versioning (quite basic but it is there)

# Getting Started #
For a sample check out the [sample build file](http://code.google.com/p/fluent-build/wiki/SampleBuildClass) or the [Tutorial](Tutorial.md)