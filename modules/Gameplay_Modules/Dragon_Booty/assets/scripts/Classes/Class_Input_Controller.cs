function Class_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%this.Module_ID_Parent.Sprite_Dragon.playAnimation("Module_Dragon_Booty:DragonAnimation");

if (%this.Module_ID_Parent.Trigger_Eat_Zone.Bool_Triggered)
{

%Sprite_Blood=new Sprite()
{

BodyType="static";

Position=%this.Position;

Size=%this.Module_ID_Parent.Vector_2D_Sparkle_Size;

Image="Module_Dragon_Booty:trak_rustdecal1128x128ImageMap";

LifeTime=1;

SceneLayer=1;

};

Scene_Dragon_Booty.add(%Sprite_Blood);

%this.Module_ID_Parent.Respawn_Dwarf();

%this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score++;

%this.Module_ID_Parent.GuiTextCtrl_Score.setText("Score:" SPC %this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score);

if (%this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score>%this.Module_ID_Parent.GuiTextCtrl_High_Score.Int_Score)
{

%this.Module_ID_Parent.GuiTextCtrl_High_Score.Int_Score=%this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score;

%this.Module_ID_Parent.GuiTextCtrl_High_Score.setText("High Score:" SPC %this.Module_ID_Parent.GuiTextCtrl_High_Score.Int_Score);

%this.Module_ID_Parent.File_Top_Score.OpenForWrite("./../Top_Score.txt");

%this.Module_ID_Parent.File_Top_Score.writeline(%this.Module_ID_Parent.GuiTextCtrl_High_Score.Int_Score);

%this.Module_ID_Parent.File_Top_Score.close();

}

}

}
