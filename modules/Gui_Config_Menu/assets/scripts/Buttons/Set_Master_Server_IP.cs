function Module_Gui_Config_Menu::Set_Master_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Dragon_Booty::Master_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_IP.getText();

Dragon_Booty.Preferences_Save();

}
