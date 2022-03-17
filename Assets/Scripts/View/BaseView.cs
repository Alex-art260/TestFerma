using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseView : MonoBehaviour
{
    private BaseController _controller = new BaseController();
    protected const int FirstElementIndex = 0;
    protected const int SecondElementIndex = 1;
    protected const int ThirdElementIndex = 2;
    protected const int FourthElemenIndex = 3;

    private GameObject _baseView;

    public GameObject GameObject => _baseView;

    [SerializeField] protected Sprite[] sprites;
    [SerializeField] protected SpriteRenderer spriteRenderer;
    protected int speed;

    protected virtual void ChangeSprite(BaseModel model, float vertical, float horizontal)
    {
        if (vertical < 0)
            _controller.SetSprite(spriteRenderer, sprites[FirstElementIndex]);
        if (vertical > 0)
            _controller.SetSprite(spriteRenderer, sprites[SecondElementIndex]);
        if (horizontal > 0)
            _controller.SetSprite(spriteRenderer, sprites[ThirdElementIndex]);
        if (horizontal < 0)
            _controller.SetSprite(spriteRenderer, sprites[FourthElemenIndex]);
    }


    public void Die()
    {
        gameObject.SetActive(false);
    }

}
