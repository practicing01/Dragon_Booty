function Dragon_Booty::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Dragon_Booty");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Dragon_Booty.cs");

/*Network*/
exec("./scripts/Network/Network.cs");

Window_Create_Dragon_Booty();

Scene_Create_Dragon_Booty();

Dragon_Booty.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Dragon_Booty:CannotRender";

};

Dragon_Booty.add(CannotRenderProxy);

Dragon_Booty.Camera_Size=SceneWindow_Dragon_Booty.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Dragon_Booty::destroy(%this)
{
Window_Destroy_Dragon_Booty();
}
