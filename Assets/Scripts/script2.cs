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

    public long startlong;

    public long additionTotallong;
    public long subtractionTotallong;
    public long multiplicationTotallong;
    public long divisionTotallong;

    public float startfloat;

    public float additionTotalfloat;
    public float subtractionTotalfloat;
    public float multiplicationTotalfloat;
    public float divisionTotalfloat;

    public double startdouble;

    public double additionTotaldouble;
    public double subtractionTotaldouble;
    public double multiplicationTotaldouble;
    public double divisionTotaldouble;
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


        //LONG

        startlong = 628934526;
        additionTotallong = 600912596;
        subtractionTotallong = 109223459;
        multiplicationTotallong = 400;
        divisionTotallong = 2;

        //addition
        Debug.Log("The starting number for startlong is: " + startlong);
        additionTotallong = additionTotallong + startlong;
        Debug.Log("The additionTotallong variable after adding " + startlong + " is " + additionTotallong);

        //subtraction
        Debug.Log("The starting number for startlong is: " + additionTotallong);
        subtractionTotallong = additionTotallong - subtractionTotallong;
        Debug.Log("The subtractionTotallong variable after subtracting " + additionTotallong + " is " + subtractionTotallong);

        //multiplication
        Debug.Log("The starting number for startlong is: " + subtractionTotallong);
        multiplicationTotallong = multiplicationTotallong * subtractionTotallong;
        Debug.Log("The multiplicationTotallong variable after multiplying " + subtractionTotallong + " is " + multiplicationTotallong);

        //division
        Debug.Log("The starting number for startlong is: " + multiplicationTotallong);
        divisionTotallong = subtractionTotallong / divisionTotallong;
        Debug.Log("The divisionTotallong variable after dividing " + multiplicationTotallong + " is " + divisionTotallong);






        //FLOAT

        startfloat = 1.462f;
        additionTotalfloat = 5.12f;
        subtractionTotalfloat = 1.09f;
        multiplicationTotalfloat = 16.63f;
        divisionTotalfloat = 5.5f;

        //addition
        Debug.Log("The starting number for startfloat is: " + startfloat);
        additionTotalfloat = additionTotalfloat + startfloat;
        Debug.Log("The additionTotalfloat variable after adding " + startfloat + " is " + additionTotalfloat);

        //subtraction
        Debug.Log("The starting number for startfloat is: " + additionTotalfloat);
        subtractionTotalfloat = additionTotalfloat - subtractionTotalfloat;
        Debug.Log("The subtractionTotalfloat variable after subtracting " + additionTotalfloat + " is " + subtractionTotalfloat);

        //multiplication
        Debug.Log("The starting number for startfloat is: " + subtractionTotalfloat);
        multiplicationTotalfloat = multiplicationTotalfloat * subtractionTotalfloat;
        Debug.Log("The multiplicationTotalfloat variable after multiplying " + subtractionTotalfloat + " is " + multiplicationTotalfloat);

        //division
        Debug.Log("The starting number for startfloat is: " + multiplicationTotalfloat);
        divisionTotalfloat = subtractionTotalfloat / divisionTotalfloat;
        Debug.Log("The divisionTotalfloat variable after dividing " + multiplicationTotalfloat + " is " + divisionTotalfloat);







        //DOUBLE

        startdouble = 9.58192855;
        additionTotaldouble = 961.1266172;
        subtractionTotaldouble = 6.668183936;
        multiplicationTotaldouble = 16.61629722;
        divisionTotaldouble = 2.5874719751257;

        //addition
        Debug.Log("The starting number for startdouble is: " + startdouble);
        additionTotaldouble = additionTotaldouble + startdouble;
        Debug.Log("The additionTotaldouble variable after adding " + startdouble + " is " + additionTotaldouble);

        //subtraction
        Debug.Log("The starting number for startdouble is: " + additionTotaldouble);
        subtractionTotaldouble = additionTotaldouble - subtractionTotaldouble;
        Debug.Log("The subtractionTotaldouble variable after subtracting " + additionTotaldouble + " is " + subtractionTotaldouble);

        //multiplication
        Debug.Log("The starting number for startdouble is: " + subtractionTotaldouble);
        multiplicationTotaldouble = multiplicationTotaldouble * subtractionTotaldouble;
        Debug.Log("The multiplicationTotaldouble variable after multiplying " + subtractionTotaldouble + " is " + multiplicationTotaldouble);

        //division
        Debug.Log("The starting number for startdouble is: " + multiplicationTotaldouble);
        divisionTotaldouble = subtractionTotaldouble / divisionTotaldouble;
        Debug.Log("The divisionTotaldouble variable after dividing " + multiplicationTotaldouble + " is " + divisionTotaldouble);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
