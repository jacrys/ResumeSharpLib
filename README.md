# ResumeSharpLib

An open source library for creating and manipulating [Json Resume](https://jsonresume.org/schema/ "Json Resume") object in C#

## Getting Started



### Prerequisites

.NET Standard 2.1 or higher

### Installing

To install ResumeSharpLib just execute the following command in your nuget CLI :

```bash
Install-Package ResumeSharpLib -Version 2.0.0
```
### Usage
To use the ResumeSharpLib do these steps: 
1. import ResumeSharpLib namespaces to your project:
```C#
using using ResumeSharpLib;
using ResumeSharpLib.Utils.Extentions;
```
2. Create a new instance of JsonResume:
```C#
 JsonResume jsonResume = new JsonResume();
```
3. Add your background to it:
```C#
jsonResume.AddAward(new Award())
                .AddWork(new Work())
                .AddEducation(new Education())
                .AddPublication(new Publication)
                ...
```
4. Convert your object easily to a json string:
```C#
string jsonString = jsonResume.ToJson();
```
And now every thing is done.

### Other Features
You can also create the JsonResume object from a json string:
```C#
JsonResume jsonResume = JsonResume.FromJson(jsonString);
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

