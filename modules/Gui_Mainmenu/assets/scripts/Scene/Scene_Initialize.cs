function Module_Gui_Main_Menu::Scene_Initialize(%this)
{

%Sprite_BG_Render=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_BG_Render);
Image="Module_Gui_Main_Menu:Image_BG_Render";

BodyType="static";

};

Scene_Dragon_Booty.add(%Sprite_BG_Render);
return;
if (isObject(Dragon_Booty.GameConnection_Client_Connection))
{

Dragon_Booty.GameConnection_Client_Connection.delete("Returning to Main Menu.");

}

if (isObject(Module_Master_Server))
{

Module_Master_Server.Master_Server_Unload();

}

if (isObject(Module_Server))
{

Module_Server.Server_Unload();

}

if (isObject(Module_Lobby))
{

Module_Lobby.Scene_Unload();

}

ModuleDatabase.LoadExplicit("Module_Master_Server");

ModuleDatabase.LoadExplicit("Module_Server");

ModuleDatabase.LoadExplicit("Module_Lobby");

}
