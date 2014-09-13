function Module_Dragon_Booty::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Dragon))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dragon.getAssetId());

}

if (isObject(%this.Ass_Image_Dwarf))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dwarf.getAssetId());

}

if (isObject(%this.Ass_Image_Sparkle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Sparkle.getAssetId());

}

if (isObject(%this.Ass_Image_Blood))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Blood.getAssetId());

}

}
