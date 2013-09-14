//--- OBJECT WRITE BEGIN ---
new GuiControl(ThemeGui) {
   profile = "GuiDefaultProfile";
   horizSizing = "right";
   vertSizing = "bottom";
   position = "0 0";
   extent = "640 480";
   minExtent = "8 2";
   visible = "1";
   helpTag = "0";

   new GuiWindowCtrl() {
      profile = "TBM_WindowProfile";
      horizSizing = "center";
      vertSizing = "center";
      position = "79 37";
      extent = "432 435";
      minExtent = "8 2";
      visible = "1";
      helpTag = "0";
      text = "Chat Theme Menu";
      maxLength = "255";
      resizeWidth = "1";
      resizeHeight = "1";
      canMove = "1";
      canClose = "1";
      canMinimize = "0";
      canMaximize = "0";
      minSize = "50 50";
      closeCommand = "Canvas.popdialog(ThemeGui);";

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "11 30";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Guests:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiPopUpMenuCtrl(themeGuests) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "60 30";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "211 30";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Mods:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiPopUpMenuCtrl(themeMods) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "261 30";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "11 60";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Admins:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiPopUpMenuCtrl(themeAdmins) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "60 60";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "211 60";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Supers:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiPopUpMenuCtrl(themeSupers) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "261 60";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "11 90";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Custom Names:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiScrollCtrl() {
         profile = "TBM_ScrollProfile";
         horizSizing = "width";
         vertSizing = "height";
         position = "11 110";
         extent = "410 120";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         willFirstRespond = "1";
         hScrollBar = "alwaysOff";
         vScrollBar = "alwaysOn";
         constantThumbHeight = "0";
         childMargin = "0 0";

         new GuiTextListCtrl(themeNameList) {
            profile = "GuiTextListProfile";
            horizSizing = "right";
            vertSizing = "bottom";
            position = "2 -1631";
            extent = "358 2672";
            minExtent = "8 2";
            visible = "1";
            helpTag = "0";
            enumerate = "0";
            altCommand = "editThemeName();";
            resizeCell = "1";
            columns = "0 160";
            fitParentWidth = "1";
            clipColumnText = "0";
         };
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "11 240";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Themes:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiScrollCtrl() {
         profile = "TBM_ScrollProfile";
         horizSizing = "width";
         vertSizing = "height";
         position = "11 260";
         extent = "410 120";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         willFirstRespond = "1";
         hScrollBar = "alwaysOff";
         vScrollBar = "alwaysOn";
         constantThumbHeight = "0";
         childMargin = "0 0";

         new GuiTextListCtrl(themeList) {
            profile = "GuiTextListProfile";
            horizSizing = "right";
            vertSizing = "bottom";
            position = "2 -1631";
            extent = "358 2672";
            minExtent = "8 2";
            visible = "1";
            helpTag = "0";
            enumerate = "0";
            altCommand = "editThemeList();";
            resizeCell = "1";
            columns = "0 160";
            fitParentWidth = "1";
            clipColumnText = "0";
         };
      };
   };
};
//--- OBJECT WRITE END ---

new GuiControl(ThemeEditGui) {
   profile = "GuiDefaultProfile";
   horizSizing = "right";
   vertSizing = "bottom";
   position = "0 0";
   extent = "640 480";
   minExtent = "8 2";
   visible = "1";
   helpTag = "0";

   new GuiWindowCtrl() {
      profile = "TBM_WindowProfile";
      horizSizing = "center";
      vertSizing = "center";
      position = "79 37";
      extent = "432 100";
      minExtent = "8 2";
      visible = "1";
      helpTag = "0";
      text = "Edit Theme";
      maxLength = "255";
      resizeWidth = "1";
      resizeHeight = "1";
      canMove = "1";
      canClose = "1";
      canMinimize = "0";
      canMaximize = "0";
      minSize = "50 50";
      closeCommand = "Canvas.popdialog(ThemeEditGui);";

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "11 30";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Name:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiTextEditCtrl(themeName) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "60 30";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "211 30";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Formatted name:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiTextEditCtrl(themeFName) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "261 30";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };

      new GuiTextCtrl() {
         profile = "GuiTextProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "111 30";
         extent = "250 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         text = "Theme:";
         lineSpacing = "2";
         allowColorChars = "1";
         maxChars = "-1";
      };
      new GuiTextEditCtrl(themeEditCtrl) {
         profile = "GuiTextEditProfile";
         horizSizing = "width";
         vertSizing = "top";
         position = "160 30";
         extent = "140 18";
         minExtent = "8 2";
         visible = "1";
         helpTag = "0";
         maxLength = "255";
         historySize = "0";
         password = "0";
         tabComplete = "0";
         sinkAllKeyEvents = "0";
      };
      new GuiButtonCtrl() {
         profile = "TBM_ButtonProfile";
         horizSizing = "right";
         vertSizing = "bottom";
         position = "155 60";
         extent = "100 25";
         minExtent = "8 2";
         visible = "1";
         command = "doEditTheme();";
         helpTag = "0";
         groupNum = "-1";
         text = "OK";
         buttonType = "PushButton";
      };

   };
};

