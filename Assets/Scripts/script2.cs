using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int startint;
  
    public int additionTotal;
    public int subtractionTotal;
    public int multiplicationTotal;
    public int divisionTotal;
    void Start()
    {
        //INT

        startint = 126235;
        additionTotal = 6009096;
        subtractionTotal = 109;
        multiplicationTotal = 16;
        divisionTotal = 256;

        //addition
        Debug.Log("The starting number for startint is: " + startint);
        additionTotal = additionTotal + startint;
        Debug.Log("The additionTotal variable after adding " + startint + " is " + additionTotal);

        //subtraction
        Debug.Log("The starting number for startint is: " + additionTotal);
        subtractionTotal = additionTotal - subtractionTotal;
        Debug.Log("The subtractionTotal variable after subtracting " + additionTotal + " is " + subtractionTotal);

        //multiplication
        Debug.Log("The starting number for startint is: " + subtractionTotal);
        multiplicationTotal = multiplicationTotal * subtractionTotal;
        Debug.Log("The multiplicationTotal variable after multiplying " + subtractionTotal + " is " + multiplicationTotal);

        //division
        Debug.Log("The starting number for startint is: " + multiplicationTotal);
        divisionTotal = subtractionTotal / divisionTotal;
        Debug.Log("The divisionTotal variable after dividing " + multiplicationTotal + " is " + divisionTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
