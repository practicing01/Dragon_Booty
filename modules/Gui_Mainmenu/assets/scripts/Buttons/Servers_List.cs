function Module_Gui_Main_Menu::Servers_List(%this,%GuiButtonCtrl)
{

//queryLanServers(0,0,"","",0,0,0,0,0,0,0);return;

//querySingleServer("192.168.1.100:9001","");return;

if (Dragon_Booty.Bool_Hosting_Server||Dragon_Booty.Bool_Hosting_Master_Server)
{

return;

}

if (!isObject(Dragon_Booty.GameConnection_Master_Server_Query))
{

setNetPort(9003);//OVER NINE THOUSAND

Dragon_Booty.GameConnection_Master_Server_Query=new GameConnection();

Dragon_Booty.GameConnection_Master_Server_Query.setConnectArgs
(

$pref::Dragon_Booty::Player_Name,//Connector Name

"Client"//Connector Type

);

if (Dragon_Booty.Bool_Local_Connection)
{

echo("Can't query master server, this is a local connection.");

}
else
{

echo("Connecting to the master server for query.");

Dragon_Booty.GameConnection_Master_Server_Query.connect($pref::Dragon_Booty::Master_IP);

}

}

}
