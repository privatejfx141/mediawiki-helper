using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;

namespace MediaWikiHelperApplet {

    /// <summary>
    /// A class to represent the markup code layout of a MediaWiki template.
    /// </summary>
    [DataContract(Name = "Template")]
    public class Template {

        /// <summary>
        /// The name of this template.
        /// </summary>
        [DataMember(Name = "TmpName")]
        public string Name { get; set; }

        /// <summary>
        /// The list of Variables this template holds.
        /// </summary>
        [DataMember(Name = "TmpVariables")]
        private Dictionary<string, string> Variables;

        /// <summary>
        /// The length of the longest tvariable name (used for markup alignment).
        /// </summary>
        [DataMember(Name = "TmpMaxVarLength")]
        private int MaxVarLength;

        private Template() {
            this.Variables = new Dictionary<string, string>();
            this.MaxVarLength = 0;
        }

        /// <summary>
        /// Creates a new code layout for a MediaWiki template.
        /// </summary>
        /// <param name="name"></param>
        public Template(string name) : this() {
            this.Name = name;
        }

        public static void WriteObject(string path, Template template) {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(fs);
            DataContractSerializer ser = new DataContractSerializer(typeof(Template));
            writer.Flush();
            ser.WriteObject(writer, template);
            Console.WriteLine("Finished writing object.");
            writer.Close();
            fs.Close();
        }

        public static Template ReadTemplate(string path) {
            Template template = null;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

            DataContractSerializer ser = new DataContractSerializer(typeof(Template));
            template = (Template)ser.ReadObject(fs);

            return template;
        }

        /// <summary>
        /// Adds a new tvariable to the template. Throws a DuplicatetvariableException if the
        /// template already has the tvariable.
        /// </summary>
        /// <param name="tvar">The new tvariable to be added.</param>
        public void AddVariable(string tvar) {
            string addtvar = tvar.Trim().ToLower();
            if (Variables.ContainsKey(addtvar)) {
                string errorMsg = "";
                throw new DuplicateVariableException(errorMsg);
            } else {
                Variables.Add(addtvar, "");
                MaxVarLength = Math.Max(addtvar.Count<char>(), MaxVarLength);
            }
        }

        /// <summary>
        /// Returns a set of Variables of this template.
        /// </summary>
        /// <returns>A set of this template's Variables.</returns>
        public HashSet<string> GetVariables() {
            return new HashSet<string>(Variables.Keys);
        }
        
        /// <summary>
        /// Sets a tvariable to a value in this template.
        /// </summary>
        /// <param name="tvar"></param>
        /// <param name="value"></param>
        public void SetValue(string tvar, string value) {
            if (Variables.ContainsKey(tvar)) {
                Variables[tvar] = value;
            }
        }

        /// <summary>
        /// Clears all the values in this template.
        /// </summary>
        public void ClearValues() {
            foreach (string tvar in Variables.Keys) {
                Variables[tvar] = "";
            }
        }

        /// <summary>
        /// Adds the default Variables (name, image, imgsize, imgdesc) to this template.
        /// </summary>
        public void AddDefaults() {
            AddVariable("name");
            AddVariable("image");
            AddVariable("imgsize");
            AddVariable("imgdesc");
        }

        /// <summary>
        /// Returns the number of Variables in this template.
        /// </summary>
        /// <returns>The number of Variables.</returns>
        public int NumVariables() {
            return Variables.Count;
        }

        /// <summary>
        /// Builds and returns the usage markup code of this template.
        /// </summary>
        /// <returns>The usage markup code of this template.</returns>
        public string ToMarkup() {
            return ToMarkup(false);
        }

        /// <summary>
        /// Builds and returns the usage markup code of this template.
        /// </summary>
        /// <param name="aligntvars">Whether or not the tvariable assignments are aligned.</param>
        /// <returns>The usage markup code of this template.</returns>
        public string ToMarkup(bool aligntvars) {
            string markup = "{{";
            // concatenate name of template to markup
            markup += Name + "\n";
            // concatenate Variables to markup
            foreach (string tvar in Variables.Keys) {
                string addtvar = tvar;
                if (aligntvars) {
                    addtvar = String.Format("{0,-" + MaxVarLength + "}", tvar);
                }
                markup += "|" + addtvar + " =" + Variables[tvar] + "\n";
            }
            // concatenate end brace and return markup
            return markup + "}}";
        }

    }

}
