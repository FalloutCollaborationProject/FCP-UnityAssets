using System.IO;
using UnityEditor;
using Directory = UnityEngine.Windows.Directory;


public class CreateAssetBundles
{
    [MenuItem ("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles ()
    {
        string pathPrefix = Path.Combine("Materials");
        string pathLinux = Path.Combine(pathPrefix, "StandaloneLinux64");
        string pathOSX = Path.Combine(pathPrefix, "StandaloneOSX");
        string pathWin = Path.Combine(pathPrefix, "StandaloneWindows64");
        
        if(!Directory.Exists(pathLinux)) Directory.CreateDirectory(pathLinux);
        BuildPipeline.BuildAssetBundles (pathLinux, BuildAssetBundleOptions.None, BuildTarget.StandaloneLinux64);

        if(!Directory.Exists(pathOSX)) Directory.CreateDirectory(pathOSX);
        BuildPipeline.BuildAssetBundles (pathOSX, BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);

        if(!Directory.Exists(pathWin)) Directory.CreateDirectory(pathWin);
        BuildPipeline.BuildAssetBundles (pathWin, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }

}
