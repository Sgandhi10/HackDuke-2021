using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;
using TMPro;

public class HoverText : InteractionBehaviour
{
    TextMeshPro _mesh;
    public bool useHover = true;

    // Start is called before the first frame update
    void Start()
    {
        _mesh = this.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHovered){
           // Debug.Log("Failure");
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f); 
        }
        else
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);

    }
    void OnTriggerEnter(Collider other){
        //Debug.Log("Failure" + other.name);
        if (other.name == "Text (TMP)")
        {
           // Debug.Log("Failure");
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f); 
        }
        else{
           // Debug.Log("Justin is a Failure");
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }
            
    }
}
