exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");
exec("./../Classes/Classes.cs");

function Module_Gui_Main_Menu::Scene_Load(%this)
{

Gui_Dragon_Booty_Overlay.deleteObjects();

%this.Ass_Load();

Scene_Dragon_Booty.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Gui_Main_Menu.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

%this.Variables_Initialize();

%this.Scene_Initialize();

}