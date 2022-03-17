using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private PlayerModel _playerModel = new PlayerModel();

    public PlayerModel PlayerModel => _playerModel;
    private Vector2 direction;

    public override void SetMovement(Transform transform, int speed, BaseModel model, float horizontal, float vertical, Rigidbody2D rigidbody)
    {
        Vector3 moveInput = new Vector3(horizontal, vertical);
        direction = moveInput.normalized * speed;
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    public int BombsAmount 
    {
        get => _playerModel.BombsAmount = _playerModel.MaximumBombsCounter;
        set => _playerModel.BombsAmount = value;
    } 


    public int MinimumBombsCounter => _playerModel.MinimumBombsCounter;

    public int MaximumBombsCounter => _playerModel.MaximumBombsCounter;

    public List<GameObject> Bombs
    {
        get => _playerModel.Bombs;
        set { }
    }
}
