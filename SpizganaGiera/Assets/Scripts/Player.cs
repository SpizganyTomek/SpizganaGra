using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode key = KeyCode.K; 
    [SerializeField] private BoxCollider2D coll = null;
    [SerializeField] private SpriteRenderer sprite = null;

    
  

    void Start()
    {

        
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            coll.enabled  = false;
            sprite.color = new Vector4(1,1,1,.5f);
		}
        if (Input.GetKeyUp(key))
        {
            coll.enabled  = true;
            sprite.color = new Vector4(1,1,1,1);
		}

    }

    public void Dead(){
     Debug.Log("Zginąłem");
	}
}
