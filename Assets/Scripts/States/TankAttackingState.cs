using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttackingState : TankState
{
    private TankController tankController;
    private bool stateActive = false;
    public override void OnEnterState()
    {
        base.OnEnterState();
        stateActive = true;
        Debug.Log("Entering Attacking state");
        
    }

    public override void OnExitState()
    {
        base.OnExitState();
        stateActive = false;
        Debug.Log("Exiting Attacking state");

    }

    private void Update()
    {
        //Debug.Log("Start Shooting on the Player");
        if (Input.GetKeyDown(KeyCode.F))
        {
            tankController.Fire();
        }
    }
}
