﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_code
{
    class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        private const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if(preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            return value;
        }
        
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            //Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> subDict = new Dictionary<string, string>();

            preferences.Add(UserName, subDict);

            return "success";
        }
    }
}
