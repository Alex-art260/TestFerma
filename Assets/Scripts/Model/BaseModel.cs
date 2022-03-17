using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BaseModel
{
    public virtual int waypointIndex { get; set; }

    public virtual List<Vector3> _waypoints { get; set; }

    public virtual Vector3 directionVector3 { get; set; }

    public virtual Vector2 directionVector2 { get; set; }
}
