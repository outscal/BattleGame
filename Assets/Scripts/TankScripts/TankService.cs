using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    private static TankService instance;
    public TankService Instance {  get { return instance; } } 
    
    public TankView tankView;

    public BulletView bulletPrefab;
    
    public float speed;
    public BulletService bulletService;
    public TankScriptableObjectList tankList;
    public BulletScriptableObjectList bulletList;

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
        PlayerPrefs.SetFloat("Score", 0);
        bulletService = GetComponent<BulletService>();
    }

    public void Update()
    {
        SpawnTank();
        SpawnBullets();
        SpawnEnemyTanks();
    }

    private void SpawnTank()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            TankModel model = new TankModel(tankList.tanks[0]);
            BulletModel bulletPrefab =new BulletModel(bulletList.bullets[0]);
            InstantiateTank(model);
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            TankModel model = new TankModel(tankList.tanks[1]);
            BulletModel bulletPrefab = new BulletModel(bulletList.bullets[1]);
            InstantiateTank(model);
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            TankModel model = new TankModel(tankList.tanks[2]);
            BulletModel bulletPrefab = new BulletModel(bulletList.bullets[2]);
            InstantiateTank(model);
        }
    }

    private void InstantiateTank(TankModel tankmodel)
    {
        TankController tankController = new TankController(tankmodel, tankView, bulletService);

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
        if (Input.GetKeyDown(KeyCode.O))
        {
            randomPosition = new Vector3(Random.Range(-10.0F, 40.0F), 0, Random.Range(-10.0F, 40.0F));
            int selection = Random.Range(0, enemyTanks.Count);
            Instantiate(enemyTanks[selection], randomPosition, Quaternion.identity);
            BulletController bulletController = new BulletController(bulletPrefab);

        }

    }
}
    