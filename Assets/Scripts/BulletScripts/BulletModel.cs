using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletModel(BulletScriptableObject bulletScriptableObject)
    {
        Speed =bulletScriptableObject.Speed;
        Damage = bulletScriptableObject.Damage;
        BulletType = bulletScriptableObject.bulletType;
        Debug.Log("Bullet Type"+BulletType);
    }

    public static float Speed { get; set; }
    public float Damage { get; set; }
    public BulletType BulletType { get; set; }
}
