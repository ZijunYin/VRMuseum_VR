using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Create menu of all scenes included in the build.
public class GoOutside : MonoBehaviour
{   
    // public OVROverlay overlay;
    // public OVROverlay text;
    // public OVRCameraRig vrRig;

    void Start()
    {
        DebugUIBuilder.instance.AddLabel("You can choose");
        
        // int n = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        // for (int i = 0; i < n; ++i)
        // {
        //     string path = UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(i);
        //     var sceneIndex = i;
        //     DebugUIBuilder.instance.AddButton(Path.GetFileNameWithoutExtension(path), () => LoadScene(sceneIndex));
        // }
        // DebugUIBuilder.instance.AddButton("Go outside", () => LoadScene(1));
        DebugUIBuilder.instance.AddButton("Go outside", LoadScene);
        DebugUIBuilder.instance.AddButton("Go Santorini", LoadSceneSan);
        DebugUIBuilder.instance.Show();
    }

    public void LoadScene()
    {
        DebugUIBuilder.instance.Hide();
        // Debug.Log("Load scene: " + idx);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadSceneSan()
    {
        DebugUIBuilder.instance.Hide();
        // Debug.Log("Load scene: " + idx);
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
