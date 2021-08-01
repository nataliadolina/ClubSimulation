using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityGuard : Agent
{
    protected override void SetAims()
    {
        aims = Storage.agents;
    }
}
