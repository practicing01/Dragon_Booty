function Module_Gui_Main_Menu::Variables_Initialize(%this)
{

Dragon_Booty.Bool_Local_Connection=false;

/******************************/

%this.GuiControl_Main_Menu=TamlRead("./../../gui/GuiControl_Main_Menu.gui.taml");

%this.GuiControl_Main_Menu.resize(0,0,Gui_Dragon_Booty_Overlay.Extent.X,Gui_Dragon_Booty_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Main_Menu,%this);

Dragon_Booty.add(%this.GuiControl_Main_Menu);

Gui_Dragon_Booty_Overlay.add(%this.GuiControl_Main_Menu);

/******************************/

}
