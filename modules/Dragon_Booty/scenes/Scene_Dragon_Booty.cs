function Window_Create_Dragon_Booty()
{

if (!isObject(SceneWindow_Dragon_Booty))
{

new SceneWindow(SceneWindow_Dragon_Booty);   

SceneWindow_Dragon_Booty.Profile=Gui_Profile_SceneWindow_Dragon_Booty;

Canvas.setContent(SceneWindow_Dragon_Booty);                     

}

SceneWindow_Dragon_Booty.stopCameraMove();
SceneWindow_Dragon_Booty.dismount();
SceneWindow_Dragon_Booty.setViewLimitOff();
SceneWindow_Dragon_Booty.setRenderGroups(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setRenderLayers(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setObjectInputEventGroupFilter(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setObjectInputEventLayerFilter(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setUseObjectInputEvents(true);
SceneWindow_Dragon_Booty.setLockMouse(true);
SceneWindow_Dragon_Booty.setCameraPosition(0,0);
SceneWindow_Dragon_Booty.setCameraZoom(1);
SceneWindow_Dragon_Booty.setCameraAngle(0);

Dragon_Booty.Resolution=getRes();
%Y_Times_100=100*Dragon_Booty.Resolution.Y;
%Cam_Y=%Y_Times_100/Dragon_Booty.Resolution.X;

SceneWindow_Dragon_Booty.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Dragon_Booty_Overlay))
{

new GuiControl(Gui_Dragon_Booty_Overlay)
{

Position="0 0";

Extent=Dragon_Booty.Resolution;

Profile=gui_profile_modalless;

class="Class_Gui_Dragon_Booty_Overlay";

};   

SceneWindow_Dragon_Booty.addGuiControl(Gui_Dragon_Booty_Overlay);

Gui_Dragon_Booty_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Dragon_Booty()
{
    
if (isObject(SceneWindow_Dragon_Booty))
{

SceneWindow_Dragon_Booty.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Dragon_Booty()
{

if (isObject(Scene_Dragon_Booty))
{

Scene_Dragon_Booty.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Dragon_Booty))
{

error("Cannot set Dragon_Booty Scene to Window as the Scene is invalid.");
return;

}
    
SceneWindow_Dragon_Booty.setScene(Scene_Dragon_Booty);

SceneWindow_Dragon_Booty.stopCameraMove();
SceneWindow_Dragon_Booty.dismount();
SceneWindow_Dragon_Booty.setViewLimitOff();
SceneWindow_Dragon_Booty.setRenderGroups(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setRenderLayers(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setObjectInputEventGroupFilter(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setObjectInputEventLayerFilter(Dragon_Booty.All_Bits);
SceneWindow_Dragon_Booty.setUseObjectInputEvents(true);
SceneWindow_Dragon_Booty.setLockMouse(true);
SceneWindow_Dragon_Booty.setCameraPosition(0,0);
SceneWindow_Dragon_Booty.setCameraZoom(1);
SceneWindow_Dragon_Booty.setCameraAngle(0);

Dragon_Booty.Resolution=getRes();
%Y_Times_100=100*Dragon_Booty.Resolution.Y;
%Cam_Y=%Y_Times_100/Dragon_Booty.Resolution.X;

SceneWindow_Dragon_Booty.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Dragon_Booty()
{

//Scene_Destroy_Dragon_Booty();

//new Scene(Scene_Dragon_Booty);

if (!isObject(SceneWindow_Dragon_Booty))
{

error("Dragon_Booty: did not create scene; no window available.");

//error("Dragon_Booty: Created scene but no window available.");

return;

}

Scene_Destroy_Dragon_Booty();

new Scene(Scene_Dragon_Booty);

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Dragon_Booty to use an invalid Scene.");
return;

}
   
Scene_Destroy_Dragon_Booty();

%Scene.setName("Scene_Dragon_Booty");

//%Scene.class="Class_Scene_Dragon_Booty";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Dragon_Booty::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/

function Class_Gui_Dragon_Booty_Overlay::onControlDropped(%this,%GuiControl_Target,%Vector_2D_Position)
{

%GuiControl_Target.onControlDropped(%Vector_2D_Position);

}
