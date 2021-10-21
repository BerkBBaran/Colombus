using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class UIHealth : MonoBehaviour
{
    //Serialize
    [SerializeField] private List<GameObject> _heartList;
    [SerializeField] private Color _emptyHeartColor;
    [SerializeField] private CollisionManager _collisionManager;

    //private fields

    private int currentHearts;

    // Start is called before the first frame update
    void Start()
    {
        currentHearts = _heartList.Count;

    }
    public void RemoveHeart()
    {
        if (currentHearts > 0)
        {
            var heart = _heartList[currentHearts-1];
            --currentHearts;
            heart.GetComponent<Image>().color = _emptyHeartColor;
        }
    }
    private void OnEnable()
    {
        _collisionManager.OnTakeDamage += RemoveHeart;
    }
    private void OnDisable()
    {
        _collisionManager.OnTakeDamage -= RemoveHeart;
    }



}
