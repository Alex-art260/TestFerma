using UnityEngine;
using UnityEngine.UI;
using System;

public  class UIElementsManager : MonoBehaviour
{
    public static event Action OnPlayGame;

    [SerializeField] private Button _buttonBomb;
    [SerializeField] private Button _playButton;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _playButtonObject;
    [SerializeField] private PlayerView _player;

    public static bool isGame;

    private void OnEnable()
    {
        _buttonBomb.onClick.AddListener(OnClickBomb);
        _playButton.onClick.AddListener(OnClickPlayButton);
    }

    private void OnDisable()
    {
        _buttonBomb.onClick.RemoveListener(OnClickBomb);
        _playButton.onClick.RemoveListener(OnClickPlayButton);
    }

    private void OnClickBomb()
    {
        _player.PlantBomb();
    }

    private void OnClickPlayButton()
    {
        _panel.SetActive(false);
        _playButtonObject.SetActive(false);
        OnPlayGame?.Invoke();
    }
}
