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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

    public BulletController BulletController { get; set; }
}
