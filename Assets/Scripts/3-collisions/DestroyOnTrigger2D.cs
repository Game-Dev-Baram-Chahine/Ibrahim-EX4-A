using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField]
    string triggeringTag;
    private HitPoints hitPointsComponent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (enabled)
        {
            if (other.tag == triggeringTag && triggeringTag != "Enemy")
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
            else if (other.tag == triggeringTag && triggeringTag == "Enemy")
            {
                var hitPointsComponent = GetComponent<HitPoints>();
                int hitPoints = hitPointsComponent.getHitPoints();
                if (hitPoints < 1)
                {
                    Destroy(this.gameObject);
                    Destroy(other.gameObject);
                }
                else
                {
                    int currentHitPoints = hitPoints - 1;
                    hitPointsComponent.setHitPoints(currentHitPoints);
                    Debug.Log("HitPoints: " + currentHitPoints);
                }
            }
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
