using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController 
{
    public virtual void SetMovement(Transform transform, int speed, BaseModel model)
    {

    }

    public virtual void SetMovement(Transform transform, int speed, BaseModel model, float direction, float direction2, Rigidbody2D rigidbody)
    {

    }

    public  void SetSprite(SpriteRenderer spriteRenderer, Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public  Vector3 GetDirection(BaseModel model)
    {
        return model.directionVector3;
    }

    public void SetStartPosition(Transform transform, BaseModel model)
    {
        transform.position = model._waypoints[model.waypointIndex];
    }
}
