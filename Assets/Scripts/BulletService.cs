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

    void Start()
    {
        tankService = GetComponent<TankService>();
        bulletController = GetComponent<BulletController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //bulletController.Fire();
        }
    }

    void GetBulletsData()
    {

    }
    /*

    public void ShootBullets()
    {
        if(tankService.redTankView)
        {
            Debug.Log("Shoot Red Bullets");
            BulletModel model = new BulletModel(100f, 50f);
            BulletController bullet = new BulletController(model, redBulletView);
        }
        else if (tankService.blueTankView)
        {
            Debug.Log("Shoot Blue Bullets");
            BulletModel model = new BulletModel(110f, 60f);
            BulletController bullet = new BulletController(model, blueBulletView);
        }
        else if (tankService.greenTankView)
        {
            Debug.Log("Shoot Green Bullets"); 
            BulletModel model = new BulletModel(200f, 10f); 
            BulletController bullet = new BulletController(model, greenBulletView);
        }   
    }
    */
}
