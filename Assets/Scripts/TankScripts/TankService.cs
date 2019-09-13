using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : GenericSingleton<TankService>
{
    public TankView tankView;
    private ServicePoolTank servicePoolTank;
    public float speed;
    //public BulletService bulletService;
    public TankScriptableObjectList tankList;
    //public BulletScriptableObjectList bulletList;
    public BulletService bulletService;
    public Vector3 randomPosition;
    public int tank_no;

    public List<TankView> enemyTanks;

    protected override void Awake()
    {
        base.Awake();
    }
    void Start()
    {
        PlayerPrefs.SetFloat("Score", 0);
        bulletService = GetComponent<BulletService>();
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
            tank_no = 0;
            SpawnTankType(tank_no);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            tank_no = 1;
            SpawnTankType(tank_no);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            tank_no = 2;
            SpawnTankType(tank_no);
        }
    }

    public void SpawnTankType(int a)
    {
        TankModel tankModel = new TankModel(tankList.tanks[a]);
        InstantiateTank(tankModel);
        
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
    