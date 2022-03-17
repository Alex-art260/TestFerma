using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : BaseView, IPlayerView
{
    PlayerController _controller = new PlayerController();
    [SerializeField] private Joystick _joystick;
    [SerializeField] private Rigidbody2D _rigidbody;
    protected int _speed = 15;

    [SerializeField] private BombView _bomb;

    private void Start()
    {
        _rigidbody.freezeRotation = true;
        _controller.Bombs = new List<GameObject>();
    }
    private void Update()
    {
        _controller.SetMovement(this.transform, _speed, _controller.PlayerModel, _joystick.Horizontal, _joystick.Vertical, _rigidbody);
        ChangeSprite(_controller.PlayerModel, _joystick.Vertical, _joystick.Horizontal);
    }

    protected override void ChangeSprite(BaseModel model, float vertical, float horizontal)
    {
        if (horizontal > 0.5f)
            _controller.SetSprite(spriteRenderer, sprites[FirstElementIndex]);

        if (horizontal < -0.5f)
            _controller.SetSprite(spriteRenderer, sprites[SecondElementIndex]);

        if (vertical > 0.5f)
            _controller.SetSprite(spriteRenderer, sprites[ThirdElementIndex]);

        if (vertical < -0.5f)
            _controller.SetSprite(spriteRenderer, sprites[FourthElemenIndex]);
    }

    public void PlantBomb()
    {
        if (gameObject.activeSelf == true)
        {
            if (_controller.BombsAmount > _controller.MinimumBombsCounter)
            {
                ObjectPool.Instance.GetObject(this.transform, _bomb.gameObject);

                _controller.BombsAmount--;
            }
        }
    }
}
