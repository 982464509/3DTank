using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject texiao;
	void Start () {
		
	}
	
	void Update () {
		
	}

    public void OnTriggerEnter()
    {
        GameObject.Instantiate(texiao, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
