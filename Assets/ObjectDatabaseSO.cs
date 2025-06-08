using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ObjectDatabaseSO : ScriptableObject
{
    public List<ObjectData> objectsData;
}

[Serializable]
public class ObjectData
{
    [field: SerializeField]
    public string Name { get; private set; }
    [field: SerializeField] 
    public int ID { get; private set; }
    [field: SerializeField]

    public Vector2Int Size { get; private set; } = Vector2Int.one;
    [field: SerializeField]

    public GameObject Prefab { get; private set; }

    //Aumento
    [field: SerializeField]
    public int BaseResistance { get; private set; } = 1;

    // Aqu� puedes agregar un array o lista con stats de evoluci�n:
    // Por ejemplo, resistencia por nivel (�ndice 0 = base)
    [field: SerializeField]
    public int[] ResistancePerLevel;
}
