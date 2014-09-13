function Module_Dragon_Booty::Unload(%this)
{

%this.Ass_Unload();

if (isObject(%this.Script_Object_Input_Controller)&&isObject(SceneWindow_Dragon_Booty))
{

SceneWindow_Dragon_Booty.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

if (isObject(%this.File_Top_Score))
{

%this.File_Top_Score.delete();

}

}
