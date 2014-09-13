function Class_Trigger_Zone::onEnter(%this,%Object)
{

%this.Bool_Triggered=true;

if (%this.String_Zone$="End")
{

%Sprite_Sparkle=new Sprite()
{

BodyType="static";

Position=%this.Position;

Size=%this.Module_ID_Parent.Vector_2D_Sparkle_Size;

Animation="Module_Dragon_Booty:lightningballAnimation";

LifeTime=1;

SceneLayer=1;

};

Scene_Dragon_Booty.add(%Sprite_Sparkle);

%this.Module_ID_Parent.Respawn_Dwarf();

%this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score=0;

%this.Module_ID_Parent.GuiTextCtrl_Score.setText("Score:" SPC %this.Module_ID_Parent.GuiTextCtrl_Score.Int_Score);

}

}

function Class_Trigger_Zone::onLeave(%this,%Object)
{

%this.Bool_Triggered=false;

}
