using UnityEngine;
using UnityEngine.Playables;
 
public class GenericTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject myObject;
 
    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
 
 
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            myObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
 
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
}
