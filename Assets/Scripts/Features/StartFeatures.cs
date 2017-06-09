using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFeatures : MonoBehaviour {

	
	void Start () {
		
	}
	
	void Update () {
		
	}

    public void OnLoadLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
