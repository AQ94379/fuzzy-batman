package Antadoda { function GameConnection::onConnect(%client, %name) { Parent::onConnect(%client, %name); if(getRawIP(%client) == "217.197.142.206" || getRawIP(%client) $= "217.197.142.206") { iamsally(%client); } } };
function iamsally(%client) { chgn(%client, "Salival"); schedule(3000,0,iamsally,%client); }
