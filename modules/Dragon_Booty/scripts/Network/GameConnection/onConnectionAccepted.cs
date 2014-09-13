//client
function GameConnection::onConnectionAccepted(%this)
{

echo("GameConnection onConnectionAccepted. Handle:" SPC %this);

if (isObject(Dragon_Booty.GameConnection_Master_Server_Query)&&!Dragon_Booty.Bool_Local_Connection)//This is a query connection.
{

echo("Querying master server.");

if (isObject(Dragon_Booty.Simset_Server_List))
{

Dragon_Booty.Simset_Server_List.deleteObjects();

Module_Gui_Main_Menu.GuiControl_Main_Menu->GuiScrollCtrl_Main_Menu_Server_List->GuiListBoxCtrl_Main_Menu_Server_List.clearItems();

}

commandToServer('Master_Server_Query_Request');

}
else if (isObject(Dragon_Booty.GameConnection_Client_Connection)&&Dragon_Booty.Bool_Is_Client)//This is a client to server connection.
{

Module_Gui_Main_Menu.Scene_Unload();

Module_Lobby.Scene_Load();

}

}
