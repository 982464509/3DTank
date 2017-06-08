using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public GameObject turret;  //炮塔
    private float shellspeed = 25;  //炮弹速度
    public GameObject shell;  //炮弹
    public Transform FireTransform; //炮弹实例化坐标
    void Start () {
		
	}
	
	void Update ()
	{
	    
	}

    public void Fire()
    {
        GameObject go = GameObject.Instantiate(shell, FireTransform.position, FireTransform.rotation) as GameObject;
        go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
    }
}





