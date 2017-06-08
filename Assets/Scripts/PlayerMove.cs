using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody rigidbody;    //玩家刚体
    private float speed=5f;          //玩家速度
    private float angularSpeed = 1f;  //玩家转速
    

    private float Turnspeed = 1;    //炮塔转速
    public GameObject turret;  //炮塔
    private float shellspeed = 25;  //炮弹速度
    public GameObject shell;  //炮弹
    public Transform FireTransform; //炮弹实例化坐标


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

    /// <summary>
    /// 自动瞄准，开火系统
    /// </summary>
    public void Fire()
    {
        GameObject go = GameObject.Instantiate(shell, FireTransform.position, FireTransform.rotation) as GameObject;
        go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
    }


   
  

    
    void FixedUpdate()
    {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
    {
        Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
        turret.transform.Rotate(0, touchDeltaPosition.x * Turnspeed, 0);
    }
    else
    {     //炮塔自动警戒转向
    

    }
    }

    void Automatic()
    {
        bool IsTurn = false;  //是否进行下一次转动
        if (IsTurn)
        {
           
        }
        else
        {
            
        }
    }








}
