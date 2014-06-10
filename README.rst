=======================================
README for the Lazy Newb Pack GUI V18.3
=======================================

The Lazy Newb Pack is an open-source third party launcher for the game Dwarf Fortress
It provides a GUI to easily change game settings, run other third party utilities, install graphics packs, and more.

Documentation is available at the github page and in the `LNP\About` folder.  

-----------
Development
-----------
The Launcher was originally developed by Lucas Paquette/LucasUP in 2010, who later released it under the GPL3 in February 2013.  

Building the project from source requires Microsoft Visual Basic 2010 Express or higher (open "LazyNewbPackGUI.vbproj").  The folder ``./bin/debug/`` is used when you export/test the program, it includes the LNP folder structure - which is explained below.  Daveralph1234 maintains the current branch, hosted `on DFFD`_.

.. _`on DFFD`: http://dffd.wimbli.com/file.php?id=7426

*Dwarf Fortress* is not included, and nor are any other files and utilities; they can be added individually or you can download a pre-configured package such as the `Dwarf Fortress Starter Pack`_.  See also the `Bay12 Forums thread for development`_ of this launcher.

.. _`Dwarf Fortress Starter Pack`: http://www.bay12forums.com/smf/index.php?topic=126076
.. _`Bay12 Forums thread for development`: http://www.bay12forums.com/smf/index.php?topic=123384

Contributors:  
-------------

- Lucas Paquette/LucasUP (Origional creator and coder, retired Feb 2013)
- TolyK/aTolyK (Graphical concept and coding)
- Mason11987 (Provided source of DFConfig)
- xndrad (Provided source of DFInit)
- daveralph1234 (current lead coder)
- PeridexisErrant (documentation, maintains Starter Pack)

==================================

-------------------------------------
Lazy Newb Pack Launcher documentation
-------------------------------------
As used in the `Dwarf Fortress Starter Pack`_

Besides the GUI itself the launcher comes with a folder structure, each part of which has a purpose.  At the top level, there is the GUI, the "Dwarf Fortress" folder, and the "LNP" folder.  An explanation of each component follows.  

Dwarf Fortress Folder
---------------------
Extract a copy of Dwarf Fortress, and place the folder next to ``"./Lazy Newb Pack.exe"``
The Dwarf Fortress folder can be named anything starting with ``"Dwarf Fortress"`` (ie ``"./Dwarf Fortress 9001/"`` would work).
This is compatible with mods, but be careful as mods may conflict with the way graphics packs are installed. 


Under ``./LNP/``
----------------

``./LNP/About/``
----------------
Contains documentation about the launcher and the package as a whole.

``./LNP/Defaults/``
-------------------
Copy d_init.txt and init.txt from the new DF version into "LNP\Defaults"
These will be what your settings revert to when you click the "Defaults" button.

``./LNP/Extras/``
-----------------
Any files in "LNP\Extras" are copied into the Dwarf Fortress folder the first time "Lazy Newb Pack.exe" is run.
A text file is made named "LNPx.x.txt" in the DF directory, where "x.x" is the version of the GUI. If you delete this file, the Extras folder will be installed again the next time Lazy Newb Pack is run.

``./LNP/Keybinds/``
-------------------
Contains renamed and edited versions of DF's "data\init\interface.txt".  
The launcher can substitute the contents to provide control schemes which are better suited to a laptop (Classic LNP) or also to mouse control (PeridexisErrant).  The default keys are provided to switch back.  

``./LNP/Graphics/``
-------------------
Extract any graphics packs you want to be able to use into a subfolder of "LNP\Graphics"
LOOKS LIKE: 	"Graphics\Mayday\[files]"
NOT LIKE:   	"Graphics\Mayday\Mayday\[files]"
Once placed you can press the "Simplify Graphic Folder" button in the Lazy Newb Pack program to delete all the extra files the pack may contain - effictively extracting the graphics from a full install of Dwarf Fortress.
This is useful to save space or to re-pack to a friend

``./LNP/Useful/``
-----------------
A folder provided as a default place to put useful things, such as saved copies of tutorials.

``./LNP/Utilities/``
--------------------
Put ANY utilities you want to use into the "LNP\Utilities" folder. LNP automatically recognizes .exe, .bat, and .jar files.  
You can hide files from the utilities pane of the launcher by adding their filenames to "LNP\exclude.txt".  The configuration for Soundsense is provided as an example.  

``./LNP/LNPWin.txt``
---------------------
Defines the entries in the dropdown menus 'links' and 'folders'.  Modifiable to add or remove entries; sensible defaults are provided.  
