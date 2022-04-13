using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vadsomhelst : MonoBehaviour
{
    public void Died()
    {
        ScoreText.instance.AddPoints();
    }
}
