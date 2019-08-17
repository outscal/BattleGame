using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    public static int score;
    public float bulletSpeed;
    public float bulletDamage;

    public BulletController bulletController;
    public TankService tankService;
    private void Start()
    {
        score = 0;
        bulletSpeed = BulletModel.Speed;
        tankService = GetComponent<TankService>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
            score++;
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject,2f);
    }

    public BulletController BulletController { get; set; }
}
