using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
   
    public TankModel(float speed, float health)
    {
        Speed = speed;
        Health = health;
    }
    
    public static float Speed { get; set;  }
    public float Health { get; }
}
