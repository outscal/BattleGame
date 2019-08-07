using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletModel(float speed, float damage)
    {
        Speed = speed;
        Damage = damage;
    }

    public static float Speed { get; set; }
    public float Damage { get; }
}
