﻿using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Mahou
{
    class Configs
    {
        //Path where Mahou is now + Mahou.ini
        private string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Mahou.ini");
        public Configs()//Initializes settings, if some of elements or settinhs file, not exists it creates them with default value
        {
            if (!File.Exists(filePath)) //Create an UTF-16 configuration file
            {
                File.WriteAllText(filePath, "!Unicode(✔), Mahou settings file", Encoding.Unicode);
            }
            int it = 0;      //int temp
            uint uit = 0;    //uint temp
            bool bt = false; //bool temp
            //Hotkeys section
            if (!Int32.TryParse(this.Read("Hotkeys", "HKCLKey"), out it))
                this.Write("Hotkeys", "HKCLKey", "19"); //Hotkey convert last word

            if (String.IsNullOrEmpty(this.Read("Hotkeys", "HKCLMods")))
                this.Write("Hotkeys", "HKCLMods", "None"); //Hotkey convert last word modifiers

            if (!Int32.TryParse(this.Read("Hotkeys", "HKCSKey"), out it))
                this.Write("Hotkeys", "HKCSKey", "145"); //Hotkey convert selection

            if (String.IsNullOrEmpty(this.Read("Hotkeys", "HKCSMods")))
                this.Write("Hotkeys", "HKCSMods", "None"); //Hotkey convert selection modifiers

            if (!Int32.TryParse(this.Read("Hotkeys", "HKCLineKey"), out it))
                this.Write("Hotkeys", "HKCLineKey", "19"); //Hotkey convert line

            if (String.IsNullOrEmpty(this.Read("Hotkeys", "HKCLineMods"))) //Hotkey convert line modifiers
                this.Write("Hotkeys", "HKCLineMods", "Shift");

            if (String.IsNullOrEmpty(this.Read("Hotkeys", "OnlyKeyLayoutSwicth")))
                this.Write("Hotkeys", "OnlyKeyLayoutSwicth", "CapsLock"); //One key to switch layout

            if (!Int32.TryParse(this.Read("Hotkeys", "HKSymIgnKey"), out it))
                this.Write("Hotkeys", "HKSymIgnKey", "122"); //Hotkey Symbol ignore mode

            if (String.IsNullOrEmpty(this.Read("Hotkeys", "HKSymIgnMods"))) //Hotkey Symbol ignore mode modifiers
                this.Write("Hotkeys", "HKSymIgnMods", "Shift + Control + Alt");

            //Locales section
            if (!UInt32.TryParse(this.Read("Locales", "locale1uId"), out uit))
                this.Write("Locales", "locale1uId", ""); //Locale 1 id

            if (String.IsNullOrEmpty(this.Read("Locales", "locale1Lang")))
                this.Write("Locales", "locale1Lang", ""); //Locale 1 name

            if (!UInt32.TryParse(this.Read("Locales", "locale2uId"), out uit))
                this.Write("Locales", "locale2uId", ""); //Locale 2 id

            if (String.IsNullOrEmpty(this.Read("Locales", "locale2Lang")))
                this.Write("Locales", "locale2Lang", ""); //Locale 2 name

            if (String.IsNullOrEmpty(this.Read("Locales", "LANGUAGE")))
                this.Write("Locales", "LANGUAGE", "EN"); //Language of user interface, messages etc.

            //Functions section
            if (!Boolean.TryParse(this.Read("Functions", "IconVisibility"), out bt))
                this.Write("Functions", "IconVisibility", "true"); //Tray icon visibility

            if (!Boolean.TryParse(this.Read("Functions", "CycleMode"), out bt))
                this.Write("Functions", "CycleMode", "false");

            if (!Boolean.TryParse(this.Read("Functions", "EmulateLayoutSwitch"), out bt))
                this.Write("Functions", "EmulateLayoutSwitch", "false");

            if (!Int32.TryParse(this.Read("Functions", "ELSType"), out it))
                this.Write("Functions", "ELSType", "0");

            if (!Boolean.TryParse(this.Read("Functions", "CSSwitch"), out bt))
                this.Write("Functions", "CSSwitch", "true");

            if (!Boolean.TryParse(this.Read("Functions", "BlockCTRL"), out bt))
                this.Write("Functions", "BlockCTRL", "false");

            if (!Boolean.TryParse(this.Read("Functions", "RePress"), out bt))
                this.Write("Functions", "RePress", "false");

            if (!Boolean.TryParse(this.Read("Functions", "EatOneSpace"), out bt))
                this.Write("Functions", "EatOneSpace", "false");
            
            if (!Boolean.TryParse(this.Read("Functions", "ReSelect"), out bt))
                this.Write("Functions", "ReSelect", "true");

            if (!Boolean.TryParse(this.Read("Functions", "SymIgnModeEnabled"), out bt))
                this.Write("Functions", "SymIgnModeEnabled", "false");

            //EnabledHotkeys section
            if (!Boolean.TryParse(this.Read("EnabledHotkeys", "HKCLEnabled"), out bt))
                this.Write("EnabledHotkeys", "HKCLEnabled", "true"); //Hotkey convert last word enabled

            if (!Boolean.TryParse(this.Read("EnabledHotkeys", "HKCSEnabled"), out bt))
                this.Write("EnabledHotkeys", "HKCSEnabled", "true"); //Hotkey convert selection enabled

            if (!Boolean.TryParse(this.Read("EnabledHotkeys", "HKCLineEnabled"), out bt))
                this.Write("EnabledHotkeys", "HKCLineEnabled", "true"); //Hotkey convert line enabled

            if (!Boolean.TryParse(this.Read("EnabledHotkeys", "HKSymIgnEnabled"), out bt))
                this.Write("EnabledHotkeys", "HKSymIgnEnabled", "true"); //Hotkey symbol ignore enabled

            //ExtCtrls section
            if (!Boolean.TryParse(this.Read("ExtCtrls", "UseExtCtrls"), out bt))
                this.Write("ExtCtrls", "UseExtCtrls", "false"); //Use extended CTRLs feature

            if (!Int32.TryParse(this.Read("ExtCtrls", "LCLocale"), out it))
                this.Write("ExtCtrls", "LCLocale", ""); //Left CTRL switch to locale

            if (String.IsNullOrEmpty(this.Read("ExtCtrls", "LCLocaleName")))
                this.Write("ExtCtrls", "LCLocaleName", "");

            if (!Int32.TryParse(this.Read("ExtCtrls", "RCLocale"), out it))
                this.Write("ExtCtrls", "RCLocale", ""); //Right CTRL switch to locale

            if (String.IsNullOrEmpty(this.Read("ExtCtrls", "RCLocaleName")))
                this.Write("ExtCtrls", "RCLocaleName", "");

        }
        public void Write(string section, string key, string value) //Writes "value" to "key" in "section"
        {
            WritePrivateProfileString(section, key, value, this.filePath);
        }
        public string Read(string section, string key) //Returns "key" value in "section" as string
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return SB.ToString();
        }
        public int ReadInt(string section, string key) //Returns "key" value in "section" as int
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return Int32.Parse(SB.ToString());
        }
        public bool ReadBool(string section, string key) //Returns "key" value in "section" as bool
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return Boolean.Parse(SB.ToString().ToLower());
        }
        #region Dll imports
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section,
        string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section,
        string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion
    }
}
