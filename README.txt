Lazy Newb Pack GUI V18.3

The Lazy Newb Pack is an open-source third party launcher for the game Dwarf Fortress
It provides a GUI to easily change game settings, run other third party utilities, install graphics packs, and more.

Documntation is available at the github page and in the `LNP\About` folder.  

-Released under the GNU General Public License V3
-Requires Microsoft Visual Basic 2008 Express or higher. Open "LazyNewbPackGUI.vbproj"
-The folder bin\debug is used when you export/test the program, it includes the LNP folder structure.
-Does not include Dwarf Fortress files, or LNP utilities or graphics packs, you must add them yourself.

The main Lazy Newb Pack thread can be found here:
http://www.bay12forums.com/smf/index.php?topic=126076

The Lazy Newb Pack Developtment thread can be found here:
http://www.bay12forums.com/smf/index.php?topic=123384

Github Code Repository:
https://github.com/PeridexisErrant/LNP-GUI


Contributors:  
Lucas Paquette/LucasUP (Origional creator and coder, retired Feb 2013)
TolyK/aTolyK (Graphical concept and coding)
Mason11987 (Provided source of DFConfig)
xndrad (Provided source of DFInit)
daveralph1234 (current lead coder)
PeridexisErrant (documentation, maintains Starter Pack)

==================================
Lazy Newb Pack (LNP) Launcher GUI documentation
--as used in the Dwarf Fortress Starter Pack (dffd.wimbli.com/file.php?id=7622)

=GAME=
Extract a copy of Dwarf Fortress, and place the folder next to "Lazy Newb Pack.exe"
The "Dwarf Fortress" folder can be named anything starting with "Dwarf Fortress" (ie "Dwarf Fortress 9001" would work)


In the LNP Folder:
==================

=About=
Contains documentation about the launcher and the package as a whole.

=Defaults=
Copy d_init.txt and init.txt from the new DF version into "LNP\Defaults"
These will be what your settings revert to when you click the "Defaults" button.

=Extras=
Any files in "LNP\Extras" are copied into the Dwarf Fortress folder the first time "Lazy Newb Pack.exe" is run.
A text file is made named "LNPx.x.txt" in the DF directory, where "x.x" is the version of the GUI. If you delete this file, the Extras folder will be installed again the next time Lazy Newb Pack is run.

=Keybinds=
Contains renamed and edited versions of DF's "data\init\interface.txt".  
The launcher can substitute the contents to provide control schemes which are better suited to a laptop (Classic LNP) or also to mouse control (PeridexisErrant).  The default keys are provided to switch back.  

=Graphics=
Extract any graphics packs you want to be able to use into a subfolder of "LNP\Graphics"
	LOOKS LIKE: 	"Graphics\Mayday\[files]"
	NOT LIKE:   	"Graphics\Mayday\Mayday\[files]"
Once placed you can press the "Simplify Graphic Folder" button in the Lazy Newb Pack program to delete all the extra files the pack may contain - effictively extracting the graphics from a full install of Dwarf Fortress.
This is useful to save space or to re-pack to a friend

=Useful=
A folder provided as a default place to put useful things, such as saved copies of tutorials.

=Utilities=
Put ANY utilities you want to use into the "LNP\Utilities" folder. LNP automatically recognizes .exe, .bat, and .jar files.  
You can hide files from the utilities pane of the launcher by adding their filenames to "LNP\exclude.txt".  The configuration for Soundsense is provided as an example.  

=LNPWin.txt=
Defines the entries in the dropdown menus 'links' and 'folders'.  Modifiable to add or remove entries; sensible defaults are provided.  
