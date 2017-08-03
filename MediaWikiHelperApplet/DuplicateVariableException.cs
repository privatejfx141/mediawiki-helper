using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWikiHelperApplet {

    /// <summary>
    /// An exception for duplicate variables in a template code.
    /// </summary>
    public class DuplicateVariableException : Exception {

        /// <summary>
        /// Creates a new duplicate variable exception instance.
        /// </summary>
        public DuplicateVariableException() : base() {
            /* calls parent Exception constructor */
        }

        /// <summary>
        /// Creates a new duplicate variable exception instance.
        /// </summary>
        /// <param name="message">The exception message to be displayed.</param>
        public DuplicateVariableException(String message) : base(message) {
            /* calls parent Exception constructor */
        }

    }
}
