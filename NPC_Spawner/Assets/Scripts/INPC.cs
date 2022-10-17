using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INPC
{
    void Speak();
    void CreateModel(GameObject mdl);
}

public class Beggar : MonoBehaviour, INPC 
{
    public void Speak()
    {
        Debug.Log("DO you have some change to spare?");
    }

    public void CreateModel(GameObject mdl)
    {
        Instantiate(mdl, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
    }
}

public class Shopowner : MonoBehaviour, INPC
{
    public void Speak()
    {
        Debug.Log("Do you wish to purchase something?");
    }

    public void CreateModel(GameObject mdl)
    {
        Instantiate(mdl, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.Euler(new Vector3(0,Random.Range(0,360),0)));
    }
}

public class Farmer : MonoBehaviour, INPC
{
    public void Speak()
    {
        Debug.Log("You reap what you sow!");
    }

    public void CreateModel(GameObject mdl)
    {
        Instantiate(mdl, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
    }
}

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}