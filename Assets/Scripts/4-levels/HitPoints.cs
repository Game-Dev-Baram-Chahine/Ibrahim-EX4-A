using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    [SerializeField]
    public int hitPoints;

    // Start is called before the first frame update
    void Start()
    {
        hitPoints = 3;
    }

    public void setHitPoints(int hp)
    {
        hitPoints = hp;
    }

    public int getHitPoints()
    {
        return hitPoints;
    }
}
