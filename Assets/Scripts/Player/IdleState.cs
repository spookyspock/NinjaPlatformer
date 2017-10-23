﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : AbstractState
{
    public override StateType Type { get { return StateType.Idle; } }

    public IdleState(CharacterController2D characterController, IStateInputProvider stateInputProvider) 
        : base(characterController, stateInputProvider) { }

    public override bool TryMakeTransition(StateType current, out StateType newState)
    {
        newState = Type;
        var input = inputProvider.Get();

        if (Mathf.Abs(input.horizontal) > Constants.axisThreshold)
        {
            newState = StateType.Run;
            return true;
        }
        return false;
    }

    public override void Update()
    {
        
    }
}
