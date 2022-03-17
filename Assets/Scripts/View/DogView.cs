using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogView : EnemyView
{
    private EnemyController _controller = new EnemyController();

    private void Start()
    {
        _controller.SetStartPosition(this.transform, _controller.DogModel);
    }

    private void Update()
    {
        _controller.SetMovement(this.transform, speed, _controller.DogModel);
        ChangeSprite(_controller.DogModel, _controller.GetDirection(_controller.DogModel).y,_controller.GetDirection(_controller.DogModel).x);
    }
}
