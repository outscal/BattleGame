using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    private static TankService instance;
    public TankService Instance {  get { return instance; } } 
    
    public TankView tankView;

    public float speed;
    //public BulletService bulletService;
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
        //bulletService = GetComponent<BulletService>();
    }

    public void Update()
    {
        SpawnTank();
        SpawnEnemyTanks();
    }

    private void SpawnTank()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SpawnTankType(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnTankType(1, 1);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnTankType(2, 2);
        }
    }

    private void SpawnTankType(int a,int b)
    {
        TankModel tankModel = new TankModel(tankList.tanks[a]);
        BulletModel bulletModel = new BulletModel(bulletList.bullets[b]);
        InstantiateTank(tankModel);

        
            tankView.SpawnBullets(bulletModel);
        
    }

    private void InstantiateTank(TankModel tankmodel)
    {
        TankController tankController = new TankController(tankmodel, tankView);
    }

    void SpawnEnemyTanks()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            randomPosition = new Vector3(Random.Range(-10.0F, 40.0F), 0, Random.Range(-10.0F, 40.0F));
            int selection = Random.Range(0, enemyTanks.Count);
            Instantiate(enemyTanks[selection], randomPosition, Quaternion.identity);
           // BulletController bulletController = new BulletController(bulletPrefab);

        }

    }
}
    