using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPatrollingState : TankState
{
    private float timeElapsed;
    public override void OnEnterState()
    {
        base.OnEnterState();
        Debug.Log("Entering Patrolling state");
        tankView.ChangeColor(color);
    }

    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exiting Patrolling state");

    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed>5f)
        {
            //tankView.ChangeState(GetComponent<TankChasingState>());
            tankView.ChangeState(tankView.chasingState);

        }
    }
}
