# NetworkConnectionCheck_Unity

 Do not use Application.internetReachability
 
 https://docs.unity3d.com/ScriptReference/Application-internetReachability.html
 
 Note: Do not use this property to determine the actual connectivity.


how to use?

if(true == ConnectionCheck.IsConnected())

{

   YourConnectedEvent(); // ex) "The data was read normally."
   
}

else

{

   YourDisconnectedEvent(); // ex) "Please check your internet connection."
   
}


default timeout = 3s

