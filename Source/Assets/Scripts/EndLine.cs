﻿using UnityEngine;
using System.Collections;

public class EndLine : MonoBehaviour {

void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject hitObj = collider.gameObject;
    if (hitObj.tag =="Player")
        {
            transform.parent.gameObject.AddComponent<GameOverScript>();
        }
    }
}
