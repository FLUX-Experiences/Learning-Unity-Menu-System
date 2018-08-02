
using UnityEngine;

public class SceneLoader : MonoBehaviour {

    private static SceneLoader instance;
    internal static SceneLoader Instance { get { return instance; } }
    
    void Awake()
    {
        instance = this;
    }




    public void LoadScene(string scene_name)
    {
        Debug.Log("SceneLoader will now load scene named " + scene_name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene_name);
    }



	
	
}
