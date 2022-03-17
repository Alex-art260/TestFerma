using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermerModel : EnemyModel
{
    public override List<Vector3> _waypoints
    {
        get
        {
            return new List<Vector3>()
            {
                new Vector3(6.5f, 4f, 0f),
                new Vector3(6.5f, -3f, 0),
                new Vector3(6.5f, 4f, 0f),
                new Vector3(-6f, 4f, 0f),
            };
        }
    }
    public override Vector3 directionVector3 { get => base.directionVector3; set => base.directionVector3 = value; }
}
