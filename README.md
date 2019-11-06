# NetworkConnectionCheck_Unity

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

