using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : BaseView
{
    public EnemyEnum enemyEnum;
    private EnemyController _controller = new EnemyController();
    public  int _speed = 3;

    private void Awake()
    {
        switch (enemyEnum)
        {
            case EnemyEnum.Dog:
                _controller.model = _controller.DogModel;
                break;
            case EnemyEnum.Fermer:
                _controller.model = _controller.FermerModel;
                break;
        }
    }

    private void Start()
    {
        _controller.SetStartPosition(this.transform, _controller.model);
    }

    private void Update()
    {
        _controller.SetMovement(this.transform, _speed, _controller.model);
        ChangeSprite(_controller.model, _controller.GetDirection(_controller.model).y, _controller.GetDirection(_controller.model).x);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerView>(out PlayerView player))
        {
            player.Die();
        }
    }
}