//$themesetting = "#sc#nm: \c2#txt";

function themeGui::onWake(%this) {
loadThemes();
}

function themeGui::onSleep(%this) {
saveThemes();
}

function loadThemes() {
%f = new FileObject();
%f.openForRead("dtb/themes.txt");
%f.readLine();
$FixFireNameColorsGuest      = %f.readLine();
$FixFireNameColorsMod        = %f.readLine();
$FixFireNameColorsAdmin      = %f.readLine();
$FixFireNameColorsSuperAdmin = %f.readLine();
%colornames[0] = "Gray";
%colornames[1] = "Pink";
%colornames[2] = "Yellow";
%colornames[3] = "White";
%colornames[4] = "Aqua";
%colornames[5] = "Green";
%colornames[6] = "Orange";
%colornames[7] = "Pale";
%colornames[8] = "Purple";
%colornames[9] = "Red";
themeGuests.clear();
themeMods.clear();
themeAdmins.clear();
themeSupers.clear();
themeGuests.setValue(%colornames[$FixFireNameColorsGuest]);
themeMods.setValue(%colornames[$FixFireNameColorsMod]);
themeAdmins.setValue(%colornames[$FixFireNameColorsAdmin]);
themeSupers.setValue(%colornames[$FixFireNameColorsSuperAdmin]);
$themeGuestsLastSelected = %colornames[$FixFireNameColorsGuest];
$themeModsLastSelected = %colornames[$FixFireModColorsMod];
$themeAdminsLastSelected = %colornames[$FixFireNameColorsAdmin];
$themeSupersLastSelected = %colornames[$FixFireModColorsSuperAdmin];
themeList.clear();
themeNameList.clear();
for(%i = 0; %i < 10; %i++) {
themeGuests.add(%colornames[%i], %i);
themeMods.add(%colornames[%i], %i);
themeAdmins.add(%colornames[%i], %i);
themeSupers.add(%colornames[%i], %i);
}
$FixFireNameThemes = 0;
%f.readLine();
while(!%f.isEOF()) {
  %l = %f.readLine();
    $FixFireNameThemeName[$FixFireNameThemes++] = getField(%l, 0);
    $FixFireNameTheme[$FixFireNameThemes] = getField(%l, 1);
    themeNameList.addRow($FixFireNameThemes, %l);
}
%f.delete();
%loc = "dtb/client/Dynamic/FixFire/themes/*";
for (%filename = findFirstFile(%loc); %filename !$= ""; %filename = findNextFile(%loc)) {
	%d = new FileObject();
	%d.openForRead(%filename);
	%name = %d.readLine();
	%d.close();
	%d.delete();
	%shortname = strreplace(%filename, "dtb/client/Dynamic/FixFire/", "");
	themeList.addRow(%c++, %name@"		"@%shortname);
	$themesettinglistnum[%c] = strreplace(strreplace(%filename, "dtb/client/Dynamic/FixFire/themes/", ""), ".ftct", "");
	if($themesettinglistnum[%c] == $Pref::FixFire::ThemeSet) %settheme = %c;
}
//for(%i = 0; %i < themeList.rowCount(); %i++)
//  if(themeList.getRowText(%i) $= $themeSetting)
//    %u = %i;
//if(%u $= "") {
//  themeList.addRow(%c++, $themeSetting);
//  %u = %c;
//}
themeList.setSelectedRow(%c);
//themeList.setSelectedRow(%u);
themeNameList.addRow($FixFireNameThemes + 1, "Add new...");
//themeList.addRow(%c++, "Add new...");
// This next part wasn't actually needed because my mod does this automatically.
// if($themeSetting $= "")
//   $themeSetting = "#sc#nm: \c2#txt";
// if($themeSettingMe $= "")
//   $themeSettingMe = "\c1*#sc#nm\c1 #txt";

// Adding some stuff to make sure that it saves properly even if you don't change the values.
themeGuests.onSelect($FixFireNameColorsGuest);
themeMods.onSelect($FixFireNameColorsMod);
themeAdmins.onSelect($FixFireNameColorsAdmin);
themeSupers.onSelect($FixFireNameColorsSuperAdmin);
}


