using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BunBuildAssets : MonoBehaviour
{
    [MenuItem("Tools/Build Asset Bundles")]
    static void BuildAssetsBundles()
    {
        BuildPipeline.BuildAssetBundles(Application.dataPath + "/Assetbundle", BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.WebGL);
    }
}
