using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rg;
    [SerializeField] private float hiz = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody>(); //hangi rigidbody onu tan�mlad�m
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg.AddForce(new Vector3(-1 * Time.deltaTime * hiz,0,0)); //time.delta yazal�m ki ay� gibi u�up gitmesin fps cart curt biliyon sen anlatm�y�m
        }
        if (Input.GetKey(KeyCode.S))
        {
            rg.AddForce(new Vector3(1 * Time.deltaTime * hiz, 0, 0)); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            rg.AddForce(new Vector3(0, 0, -1 * Time.deltaTime * hiz)); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            rg.AddForce(new Vector3(0, 0, 1 * Time.deltaTime * hiz)); 
        }
    }
}
