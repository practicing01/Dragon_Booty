function clientCmdRegister_Player_Disconnect(%GameConnection_Client_Sender)
{

echo("Register_Player_Disconnect:" SPC %GameConnection_Client_Sender);

for (%x=0;%x<Dragon_Booty.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dragon_Booty.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{

for (%y=0;%y<Dragon_Booty.SimSet_Modules_That_Synchronize_Clients.getCount();%y++)
{

%Module_ID=Dragon_Booty.SimSet_Modules_That_Synchronize_Clients.getObject(%y);

%Module_ID.Synchronize_Clients(%ScriptObject_Client,false);

}

Dragon_Booty.Simset_Client_List.remove(%ScriptObject_Client);

%ScriptObject_Client.delete();

return;

}

}

}
