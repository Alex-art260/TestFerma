using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : BaseController
{
    public  EnemyModel model = new EnemyModel();
    private DogModel _dogModel = new DogModel();
    private FermerModel _fermerModel = new FermerModel();

    public FermerModel FermerModel => _fermerModel;
    public DogModel DogModel => _dogModel;

    public override void  SetMovement(Transform transform, int speed, BaseModel model)
    {
        transform.position = Vector3.MoveTowards(transform.position, model._waypoints[model.waypointIndex], speed * Time.deltaTime);

        model.directionVector3 = transform.position - model._waypoints[model.waypointIndex];

        if (transform.position == model._waypoints[model.waypointIndex])
            model.waypointIndex++;
        if (model.waypointIndex == model._waypoints.Count)
            model.waypointIndex = 0;
    }

}
