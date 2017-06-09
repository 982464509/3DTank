using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

    public GameObject camera;
	
	
	void Update () {
        this.transform.LookAt(camera.transform);
    }
}
