using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance=null;

    [SerializeField] private GameObject _playerParent;
    [SerializeField] private float _ghostTime;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("sa");
    }
    public void TakeDamage()
    {
        _playerParent.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        Invoke(nameof(ReturnRigidbody), _ghostTime);

    }
    private void ReturnRigidbody()
    {
        _playerParent.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
