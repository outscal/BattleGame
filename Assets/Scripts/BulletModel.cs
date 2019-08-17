using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletModel(BulletScriptableObject bulletScriptableObject)
    {
        Speed =bulletScriptableObject.Speed;
        Damage = bulletScriptableObject.Damage;
    }

    public static float Speed { get; set; }
    public float Damage { get; }
    public BulletType BulletType { get; }
}
