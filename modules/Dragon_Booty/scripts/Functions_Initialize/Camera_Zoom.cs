function Class_Dragon_Booty_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Dragon_Booty.setCameraZoom(SceneWindow_Dragon_Booty.getCameraZoom()+$pref::Dragon_Booty::cameraMouseZoomRate);

}

function Class_Dragon_Booty_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Dragon_Booty.setCameraZoom(SceneWindow_Dragon_Booty.getCameraZoom()-$pref::Dragon_Booty::cameraMouseZoomRate);

}
