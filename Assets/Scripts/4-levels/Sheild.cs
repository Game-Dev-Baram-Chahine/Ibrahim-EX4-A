using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : MonoBehaviour
{
    private Renderer renderer;

    [SerializeField]
    private float fadeSpeed;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.enabled = ShieldThePlayer.isShieldActive;
        if (renderer.enabled)
        {
            Color color = renderer.material.color;
            color.a -= Time.deltaTime * fadeSpeed;
            renderer.material.color = color;
        }
        else
        {
            if (ColorUtility.TryParseHtmlString("#1BFF00", out color))
            {
                renderer.material.color = color;
            }
        }
    }
}
