function Class_GuiPopUpMenuCtrl_Resolution_List::onSelect(%this,%GuiButtonCtrl)
{

%String_Resolution=%this.getText();

if(setRes(%String_Resolution.X,%String_Resolution.Y,%String_Resolution.Z))
{

$pref::Video::defaultResolution = %String_Resolution.X SPC %String_Resolution.Y;

$pref::Video::windowedRes = %String_Resolution;

Dragon_Booty.Preferences_Save();

Dragon_Booty.Resolution=%String_Resolution.X SPC %String_Resolution.Y;

%Y_Times_100=100*Dragon_Booty.Resolution.Y;
%Cam_Y=%Y_Times_100/Dragon_Booty.Resolution.X;

SceneWindow_Dragon_Booty.setCameraSize(100,%Cam_Y);

Gui_Dragon_Booty_Overlay.resize(0,0,Dragon_Booty.Resolution.X,Dragon_Booty.Resolution.Y);

}

}
