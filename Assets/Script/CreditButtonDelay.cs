using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditButtonDelay : MonoBehaviour
{
    [SerializeField] GameObject delayButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayButton()
    {
        yield return new WaitForSeconds(16);
        delayButton.SetActive(true);
    }

    private void OnEnable()
    {
        StartCoroutine(DelayButton());
        delayButton.SetActive(false);
    }

}
