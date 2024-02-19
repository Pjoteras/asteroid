using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //wspó³rzêdne gracza
    Transform player;
    public float cameraHeight = 10.0f;
    //prêdkoœæ kamery
    
    // Start is called before the first frame update
    void Start()
    {
        //pod³¹cz pozycje gracza do lokalnej zmiennej korzystaj¹c z jego taga
        //player zawszê bedzie zawiera³ aktualn¹ pozycje gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //oblicz docelow¹ pozycjê kamery
        Vector3 targetPosition = player.position + Vector3.up * 10;
        //p³ynnie przesuñ kamerê w kierunku gracza
        //funckja Vector3.Lerp
        //p³ynnie przechodzi z pozycji pierwszego argumentu do drugiego w czasie trzeciego
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
