function Module_Dragon_Booty::Variables_Initialize(%this)
{

%this.Vector_2D_Dragon_Size=%this.Ass_Image_Dragon.getCellWidth() SPC %this.Ass_Image_Dragon.getCellHeight();

%this.Vector_2D_Dragon_Size=Vector2Mult(%this.Vector_2D_Dragon_Size,SceneWindow_Dragon_Booty.getCameraWorldScale());

%this.Vector_2D_Dwarf_Size=%this.Ass_Image_Dwarf.getCellWidth() SPC %this.Ass_Image_Dwarf.getCellHeight();

%this.Vector_2D_Dwarf_Size=Vector2Mult(%this.Vector_2D_Dwarf_Size,SceneWindow_Dragon_Booty.getCameraWorldScale());

%this.Vector_2D_Dragon_Size_Half=Vector2Mult(%this.Vector_2D_Dragon_Size,"0.5 0.5");

%this.Vector_2D_Dwarf_Size_Half=Vector2Mult(%this.Vector_2D_Dwarf_Size,"0.5 0.5");

%this.Vector_2D_Camera_Size=SceneWindow_Dragon_Booty.getCameraSize();

%this.Vector_2D_Camera_Size_Half=Vector2Mult(%this.Vector_2D_Camera_Size,"0.5 0.5");

%this.Vector_2D_Sparkle_Size=%this.Ass_Image_Sparkle.getCellWidth() SPC %this.Ass_Image_Sparkle.getCellHeight();

%this.Vector_2D_Sparkle_Size=Vector2Mult(%this.Vector_2D_Sparkle_Size,SceneWindow_Dragon_Booty.getCameraWorldScale());

%this.Vector_2D_Blood_Size=%this.Ass_Image_Blood.getImageSize();

%this.Vector_2D_Blood_Size=Vector2Mult(%this.Vector_2D_Blood_Size,SceneWindow_Dragon_Booty.getCameraWorldScale());

/**************************************************************************************************************/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dragon_Booty.addInputListener(%this.Script_Object_Input_Controller);

/**************************************************************************************************************/

%this.GuiTextCtrl_Score=new GuiTextCtrl()
{

Profile="Gui_Profile_Modalless_Text";

Text="Score: 0";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="200 40";

MaxLength="512";

Module_ID_Parent=%this;

Int_Score=0;

};

Gui_Dragon_Booty_Overlay.add(%this.GuiTextCtrl_Score);

/**************************************************************************************************************/

%this.File_Top_Score=new FileObject();

%this.File_Top_Score.OpenForRead("./Top_Score.txt");

%Int_Top_Score=%this.File_Top_Score.readline();

%this.File_Top_Score.close();

%this.GuiTextCtrl_High_Score=new GuiTextCtrl()
{

Profile="Gui_Profile_Modalless_Text";

Text="High Score:" SPC %Int_Top_Score;

HorizSizing="relative";

VertSizing="relative";

Position="600 0";

Extent="200 40";

MaxLength="512";

Module_ID_Parent=%this;

Int_Score=%Int_Top_Score;

};

Gui_Dragon_Booty_Overlay.add(%this.GuiTextCtrl_High_Score);

/**************************************************************************************************************/

//Return to Main Menu button.
/*
%this.GuiButtonCtrl_MainMenu=new GuiButtonCtrl()
{

class="Class_GuiButtonCtrl_Module_Dragon_Booty";

String_Action="Main_Menu";

Profile="Black_0ButtonProfile";

Text="X";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="760 0";

Extent="40 40";

Module_ID_Parent=%this;

};

Gui_Dragon_Booty_Overlay.add(%this.GuiButtonCtrl_MainMenu);
*/

}
