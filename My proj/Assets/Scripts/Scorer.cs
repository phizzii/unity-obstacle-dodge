using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        hits ++;
        Debug.Log("you bumped into a thing this many times: " + hits);
    }
}
