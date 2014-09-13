function Module_Dragon_Booty::Scene_Initialize(%this)
{

%this.Sprite_Dragon=new Sprite()
{

BodyType="static";

Position=0 SPC %this.Vector_2D_Camera_Size_Half.Y-%this.Vector_2D_Dragon_Size_Half.Y;

Size=%this.Vector_2D_Dragon_Size;

Animation="Module_Dragon_Booty:DragonAnimation";

SceneLayer=0;

};

Scene_Dragon_Booty.add(%this.Sprite_Dragon);

%this.Sprite_Dwarf=new Sprite()
{

Position=(-%this.Vector_2D_Camera_Size_Half.X)+%this.Vector_2D_Dwarf_Size_Half.X SPC "0";

Size=%this.Vector_2D_Dwarf_Size;

Animation="Module_Dragon_Booty:dwarvesAnimation";

FlipX=true;

Collision_Shape_Index=-1;

LinearVelocity="30 0";

SceneLayer=2;

};

%this.Sprite_Dwarf.Collision_Shape_Index=%this.Sprite_Dwarf.createPolygonBoxCollisionShape(%this.Vector_2D_Dwarf_Size_Half);

%this.Sprite_Dwarf.setCollisionShapeIsSensor(%this.Sprite_Dwarf.Collision_Shape_Index,true);

Scene_Dragon_Booty.add(%this.Sprite_Dwarf);

%this.Trigger_Eat_Zone=new Trigger()
{

BodyType="static";

class="Class_Trigger_Zone";

Position="0 0";

Size=%this.Vector_2D_Dwarf_Size_Half.X SPC %this.Vector_2D_Camera_Size.Y;

Collision_Shape_Index=-1;

Bool_Triggered=false;

String_Zone="Eat";

Module_ID_Parent=%this;

};

%this.Trigger_Eat_Zone.Collision_Shape_Index=%this.Trigger_Eat_Zone.createPolygonBoxCollisionShape(%this.Trigger_Eat_Zone.Size);

%this.Trigger_Eat_Zone.setCollisionShapeIsSensor(%this.Trigger_Eat_Zone.Collision_Shape_Index,true);

Scene_Dragon_Booty.add(%this.Trigger_Eat_Zone);

%this.Trigger_End_Zone=new Trigger()
{

BodyType="static";

class="Class_Trigger_Zone";

Position=%this.Vector_2D_Camera_Size.X*0.25 SPC "0";

Size=%this.Vector_2D_Dwarf_Size_Half.X SPC %this.Vector_2D_Camera_Size.Y;

Collision_Shape_Index=-1;

Bool_Triggered=false;

String_Zone="End";

Module_ID_Parent=%this;

};

%this.Trigger_End_Zone.Collision_Shape_Index=%this.Trigger_End_Zone.createPolygonBoxCollisionShape(%this.Trigger_End_Zone.Size);

%this.Trigger_End_Zone.setCollisionShapeIsSensor(%this.Trigger_End_Zone.Collision_Shape_Index,true);

Scene_Dragon_Booty.add(%this.Trigger_End_Zone);

}
