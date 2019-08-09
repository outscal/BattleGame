using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDamage;

    void Start()
    {
        bulletSpeed = BulletModel.Speed;
    }

    
    public void Call()
    {
        Debug.Log("Fire");
        BulletView bulletView = GameObject.Instantiate<BulletView>(BulletController.prefab);
    }
    
    public BulletController BulletController { get; set; }
}
