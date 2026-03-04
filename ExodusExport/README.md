# README #

This is unity part of ProjectExodus.

Currently supported versions are **2018.3** to **Unity 6 (6000.x)**.

Json Exporter is present in Editor/ExportScripts folder.
The export utility was designed to transfer unity engine scene into Unreal 4.

### How to use in Unity 6 ###

1. **Import the Plugin**: Drop the `ExodusExport` folder into your Unity project's `Assets` folder.
2. **Enable the Plugin**: In Unity 6, the plugin is automatically discovered via the Assembly Definition file. You should see a new menu item **"Migrate to UE 4"** in the top menu bar.
3. **Export a Scene**: 
    - Objects you want to export must be parented to some sort of "root" object.
    - Right-click on the root object in the Hierarchy window and select **"Migration to UE4" > "Export selected objects"** or **"Export current object"**.
    - This will open a "save file" dialog. Choose a location for the resulting JSON file (preferably in your project's root folder).
4. **URP Support**: This version now includes support for Universal Render Pipeline (URP) materials.

### Notes ###

For additional information check readme of "JsonImporter" project. There are couple of gotchas, for example, the script 
will not automatically convert *.tif textures into png, and you should do it yourself.
