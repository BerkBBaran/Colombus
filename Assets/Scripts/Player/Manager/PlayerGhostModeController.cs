using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerGhostModeController : MonoBehaviour
{
    public static PlayerGhostModeController Instance = null;

    [SerializeField] private GameObject _playerParent;
    [SerializeField] private float _ghostTime = 3f;

    public event Action<GameObject, float> OnGhostModeStarted;


    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator GhostModeRoutine()
    {
        GhostModeOn();
        yield return new WaitForSeconds(_ghostTime);

        ExitGhostMode();
    }

    private void GhostModeOn()
    {
        // Ghost Player layer
        SetLayer(_playerParent, 10);
        // pass child as parameter
        OnGhostModeStarted?.Invoke(_playerParent, _ghostTime);
    }

    private void ExitGhostMode()
    {
        // Normal Player layer
        SetLayer(_playerParent, 6);
    }

    private void SetLayer(GameObject go, int layerNum)
    {
        go.layer = layerNum;

        foreach (Transform child in go.transform)
        {
            SetLayer(child.gameObject, layerNum);
        }
    }
}