using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWikiHelperApplet {

    /// <summary>
    /// A class to represent the markup code layout of a MediaWiki template.
    /// </summary>
    class Template {

        /// <summary>
        /// The name of this template.
        /// </summary>
        private String Name { get; set; }

        /// <summary>
        /// The list of variables this template holds.
        /// </summary>
        private List<String> Variables { get; }

        private int MaxVarLength;

        /// <summary>
        /// Creates a new code layout for a MediaWiki template.
        /// </summary>
        /// <param name="name"></param>
        public Template(String name) {
            this.Name = name;
            this.Variables = new List<String>();
            this.MaxVarLength = 0;
        }

        /// <summary>
        /// Adds a new variable to the template. Throws a DuplicateVariableException if the
        /// template already has the variable.
        /// </summary>
        /// <param name="var">The new variable to be added.</param>
        public void AddVariable(String var) {
            String addVar = var.Trim().ToLower();
            if (Variables.Contains(addVar)) {
                String errorMsg = "";
                throw new DuplicateVariableException(errorMsg);
            } else {
                Variables.Add(addVar);
                MaxVarLength = Math.Max(addVar.Count<char>(), MaxVarLength);
            }
        }

        /// <summary>
        /// Returns the number of variables in this template.
        /// </summary>
        /// <returns>The number of variables.</returns>
        public int NumVariables() {
            return Variables.Count;
        }

        /// <summary>
        /// Builds and returns the usage markup code of this template.
        /// </summary>
        /// <returns>The usage markup code of this template.</returns>
        public String ToMarkup() {
            return ToMarkup(false);
        }

        /// <summary>
        /// Builds and returns the usage markup code of this template.
        /// </summary>
        /// <param name="alignVars">Whether or not the variable assignments are aligned.</param>
        /// <returns>The usage markup code of this template.</returns>
        public String ToMarkup(bool alignVars) {
            String markup = "{{";
            // concatenate name of template to markup
            markup += Name + "\n";
            // concatenate variables to markup
            foreach (String var in Variables) {
                String addVar = var;
                if (alignVars) {
                    addVar = String.Format("{0,-" + MaxVarLength + "}", var);
                }
                markup += "|" + addVar + " =\n";
            }
            // concatenate end brace and return markup
            return markup + "}}";
        }

    }

}
