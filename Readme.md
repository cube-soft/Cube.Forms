Cube.Forms
====

[![NuGet](https://img.shields.io/nuget/v/Cube.Forms.svg)](https://www.nuget.org/packages/Cube.Forms/)
[![AppVeyor](https://ci.appveyor.com/api/projects/status/k5a3hpx8q788dpq2?svg=true)](https://ci.appveyor.com/project/clown/cube-forms)
[![Azure Pipelines](https://dev.azure.com/cube-soft-jp/Cube.Forms/_apis/build/status/cube-soft.Cube.Forms?branchName=master)](https://dev.azure.com/cube-soft-jp/Cube.Forms/_build)

Cube.Forms is a WinForms based GUI library.
The library is available for .NET Framework 3.5, 4.5 or higher.

## Installation

You can install using NuGet like this:

    PM> Install-Package Cube.Forms

Or select it from the NuGet packages UI on Visual Studio.

## Dependencies

* [Cube.Core](https://github.com/cube-soft/Cube.Core)
* [Cube.FileSystem](https://github.com/cube-soft/Cube.FileSystem)
* [Cube.Images](https://github.com/cube-soft/Cube.Images)

## Contributing

1. Fork [Cube.Forms](https://github.com/cube-soft/Cube.Forms/fork) repository.
2. Create a feature branch from the master or stable branch (e.g. git checkout -b my-new-feature origin/master). Note that the master branch may refer some pre-released NuGet packages. Try the [rake clean](https://github.com/cube-soft/Cube.Forms/blob/master/Rakefile) command when build errors occur.
3. Commit your changes.
4. Rebase your local changes against the master or stable branch.
5. Run test suite with the [NUnit](https://nunit.org/) console or the Visual Studio (NUnit 3 test adapter) and confirm that it passes.
6. Create new Pull Request.

## License

Copyright © 2010 [CubeSoft, Inc.](https://www.cube-soft.jp/)
The project is licensed under the [Apache 2.0](https://github.com/cube-soft/Cube.Forms/blob/master/License.txt).