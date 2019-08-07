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

    void Update()
    {
        
    }
}
