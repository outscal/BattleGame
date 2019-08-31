using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoBehaviour
{
    private static int score;
    private static BulletService instance;
    public BulletService Instance { get { return instance; } }

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
