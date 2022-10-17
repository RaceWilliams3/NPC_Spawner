using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    public GameObject beggar;
    public GameObject farmer;
    public GameObject shopowner;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;


    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Beggar.Speak();
        m_Beggar.CreateModel(beggar);

        m_Farmer.Speak();
        m_Farmer.CreateModel(farmer);

        m_Shopowner.Speak();
        m_Shopowner.CreateModel(shopowner);
    }
}
