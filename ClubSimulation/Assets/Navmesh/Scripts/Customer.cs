using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Agent
{
    protected override void SetAims()
    {
        aims = Storage.points;
    }
}
