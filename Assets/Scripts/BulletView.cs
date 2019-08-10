using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDamage;

    public BulletController bulletController;
    public TankService tankService;
    void Start()
    {
        bulletSpeed = BulletModel.Speed;
        tankService = GetComponent<TankService>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject,2f);
    }

    public BulletController BulletController { get; set; }
}
