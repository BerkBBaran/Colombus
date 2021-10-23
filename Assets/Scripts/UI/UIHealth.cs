using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private List<GameObject> _heartList;
    
    private CollisionManager _collisionManager;

    private int currentHearts;

    public event Action<RectTransform> OnHeartRemoved;


    private void Awake()
    {
        _collisionManager = FindObjectOfType<CollisionManager>();
    }

    void Start()
    {
        currentHearts = _heartList.Count;

    }

    public void RemoveHeart()
    {
        if (currentHearts > 0)
        {
            var heart = _heartList[currentHearts-1];
            OnHeartRemoved?.Invoke(heart.GetComponent<RectTransform>());
            --currentHearts;
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
