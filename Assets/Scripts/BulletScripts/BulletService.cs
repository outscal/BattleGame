using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : GenericSingleton<BulletService>
{
    protected override void Awake()
    {
        base.Awake();
    }

    private static int score;
    
    public float speed;
    public BulletModel bulletModel;
    public BulletView bulletView;
    public BulletController bulletController;
    public BulletScriptableObjectList bulletLists;

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

}
