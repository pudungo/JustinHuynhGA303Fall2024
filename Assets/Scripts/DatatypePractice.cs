using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Allows us to manipulate Unity functions

public class DatatypePractice : MonoBehaviour //Class Declaration
{
    //WHOLE NUMBERS
    public int num1; //int is 4 bytes - Stores whole numbers from -2,147,483,648 tp 2,147,483,648
    public int num2; //public or private, then datatype, then name of variable

    public long num3; //long is 8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,233,372,036,854,775,808

    public uint num4; //uint is _STILL_ 4 bytes, alllows up to ~4.29 billion (positive only)
    public ulong num5; //ulong is _STILL_ 8 bytes, allows up to ~18.4 quintillion (positive only)

    //DECIMALS
    public float num6 = 3.1415f; //float is 4 bytes - Stores decimals numbers up to 6-7 digits
    public double num7 = 3.14159265f; //double is 8 bytes - Stores decimals numbers up to 15-16 digits

    //TRUE OR FALSE
    public bool isProgrammingHard = true; //bool is 1 bit - Only stores True/False (or technically, 0/1)

    //DATA SIZES
    //1 Byte = 8 bits
    //1024 Bytes = 1 Kilobyte
    //1024 Kilobytes = 1 Megabyte
    //1024 Megabytes = 1 Gigabyte
    //1024 Gigabytes = 1 Terabyte
    //300Mbps - This is not 300 MBps - this is 300 Megabites per second
    //1 gigabit internet = download speed of 125 MegaBYTES per second

    //TEXT VARIABLES
    public char chara = 'a';
    public char blastoise = 'b';
    public char venusaur = 'c';

    public string monsters = "Pokemon are cool, but so is Undertale," +
        "so I wanted to refer to it anyway, but no this is getting long. " +
        "but I'll show that it's okay to do this by showing something else shortly";


    //THESE ARE ALSO DATATYPES?!?
    public Light theLightThatShineFromTheSky;
    public Transform theThingThatLetsUsMoveAround;


    // Start is called before the first frame update
    void Start() //Everything in a function happens line by line
    {
        Debug.Log("The starting number for num1 is: " + num1); // Debug.Log() will display on console
        num1 = num1 + 1; //simple addition!
        Debug.Log("The end number for num1 after adding 1 is: " + num1);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(chara);
    }
}
