using UnityEngine;
using System.Collections;
using HedgehogTeam.EasyTouch;

public class TurnTurret : MonoBehaviour
{
    public Transform Turret;  //坦克炮塔


    void OnEnable()
    {
        EasyTouch.On_SwipeEnd += On_SwipeEnd;
    }
    void OnDestroy()
    {
        EasyTouch.On_SwipeEnd -= On_SwipeEnd;
    }
   
    void On_SwipeEnd(Gesture gesture)
    {
            switch (gesture.swipe)
            {
              case EasyTouch.SwipeDirection.Left:
                    Turret.transform.rotation = new Quaternion(0,10,0,0);
                    break;
              
              case EasyTouch.SwipeDirection.Right:
                Turret.transform.rotation = new Quaternion(0, -10, 0, 0);
                break;
            }
   }
    

}

