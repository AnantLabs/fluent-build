Getting started is quite easy.

  1. Create a C# project to contain your builds (currently the only language supported)
  1. Create a class named Default that inherits from FluentBuild.Core.BuildFile
  1. In your constructor call AddTask() for each method you want the build to run.
  1. Place fb.exe and FluentBuild.dll in a convenient folder.
  1. run fb.exe path/to/build/folder (NOTE: it is the path to the FOLDER that contains the build file(s), not the path to the build file itself)
  1. fb.exe will then compile the build file and then execute it.

For an example of what you can do see the [sample build class](SampleBuildClass.md) or read the [Tutorial](Tutorial.md)