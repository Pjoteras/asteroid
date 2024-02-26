using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    
    GameObject model;
    //losowanie rotacji/s
    Vector3 rotation = Vector3.one;
    void Start()
    {
        //przypisuje do zmiennej model zawieraj¹cy kostki
        model = transform.Find("Model").gameObject;


        foreach (Transform cube in model.transform) {

            //losowanie obrotu koœci w zakresie <0;90)
            cube.rotation = Random.rotation;

            //generowanie losowej wielkoœci
            float scale = Random.Range(0.9f, 1.1f);

            cube.localScale = new Vector3 (scale, scale, scale);
        }
        rotation.x = Random.value;
        rotation.y = Random.value;
        rotation.z = Random.value;
        rotation *= Random.RandomRange(10, 20);
    }

    
    void Update()
    {
        //obrócenie asteroidy
        model.transform.Rotate(rotation * Time.deltaTime);
    }
}
