using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaRepeater : MonoBehaviour
{
    public Transform Sea1,Sea2;
    public float speed;

    private List<Transform> SeaList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        SeaList.Add(Sea1);
        SeaList.Add(Sea2);

    }

    // Update is called once per frame
    void Update()
    {
        Sea1.position -= new Vector3(0,speed * Time.deltaTime,0);
        Sea2.position -= new Vector3(0, speed * Time.deltaTime, 0);
        if (SeaList[0].position.y < -15f)
            ChangeObjects();
    }


    public void ChangeObjects()
    {
        Vector2 tempPos = SeaList[1].position;
        tempPos += new Vector2(0, 20);
        SeaList[0].position = tempPos;

        Transform tempSea = SeaList[0];
        SeaList[0] = SeaList[1];
        SeaList[1] = tempSea;
    }
}
