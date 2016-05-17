@script ExecuteInEditMode() 

var fieldOfView : int = 80;

	
function OnGUI () {
var qualities = QualitySettings.names;
		
		GUILayout.BeginVertical ();
		
		for (var i = 0; i < qualities.Length; i++){

		
			if (GUI.Button(Rect(Screen.width/2 - 50,  160 + i * 25, 100, 25), qualities[i])){

			
				QualitySettings.SetQualityLevel (i, true);
			}
		}
		
		GUILayout.EndVertical ();

			
		fieldOfView = GUI.HorizontalSlider (Rect (Screen.width/2 - 50,Screen.height - 160,100,20), fieldOfView, 30, 120);
		GUI.Label(Rect(Screen.width/2 - 50 + 110, Screen.height - 160, 100, 30), "FOV: " + fieldOfView);
}