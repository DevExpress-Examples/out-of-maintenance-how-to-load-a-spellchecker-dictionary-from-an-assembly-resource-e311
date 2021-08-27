<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612455/18.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E311)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication27/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication27/Form1.vb))
* [Program.cs](./CS/WindowsApplication27/Program.cs) (VB: [Program.vb](./VB/WindowsApplication27/Program.vb))
<!-- default file list end -->
# How to load a spellchecker dictionary from an assembly resource


<p>XtraSpellChecker allows a developer to deploy dictionaries within an application's assembly.  To do this, add dictionary files to this assembly as an embedded resource.  Then create a new dictionary object, get stream objects representing dictionary files and finally use the dictionary's LoadFromStream method to load a dictionary.  To obtain stream objects, it is possible to use the Assembly.GetManifestResourceStream method.  To determine the resource's name, use the IlDasm tool.</p>

<br/>


