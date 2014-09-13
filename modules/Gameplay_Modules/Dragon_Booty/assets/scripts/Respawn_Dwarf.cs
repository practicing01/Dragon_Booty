function Module_Dragon_Booty::Respawn_Dwarf(%this)
{

%this.Sprite_Dwarf.Position=(-%this.Vector_2D_Camera_Size_Half.X)+%this.Vector_2D_Dwarf_Size_Half.X SPC "0";

%this.Sprite_Dwarf.setLinearVelocity(getRandom(10,500) SPC "0");

}
