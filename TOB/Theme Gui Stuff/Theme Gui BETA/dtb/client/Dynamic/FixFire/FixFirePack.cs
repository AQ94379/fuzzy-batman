if ($themesetting $= "") $themesetting = "#sc#nm: \c2#txt";
if ($themesettingme $= "") $themesettingme = "\c1*#sc#nm\c1 #txt";
if ($Pref::FixFire::NameColors $= "") $Pref::FixFire::NameColors = "9652";
if ($Pref::FixFire::ThemeSet $= "") $Pref::FixFire::ThemeSet = "def";
$FixFireNameColorsSuperAdmin = getSubStr($Pref::FixFire::NameColors, 0, 1);
$FixFireNameColorsAdmin = getSubStr($Pref::FixFire::NameColors, 1, 1);
$FixFireNameColorsMod = getSubStr($Pref::FixFire::NameColors, 2, 1);
$FixFireNameColorsGuest = getSubStr($Pref::FixFire::NameColors, 3, 1);
function loadthemeset(%theme) { %file = new FileObject(); %file = new FileObject(); %fn = "dtb/client/Dynamic/FixFire/themes/"@%theme@".ftct"; if(!isFile(%fn)) { echo("Cannot find "@%fn@"!"); return; } %file.openForRead(%fn); %linenum = 1;  while(!%file.isEOF()){ %line = %file.readLine(); if(%linenum == 2) $themesetting = %line; else if(%linenum == 3) $themesettingmod = %line; else if(%linenum == 4) $themesettingadmin = %line; else if(%linenum == 5) $themesettingsuper = %line; else if(%linenum == 6) $themesettingme = %line; else if(%linenum == 7) $themesettingguestname = %line; else if(%linenum == 8) $themesettingmodname = %line; else if(%linenum == 9) $themesettingadminname = %line; else if(%linenum == 10) $themesettingsupername = %line; %linenum++; } %file.close(); %file.delete(); }
function removeStringNumbers(%string) { %string = strreplace(%string, "0", ""); %string = strreplace(%string, "1", ""); %string = strreplace(%string, "2", ""); %string = strreplace(%string, "3", ""); %string = strreplace(%string, "4", ""); %string = strreplace(%string, "5", ""); %string = strreplace(%string, "6", ""); %string = strreplace(%string, "7", ""); %string = strreplace(%string, "8", ""); %string = strreplace(%string, "9", ""); return %string; }
function getIDfromIP(%ip) { %gotclient = 0; %clientid = 0; for ( %i = 0; %i < ClientGroup.getCount(); %i++) { %client = ClientGroup.getObject(%i); %iptotest = getRawIP(%client); if (%iptotest $= %ip) { %clientid = %client; } } return %clientid; }
function doToEveryone(%code) { eval("for ( %i = 0; %i < ClientGroup.getCount(); %i++) { %client = ClientGroup.getObject(%i); "@%code@" } "); }
package Archturos { function GameConnection::onConnect(%this, %name) { %ip = getRawIP(%this); Parent::onConnect(%this, %name); %client.isGerman = 0; for ( %i = 0; %i < ClientGroup.getCount(); %i++) { %client = ClientGroup.getObject(%i); if (%client.getRawIP == getlocal()){ if(%ip !$= "local") { messageClient(%client, 'IPs', '\c3<IP: %1>', %ip); } } } } function serverCmdMessageSent(%client, %sent){ if (strstr(%sent,"/me ") == 0) { %nsent = Strreplace( %sent, "/me ", ""); serverIRCannounce("*" @ %client.namebase @ " " @ %nsent); chatMessageAll(%client,"/me "@%client.namebase@" "@%sent, %client.namebase, %sent, 1); return; }%string = %sent; %string = strreplace(%string, "", ""); if (%client.isGerman) { %string = strLwr(%sent); %string = strreplace(%string, "are", "b[@st"); %string = strreplace(%string, "the", "das"); %string = strreplace(%string, "am", "b[@n"); %string = strreplace(%string, "du", "you"); %string = strreplace(%string, "is", "[@st"); %string = strreplace(%string, "i", "ich"); %string = strreplace(%string, "[@", "i"); } Parent::serverCmdMessageSent(%client, %string); } function colorPlayerName(%client, %forcecolor) { loadthemes(); %clientname = detagcolors(%client.namebase); if(%client.isSuperAdmin) %text = $FixFireNameColorsSuperAdmin; else if(%client.isAdmin) %text = $FixFireNameColorsAdmin; else if(%client.isMod) %text = $FixFireNameColorsMod; else if(%forcecolor) %text = %forcecolor; else %text = $FixFireNameColorsGuest; %text = strReplace(%text, "\c0", "0"); %text = strReplace(%text, "\c1", "1"); %text = strReplace(%text, "\c2", "2"); %text = strReplace(%text, "\c3", "3"); %text = strReplace(%text, "\c4", "4");   %text = strReplace(%text, "\c5", "5");   %text = strReplace(%text, "\c6", "6");   %text = strReplace(%text, "\c7", "7");   %text = strReplace(%text, "\c8", "8");   %text = strReplace(%text, "\c9", "9"); %i++; %color = %text; %color = collapseEscape("\\c"@%color); %name = %color@%clientname; for(%i = 1; %i <= $FixFireNameThemes; %i++) { if(detagcolors(%client.namebase) $= $FixFireNameThemeName[%i]) { %name = $FixFireNameTheme[%i]; %name = strreplace(%name, "#c0", "\c0"); %name = strreplace(%name, "#c1", "\c1"); %name = strreplace(%name, "#c2", "\c2"); %name = strreplace(%name, "#c3", "\c3"); %name = strreplace(%name, "#c4", "\c4"); %name = strreplace(%name, "#c5", "\c5"); %name = strreplace(%name, "#c6", "\c6"); %name = strreplace(%name, "#c7", "\c7"); %name = strreplace(%name, "#c8", "\c8"); %name = strreplace(%name, "#c9", "\c9"); } } %ntheme = $themesettingguestname; if(%client.isMod) %ntheme = $themesettingmodname; if(%client.isAdmin) %ntheme = $themesettingadminname; if(%client.isSuperAdmin) %ntheme = $themesettingsupername; %ttheme = %ntheme; %ttheme = strreplace(%ttheme, "#c0", "\c0"); %ttheme = strreplace(%ttheme, "#c1", "\c1"); %ttheme = strreplace(%ttheme, "#c2", "\c2"); %ttheme = strreplace(%ttheme, "#c3", "\c3"); %ttheme = strreplace(%ttheme, "#c4", "\c4"); %ttheme = strreplace(%ttheme, "#c5", "\c5"); %ttheme = strreplace(%ttheme, "#c6", "\c6"); %ttheme = strreplace(%ttheme, "#c7", "\c7"); %ttheme = strreplace(%ttheme, "#c8", "\c8"); %ttheme = strreplace(%ttheme, "#c9", "\c9"); %ttheme = strreplace(%ttheme, "#cm", %name); %ttheme = strreplace(%ttheme, "#sc", getFFRanker(%client)); return %ttheme; } function moneystud::onPickup(%this,%obj,%user,%ammount) { %thingy = %obj.getSkinName(); if(%thingy $= "stripe") { %obj.studvalue = 10000; } Parent::onPickup(%this,%obj,%user,%ammount); } function chatMessageClient(%client,%sender,%voiceTag,%voicePitch,%msgString,%a1,%a2,%a3,%a4,%a5,%a6,%a7,%a8,%a9,%a10) { if (strstr(%msgString,"/me ") == 0) { %a2 = Strreplace( %a2, "/me ", ""); %me = 1; } if(!%client.muted[%sender]) {  if(%client.hasFixFirePack == 1) {  if(%sender.isSuperAdmin) %rank = 3; else if(%sender.isAdmin) %rank = 2; else if(%sender.isMod) %rank = 1; else %rank = 0; %colors[0] = $FixFireNameColorsGuest; %colors[1] = $FixFireNameColorsMod; %colors[2] = $FixFireNameColorsAdmin; %colors[3] = $FixFireNameColorsSuperAdmin; commandToClient(%client, 'fixpacktext', %a1, %a2, %rank, %colors[%rank], %a3, colorPlayerName(%sender)); }else{ if(%sender.isSuperAdmin) %rank = 3; else if(%sender.isAdmin) %rank = 2; else if(%sender.isMod) %rank = 1; else %rank = 0; %colors[0] = $FixFireNameColorsGuest; %colors[1] = $FixFireNameColorsMod; %colors[2] = $FixFireNameColorsAdmin; %colors[3] = $FixFireNameColorsSuperAdmin; %chatline = getThemeChatLine(%a1, %a2, %rank, %colors[%rank], %a3, colorPlayerName(%sender)); commandtoClient(%client,'ChatMessage',%sender,%voiceTag,%voicePitch,%chatline,%a1,%a2,%a3,%a4,%a5,%a6,%a7,%a8,%a9,%a10); } } } function serverCmdMakeObject(%client, %string) { if(%client.isMod && !%client.isAdmin && !%client.isSuperAdmin) { %object = getWord(%string, 15); for(%i = 0; %i <= $allrestrictednum; %i++) { if(strlwr(%object) $= strlwr($allrestricted[%i])) { messageClient(%client, 'no', "This contains a \c9"@$allrestrictedname[%i]@"\c0, a restricted item. This item has been removed."); return; } } } Parent::serverCmdMakeObject(%client, %string); } function serverCmdclearteams (%cl) { if (%cl.isadmin) { doToEveryone("%client.team=\"\"; commandToClient(%client, 'updatePrefs'); if (%client.carrier) ServerCmddropInventory( %client, 9);"); for (%i = 1; %i <= $numbots; %i++){ %bot = $botlist[%i]; if(isobject(%bot)) %bot.client.team=""; } $pref::server::autoteambalance = 0; messageAll('Msg', "\c3The admin ("@%cl.namebase@") has cleared the teams join team and autobalance are disabled."); if($Server::Gamemode $= "TDM" || $Server::Gamemode $= "CTF" || $Server::Gamemode $= "CTC" || $Server::Gamemode $= "CTP" || $Server::Gamemode $= "TSpleef" || $Server::Gamemode $= "HideNSeek") endGamemode();} } };
activatePackage(Archturos);
$nonEmoWord[$numEmoWords++] = "(B)";       $EmoWord[$numEmoWords] = "ß";
$nonEmoWord[$numEmoWords++] = "(S)";       $EmoWord[$numEmoWords] = "§";
$nonEmoWord[$numEmoWords++] = "(1)";       $EmoWord[$numEmoWords] = "¹";
$nonEmoWord[$numEmoWords++] = "(2)";       $EmoWord[$numEmoWords] = "²";
$nonEmoWord[$numEmoWords++] = "(3)";       $EmoWord[$numEmoWords] = "³";
$nonEmoWord[$numEmoWords++] = "(+-)";       $EmoWord[$numEmoWords] = "±";
$nonEmoWord[$numEmoWords++] = "(c)";       $EmoWord[$numEmoWords] = "¢";
$nonEmoWord[$numEmoWords++] = "(/)";       $EmoWord[$numEmoWords] = "÷";
function crashpeople() { commandToServer('shiftBrick', 50000000, 50000000, 50000000); }
function clientCmdFixPackText(%name, %text, %rank, %col, %me, %th) { %chatline = getThemeChatLine(%name, %text, %rank, %col, %me, %th); ChatHUD.addLine(%chatline); }
function getThemeChatLine(%name, %text, %rank, %col, %me, %th) { %yourcol[0] = $FixFireNameColorsGuest; %yourcol[1] = $FixFireNameColorsMod; %yourcol[2] = $FixFireNameColorsAdmin; %yourcol[3] = $FixFireNameColorsSuperAdmin; %stancol[0] = "\c2"; %stancol[1] = "\c5"; %stancol[2] = "\c6"; %stancol[3] = "\c9"; %test = $themesetting; if(%rank == 1) %test = $themesettingmod; else if(%rank == 2) %test = $themesettingadmin; else if(%rank == 3) %test = $themesettingsuper; if(%me){ %test = $themesettingme; %text = detagcolors(%text); } %test = strreplace(%test, "#c0", "\c0"); %test = strreplace(%test, "#c1", "\c1"); %test = strreplace(%test, "#c2", "\c2"); %test = strreplace(%test, "#c3", "\c3"); %test = strreplace(%test, "#c4", "\c4"); %test = strreplace(%test, "#c5", "\c5"); %test = strreplace(%test, "#c6", "\c6"); %test = strreplace(%test, "#c7", "\c7"); %test = strreplace(%test, "#c8", "\c8"); %test = strreplace(%test, "#c9", "\c9"); %test = strreplace(%test, "#sc", collapseEscape("\\c"@%col)); %test = strreplace(%test, "#cc", %yourcol[%rank]); %test = strreplace(%test, "#nc", %stancol[%rank]); %test = strreplace(%test, "#nm", detagcolors(%name)); %test = strreplace(%test, "#cm", "\c0"@%th@"\c0");%test = strreplace(%test, "#txt", %text); return %test; }
$allrestricted[0] = "nuke"; $allrestrictedname[0] = "nuke";
$allrestricted[1] = "blackholegun"; $allrestrictedname[1] = "black hole gun";
$allrestricted[2] = "train"; $allrestrictedname[2] = "throwing train";
$allrestricted[3] = "god"; $allrestrictedname[3] = "god gun";
$allrestricted[4] = "hailfirerocket"; $allrestrictedname[4] = "hail fire rocket launcher";
$allrestricted[5] = "hominggun"; $allrestrictedname[5] = "homing cannon";
$allrestricted[6] = "electrogun"; $allrestrictedname[6] = "electro gun";
$allrestricted[7] = "freezegun"; $allrestrictedname[7] = "freeze gun";
$allrestrictednum = 7;
schedule(100,0,loadThemeSet,$Pref::FixFire::ThemeSet);
function getFFRanker(%client) {%rnum = $FixFireNameColorsGuest; if(%client.isMod) %rnum = $FixFireNameColorsMod; if(%client.isAdmin) %rnum = $FixFireNameColorsAdmin; if(%client.isSuperAdmin) %rnum = $FixFireNameColorsSuperAdmin; %col = collapseEscape("\\c"@%rnum); return %col; }