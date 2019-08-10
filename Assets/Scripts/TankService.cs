using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    private static TankService instance;
    public TankService Instance {  get { return instance; } } 

    public TankView redTankView;
    public TankView blueTankView;
    public TankView greenTankView;

    public BulletView bulletPrefab;
    
    public float speed;
    public BulletService bulletService;

    public Vector3 randomPosition;

    public List<TankView> enemyTanks;

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
        bulletService = GetComponent<BulletService>();
    }

    public void Update()
    {
        SpawnTank();
        SpawnBullets();
        
    }

    void SpawnTank()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            TankModel model = new TankModel(0.05f, 100f, 100f, 100f);
            TankController tank = new TankController(model, redTankView);
            bulletPrefab = bulletService.redBulletView;
            //BulletModel bulletModel = new BulletModel(5f, 100f);
            
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            TankModel model = new TankModel(.02f, 50f, 200f, 100f);
            TankController tank = new TankController(model, blueTankView);
            bulletPrefab = bulletService.blueBulletView;
            
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            TankModel model = new TankModel(.1f, 200f, 150f, 100f);
            TankController tank = new TankController(model, greenTankView);
            bulletPrefab = bulletService.greenBulletView;
            
        }

        else if(Input.GetKeyDown(KeyCode.O))
        {
            SpawnEnemyTanks();
        }
        
    }

    public void SpawnBullets()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            BulletController bulletController = new BulletController(bulletPrefab);
            //Destroy(bulletController, 2f);
        }
    }

    void SpawnEnemyTanks()
    {
        randomPosition = new Vector3(Random.Range(-10.0F, 40.0F), 0, Random.Range(-10.0F, 40.0F));
        int selection = Random.Range(0, enemyTanks.Count);
        Instantiate(enemyTanks[selection], randomPosition ,Quaternion.identity);
        BulletController bulletController = new BulletController(bulletPrefab);
    }
}
    