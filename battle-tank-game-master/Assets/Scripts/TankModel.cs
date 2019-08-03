using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
   // public static float inspectorSpeed;
 
    public TankModel(float speed, float health)
    {
        Speed = speed;
        //inspectorSpeed = speed;
        Health = health;
        //Debug.Log(speed);
    }

    //public void Movement()
    //{
        
    //}

    
    public static float Speed { get; set;  }
    public float Health { get; }
}
