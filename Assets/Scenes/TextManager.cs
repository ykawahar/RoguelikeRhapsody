using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{

    public Queue<string> messageQueue;
    // Start is called before the first frame update
    void Start()
    {
        messageQueue = new Queue<string>();

        messageQueue.Enqueue("This is the start of this hero's journey.");
    }

    // Update is called once per frame
    void Update()
    {
        CheckNewMessages();
    }

    void CheckNewMessages(){
        
        if (messageQueue.Count > 0) {
            foreach (string line in messageQueue)
            {
                TextLogController.Instance.AddTextLog(line);
            }
            messageQueue.Dequeue();
        }
    }


}
