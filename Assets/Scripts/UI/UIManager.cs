using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _button;

    public static bool isGame;

    public void PlayButton()
    {
        _panel.SetActive(false);
        _button.SetActive(false);
        isGame = true;
    }
}
