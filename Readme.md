<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication27/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication27/Form1.vb))
* [Program.cs](./CS/WindowsApplication27/Program.cs) (VB: [Program.vb](./VB/WindowsApplication27/Program.vb))
<!-- default file list end -->
# How to load a spellchecker dictionary from an assembly resource


<p>XtraSpellChecker allows a developer to deploy dictionaries within an application's assembly.  To do this, add dictionary files to this assembly as an embedded resource.  Then create a new dictionary object, get stream objects representing dictionary files and finally use the dictionary's LoadFromStream method to load a dictionary.  To obtain stream objects, it is possible to use the Assembly.GetManifestResourceStream method.  To determine the resource's name, use the IlDasm tool.</p>

<br/>