function saveThemes() {
%f = new FileObject();
%f.openForWrite("dtb/themes.txt");
%f.writeLine("//This has been automatically generated by themeGUI.cs!  Do not manually edit this unless you know what you're doing!");
%f.writeLine($themeGuestsLastSelected);
%f.writeLine($themeModsLastSelected);
%f.writeLine($themeAdminsLastSelected);
%f.writeLine($themeSupersLastSelected);
%f.writeLine("//Custom name styles:");
for(%i = 0; %i < themeNameList.rowCount(); %i++)
  if(themeNameList.getRowText(%i) !$= "" && themeNameList.getRowText(%i) !$= "Add new...")
    %f.writeLine(themeNameList.getRowText(%i));
%f.delete();
}
function themeSupers::onSelect(%this, %id, %text) {
$themeSupersLastSelected = %id;
}
function themeAdmins::onSelect(%this, %id, %text) {
$themeAdminsLastSelected = %id;
}
function themeMods::onSelect(%this, %id, %text) {
$themeModsLastSelected = %id;
}
function themeGuests::onSelect(%this, %id, %text) {
$themeGuestsLastSelected = %id;
}
function themeList::onSelect(%this, %row, %text) {
if(%text !$= "Add new...") {
// I'm a little stumped on when this function even runs because so far I can't find any instance where it does.
// Nevermind, I figured it out. I'm taking out my theme selection code because I found somewhere better for it anyway.
//  loadThemeSet($themesettinglistnum[%row + 1]);
//  $Pref::FixFire::ThemeSet = $themesettinglistnum[%row + 1];
  saveThemes();
}
}

function editThemeName() {
%i = themeNameList.getSelectedRow();
%t = themeNameList.getRowText(%i);
canvas.pushDialog(ThemeEditGui);
for(%i = nameToID(themeName) - 1; %i <= nameToID(themeEditCtrl); %i++)
  %i.setVisible(%i <= nameToID(themeFName));
themeName.setValue(getField(%t, 0));
themeFName.setValue(getField(%t, 1));
}

function editThemeList() {
//I'm editing this part to save the selected theme rather than editing it, because it'd be quite hard to get a theme editor working like this from the way my script works. We can talk about making a theme creator/editor later.
%i = themeList.getSelectedRow();
loadThemeSet($themesettinglistnum[%i + 1]);
$Pref::FixFire::ThemeSet = $themesettinglistnum[%i + 1];
// %i = themeList.getSelectedRow();
// %t = themeList.getRowText(%i);
// canvas.pushDialog(ThemeEditGui);
// for(%i = nameToID(themeName) - 1; %i <= nameToID(themeEditCtrl); %i++)
//   %i.setVisible(%i > nameToID(themeFName));
// themeEditCtrl.setValue(%t);
}

function doEditTheme() {
if(themeName.isVisible())
  themeNameList.setRowByID(themeNameList.getSelectedID(), themeName.getValue() TAB themeFName.getValue());
else
  themeList.setRowByID(themeList.getSelectedID(), themeEditCtrl.getValue());
saveThemes();
loadThemes();
canvas.popDialog(ThemeEditGui);
}