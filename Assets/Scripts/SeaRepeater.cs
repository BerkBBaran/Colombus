using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaRepeater : MonoBehaviour
{
    public float speed;

    private List<Transform> _seaList = new List<Transform>();
    // Start is called before the first frame update

    private void Initiliaze()
    {
        _seaList.Add(transform.GetChild(0));
        _seaList.Add(transform.GetChild(1));

    }
    void Start()
    {
        Initiliaze();

    }

    // Update is called once per frame
    void Update()
    {
        ShiftObjects();
    }

    void ShiftObjects()
    {
        foreach (Transform sea in _seaList)
        {
            sea.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (_seaList[0].position.y < -15f)
            ChangeObjects();
    }
    public void ChangeObjects()
    {
        Vector2 tempPos = _seaList[1].position;
        tempPos += new Vector2(0, 20);
        _seaList[0].position = tempPos;

        Transform tempSea = _seaList[0];
        _seaList[0] = _seaList[1];
        _seaList[1] = tempSea;
    }
}
