using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode key = KeyCode.K;
    [SerializeField] private BoxCollider2D coll = null;
    [SerializeField] private SpriteRenderer sprite = null;
    public float Duration = 2.5f; //czas trwania pierwszej niewidzialności
    public float start = 1f; // czas do pierwszego użycia niewidzialności
    public float startRecharge = 5.5f; // czas pomiędzy używaniem umiejętności
    public float durationRecharge = 2.5f; //czas trwania kolejnych niewidzialności 

    bool wait = false;

    void Start()
    {
        GameObject Timer = GameObject.Find("Timer");
        Countdown countdown = Timer.GetComponent<Countdown>();
    }


    void Update()
    {
        if (start > 0)
        {
            start -= Time.deltaTime;
        } else if (Input.GetKey(key) || wait)
        {
            wait = true;
            if (Duration > 0)
            {
            coll.enabled = false;
            sprite.color = new Vector4(1, 1, 1, .5f);
                Duration -= Time.deltaTime;
            } else
            {
            Duration = durationRecharge;
            start = startRecharge;
            coll.enabled = true;
            sprite.color = new Vector4(1, 1, 1, 1);
                wait = false;
            }


        }

    }
    public void Dead()
    {
        Debug.Log("zginąłem");
    }
}