using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerGhostModeController : MonoBehaviour
{
    [SerializeField] private float _ghostTime = 3f;

    public event Action<GameObject, float> OnGhostModeStarted;

    public IEnumerator GhostModeRoutine()
    {
        GhostModeOn();
        yield return new WaitForSeconds(_ghostTime);

        ExitGhostMode();
    }

    private void GhostModeOn()
    {
        // Ghost Player layer
        SetLayer(gameObject, 10);

        OnGhostModeStarted?.Invoke(gameObject, _ghostTime);
    }

    private void ExitGhostMode()
    {
        // Normal Player layer
        SetLayer(gameObject, 6);
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