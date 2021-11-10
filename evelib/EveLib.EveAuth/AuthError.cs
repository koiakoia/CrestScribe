using System.Runtime.Serialization;

namespace eZet.EveLib.EveAuthModule {
    /// <summary>
    ///     Represents a CREST exception
    /// </summary>
    [DataContract]
    public class AuthError {
        /// <summary>
        ///     The error message
        /// </summary>
        [DataMember(Name = "error_description")]
        public string Message { get; set; }

        /// <summary>
        ///     The error key
        /// </summary>
        [DataMember(Name = "error")]
        public string Key { get; set; }
    }
}