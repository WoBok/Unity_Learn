using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class A : MonoBehaviour
{
    public void FunA()
    {
        print("Class A FunA.");
    }
}
class B : A
{
    public void FunB()
    {
        print("Class B FunB.");
    }
}
public class Conversion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //A a = new A();
        //B b = (B)a;//InvalidCastException: Specified cast is not valid.
        //b.FunA();
        //b.FunB();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
