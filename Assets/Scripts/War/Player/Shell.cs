using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject texiao;//爆炸特效
	void Start () {
		
	}
	
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
       
        if (col.name== "PlayerEye")
        {
            return;
        }
        GameObject.Instantiate(texiao, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
