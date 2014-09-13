function Module_Gui_Main_Menu::Single_Player(%this,%GuiButtonCtrl)
{

ModuleDatabase.LoadExplicit( "Module_Dragon_Booty" );

Module_Gui_Main_Menu.Scene_Unload();

return;

if (Dragon_Booty.Bool_Hosting_Server||Dragon_Booty.Bool_Hosting_Master_Server)
{

return;

}

if (isObject(Dragon_Booty.GameConnection_Master_Server_Query))
{

Dragon_Booty.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Dragon_Booty.GameConnection_Client_Connection))
{

Dragon_Booty.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

setNetPort(9002);//OVER NINE THOUSAND

ClientGroup.deleteObjects();//Clear clients.

Dragon_Booty.Bool_Local_Connection=true;

Dragon_Booty.Bool_Hosting_Server=true;

Module_Server.Server_Load();

Dragon_Booty.GameConnection_Client_Connection=new GameConnection();

Dragon_Booty.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dragon_Booty::Player_Name,//Connector Name

"Client"//Connector Type

);

Dragon_Booty.GameConnection_Client_Connection.connectLocal();

}
