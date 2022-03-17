using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _stone;
    [SerializeField] private List<GameObject> _gameObjects;
    [SerializeField] private GameObject _player;
    [SerializeField] private Image _panel;

    private const int gridWidth = 8;
    private const int gridHeight = 4;

    private float _transPosX = -6f;
    private float _transPosY = -3f;

    private void OnEnable()
    {
        UIElementsManager.OnPlayGame += StartGame;
    }

    private void OnDisable()
    {
        UIElementsManager.OnPlayGame -= StartGame;
    }

    private void StartGame()
    {
        _player.SetActive(true);
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    _transPosX = _transPosX + 0.04f;
                    var transformPos = _transPosX;

                    var stone = Instantiate(_stone, new Vector3(transformPos + j * 1.5f, _transPosY + i * 1.8f, 0), Quaternion.identity);
                    stone.transform.SetParent(this.gameObject.transform);
                }
            }

            for (int i = 0; i < _gameObjects.Count; i++)
            {
                Instantiate(_gameObjects[i], _gameObjects[i].transform.position, Quaternion.identity);
            }
    }
}
