using System;

namespace SoloKee
{
    class CredentialObject
    {

        private string credId;
        public string CredentialID { 
            get {
                return credId;
            } 
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                credId = value;
            } 
        }

        private string key;
        public string Key {
            get
            {
                return key;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                key = value;
            }
        }

        private string challenge;
        public string Challenge
        {
            get
            {
                return challenge;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                challenge = value;
            }
        }
    }
}
