using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollLeft : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x - speed * Time.deltaTime;
        
        if (x <= - 20.48f) {
            x += 40.96f;
        }

        transform.position = new Vector3(x, 0, 0);



    }
}
