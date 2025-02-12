using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseSaumon : MonoBehaviour
{

    private float _vitesse;

    void Start() {
        _vitesse = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_vitesse * Time.deltaTime, 0, 0, Space.World);
        if (transform.position.x > 4f){
            Debug.Log(gameObject.name);
        }
    }



}
