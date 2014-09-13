function Dragon_Booty::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Dragon_Booty_Input_Controller";

};

SceneWindow_Dragon_Booty.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
