function Module_Gui_Instructions_Menu::Variables_Initialize(%this)
{

%this.Gui_Text_ML=0;

%this.GuiControl_Instructions_Menu=TamlRead("./../../gui/GuiControl_Instructions_Menu.gui.taml");

%this.GuiControl_Instructions_Menu.resize(0,0,Gui_Dragon_Booty_Overlay.Extent.X,Gui_Dragon_Booty_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Instructions_Menu,%this);

Dragon_Booty.add(%this.GuiControl_Instructions_Menu);

Gui_Dragon_Booty_Overlay.add(%this.GuiControl_Instructions_Menu);

}
 