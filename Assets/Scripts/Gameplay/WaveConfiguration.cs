using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Paty/WaveConfig" , fileName = "WaveConfiguration", order =0)]
    public class WaveConfiguration : ScriptableObject
{
    //un ScriptableObject almacena informaci�n
    public List<Wave> _waves;

}
