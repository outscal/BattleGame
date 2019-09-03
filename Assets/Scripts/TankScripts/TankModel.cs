using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    public TankModel(TankScriptableObject tankscriptableobject)
    {
        Speed = tankscriptableobject.Speed;
        Health = tankscriptableobject.Health;
        TankType = tankscriptableobject.tankType;
        //Position = TankView.transform.position;
        Debug.Log("Tank Type"+TankType);
    }

    //public TankModel(TankType tankType,float speed, float health,float bulletSpeed,float damage)
    //{
    //    Speed = speed;
    //    Health = health;
    //    BulletSpeed = bulletSpeed;
    //    Damage = damage;
    //}
    
    public static float Speed { get; set;  }
    public float Health { get; }
    public static float BulletSpeed { get; set; }
    public static float Damage { get; set; }
    public TankType TankType { get; set; }
    public static Vector3 Position { get; set; }
}
