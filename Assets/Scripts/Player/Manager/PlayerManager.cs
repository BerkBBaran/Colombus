using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance=null;

    [SerializeField] private GameObject _playerParent;
    [SerializeField] private float _ghostTime = 3f;


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


    public void GhostModeOn()
    {
        // Ghost Player layer
        SetLayer(_playerParent, 10);
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