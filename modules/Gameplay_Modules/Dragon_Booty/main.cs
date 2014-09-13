function Module_Dragon_Booty::create(%this)
{

exec("./assets/scripts/scripts.cs");

%this.Load();

}

function Module_Dragon_Booty::destroy(%this)
{

%this.Unload();

}
