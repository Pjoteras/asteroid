using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //wsp�rz�dne gracza
    Transform player;
    public float cameraHeight = 10.0f;
    //pr�dko�� kamery
    
    // Start is called before the first frame update
    void Start()
    {
        //pod��cz pozycje gracza do lokalnej zmiennej korzystaj�c z jego taga
        //player zawsz� bedzie zawiera� aktualn� pozycje gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //oblicz docelow� pozycj� kamery
        Vector3 targetPosition = player.position + Vector3.up * 10;
        //p�ynnie przesu� kamer� w kierunku gracza
        //funckja Vector3.Lerp
        //p�ynnie przechodzi z pozycji pierwszego argumentu do drugiego w czasie trzeciego
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
