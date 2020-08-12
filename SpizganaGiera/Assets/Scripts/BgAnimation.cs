using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgAnimation : MonoBehaviour
{

    [SerializeField] private float speed = 4;
    [SerializeField] private float startX = 20;
    [SerializeField] private float endX = 0;
    [SerializeField] private float amplitude = 3;

    [SerializeField] private GameObject XD = null;
    
    private Vector2 startPos = Vector2.zero;

    void Start()
    {
        startPos = transform.position;
	}

    void Update()
    {
        if(XD != null){
            if(Input.GetKeyDown(KeyCode.T))
                XD?.SetActive(true);

            if(Input.GetKeyUp(KeyCode.T))
                XD?.SetActive(false);
        }
        //transform.Translate(Vector2.left * speed * Time.deltaTime);

        transform.position -= new Vector3(speed, 0, 0)* Time.deltaTime;

        if (transform.position.x <= endX) 
            transform.position = new Vector2(startX, startPos.y + Random.Range(-amplitude, amplitude));
    }
}
