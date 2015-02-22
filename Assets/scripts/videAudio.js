

 var url = "";
 var www;
 var movieTexture;
 
 function Start ()
 {
     www = new WWW(url);
 
     Debug.Log("Movie Loading..." + url);
 
     movieTexture = www.movie;
     while (!movieTexture.isReadyToPlay)
          yield;
 
     Debug.Log("Movie Loaded");
 }
 
 function OnMouseDown()
 {
     guiTexture.texture = movieTexture;
 
     transform.localScale = Vector3 (0,0,0);
     transform.position = Vector3 (0.5,0.5,0);
     guiTexture.pixelInset.xMin = -movieTexture.width / 2;
     guiTexture.pixelInset.xMax = movieTexture.width / 2;
     guiTexture.pixelInset.yMin = -movieTexture.height / 2;
     guiTexture.pixelInset.yMax = movieTexture.height / 2;
 
     audio.clip = movieTexture.audioClip;
 
     movieTexture.Play();
     audio.Play();
 }
 @script RequireComponent(GUITexture)
 @script RequireComponent(AudioSource)