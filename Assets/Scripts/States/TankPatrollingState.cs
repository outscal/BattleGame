using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPatrollingState : TankState
{
    //private float timeElapsed;
    private TankController tankController; 
    private EnemyScript enemyScript;
    public Transform player;
    //private TankView tankView;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //tankView = GetComponent<TankView>();
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        Debug.Log("Entering Patrolling state");
        //tankView.ChangeColor(color);
    }

    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exiting Patrolling state");

    }

    private void Update()
    {
        //timeElapsed += Time.deltaTime;
        //if (timeElapsed > 5f)
        //{
            //tankView.ChangeState(GetComponent<TankChasingState>());
            
            if (Vector3.Distance(player.position,GetComponent<EnemyScript>().transform.position) < 30f)
            {
                Debug.Log(player.position);
                Debug.Log("Change to Attacking State");
                //Debug.Log(GetComponent<EnemyScript>().transform.position);
                //Debug.Log(tankController.currentPosition);
                tankView.ChangeState(tankView.chasingState);
            }
            
            //tankView.ChangeState(tankView.chasingState);
        //}
    }
}
