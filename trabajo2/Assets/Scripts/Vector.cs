using System;
using UnityEngine;

[Serializable]
public struct Vector
{
    public float x;
    public  float y;



    public Vector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector Sum(Vector vector)
    {
        return new Vector(
            x + vector.x, 
            y + vector.y);
    }
     public Vector Sub(Vector vector)
     {
        return new Vector(
            x - vector.x, 
            y - vector.y);
     }
    public Vector Mul(float vector)
    {
        return new Vector(
            x * vector,
            y * vector);
    }
    public static Vector operator+(Vector vector, Vector vector2)
    {
        return vector.Sum(vector2);
    }
    public static Vector operator-(Vector vector, Vector vector2)
    {
        return vector.Sub(vector2);
    }
    public static Vector operator*(Vector vector, float numero)
    {
        return vector.Mul(numero);
    } public static Vector operator/( Vector vector,float numero  )
    {
        return vector.Mul(numero);
    }
    public void Draw(Color color)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(x, y, 0), color);
    }

    public void Draw(Vector vector, Color color)
    {
        Debug.DrawLine(new Vector3(vector.x, vector.y), new Vector3(vector.x + x, vector.y + y), color);
    }
   

    public override string ToString()
    {
        return $"[{x},{y}]";
    }

}
