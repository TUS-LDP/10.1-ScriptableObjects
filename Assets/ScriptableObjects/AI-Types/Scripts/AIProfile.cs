using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New-AI-Type", menuName ="AI-Type")]
public class AIProfile : ScriptableObject
{
    public float speed;
    public float angularSpeed;
    public float acceleration;
    public float stoppingDistance;
    public bool autoBraking;
}
