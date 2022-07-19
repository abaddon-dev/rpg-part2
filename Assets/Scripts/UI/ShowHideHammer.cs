using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryExample.UI
{
    public class ShowHideHammer : MonoBehaviour
    {
        [SerializeField] KeyCode toggleKey = KeyCode.W;
        [SerializeField] GameObject uiContainer = null;

        // Start is called before the first frame update
        void Start()
        {
            uiContainer.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(toggleKey))
            {
                uiContainer.SetActive(!uiContainer.activeSelf);
            }
        }
    }   
}
