using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogModel : EnemyModel
{
    public override  List<Vector3> _waypoints
    {
        get
        {
            return new List<Vector3>()
            {
                new Vector3(-4.8f, -2f, 0f),
                new Vector3(-4.8f, 1.5f, 0),
                new Vector3(-4.8f, -2f, 0f),
                new Vector3(4.8f, -2f, 0f),
            };
        }
    }

    public override Vector3 directionVector3 { get => base.directionVector3; set => base.directionVector3 = value; }
}
