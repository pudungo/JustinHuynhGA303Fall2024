using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public ComponentFun ourOtherScript;
    public Light coolLightObject;
    public Light referenceLight;

    public Color lightColor;

    // Start is called before the first frame update
    void Start()
    {
        ourOtherScript.counter++; //This is the same as ourOtherScript.counter = ourOtherscript.counter + 1;

        coolLightObject.intensity = 2f;
        coolLightObject.range = 25f;
        coolLightObject.color = Color.blue;
        //coolLightObject.color = Color.blue;

        coolLightObject.color = referenceLight.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        
    }

}
