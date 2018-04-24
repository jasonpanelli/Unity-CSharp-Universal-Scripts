using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour
{
    public Camera cam;
    public string wall;
    void Start()
    {
        float aspect = cam.aspect;
        float height = 2 * cam.orthographicSize;
        float units = height * aspect;
        if (wall=="right")
            transform.position = new Vector2(units / 2f + .5f, 0);
        else
            transform.position = new Vector2(-units / 2f - .5f, 0);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Line")
        {
            string wallName = transform.name;
            hitInfo.gameObject.SendMessage("ChangeDirection", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}