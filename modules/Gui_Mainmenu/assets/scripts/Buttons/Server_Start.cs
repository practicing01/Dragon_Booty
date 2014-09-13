function Module_Gui_Main_Menu::Server_Start(%this,%GuiButtonCtrl)
{

Dragon_Booty.Bool_Hosting_Server=!Dragon_Booty.Bool_Hosting_Server;

if (Dragon_Booty.Bool_Hosting_Server)
{

%GuiButtonCtrl.setText("Stop Server");

setNetPort(9002);//OVER NINE THOUSAND

Module_Server.Server_Load();

}
else
{

%GuiButtonCtrl.setText("Start Server");

Module_Server.Server_Unload();

}

}
