function Module_Gui_Config_Menu::Variables_Initialize(%this)
{

/******************************/

%this.GuiControl_Config_Menu=TamlRead("./../../gui/GuiControl_Config_Menu.gui.taml");

%this.GuiControl_Config_Menu.resize(0,0,Gui_Dragon_Booty_Overlay.Extent.X,Gui_Dragon_Booty_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Config_Menu,%this);

Dragon_Booty.add(%this.GuiControl_Config_Menu);

Gui_Dragon_Booty_Overlay.add(%this.GuiControl_Config_Menu);

/******************************/


}
