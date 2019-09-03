using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : GenericSingleton<BulletService>
{
    public TankService tankService;
    private static int score;

    public float speed;
    public BulletModel bulletModel;
    public BulletView bulletView;
    public BulletController bulletController;
    public BulletScriptableObjectList bulletLists;

    protected override void Awake()
    {
        base.Awake();
        tankService = GetComponent<TankService>();
    }

    
    public BulletController SpawnBulletType()
    {
        Debug.Log("Any" + tankService.tank_no);
        BulletModel bulletModel = new BulletModel(bulletLists.bullets[tankService.tank_no]);
        BulletController bulletController = new BulletController(bulletModel, bulletView);
        return bulletController;
    }


}
