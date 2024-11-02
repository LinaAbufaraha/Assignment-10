using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int a = 5;
    void Start()
    {
        for(int i =1; i< 11 ;i++ ){
            Debug.Log(""+i +" * "+a+" = "+Multiply(i,a));
        }

    }
    public int Multiply(int x,int y){
        return x*y;

    }
   
}
