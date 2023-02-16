using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBounce : MonoBehaviour
{

    Vector3 scaleSpeed = new Vector3(0.01f, 0.01f, 0.01f);
    Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3((float) 0.0002, (float) 0.0002, (float) 0.0002);
    }
}
