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
        rg = gameObject.GetComponent<Rigidbody>(); //hangi rigidbody onu tanýmladým
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg.AddForce(new Vector3(-1 * Time.deltaTime * hiz,0,0)); //time.delta yazalým ki ayý gibi uçup gitmesin fps cart curt biliyon sen anlatmýyým
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
