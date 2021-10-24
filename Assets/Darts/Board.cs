using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Board : InteractionBehaviour
{
    Material DefaultMaterial;
    Renderer mRenderer;
    Color DefaultColor;
    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponentsInChildren<Renderer>(true)[0];
        if(mRenderer != null)
        {
            Debug.Log("Default Mat is not null!!");
            DefaultMaterial = mRenderer.materials[0];
            DefaultColor = DefaultMaterial.color;
        }
        Debug.Log(DefaultMaterial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColor(Color color){
        Debug.Log("Color Change supposed to happen");
        Material mat = DefaultMaterial;
        mat.color = color;
        mRenderer.materials[0] = mat;
    }
    public void ResetColor(){
        
        mRenderer.materials[0].color =DefaultColor;
    }
}
