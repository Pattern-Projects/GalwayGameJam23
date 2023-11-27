using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobbyController : MonoBehaviour
{
    public float speed;
    public float rotation;
    private Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
    float y = transform.position.y + speed*transform.rotation.z* Time.deltaTime;
        y = Mathf.Clamp(y, -4, 4);
        transform.position = new Vector3(0, y, 0);


        
        if (Input.GetAxis ("Vertical")>0)
        {
            if (transform.rotation.z < 0.5) {
                transform.Rotate(new Vector3(0, 0, 1));
            // anim.SetBool("Move", true);
            // anim.SetBool("Idle",false);
            }
        }
        if (Input.GetAxis("Vertical")<0)
        {
            if (transform.rotation.z > -0.5) {
                transform.Rotate(new Vector3(0, 0, -1));
                // anim.SetBool("Move", true);
                // anim.SetBool("Idle",false);
            }
        }
        if (Input.GetAxis("Vertical")==0)
        {
            // anim.SetBool("Move", false);
            // anim.SetBool("Idle", true);
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
                Debug.Log("here");
                anim.SetTrigger("Dead");
    }
}
