using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtils : MonoBehaviour
{

    public static Vector2 CalcualteDirection(Vector2 initialVector, Vector2 currentVector) {
        Vector2 knob = initialVector + Vector2.ClampMagnitude(currentVector - initialVector, initialVector.x);
        Vector2 outsideBoundsVector = currentVector - knob;
        initialVector += outsideBoundsVector;
        return (knob - initialVector).normalized;
    }
    public static double KGgenerator(double valorInicial, double seed)
    {
        double m1 = (double)valorInicial * seed;
        return (double)Mathf.Log((float)(m1 / valorInicial));
    }

    public static int ExponentialGrow(double valorInicial, double k, int rondaActual)
    {
        double valorActual = valorInicial * (Mathf.Exp((float)(k * rondaActual)));
        return (int)(valorActual);
    }

}
