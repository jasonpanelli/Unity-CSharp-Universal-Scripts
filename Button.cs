using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {
    public string buttonName;
    public string sceneName;
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount==1)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
                if (hit.collider != null && hit.collider.name == buttonName)
                {
                    transform.localScale = new Vector2(.95f, .95f);
                }
                else
                {
                    transform.localScale = new Vector2(1, 1);
                }
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                transform.localScale = new Vector2(1, 1);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
                if (hit.collider != null && hit.collider.name == buttonName)
                {
                    SceneManager.LoadScene(sceneName);
                }
            }
            
        }
	}
}
