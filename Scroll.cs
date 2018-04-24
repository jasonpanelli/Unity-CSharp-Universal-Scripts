using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
    public float speed;
    public float sizeOfSprite;
    private float size;
    private float startPos;

    public static Scroll instance;
    public Scroll otherObject;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        size = sizeOfSprite;
        startPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-speed / 100f, 0f, 0f);
        if (speed>0)
        {
            if (startPos - transform.position.x >=  size)
            {
                transform.Translate(size, 0f, 0f);
            }
        }
        else
        {
            if (startPos - transform.position.x <= size)
            {
                transform.Translate(-size, 0f, 0f);
            }
        }
	}
}
