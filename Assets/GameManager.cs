using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] RectTransform obj;

    // Update is called once per frame
    void Update()
    {
        //Push Debug Console

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            obj.position = new Vector3(0, Screen.height / 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            obj.transform.position = new Vector3(Screen.width - obj.rect.width, Screen.height / 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            obj.transform.position = new Vector3(Screen.width / 2, Screen.height - obj.rect.height, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            obj.transform.position = new Vector3(Screen.width / 2, 0, 0);
        }
    }
}
