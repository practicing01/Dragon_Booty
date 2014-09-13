function Dragon_Booty::Preferences_Save(%this)
{

%FileObject_File_Out=new FileObject();

%FileObject_File_Out.openForWrite("./../../../../preferences.cs");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::aabbOption =" SPC $pref::Dragon_Booty::aabbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::cameraMouseZoomRate =" SPC $pref::Dragon_Booty::cameraMouseZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::cameraTouchZoomRate =" SPC $pref::Dragon_Booty::cameraTouchZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::collisionOption =" SPC $pref::Dragon_Booty::collisionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::defaultBackgroundColor = \"" @ $pref::Dragon_Booty::defaultBackgroundColor @ "\";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::fpsmetricsOption =" SPC $pref::Dragon_Booty::fpsmetricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::jointsOption =" SPC $pref::Dragon_Booty::jointsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::metricsOption =" SPC $pref::Dragon_Booty::metricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::oobbOption =" SPC $pref::Dragon_Booty::oobbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::positionOption =" SPC $pref::Dragon_Booty::positionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::sleepOption =" SPC $pref::Dragon_Booty::sleepOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::sortOption =" SPC $pref::Dragon_Booty::sortOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::wireframeOption =" SPC $pref::Dragon_Booty::wireframeOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::Player_Name = \"" @ $pref::Dragon_Booty::Player_Name @ "\";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::Master_IP = \"" @ $pref::Dragon_Booty::Master_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Dragon_Booty::P2P_IP = \"" @ $pref::Dragon_Booty::P2P_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::allowOpenGL =" SPC $pref::Video::allowOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::appliedPref =" SPC $pref::Video::appliedPref @ ";");

%FileObject_File_Out.writeLine("$pref::Video::clipHigh =" SPC $pref::Video::clipHigh @ ";");

%FileObject_File_Out.writeLine("$pref::Video::defaultResolution = \"" @ $pref::Video::defaultResolution @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsRenderer = \"" @ $pref::Video::defaultsRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsVendor = \"" @ $pref::Video::defaultsVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::deleteContext =" SPC $pref::Video::deleteContext @ ";");

%FileObject_File_Out.writeLine("$pref::Video::disableVerticalSync =" SPC $pref::Video::disableVerticalSync @ ";");

%FileObject_File_Out.writeLine("$pref::Video::displayDevice = \"" @ $pref::Video::displayDevice @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::fullScreen =" SPC $pref::Video::fullScreen @ ";");

%FileObject_File_Out.writeLine("$pref::Video::only16 =" SPC $pref::Video::only16 @ ";");

%FileObject_File_Out.writeLine("$pref::Video::preferOpenGL =" SPC $pref::Video::preferOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::profiledRenderer = \"" @ $pref::Video::profiledRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::profiledVendor = \"" @ $pref::Video::profiledVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::safeModeOn =" SPC $pref::Video::safeModeOn @ ";");

%FileObject_File_Out.writeLine("$pref::Video::windowedRes = \"" @ $pref::Video::windowedRes @ "\";");

%FileObject_File_Out.writeLine("$pref::Audio::sfxVolume =" SPC $pref::Audio::sfxVolume @ ";");

%FileObject_File_Out.writeLine("$pref::Audio::musicVolume =" SPC $pref::Audio::musicVolume @ ";");

%FileObject_File_Out.writeLine("$pref::T2D::imageAssetGlobalFilterMode = \"" @ $pref::T2D::imageAssetGlobalFilterMode @ "\";");

%FileObject_File_Out.writeLine("");

%FileObject_File_Out.close();

}
