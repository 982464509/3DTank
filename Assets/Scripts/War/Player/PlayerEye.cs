using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEye : MonoBehaviour
{
    private static PlayerEye _instance;

    public static PlayerEye Instance
    {
        get { return _instance; }
    }
    void Awake()
    {
        _instance = this;
    }
    public GameObject Turret;  //炮塔
    public bool Islocking=false;//是否锁定
    public bool Isslide=false;//是否手指滑动

    public Image Sighter;//瞄准器

    void Start () {
		
	}
	void Update ()
	{
	    
    }
    
    
      void OnTriggerStay(Collider col)
      {
        if (col.transform.tag == "Enemy" && !Isslide)
        {
            Turret.transform.LookAt(col.transform.position);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy" && !Isslide)
        {
            Islocking = true;
            Sighter.color = Color.red;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.transform.tag == "Enemy" && !Isslide)
        {
            Islocking = false;
            Sighter.color = Color.white;
        }
    }
}
