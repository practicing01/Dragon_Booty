function Module_Gui_Main_Menu::P2P(%this,%GuiButtonCtrl)
{

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

setNetPort(9003);//OVER NINE THOUSAND

Dragon_Booty.GameConnection_Client_Connection=new GameConnection();

Dragon_Booty.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dragon_Booty::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to P2P server:" SPC $pref::Dragon_Booty::P2P_IP);

Dragon_Booty.GameConnection_Client_Connection.connect($pref::Dragon_Booty::P2P_IP);

}
