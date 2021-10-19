using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityShifter : MonoBehaviour
{
    public float speed;
    private List<Transform> _entityList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
            _entityList.Add(transform.GetChild(i));
        
    }

    // Update is called once per frame
    void Update()
    {
        ShiftObjects();

    }
    void ShiftObjects()
    {
        foreach (Transform entity in _entityList)
        {
            entity.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
            

    }
}
