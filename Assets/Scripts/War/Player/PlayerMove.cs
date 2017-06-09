using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rigidbody;    //玩家刚体
    private float speed=5f;          //玩家速度
    private float angularSpeed = 1f;  //玩家转速


    public GameObject turret;  //炮塔
    public GameObject shell;  //炮弹
    public Transform FireTransform; //炮弹实例化坐标
    public GameObject kaihuo;//开火特效
    public Collider EyeCollider;//眼睛范围

    
    private float shellspeed = 20;  //炮弹速度
    public Transform EyeLength;//视野长度 EyeLength.localScale.z
    private float Turnspeed = 1;    //炮塔转速

    void Start ()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }
    
    public void OnMove(Vector2 ww)
    {
        rigidbody.velocity = transform.forward * ww.y * speed;
        rigidbody.angularVelocity = transform.up * angularSpeed * ww.x;
    }
    public void end()
    {
        rigidbody.velocity = transform.forward  * 0;
        rigidbody.angularVelocity = transform.up * 0;
    }

    private int sum = 0;
    public void Onstart() //按下摇杆
    {
        sum = 1;
    }

    public void OnUp()//放下摇杆
    {
        sum = 0;
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(sum).phase == TouchPhase.Moved)
        {
           PlayerEye.Instance.Isslide = true;
            Vector2 touchDeltaPosition = Input.GetTouch(sum).deltaPosition;
            turret.transform.Rotate(0, touchDeltaPosition.x * Turnspeed, 0);
        }
        else
        {
            PlayerEye.Instance.Isslide = false;
        }
    }


    

    /// <summary>
    /// 自动瞄准，开火系统
    /// </summary>
    public void Fire()
    {
        GameObject go = GameObject.Instantiate(shell, FireTransform.position, FireTransform.rotation) as GameObject;
        GameObject goo = GameObject.Instantiate(kaihuo, FireTransform.position, FireTransform.rotation) as GameObject;
        go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
         kaihuo.SetActive(false);
        kaihuo.SetActive(true);
    }
    

   

    

   






}
