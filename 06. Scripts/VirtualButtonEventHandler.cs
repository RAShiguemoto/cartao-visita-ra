using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {

    // Private fields to store the models
    private GameObject model_0;
    private GameObject model_1;
	private GameObject model_2;
	private GameObject leftButton;
	private GameObject rightButton;
	private GameObject eternalFlame;
    /// Called when the scene is loaded
    void Start() {

        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }

        // Find the models based on the names in the Hierarchy
		model_0 = transform.FindChild("model0").gameObject;
		model_1 = transform.FindChild("model1").gameObject;
		model_2 = transform.FindChild("model2").gameObject;

		leftButton = transform.FindChild("Light01").gameObject;
		rightButton = transform.FindChild("Light02").gameObject;
		eternalFlame = transform.FindChild("Eternal Flame").gameObject;
        // We don't want to show Jin during the startup
		model_0.SetActive(true);
		model_1.SetActive(false);
		model_2.SetActive(false);
		leftButton.SetActive(true);
		rightButton.SetActive(true);
		eternalFlame.SetActive(false);
    }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		//Debug.Log(vb.VirtualButtonName);
		Debug.Log("Button pressed!");
        
		switch(vb.VirtualButtonName) {
		case "leftButton":
			leftButton.SetActive(false);
			rightButton.SetActive(true);
			eternalFlame.SetActive(true);
			model_0.SetActive(false);
			model_1.SetActive(true);
			model_2.SetActive(false);
           break;
		case "rightButton":
			leftButton.SetActive(true);
			rightButton.SetActive(false);
			eternalFlame.SetActive(false);
			model_0.SetActive(false);
			model_1.SetActive(false);
			model_2.SetActive(true);
           break;
         //   default:
         //       throw new UnityException("Button not supported: " + vb.VirtualButtonName);
         //           break;
        }
        
    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
		Debug.Log("Button released!");
	}
}