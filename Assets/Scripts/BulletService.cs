using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoBehaviour
{
    private static BulletService instance;
    public BulletService Instance { get { return instance; } }
    
    public BulletView redBulletView;
    public BulletView blueBulletView;
    public BulletView greenBulletView;

    public float speed;
    public BulletModel bulletModel;
    public TankService tankService;
    public BulletController bulletController;

    public void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    void GetBulletsData()
    {

    }

    public Dictionary<string, string> test;
}
