using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private List<GameObject> _objectPool;

    public List<GameObject> ObjectBool => _objectPool;

    public static ObjectPool Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _objectPool = new List<GameObject>();
    }

    public void GetObject(Transform transform, GameObject gameObject)
    {
        bool freeObject = false;

        for (int i = 0; i < _objectPool.Count; i++)
        {
            if (!_objectPool[i].activeInHierarchy)
            {
                _objectPool[i].transform.position = transform.position;

                _objectPool[i].transform.rotation = transform.rotation;

                _objectPool[i].SetActive(true);

                freeObject = true;
                break;
            }
        }
        if (!freeObject)
        {
            _objectPool.Add(Instantiate(gameObject, transform.position, transform.rotation) as GameObject);
        }
    }
}
