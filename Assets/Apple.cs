using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    void Update()
{
    if (transform.position.y < bottomY)
    {
        // If it's a bad apple, just destroy it
        if (CompareTag("BadApple"))
        {
            Destroy(this.gameObject);
            return;
        }

        // Normal apple: destroy + count as missed
        Destroy(this.gameObject);
        ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        apScript.AppleMissed();
    }
}

}
