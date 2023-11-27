using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public int speed;
    public float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x - speed * Time.deltaTime;

        if (x <= - 20.48f) {
            x += 40.96f + Random.Range(0.0f, 2.0f);
            y = Random.Range(-4.0f, 4.0f);
        }

        transform.position = new Vector3(x, y, 0);



    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
