using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public float scale = 4f;

    private Transform t;

    //Runs before start method
    void Awake() {
        var cam = GetComponent<Camera>();
        cam.orthographicSize = (Screen.height / 2f) / scale;
    }

    // Start is called before the first frame update
    void Start(){

        t = target.transform;
        
    }

    // Update is called once per frame
    void Update() {
        if(target != null) {
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
        }
    }
}
