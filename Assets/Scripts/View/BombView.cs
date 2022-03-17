using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;

public class BombView : BaseView
{
    PlayerController _controller = new PlayerController();

    private void OnEnable()
    {
        _controller.BombsAmount = _controller.MaximumBombsCounter;
        Explosion().Forget();
    }
    private void Start()
    {
        _controller.BombsAmount--;
    }

    private async UniTaskVoid Explosion()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(3));
        gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyView>(out EnemyView enemy))
        {
            enemy.Die();
        }
    }
}
