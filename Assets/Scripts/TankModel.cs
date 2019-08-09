using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
   
    public TankModel(float speed, float health,float bulletSpeed,float damage)
    {
        Speed = speed;
        Health = health;
        BulletSpeed = bulletSpeed;
        Damage = damage;
    }
    
    public static float Speed { get; set;  }
    public float Health { get; }
    public static float BulletSpeed { get; set; }
    public static float Damage { get; set; }
    
}
