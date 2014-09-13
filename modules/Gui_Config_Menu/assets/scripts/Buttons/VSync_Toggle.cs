function Module_Gui_Config_Menu::VSync_Toggle(%this,%GuiButtonCtrl)
{

$pref::Video::disableVerticalSync=!$pref::Video::disableVerticalSync;

setVerticalSync($pref::Video::disableVerticalSync);

Dragon_Booty.Preferences_Save();

}
