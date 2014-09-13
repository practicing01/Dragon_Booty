function Class_GuiListBoxCtrl_Main_Menu_Server_List::onDoubleClick(%this)
{

%Server_Name=%this.getItemText(%this.getSelectedItem());

%ScriptObject_Server=0;

for (%x=0;%x<Dragon_Booty.Simset_Server_List.getCount();%x++)
{

%ScriptObject=Dragon_Booty.Simset_Server_List.getObject(%x);

if (%ScriptObject.Connector_Name$=%Server_Name)
{

%ScriptObject_Server=%ScriptObject;

break;

}

}

if (%ScriptObject_Server==0){return;}

if (isObject(Dragon_Booty.GameConnection_Master_Server_Query))
{

Dragon_Booty.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Dragon_Booty.GameConnection_Client_Connection))
{

Dragon_Booty.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

Dragon_Booty.GameConnection_Client_Connection=new GameConnection();

Dragon_Booty.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dragon_Booty::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to server:" SPC %ScriptObject_Server.Connector_Name SPC "at:" SPC %ScriptObject_Server.IP_Address);

Dragon_Booty.GameConnection_Client_Connection.connect(%ScriptObject_Server.IP_Address);

}
