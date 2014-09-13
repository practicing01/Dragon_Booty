function Module_Gui_Config_Menu::Set_Player_Name(%this,%GuiButtonCtrl)
{

$pref::Dragon_Booty::Player_Name=%this.GuiControl_Config_Menu->GuiTextEditCtrl_Player_Name.getText();

Dragon_Booty.Preferences_Save();

}
